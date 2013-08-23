using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;

namespace RBV.Maestros
{
    public partial class Caracteristica : System.Web.UI.Page
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

        public short IdCaracteristica
        {
            get
            {
                if (ViewState["IdCaracteristica"] != null)
                {
                    return (short)ViewState["IdCaracteristica"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["IdCaracteristica"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                ConsultarCaracteristicas();
                ddlClasificacion.DataSource = RBV_Negocio.MaestrosBO.ConsultarClasificaciones();
                ddlClasificacion.DataBind();
                //TODO: Pasar mensaje para constante
                ddlClasificacion.Items.Insert(0, new ListItem("<---Seleccione--->", "0"));
                ddlClasificacion.SelectedValue = "0";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPagina();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Caracteristica caracteristica = new Entidades.Caracteristica();
            caracteristica.NombreCaracteristica = txtCaracteristica.Text.Trim();
            caracteristica.IdClasificacionRV = Convert.ToInt16(ddlClasificacion.SelectedValue);

            if (Actualizar)
            {
                caracteristica.IdCaracteristica = IdCaracteristica;
                RBV_Negocio.MaestrosBO.ActualizarCaracteristica(caracteristica);
                Actualizar = false;
            }
            else
            {
                RBV_Negocio.MaestrosBO.InsertarCaracteristica(caracteristica);
            }

            ConsultarCaracteristicas();
            LimpiarPagina();
        }

        private void ConsultarCaracteristicas()
        {
            grdCaracteristica.DataSource = RBV_Negocio.MaestrosBO.ConsultarCaracteristicas();
            grdCaracteristica.DataBind();
        }

        private void LimpiarPagina()
        {
            txtCaracteristica.Text = string.Empty;
            Actualizar = false;
            ddlClasificacion.SelectedIndex = 0;
        }

        protected void grdCaracteristica_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Actualizar = true;
            txtCaracteristica.Text = grdCaracteristica.Rows[e.NewEditIndex].Cells[0].Text;
            IdCaracteristica = Convert.ToInt16(grdCaracteristica.DataKeys[e.NewEditIndex].Value);
            ddlClasificacion.SelectedValue = ((Label)grdCaracteristica.Rows[e.NewEditIndex].Cells[1].FindControl("lblIdClasificionG")).Text;
        }

        protected void grdCaracteristica_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //TODO: Mostra mensaje de confirmacion
            IdCaracteristica = Convert.ToInt16(grdCaracteristica.DataKeys[e.RowIndex].Value); 
            RBV_Negocio.MaestrosBO.EliminarCaracteristica(IdCaracteristica);

            ConsultarCaracteristicas();
            LimpiarPagina();
        }        
    }
}
