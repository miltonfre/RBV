using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;

namespace RBV.Maestros
{
    public partial class TipoRecurso : System.Web.UI.Page
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

        public short IdTipoRecurso
        {
            get
            {
                if (ViewState["IdTipoRecurso"] != null)
                {
                    return (short)ViewState["IdTipoRecurso"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["IdTipoRecurso"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultarTiposRecurso();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.TipoRecurso tipoRecurso = new Entidades.TipoRecurso();
            tipoRecurso.NombreTipoRecurso = txtTipoRecurso.Text.Trim();

            if (Actualizar)
            {
                tipoRecurso.IdTipoRecurso = IdTipoRecurso;
                RBV_Negocio.MaestrosBO.ActualizarTipoRecurso(tipoRecurso);
                Actualizar = false;
            }
            else
            {
                RBV_Negocio.MaestrosBO.InsertarTipoRecurso(tipoRecurso);
            }

            ConsultarTiposRecurso();
            LimpiarPagina();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPagina();
        }

        private void ConsultarTiposRecurso()
        {
            grdTipoRecurso.DataSource = RBV_Negocio.MaestrosBO.ConsultarTiposRecurso();
            grdTipoRecurso.DataBind();
        }

        private void LimpiarPagina()
        {
            txtTipoRecurso.Text = string.Empty;
            Actualizar = false;
        }

        protected void grdTipoRecurso_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Actualizar = true;
            txtTipoRecurso.Text = grdTipoRecurso.Rows[e.NewEditIndex].Cells[1].Text;
            IdTipoRecurso = Convert.ToInt16(grdTipoRecurso.Rows[e.NewEditIndex].Cells[0].Text);
        }

        protected void grdTipoRecurso_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //TODO: Mostra mensaje de confirmacion
            IdTipoRecurso = Convert.ToInt16(grdTipoRecurso.Rows[e.RowIndex].Cells[0].Text);
            RBV_Negocio.MaestrosBO.EliminarTipoRecurso(IdTipoRecurso);

            ConsultarTiposRecurso();
            LimpiarPagina();
        }
    }
}
