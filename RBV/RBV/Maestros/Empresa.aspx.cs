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
                ConsultarSectores();
                ConsultarEmpresas();                
            }
        }

        private void ConsultarSectores()
        {
            chklSector.DataSource = RBV_Negocio.MaestrosBO.ConsultarSectores();
            chklSector.DataBind();
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

            List<Entidades.SectorEmpresa> SectorEmpresas = new List<Entidades.SectorEmpresa>();
            foreach (ListItem item in chklSector.Items)
	        {
                if (item.Selected)
                {
                    Entidades.SectorEmpresa sectorEmpresa = new Entidades.SectorEmpresa();
                    sectorEmpresa.IdSector = Convert.ToInt16(item.Value);
                    SectorEmpresas.Add(sectorEmpresa);                    
                }
	        }
            empresa.SectoresEmpresas = SectorEmpresas;

            empresa.EmpresasUsuarios = new Entidades.EmpresaUsuario();
            empresa.EmpresasUsuarios.UserName = User.Identity.Name;

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
            chklSector.ClearSelection();
        }

        protected void grdEmpresas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Actualizar = true;
            txtEmpresa.Text = grdEmpresas.Rows[e.NewEditIndex].Cells[0].Text;
            txtNIT.Text = grdEmpresas.Rows[e.NewEditIndex].Cells[1].Text;
            txtRepresentante.Text = grdEmpresas.Rows[e.NewEditIndex].Cells[2].Text;
            IdEmpresa = Convert.ToInt16(grdEmpresas.DataKeys[e.NewEditIndex].Value); 

            List<Entidades.SectorEmpresa> sectoresEmpresas = RBV_Negocio.MaestrosBO.ConsultarSectorEmpresa(IdEmpresa);

            foreach (Entidades.SectorEmpresa item in sectoresEmpresas)
            {
                for (int i = 0; i < chklSector.Items.Count; i++)
			    {
                    if (chklSector.Items[i].Value.Equals(item.IdSector.ToString()))
	                {
                        chklSector.Items[i].Selected = true;
	                }
			        
			    }
                
            }
        }

        protected void grdEmpresas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //TODO: Mostra mensaje de confirmacion
            IdEmpresa = Convert.ToInt16(grdEmpresas.DataKeys[e.RowIndex].Value);
            RBV_Negocio.MaestrosBO.EliminarEmpresa(IdEmpresa, User.Identity.Name);

            ConsultarEmpresas();
            LimpiarPagina();
        }
    }
}
