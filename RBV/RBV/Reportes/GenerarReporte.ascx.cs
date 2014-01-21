using System;
using System.Web.UI;
using RBV_Clases;
using System.Web.UI.DataVisualization.Charting;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace RBV.Reportes
{
    public partial class GenerarReporte : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SeleccionEmpresa1.Usuario =this.Page.User.Identity.Name;
                SeleccionEmpresa1.ConsultarEmpresas();
                
            }
        }
        protected void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            RBV_Negcio.InformeBO genWord = new RBV_Negcio.InformeBO();
            Empresa empresa = RBV_Negocio.MaestrosBO.ConsultarEmpresaxID(SeleccionEmpresa1.IdEmpresa);

            Informe informe = new Informe();
            informe.Empresa = empresa;
            informe.RolesInforme = llenarRolesInforme();

            string archivo = genWord.CrearWordWithDocX(informe);
            Response.Redirect(archivo, true);

            //Response.Clear();
            //Response.AddHeader("Content-Disposition", "attachment; filename=" + path);
            ////Response.AddHeader("Content-Length", file.Length.ToString());
            //Response.ContentType = "text/plain";
            //Response.WriteFile(path);
            //Response.Flush();
            //Response.End();

            //Response.Clear();
            //Response.AddHeader("Content-Disposition", "attachment; filename=" + archivo);
            ////Response.AddHeader("Content-Length", file.Length.ToString());
            //Response.ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            //Response.WriteFile(archivo);
            //Response.Flush();
            //Response.End();
        }


        private List<RolesInforme> llenarRolesInforme()
        {
            List<RolesInforme> rolesInforme = new List<RolesInforme>();
            RolesInforme objRolesInforme = new RolesInforme();
            if (!string.IsNullOrEmpty(txtNombre1.Text) || !string.IsNullOrEmpty(txtCargo1.Text))
            {
                objRolesInforme.NombreParticipante = txtNombre1.Text;
                objRolesInforme.Rol = txtCargo1.Text;
                rolesInforme.Add(objRolesInforme);
            }          
            if (!string.IsNullOrEmpty(txtNombre2.Text) || !string.IsNullOrEmpty(txtCargo2.Text))
            {
                objRolesInforme = new RolesInforme();
                objRolesInforme.NombreParticipante = txtNombre2.Text;
                objRolesInforme.Rol = txtCargo2.Text;
                rolesInforme.Add(objRolesInforme);
            }

            if (!string.IsNullOrEmpty(txtNombre3.Text) || !string.IsNullOrEmpty(txtCargo3.Text))
            {
                objRolesInforme = new RolesInforme();
                objRolesInforme.NombreParticipante = txtNombre3.Text;
                objRolesInforme.Rol = txtCargo3.Text;
                rolesInforme.Add(objRolesInforme);
            }
            if (!string.IsNullOrEmpty(txtNombre4.Text) || !string.IsNullOrEmpty(txtCargo4.Text))
            {
                objRolesInforme = new RolesInforme();
                objRolesInforme.NombreParticipante = txtNombre4.Text;
                objRolesInforme.Rol = txtCargo4.Text;
                rolesInforme.Add(objRolesInforme);
            }
            if (!string.IsNullOrEmpty(txtNombre5.Text) || !string.IsNullOrEmpty(txtCargo5.Text))
            {
                objRolesInforme = new RolesInforme();
                objRolesInforme.NombreParticipante = txtNombre5.Text;
                objRolesInforme.Rol = txtCargo5.Text;
                rolesInforme.Add(objRolesInforme);
            }
            return rolesInforme;
        }
    }
}