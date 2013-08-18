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

namespace RBV.MemberPages
{
    public partial class RoleManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindList();
        }

        private void BindList()
        {
            ListBox1.DataSource = Roles.GetAllRoles();
            ListBox1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Roles.CreateRole(TextBox1.Text);
            Label3.Text = "Role created successfully!";
            BindList();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bool success = Roles.DeleteRole(ListBox1.SelectedItem.Text);
            if (success)
                Label3.Text = "Role deleted successfully!";
            BindList();
        }
    }
}
