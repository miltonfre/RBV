using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;

namespace RBV.Maestros
{
    public partial class Sector : System.Web.UI.Page
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

        public short IdSector
        {
            get
            {
                if (ViewState["IdSector"] != null)
                {
                    return (short)ViewState["IdSector"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["IdSector"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSector.Focus();
                ConsultarSectores();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Sector sector = new Entidades.Sector();
            sector.NombreSector = txtSector.Text.Trim();

            if (Actualizar)
            {
                sector.IdSector = IdSector;
                RBV_Negocio.MaestrosBO.ActualizarSector(sector);
                Actualizar = false;
            }
            else
            {
                RBV_Negocio.MaestrosBO.InsertarSector(sector);
            }

            ConsultarSectores();
            LimpiarPagina();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPagina();
        }

        private void ConsultarSectores()
        {
            grdSector.DataSource = RBV_Negocio.MaestrosBO.ConsultarSectores();
            grdSector.DataBind();
        }

        private void LimpiarPagina()
        {
            txtSector.Text = string.Empty;
            Actualizar = false;
        }

        protected void grdSector_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Actualizar = true;
            txtSector.Text = grdSector.Rows[e.NewEditIndex].Cells[0].Text;
            IdSector = Convert.ToInt16(grdSector.DataKeys[e.NewEditIndex].Value);
        }

        protected void grdSector_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //TODO: Mostra mensaje de confirmacion
            IdSector = Convert.ToInt16(grdSector.DataKeys[e.RowIndex].Value);
            RBV_Negocio.MaestrosBO.EliminarSector(IdSector);

            ConsultarSectores();
            LimpiarPagina();
        }

       
    }
}
