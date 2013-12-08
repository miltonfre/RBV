using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;

namespace RBV.Maestros
{
    public partial class Recursos : System.Web.UI.Page
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

        public short IdRecurso
        {
            get
            {
                if (ViewState["IdRecurso"] != null)
                {
                    return (short)ViewState["IdRecurso"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["IdRecurso"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ddlEmpresas.DataSource = RBV_Negocio.MaestrosBO.ConsultarEmpresas();
                ddlEmpresas.DataBind();

                ddlTipoRecurso.DataSource = RBV_Negocio.MaestrosBO.ConsultarTiposRecurso();
                ddlTipoRecurso.DataBind();
                //TODO: Pasar mensaje para constante
                ddlEmpresas.Items.Insert(0, new ListItem("<---Seleccione--->", "0"));
                ddlEmpresas.SelectedValue = "0";

                ddlTipoRecurso.Items.Insert(0, new ListItem("<---Seleccione--->", "0"));
                ddlTipoRecurso.SelectedValue = "0";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPagina();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.RecursosEmpresa recursoEmpresa = new Entidades.RecursosEmpresa();
            recursoEmpresa.Empresa = new Entidades.Empresa();
            recursoEmpresa.TipoRecurso = new Entidades.TipoRecurso();
            recursoEmpresa.NombreRecurso = txtRecurso.Text.Trim();
            recursoEmpresa.DescripcionRecurso = txtDescripcion.Text.Trim();
            recursoEmpresa.Empresa.IdEmpresa = Convert.ToInt16(ddlEmpresas.SelectedValue);
            recursoEmpresa.TipoRecurso.IdTipoRecurso = Convert.ToInt16(ddlTipoRecurso.SelectedValue);

            if (Actualizar)
            {
                recursoEmpresa.IdRecursoEmpresa = IdRecurso;
                RBV_Negocio.MaestrosBO.ActualizarRecurso(recursoEmpresa);
                Actualizar = false;
            }
            else
            {
                RBV_Negocio.MaestrosBO.InsertarRecurso(recursoEmpresa);
            }

            ConsultarRecursos(Convert.ToInt16(ddlEmpresas.SelectedValue));
            LimpiarPagina();
        }

        private void ConsultarRecursos(short IdEmpresa)
        {
            grdRecurso.DataSource = RBV_Negocio.MaestrosBO.ConsultarRecursos(IdEmpresa);
            grdRecurso.DataBind();
        }

        private void LimpiarPagina()
        {
            txtRecurso.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            Actualizar = false;
            ddlTipoRecurso.SelectedIndex = 0;            
        }

        protected void grdRecurso_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Actualizar = true;
            txtRecurso.Text = grdRecurso.Rows[e.NewEditIndex].Cells[1].Text;
            txtDescripcion.Text = grdRecurso.Rows[e.NewEditIndex].Cells[2].Text;
            IdRecurso = Convert.ToInt16(grdRecurso.DataKeys[e.NewEditIndex].Value);
            ddlTipoRecurso.SelectedValue = ((Label)grdRecurso.Rows[e.NewEditIndex].Cells[3].FindControl("lblIdTipoRecursoG")).Text;
            ddlEmpresas.SelectedValue = ((Label)grdRecurso.Rows[e.NewEditIndex].Cells[4].FindControl("lblIdEmprsaG")).Text;
        }

        protected void grdRecurso_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //TODO: Mostra mensaje de confirmacion
            IdRecurso = Convert.ToInt16(grdRecurso.DataKeys[e.RowIndex].Value);

            RBV_Negocio.MaestrosBO.EliminarRecurso(IdRecurso);

            ConsultarRecursos(Convert.ToInt16(ddlEmpresas.SelectedValue));
            LimpiarPagina();
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarRecursos(Convert.ToInt16(ddlEmpresas.SelectedValue));
        }

        protected void ddlTipoRecurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoRecurso.SelectedValue != "0")
            {
                lblDescripcionTipo.Text = RBV_Negocio.MaestrosBO.ConsultarTipoRecurso(Convert.ToInt16(ddlTipoRecurso.SelectedValue)).Descripcion;
            }
            else
            {
                lblDescripcionTipo.Text = string.Empty;
            }
            
        }        
    }
}
