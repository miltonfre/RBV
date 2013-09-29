using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;

namespace RBV.Maestros
{
    public partial class EscalaValoracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                rptValoracion.DataSource = RBV_Negocio.MaestrosBO.ConsultarCaracteristicas();
                rptValoracion.DataBind();
                
            }
        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            string valor = "0";
        }
    }
}
