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
    public partial class TortaRecValisosoSobreTotal : System.Web.UI.UserControl
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

        }
    }
}