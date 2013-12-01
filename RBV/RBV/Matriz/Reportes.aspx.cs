using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;

namespace RBV.Matriz
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SeleccionEmpresa1.Usuario = User.Identity.Name;
                SeleccionEmpresa1.ConsultarEmpresas();
                ConsultarValoresPromedio();
            }            
        }

        private void ConsultarValoresPromedio()
        {

            List<Entidades.MatrizValoracion> MatrizValoracion = new List<RBV_Clases.MatrizValoracion>();
            List<RBV_Clases.RecursoValioso> recursosValiosos = new List<RBV_Clases.RecursoValioso>();
            decimal ValorTotal = 0;
            MatrizValoracion = RBV_Negocio.MatrizBO.ConsultarMatrizValoracion(SeleccionEmpresa1.IdEmpresa).OrderBy(p => p.IdCaracteristica).ThenBy(p => p.IdRecurso).ToList();
            
            if (MatrizValoracion.Count > 0)
            {
                recursosValiosos = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(MatrizValoracion, SeleccionEmpresa1.IdEmpresa);
                ValorTotal = recursosValiosos.Sum(p => p.Valor) / recursosValiosos.Count;
            }
            string[] Titulos = recursosValiosos.Select(p=>p.NombreRecurso).ToArray();
            decimal[] Valores = recursosValiosos.Select(p=>p.Valor).ToArray();
            decimal[] Promedio = new decimal[Titulos.Length];
            Chart1.Series["Series1"].Points.DataBindXY(Titulos, Valores);
            for (int i = 0; i < Titulos.Length; i++)
            {
                Promedio[i] = ValorTotal;
            }

            Chart1.Series["Promedio"].Points.DataBindXY(Titulos, Promedio);

        }
    }
}
