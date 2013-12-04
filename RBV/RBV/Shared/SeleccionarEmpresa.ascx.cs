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
using RBV_Negocio;

namespace RBV.Shared
{
    public partial class SeleccionarEmpresa : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ConsultarEmpresas();
            }
        }

        private void ConsultarEmpresas()
        {
            if (HttpContext.Current.User != null && !string.IsNullOrEmpty(HttpContext.Current.User.Identity.Name))
            {
                aspnet_MembershipBO userBO = new aspnet_MembershipBO();
                MembershipUser user= userBO.BuscarUsuarioPorNombre(HttpContext.Current.User.Identity.Name);
                rblEmpresas.DataSource = RBV_Negocio.MaestrosBO.ConsultarEmpresasxUsuario(user);
                rblEmpresas.DataTextField = "NombreEmpresa";
                rblEmpresas.DataValueField = "IdEmpresa";
                rblEmpresas.DataBind();
            }
        }

    }
}