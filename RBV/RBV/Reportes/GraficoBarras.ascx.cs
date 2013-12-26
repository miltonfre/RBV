using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;
using Entidades = RBV_Clases;
using System.Collections.Generic;
using RBV_Clases;


namespace RBV.Reportes
{
    public partial class GraficoBarras : System.Web.UI.UserControl
    {
        #region defVariables
        private List<Entidades.MatrizValoracion> _matrizValoracion;
        private List<RBV_Clases.RecursoValioso> _recursosValiosos;
        private Empresa _empresa;

        public List<Entidades.MatrizValoracion> MatrizValoracion
        {
            get { return _matrizValoracion; }
            set { _matrizValoracion = value; }
        }
      

        public List<RBV_Clases.RecursoValioso> RecursosValiosos
        {
            get { return _recursosValiosos; }
            set { _recursosValiosos = value; }
        }

        public Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            decimal ValorTotal = 0;
            if (MatrizValoracion.Count > 0)
            {
                RecursosValiosos = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(MatrizValoracion, this.Empresa.IdEmpresa);
                ValorTotal = RecursosValiosos.Sum(p => p.Valor) / RecursosValiosos.Count;
            }
            string[] Titulos = RecursosValiosos.Select(p => p.NombreRecurso).ToArray();
            decimal[] Valores = RecursosValiosos.Select(p => p.Valor).ToArray();
            decimal[] Promedio = new decimal[Titulos.Length];
            BarrasRecursos.Series["Recursos"].Points.DataBindXY(Titulos, Valores);
            for (int i = 0; i < Titulos.Length; i++)
            {
                Promedio[i] = ValorTotal;
            }

            BarrasRecursos.Series["Promedio"].Points.DataBindXY(Titulos, Promedio);
        }
    }
}