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

public partial class Shared_Titulo : System.Web.UI.UserControl
{
    public string Titulo
    {

        set { this.lblTitulo.Text = value==null?string.Empty:value.ToUpper(); }
        get { return this.lblTitulo.Text.ToUpper(); }
    
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
