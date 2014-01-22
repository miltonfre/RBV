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
        protected void SeleccionEmpresa1_IndexChange(object sender, EventArgs e)
        {
            if (!SeleccionEmpresa1.IdEmpresa.ToString().Equals("0"))
            {
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
            string[] Titulos = recursosValiosos.Select(p => p.NombreRecurso).ToArray();
            decimal[] Valores = recursosValiosos.Select(p => p.Valor).ToArray();
            decimal[] Promedio = new decimal[Titulos.Length];
            BarrasRecursos.Series["Recursos"].Points.DataBindXY(Titulos, Valores);
            for (int i = 0; i < Titulos.Length; i++)
            {
                Promedio[i] = ValorTotal;
            }

            BarrasRecursos.Series["Promedio"].Points.DataBindXY(Titulos, Promedio);

            //Pie recurosos porcentaje
            string[] TitulosTipo = recursosValiosos.Select(p => p.TipoRecurso).Distinct().ToArray();
            decimal[] ValoresTipo = (from p in recursosValiosos group p.IdTipoRecurso by p.IdTipoRecurso into g select Math.Round((Convert.ToDecimal(g.Count()) / Convert.ToDecimal(recursosValiosos.Count)) * 100, 2)).ToArray();

            TortaRecursos.Series["tipoRecurso"].Points.DataBindXY(TitulosTipo, ValoresTipo);
            TortaRecursos.Series["tipoRecurso"].Points[1]["Exploded"] = "true";
            for (int i = 0; i < TortaRecursos.Series["tipoRecurso"].Points.Count; i++)
            {
                TortaRecursos.Series["tipoRecurso"].Points[i].LegendText = TitulosTipo[i].ToString();
            }

            //Pie recursos valiosos sobre total recursos
            
            string[] TitulosTipoVal = recursosValiosos.Select(p => p.TipoRecurso).Distinct().ToArray();
            decimal[] ValoresTipoVal = (from p in recursosValiosos where p.Valor >= ValorTotal group p.IdTipoRecurso by p.IdTipoRecurso into g select Math.Round((Convert.ToDecimal(g.Count()) / Convert.ToDecimal(recursosValiosos.Count)) * 100, 2)).ToArray();

            Array.Resize(ref TitulosTipoVal, TitulosTipoVal.Length + 1);
            TitulosTipoVal[TitulosTipoVal.Length - 1] = "No Valiosos";

            Array.Resize(ref ValoresTipoVal, ValoresTipoVal.Length + 1);
            ValoresTipoVal[ValoresTipoVal.Length - 1] = (100 - ValoresTipoVal.Sum());

            TipoRecValioso.Series["tipoRecursoVal"].Points.DataBindXY(TitulosTipoVal, ValoresTipoVal);
                        
            TipoRecValioso.Series["tipoRecursoVal"].Points[1]["Exploded"] = "true";
            for (int i = 0; i < TipoRecValioso.Series["tipoRecursoVal"].Points.Count; i++)
            {
                TipoRecValioso.Series["tipoRecursoVal"].Points[i].LegendText = TitulosTipoVal[i].ToString();
            }
            
            //Pie recursos valiosos sobre recursos valiosos
            List<RBV_Clases.RecursoValioso> recursosVal= new List<RBV_Clases.RecursoValioso>();
            string[] TitulosValVal = recursosValiosos.Select(p => p.TipoRecurso).Distinct().ToArray();
            recursosVal = recursosValiosos.Where(p => p.Valor >= ValorTotal).ToList();
            decimal[] ValoresValVal = (from p in recursosValiosos where p.Valor >= ValorTotal group p.IdTipoRecurso by p.IdTipoRecurso into g select Math.Round((Convert.ToDecimal(g.Count()) / Convert.ToDecimal(recursosVal.Count)) * 100, 2)).ToArray();

            RecValiosoVal.Series["RecursosValioVal"].Points.DataBindXY(TitulosValVal, ValoresValVal);

            RecValiosoVal.Series["RecursosValioVal"].Points[1]["Exploded"] = "true";
            for (int i = 0; i < RecValiosoVal.Series["RecursosValioVal"].Points.Count; i++)
            {
                RecValiosoVal.Series["RecursosValioVal"].Points[i].LegendText = TitulosTipo[i].ToString();
            }

            //BarrasRecursos.SaveImage(@"D:\Barras.jpg",ChartImageFormat.Jpeg);
        }
    }

}
