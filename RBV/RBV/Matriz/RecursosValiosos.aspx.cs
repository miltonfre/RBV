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
            if (!Page.IsPostBack)
            {
                cargarEmpresas();
                if (!ddlEmpres.SelectedValue.ToString().Equals("0"))
                {
                    ConsultarMatrizConValoresCalculados();
                }
            }
        }

        private void cargarEmpresas()
        {
            List<RBV_Clases.Empresa> Empresas = RBV_Negocio.MaestrosBO.ConsultarEmpresas(User.Identity.Name).ToList();
            //TODO: Poner mensaje en constante...
            ddlEmpres.DataSource = Empresas;
            ddlEmpres.DataBind();
            ddlEmpres.Items.Insert(0, new ListItem("<---Seleccione--->", "0"));
            ddlEmpres.SelectedValue = "0";

            if (Empresas.Count > 1)
            {
                ddlEmpres.SelectedValue = "0";
            }
            else
            {
                ddlEmpres.SelectedIndex = 1;
            }
        }
        
        [WebMethod]
        public static Resultado Actualizar(string info, string totales, int idFila, short idEmpresa)
        {
            var result = new Resultado();

            List<RBV_Clases.MatrizValoracion> MatrizValoracion = ensamblarMatrizCalificar(info);

            List<RecursoValioso> recursosValioso = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(MatrizValoracion, idEmpresa);

            result.TotalLinea = recursosValioso.SingleOrDefault(p => p.Valor != 0).Valor;

            string[] ValTotales = totales.Split(';').Where(p=>p.ToString().Trim() != string.Empty).ToArray();
            ValTotales[idFila] = result.TotalLinea.ToString();

            result.TotalGrupo = decimal.Round(ValTotales.Sum(p=> Convert.ToDecimal(p.ToString())) / ValTotales.Length,4);
            
            return result;            
        }

        private void ConsultarMatrizConValoresCalculados()
        {
            decimal valorCaracteristicas = 0;
            this.idEmpresa = Convert.ToInt16(ddlEmpres.SelectedValue);
            MatrizValoracion = RBV_Negocio.MatrizBO.ConsultarMatrizValoracion(this.idEmpresa).OrderBy(p => p.IdCaracteristica).ThenBy(p => p.IdRecurso).ToList();
            
            if (MatrizValoracion.Count > 0)
            {
                recursosValiosos = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(MatrizValoracion, this.idEmpresa);
                if (recursosValiosos.Count > 0)
                {
                    ValorTotal = recursosValiosos.Sum(p => p.Valor) / recursosValiosos.Count;
                }                
            }
            
            Entidades.MatrizValoracion Matriz = RBV_Negocio.MatrizBO.ConsultarCaracteristicasRecursos(this.idEmpresa);
            if (Matriz.Recursos.Count > 0)
            {
                foreach (Entidades.Caracteristica item in Matriz.Caracteristicas.OrderBy(p => p.ClasificacionAsociada.ClasificacionRV))
                {
                    Titulos.Add(new Titulo { Nombre = item.NombreCaracteristica == "Empresa" ? ddlEmpres.SelectedItem.Text + " " + item.ValorCaracteristica + "%" : item.NombreCaracteristica + " " + item.ValorCaracteristica + "%", Descripcion = item.Descripcion, Id = item.IdCaracteristica.ToString(), IdClasificacion = item.ClasificacionAsociada.IdClasificacionRV.ToString() });
                    valorCaracteristicas += Convert.ToDecimal(item.ValorCaracteristica);
                }
                TitulosFilas.Add(new TituloFilas { NombreFilas = "" });
                foreach (Entidades.RecursosEmpresa item in Matriz.Recursos.OrderBy(p => p.IdRecursoEmpresa))
                {
                    TitulosFilas.Add(new TituloFilas { NombreFilas = item.NombreRecurso, IdFilas = item.IdRecursoEmpresa.ToString() });
                }

                Calificacion = RBV_Negocio.MaestrosBO.ConsultarEscalaCalificaciones(this.idEmpresa);

                Clasificaciones = (from cla in Matriz.Caracteristicas
                                   group cla by new
                                   {
                                       cla.ClasificacionAsociada.ClasificacionRV
                                   } into g
                                   orderby g.Key.ClasificacionRV
                                   select new TituloClasificaciones
                                            {
                                                Nombre = g.Key.ClasificacionRV + " " + g.Sum(p => Convert.ToDecimal(p.ValorCaracteristica)).ToString() + "%",
                                                CantidadCaracteristica = g.Count(p => p.ClasificacionAsociada.ClasificacionRV != null) * 2
                                                
                                            }).Distinct().ToList();

                if (valorCaracteristicas < 100)
                {
                    //TODO: Verificar error de scriptmanager al poner el ascx de mensajes
                    lblMensaje.Text = "Por favor antes de comenzar la evaluación ingrese valores a las características. Página Escala Valoración.";
                    lblMensaje.Visible = true;
                }
                else
                {
                    lblMensaje.Visible = false;
                }
            }
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
//            public string ValorCla { get; set; }
        }

        [WebMethod]
        public static string Save(string info, short idEmpresa)
        {
            List<RBV_Clases.MatrizValoracion> MatrizValoracion = ensamblarMatrizCalificar(info);
            
            RBV_Negocio.MatrizBO.InsertarMatriz(MatrizValoracion, idEmpresa);

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

        protected void ddlEmpres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ddlEmpres.SelectedValue.ToString().Equals("0"))
            {
                ConsultarMatrizConValoresCalculados();
            }
        }
    }
}
