using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;

namespace RBV.Maestros
{
    public partial class Clasificacion : System.Web.UI.Page
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

        public short IdClasificacion
        {
            get
            {
                if (ViewState["IdClasificacion"] != null)
                {
                    return (short)ViewState["IdClasificacion"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["IdClasificacion"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultarClasificaciones();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPagina();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Clasificacion clasificacion = new Entidades.Clasificacion();
            clasificacion.ClasificacionRV = txtClasificacion.Text.Trim();

            if (Actualizar)
            {
                clasificacion.IdClasificacionRV = IdClasificacion;
                RBV_Negocio.MaestrosBO.ActualizarClasificacion(clasificacion);
                Actualizar = false;
            }
            else
            {
                RBV_Negocio.MaestrosBO.InsertarClasificacion(clasificacion);
            }
            
            ConsultarClasificaciones();
            LimpiarPagina();
        }

        private void ConsultarClasificaciones()
        {
            grdClasificaciones.DataSource = RBV_Negocio.MaestrosBO.ConsultarClasificaciones();
            grdClasificaciones.DataBind();
        }

        private void LimpiarPagina()
        {
            txtClasificacion.Text = string.Empty;
            Actualizar = false;
        }

        protected void grdClasificaciones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Actualizar = true;
            txtClasificacion.Text = grdClasificaciones.Rows[e.NewEditIndex].Cells[1].Text;
            IdClasificacion = Convert.ToInt16(grdClasificaciones.Rows[e.NewEditIndex].Cells[0].Text);
        }

        protected void grdClasificaciones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //TODO: Mostra mensaje de confirmacion
            IdClasificacion = Convert.ToInt16(grdClasificaciones.Rows[e.RowIndex].Cells[0].Text);
            RBV_Negocio.MaestrosBO.EliminarClasificacion(IdClasificacion);

            ConsultarClasificaciones();
            LimpiarPagina();
        }
    }
}
