using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Entidades = RBV_Clases;
using RBV_Clases;

namespace RBV.Matriz
{
    public partial class RecursosValiosos : System.Web.UI.Page
    {
        public List<Titulo> Titulos = new List<Titulo>();
        public List<TituloFilas> TitulosFilas = new List<TituloFilas>();
        public List<TituloClasificaciones> Clasificaciones = new List<TituloClasificaciones>();
        public List<RBV_Clases.EscalaCalificacion> Calificacion = new List<RBV_Clases.EscalaCalificacion>();
        public List<Entidades.MatrizValoracion> MatrizValoracion = new List<RBV_Clases.MatrizValoracion>();
        public List<RBV_Clases.RecursoValioso> recursosValiosos = new List<RBV_Clases.RecursoValioso>();

        public decimal ValorTotal = 0;
        public short idEmpresa { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO: Cambiar empresa
            if (!Page.IsPostBack)
            {
                SeleccionEmpresa1.Usuario = User.Identity.Name;
                SeleccionEmpresa1.ConsultarEmpresas();
            }
            ConsultarMatrizConValoresCalculados();
        }

        protected void SeleccionEmpresa1_OnEmpresaIndexChange(object sender, EventArgs e)
        { 
        
        }

        [WebMethod]
        public static Resultado Actualizar(string info, string totales, int idFila)
        {
            var result = new Resultado();

            List<RBV_Clases.MatrizValoracion> MatrizValoracion = ensamblarMatrizCalificar(info);

            //TODO: CambiarEmpresa
            List<RecursoValioso> recursosValioso = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(MatrizValoracion, 5);

            result.TotalLinea = recursosValioso.SingleOrDefault(p => p.Valor != 0).Valor;

            string[] ValTotales = totales.Split(';').Where(p=>p.ToString().Trim() != string.Empty).ToArray();
            ValTotales[idFila] = result.TotalLinea.ToString();

            result.TotalGrupo = decimal.Round(ValTotales.Sum(p=> Convert.ToDecimal(p.ToString())) / ValTotales.Length,4);
            /*
            result.TotalGrupo = 20.9;
            
            */
            return result;
            
        }

        private void ConsultarMatrizConValoresCalculados()
        {
            MatrizValoracion = RBV_Negocio.MatrizBO.ConsultarMatrizValoracion(5).OrderBy(p => p.IdCaracteristica).ThenBy(p => p.IdRecurso).ToList();
            this.idEmpresa = SeleccionEmpresa1.IdEmpresa;
            if (MatrizValoracion.Count > 0)
            {
                recursosValiosos = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(MatrizValoracion, this.idEmpresa);
                ValorTotal = recursosValiosos.Sum(p => p.Valor) / recursosValiosos.Count;
            }
            
            Entidades.MatrizValoracion Matriz = RBV_Negocio.MatrizBO.ConsultarCaracteristicasRecursos(this.idEmpresa);
            foreach (Entidades.Caracteristica item in Matriz.Caracteristicas.OrderBy(p => p.ClasificacionAsociada.ClasificacionRV))
            {
                Titulos.Add(new Titulo { Nombre = item.NombreCaracteristica + " " +item.ValorCaracteristica + "%", Descripcion=item.Descripcion,Id = item.IdCaracteristica.ToString(), IdClasificacion = item.ClasificacionAsociada.IdClasificacionRV.ToString() });
            }
            TitulosFilas.Add(new TituloFilas { NombreFilas = "" });
            foreach (Entidades.RecursosEmpresa item in Matriz.Recursos.OrderBy(p => p.IdRecursoEmpresa))
            {
                TitulosFilas.Add(new TituloFilas { NombreFilas = item.NombreRecurso, IdFilas = item.IdRecursoEmpresa.ToString() });
            }

            //TODO: Cambiar empresa
            Calificacion = RBV_Negocio.MaestrosBO.ConsultarEscalaCalificaciones(this.idEmpresa);

            Clasificaciones = (from cla in Matriz.Caracteristicas
                               group cla by new
                               {
                                    cla.ClasificacionAsociada.ClasificacionRV
                                    
                               } into g
                               orderby g.Key.ClasificacionRV
                               select new TituloClasificaciones 
                                        { 
                                            Nombre = g.Key.ClasificacionRV ,
                                            CantidadCaracteristica = g.Count(p=>p.ClasificacionAsociada.ClasificacionRV != null) *2
                                            
                                        }).Distinct().ToList();

        }

        public struct Titulo
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string Id { get; set; }
            public string IdClasificacion { get; set; }
        }

        public struct TituloFilas
        {
            public string NombreFilas { get; set; }
            public string IdFilas { get; set; }
        }

        public struct TituloClasificaciones
        {
            public string Nombre { get; set; }
            public int CantidadCaracteristica { get; set; } 
        }

        [WebMethod]
        public static string Save(string info)
        {
            List<RBV_Clases.MatrizValoracion> MatrizValoracion = ensamblarMatrizCalificar(info);
            
            //TODO: Cambiar empresa
            RBV_Negocio.MatrizBO.InsertarMatriz(MatrizValoracion, 5);

            return "Datos guardados con exito";
        }

        private static List<RBV_Clases.MatrizValoracion> ensamblarMatrizCalificar(string info)
        {
            string[] datos = info.Split(';');

            List<RBV_Clases.MatrizValoracion> MatrizValoracion = new List<RBV_Clases.MatrizValoracion>();

            foreach (string item in datos)
            {
                if (!item.ToString().Equals(string.Empty))
                {
                    string[] valores = item.Split(',');
                    MatrizValoracion.Add(new RBV_Clases.MatrizValoracion { IdRecurso = Convert.ToInt16(valores[0]), IdCaracteristica = Convert.ToInt16(valores[1]), IdClasificacion = Convert.ToInt16(valores[2]), Valor = Convert.ToDecimal(valores[3]) });
                }
            }
            return MatrizValoracion;
        }
    }
}
