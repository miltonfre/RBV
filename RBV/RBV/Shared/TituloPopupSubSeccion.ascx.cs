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

public partial class Shared_TituloPopupSubSeccion : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string Titulo
    {

        set { this.lblTituloPopup.Text = value.ToUpper(); }
        get { return this.lblTituloPopup.Text.ToUpper(); }

    }
}
