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

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
                Entidades.MatrizValoracion Matriz = RBV_Negocio.MatrizBO.ConsultarCaracteristicasRecursos(5);
                foreach (Entidades.Caracteristica item in Matriz.Caracteristicas)
                {
                    Titulos.Add(new Titulo { Nombre = item.NombreCaracteristica, Id= item.IdCaracteristica.ToString() });
                }
                TitulosFilas.Add(new TituloFilas { NombreFilas = "" });
                foreach (Entidades.RecursosEmpresa item in Matriz.Recursos)
                {
                    TitulosFilas.Add(new TituloFilas { NombreFilas = item.NombreRecurso, IdFilas = item.IdRecursoEmpresa.ToString() });
                }
            
        }

        public struct Titulo
        {
            public string Nombre { get; set; }
            public string Id { get; set; }
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

            return string.Join("\u000a",datos).ToString();
        }
    }
}
