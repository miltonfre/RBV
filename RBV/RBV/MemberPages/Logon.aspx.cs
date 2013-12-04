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
using System.Collections.Generic;
using RBV_Clases;

namespace RBV.MemberPages
{
    public partial class Logon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login1_LoggedIn(object sender, EventArgs e)
        {
            try
            {


                if (Membership.ValidateUser(Login1.UserName, Login1.Password))
                {
                    FormsAuthentication.SetAuthCookie(Login1.UserName, true);

                    if (HttpContext.Current.User != null && !string.IsNullOrEmpty(HttpContext.Current.User.Identity.Name))
                    {
                        aspnet_MembershipBO userBO = new aspnet_MembershipBO();
                        MembershipUser user = userBO.BuscarUsuarioPorNombre(HttpContext.Current.User.Identity.Name);
                        List<Empresa> lsEmpresas = RBV_Negocio.MaestrosBO.ConsultarEmpresasxUsuario(user);
                        if (lsEmpresas == null || lsEmpresas.Count == 0)//no está asociado a ninguna empresa
                        {
                            Globals.Empresa = null;
                        }
                        else
                        {
                            if (lsEmpresas.Count == 1)//Tiene una sola empresa
                            {
                                Globals.Empresa = lsEmpresas[0];
                                Response.Redirect("/Maestros/EscalaCalificacion.aspx");
                            }
                            else// Asociado a más de una empresa
                            {
                                Globals.Empresa = lsEmpresas[0];
                                Response.Redirect("/Maestros/EscalaCalificacion.aspx");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Login1.FailureText = ex.Message;
            }


        }
    }
}
