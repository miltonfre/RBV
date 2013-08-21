using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;

namespace RBV.Maestros
{
    public partial class Empresa : System.Web.UI.Page
    {
        public bool Actualizar
        {
            get
            {
                if (ViewState["Actualizar"] != null)
                {
                    return (bool)ViewState["Actualizar"];
                }
                else
                {
                    return false;
                }
            }
            set
            {
                ViewState["Actualizar"] = value;
            }
        }

        public short IdEmpresa
        {
            get
            {
                if (ViewState["IdEmpresa"] != null)
                {
                    return (short)ViewState["IdEmpresa"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["IdEmpresa"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultarEmpresas();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPagina();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Empresa empresa = new Entidades.Empresa();
            empresa.NombreEmpresa = txtEmpresa.Text.Trim();
            empresa.Nit = txtNIT.Text.Trim();
            empresa.RepresetanteLegal = txtRepresentante.Text.Trim();

            if (Actualizar)
            {
                empresa.IdEmpresa = IdEmpresa;
                RBV_Negocio.MaestrosBO.ActualizarEmpresa(empresa);
                Actualizar = false;
            }
            else
            {
                RBV_Negocio.MaestrosBO.InsertarEmpresa(empresa);
            }

            ConsultarEmpresas();
            LimpiarPagina();
        }

        private void ConsultarEmpresas()
        {
            grdEmpresas.DataSource = RBV_Negocio.MaestrosBO.ConsultarEmpresas();
            grdEmpresas.DataBind();
        }

        private void LimpiarPagina()
        {
            txtEmpresa.Text = string.Empty;
            txtNIT.Text = string.Empty;
            txtRepresentante.Text = string.Empty;
            Actualizar = false;
        }

        protected void grdEmpresas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Actualizar = true;
            txtEmpresa.Text = grdEmpresas.Rows[e.NewEditIndex].Cells[1].Text;
            txtNIT.Text = grdEmpresas.Rows[e.NewEditIndex].Cells[2].Text;
            txtRepresentante.Text = grdEmpresas.Rows[e.NewEditIndex].Cells[3].Text;
            IdEmpresa = Convert.ToInt16(grdEmpresas.Rows[e.NewEditIndex].Cells[0].Text);
        }

        protected void grdEmpresas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //TODO: Mostra mensaje de confirmacion
            IdEmpresa = Convert.ToInt16(grdEmpresas.Rows[e.RowIndex].Cells[0].Text);
            RBV_Negocio.MaestrosBO.EliminarEmpresa(IdEmpresa);

            ConsultarEmpresas();
            LimpiarPagina();
        }
    }
}
