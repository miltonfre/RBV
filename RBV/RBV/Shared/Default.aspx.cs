using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace RBV.Shared
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // generar código JavaScript para asociar
            // con el evento onfocus del textbox txtSituacion
            System.Text.StringBuilder sbJS = new System.Text.StringBuilder();
            sbJS.Append("function txtSituacionOnFocus()");
            sbJS.Append("{ \n");
            sbJS.Append("    var txtSituacion = document.getElementById('txtSituacion'); \n");
            sbJS.Append("    txtSituacion.style.backgroundColor = '#FFFFFF'; \n");
            sbJS.Append("}");

            // registrar en la página el código JavaScript
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
                "CodigoJS", sbJS.ToString(), true);

            // asociar el evento cliente con la función JavaScript para este control
            this.txtSituacion.Attributes.Add("onfocus", "txtSituacionOnFocus()");
            //....
            // rellenar dos listas con los valores
            // de meses y años que usaremos 
            // en los controles de lista desplegable
            ArrayList alMeses = new ArrayList();
            ArrayList alAnualidades = new ArrayList();
            DateTime dtFecha = new DateTime(2000, 1, 1);

            for (int nContador = 1; nContador <= 12; nContador++)
            {
                alMeses.Add(dtFecha.ToString("MMMM"));
                alAnualidades.Add(dtFecha.Year);
                dtFecha = dtFecha.AddMonths(1);
                dtFecha = dtFecha.AddYears(1);
            }

            // asignar las listas a los controles
            this.ddlMeses.DataSource = alMeses;
            this.ddlMeses.DataBind();

            this.ddlAnualidades.DataSource = alAnualidades;
            this.ddlAnualidades.DataBind();
        }
    }
}
