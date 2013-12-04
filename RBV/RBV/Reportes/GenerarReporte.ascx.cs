using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Security.Principal;

namespace RBV.Reportes
{
    public partial class GenerarReporte : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //SeleccionEmpresa1.Usuario =   User.Identity.Name;
                //SeleccionEmpresa1.ConsultarEmpresas();
               
            }
        }

        protected void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Utilidades.GenerarWord genWord = new Utilidades.GenerarWord();
           string archivo= genWord.CrearWordWithDocX("Grupo Éxito");
           Response.Redirect(archivo, true);
            
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {

        }
       
    }
}