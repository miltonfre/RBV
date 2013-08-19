using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace WebApplication.Shared
{
    public partial class MensajeConfirmacion : System.Web.UI.UserControl
    {
    
        public event EventHandler ClickSi;
        public event EventHandler ClickNo;

        protected void OnClickSi(EventArgs e)
        {
            if (ClickSi != null)
            {
                ClickSi(this, e);
            }
        }
        protected void OnClickNo(EventArgs e)
        {
            if (ClickNo != null)
            {
                ClickNo(this, e);
            }
        }

        public string urlr
        {

            set { ViewState["urlr"] = value; }
            get { return (string)ViewState["urlr"]; }
        }
        public void MostrarMensaje(string mensaje)
        {
            this.Visible = true;
            this.lblMensaje.Text = mensaje;
            this.PopupMensajePersonalizado.Show();

        }
        public void MostrarMensaje(string mensaje, string url)
        {
            this.Visible = true;
            this.lblMensaje.Text = mensaje;
            this.PopupMensajePersonalizado.Show();
            urlr = url;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        protected void HacerClickSi(object sender, EventArgs e)
        {
            this.ClickSi(sender, e);
        }

        protected void HacerClickNo(object sender, EventArgs e)
        {
            this.ClickNo(sender, e);
        }

        public void CerrarPopupCrear(object sender, EventArgs e)
        {
            this.PopupMensajePersonalizado.Hide();
            if (urlr != null)
            {
                Response.Redirect(urlr);
            }

        }
    

        
    }
}