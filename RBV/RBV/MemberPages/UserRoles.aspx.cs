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
    public partial class UserRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownList();
                BindListBox1();
            }
        }

        private void BindDropDownList()
        {
            DropDownList1.Items.Clear();
            MembershipUserCollection users = Membership.GetAllUsers();
            foreach (MembershipUser user in users)
            {
                DropDownList1.Items.Add(user.UserName);
            }
        }

        private void BindListBox2()
        {
            ListBox2.DataSource = Roles.GetRolesForUser(DropDownList1.SelectedItem.Text);
            ListBox2.DataBind();
        }

        private void BindListBox1()
        {
            ListBox1.DataSource = Roles.GetAllRoles();
            ListBox1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindListBox2();
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            Roles.AddUserToRole(DropDownList1.SelectedItem.Text, ListBox1.SelectedItem.Text);
            BindListBox2();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Roles.RemoveUserFromRole(DropDownList1.SelectedItem.Text, ListBox2.SelectedItem.Text);
            BindListBox2();
        }
    }
}
