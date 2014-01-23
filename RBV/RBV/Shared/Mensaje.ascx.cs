using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RBV.Shared
{
    public partial class Mensaje : System.Web.UI.UserControl
    {

        public string Mensajes
        {
            set 
            { 
                lblMensaje.Text = value.ToString();
                lblMensaje.Visible = true;
                tmtMensaje.Interval = 10000;
                tmtMensaje.Enabled = true;
                LimpiarMensaje = true;
            }            
        }

        public bool LimpiarMensaje
        {
            get
            {
                if (ViewState["LimpiarMensaje"] != null)
                {
                    return (bool)ViewState["LimpiarMensaje"];
                }
                else
                {
                    return false;
                }
            }
            set 
            {
                ViewState["LimpiarMensaje"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (LimpiarMensaje)
            {
                Mensajes = string.Empty;
            }            
            tmtMensaje.Enabled = false;
        }
    }
}