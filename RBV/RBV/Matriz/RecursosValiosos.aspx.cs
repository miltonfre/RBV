using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Entidades = RBV_Clases;

namespace RBV.Matriz
{
    public partial class RecursosValiosos : System.Web.UI.Page
    {
        public List<Titulo> Titulos = new List<Titulo>();
        public List<TituloFilas> TitulosFilas = new List<TituloFilas>();
        public List<RBV_Clases.EscalaCalificacion> Calificacion = new List<RBV_Clases.EscalaCalificacion>();
        public List<Entidades.MatrizValoracion> MatrizValoracion = new List<RBV_Clases.MatrizValoracion>();
        public List<RBV_Clases.RecursoValioso> recursosValiosos = new List<RBV_Clases.RecursoValioso>();
        public decimal ValorTotal = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO: Cambiar empresa
            ConsultarMatrizConValoresCalculados();
        }

        private void ConsultarMatrizConValoresCalculados()
        {
            MatrizValoracion = RBV_Negocio.MatrizBO.ConsultarMatrizValoracion(5).OrderBy(p => p.IdCaracteristica).ThenBy(p => p.IdRecurso).ToList();

            if (MatrizValoracion.Count > 0)
            {
                //TODO: Cambiar empresa
                recursosValiosos = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(MatrizValoracion, 5);
                ValorTotal = recursosValiosos.Sum(p => p.Valor) / recursosValiosos.Count;
            }
            //TODO: Cambiar empresa
            Entidades.MatrizValoracion Matriz = RBV_Negocio.MatrizBO.ConsultarCaracteristicasRecursos(5);
            foreach (Entidades.Caracteristica item in Matriz.Caracteristicas.OrderBy(p => p.IdCaracteristica))
            {
                Titulos.Add(new Titulo { Nombre = item.NombreCaracteristica, Id = item.IdCaracteristica.ToString(), IdClasificacion = item.ClasificacionAsociada.IdClasificacionRV.ToString() });
            }
            TitulosFilas.Add(new TituloFilas { NombreFilas = "" });
            foreach (Entidades.RecursosEmpresa item in Matriz.Recursos.OrderBy(p => p.IdRecursoEmpresa))
            {
                TitulosFilas.Add(new TituloFilas { NombreFilas = item.NombreRecurso, IdFilas = item.IdRecursoEmpresa.ToString() });
            }

            //TODO: Cambiar empresa
            Calificacion = RBV_Negocio.MaestrosBO.ConsultarEscalaCalificaciones(5);
        }

        public struct Titulo
        {
            public string Nombre { get; set; }
            public string Id { get; set; }
            public string IdClasificacion { get; set; }
        }

        public struct TituloFilas
        {
            public string NombreFilas { get; set; }
            public string IdFilas { get; set; }
        }

        [WebMethod]
        public static string Save(string info)
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

            //TODO: Cambiar empresa
            RBV_Negocio.MatrizBO.InsertarMatriz(MatrizValoracion,5);

            return "Datos guardados con exito";
        }
    }
}
