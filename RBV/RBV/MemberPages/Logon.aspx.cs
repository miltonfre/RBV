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
using RBV_Negocio;

namespace RBV.MemberPages
{
    public partial class Logon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                //aspnet_MembershipBO membershipBO = new aspnet_MembershipBO();
                //e.Authenticated = membershipBO.ValidateUser(this.Login1.UserName, this.Login1.Password);
                e.Authenticated = true;
                //{
                //    e.Authenticated = this.UsuariosController.AutenticarUsuario(this.Login1.UserName, this.Login1.Password);

                //    if (e.Authenticated)
                //    {
                //        this.Login1.UserName = this.Login1.UserName.Substring(this.Login1.UserName.IndexOf('\\') + 1);
                //        string descripcion = "Inicio de sesión del usuario '" + this.Login1.UserName + "'";
                //        Comunes.GuardarRegistroLogAcciones("Insercion", "Usuarios", this.Login1.UserName, descripcion);
                //        Session["NombreUsuarioAutenticado"] = this.Login1.UserName;
                //    }
                //    else
                //    {
                //        System.Web.UI.WebControls.Login log = (System.Web.UI.WebControls.Login)sender;
                //        log.FailureText = GetLocalResourceObject("Login1FailureText").ToString();
                //    }
                //}
                //else
                //{
                //    e.Authenticated = false;

                //    System.Web.UI.WebControls.Login log = (System.Web.UI.WebControls.Login)sender;
                //    log.FailureText = GetLocalResourceObject("Login1UsuariosInvalidos").ToString();
                //}
            }
            catch (Exception ex)
            {
                //System.Web.UI.WebControls.Login log = (System.Web.UI.WebControls.Login)sender;
                //log.FailureText = GetLocalResourceObject("Login1FailureText").ToString();
                //UtilidadLogs.RegistrarError(ex, this.GetType());
            }
        }

        
    }
}
