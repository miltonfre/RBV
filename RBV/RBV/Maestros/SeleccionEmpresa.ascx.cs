using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;
using System.Security.Principal;

namespace RBV.Maestros
{
    public partial class SeleccionEmpresa : System.Web.UI.UserControl
    {
        public event EventHandler EmpresaIndexChange;
        public string Usuario { get; set; }

        public short IdEmpresa
        {
            set { ddlEmpresaUsr.SelectedValue = value.ToString(); }
            get { return Convert.ToInt16(ddlEmpresaUsr.SelectedValue == string.Empty ? 0 : Convert.ToInt16(ddlEmpresaUsr.SelectedValue)); }
        }
        public string Empresa
        {
            set { ddlEmpresaUsr.SelectedValue = value.ToString(); }
            get { return ddlEmpresaUsr.SelectedItem.Text == string.Empty ? string.Empty : ddlEmpresaUsr.SelectedItem.Text; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //ConsultarEmpresas();
        }

        public void ConsultarEmpresas()
        {
            List<RBV_Clases.Empresa> Empresas = new List<RBV_Clases.Empresa>(RBV_Negocio.MaestrosBO.ConsultarEmpresas(Usuario).ToList());
            //TODO: Poner mensaje en constante...
            ddlEmpresaUsr.DataSource = Empresas;
            ddlEmpresaUsr.DataBind();
            ddlEmpresaUsr.Items.Insert(0, new ListItem("<---Seleccione--->", "0"));
            ddlEmpresaUsr.SelectedValue = "0";

            if (Empresas.Count > 1)
            {
                ddlEmpresaUsr.SelectedValue = "0";
            }
            else
            {
                ddlEmpresaUsr.SelectedIndex = 1;
            }
        }

        protected void ddlEmpresaUsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmpresaIndexChange !=null)
	        {
                EmpresaIndexChange(sender, e);
	        }            
        }


    }
}