using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;

namespace RBV.Maestros
{
    public partial class EscalaCalificacion : System.Web.UI.Page
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

        public short IdEscalaCalificacion
        {
            get
            {
                if (ViewState["IdEscalaCalificacion"] != null)
                {
                    return (short)ViewState["IdEscalaCalificacion"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["IdEscalaCalificacion"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlEmpresas.DataSource = RBV_Negocio.MaestrosBO.ConsultarEmpresas();
                ddlEmpresas.DataBind();
                //TODO: Pasar mensaje para constante
                ddlEmpresas.Items.Insert(0, new ListItem("<---Seleccione--->", "0"));
                ddlEmpresas.SelectedValue = "0";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPagina();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.EscalaCalificacion escalaCalificacion = new Entidades.EscalaCalificacion();
            escalaCalificacion.Escala = txtEscala.Text.Trim();
            escalaCalificacion.IdEmpresa = Convert.ToInt16(ddlEmpresas.SelectedValue);
            escalaCalificacion.Valor = Convert.ToDecimal(txtValor.Text.Trim());

            if (Actualizar)
            {
                escalaCalificacion.IdEmpresa = IdEscalaCalificacion;
                RBV_Negocio.MaestrosBO.ActualizarEscalaCalificacion(escalaCalificacion);
                Actualizar = false;
            }
            else
            {
                RBV_Negocio.MaestrosBO.InsertarEscalaCalificacion(escalaCalificacion);
            }

            ConsultarEscalaCalificaciones(escalaCalificacion.IdEmpresa);
            LimpiarPagina();
        }

        private void ConsultarEscalaCalificaciones(short IdEmpresa)
        {
            grdEscalaCalificaciones.DataSource = RBV_Negocio.MaestrosBO.ConsultarEscalaCalificaciones(IdEmpresa);
            grdEscalaCalificaciones.DataBind();
        }

        private void LimpiarPagina()
        {
            txtEscala.Text = string.Empty;
            txtValor.Text = string.Empty;
            
            Actualizar = false;
        }

        protected void grdEscalaCalificaciones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Actualizar = true;
            txtEscala.Text = grdEscalaCalificaciones.Rows[e.NewEditIndex].Cells[1].Text;
            txtValor.Text = grdEscalaCalificaciones.Rows[e.NewEditIndex].Cells[2].Text;
            ddlEmpresas.SelectedValue = grdEscalaCalificaciones.Rows[e.NewEditIndex].Cells[3].Text;
            IdEscalaCalificacion = Convert.ToInt16(grdEscalaCalificaciones.Rows[e.NewEditIndex].Cells[0].Text);
        }

        protected void grdEscalaCalificaciones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //TODO: Mostra mensaje de confirmacion
            IdEscalaCalificacion = Convert.ToInt16(grdEscalaCalificaciones.Rows[e.RowIndex].Cells[0].Text);
            short IdEmpresa = Convert.ToInt16(grdEscalaCalificaciones.Rows[e.RowIndex].Cells[3].Text);
            RBV_Negocio.MaestrosBO.EliminarEscalaCalificacion(IdEscalaCalificacion);

            ConsultarEscalaCalificaciones(IdEmpresa);
            LimpiarPagina();
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarEscalaCalificaciones(Convert.ToInt16(ddlEmpresas.SelectedValue));
        }
    }
}
