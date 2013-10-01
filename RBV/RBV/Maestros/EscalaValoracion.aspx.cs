using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades = RBV_Clases;

namespace RBV.Maestros
{
    public partial class EscalaValoracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                rptClasificaciones.DataSource = RBV_Negocio.MaestrosBO.ConsultarClasificaciones();
                rptClasificaciones.DataBind();
            }
        }

        public void LlenarEscala(Object obj, RepeaterItemEventArgs e)
        {
            int indice = e.Item.ItemIndex;
            if (indice > -1)
            {
                Repeater rptCaracteristicaxClasificacion = (Repeater)e.Item.FindControl("rptCaracteristicaxClasificacion");
                Entidades.Clasificacion clasific = new Entidades.Clasificacion();
                clasific = (Entidades.Clasificacion)(e.Item.DataItem);
                rptCaracteristicaxClasificacion.DataSource = RBV_Negocio.MaestrosBO.ConsultarCaracteristicasxClasificacion(clasific);
                rptCaracteristicaxClasificacion.DataBind();
               
            }
        }
        public void LlenarEscalaValoracion(Object obj, RepeaterItemEventArgs e)
        {
            int indice = e.Item.ItemIndex;
            if (indice > -1)
            {
                Entidades.Caracteristica caracteristica = new Entidades.Caracteristica();
                caracteristica=(Entidades.Caracteristica)(e.Item.DataItem);
                RequiredFieldValidator rfvEscalaval = (RequiredFieldValidator)e.Item.FindControl("rfvEscalaval");
                rfvEscalaval.ErrorMessage = caracteristica.NombreCaracteristica +" Es requerida";
            }
        }

        protected void txtValor_Changed(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int suma = 0;
            Label lblValorSumaCaracteristica = new Label();
            if (textBox != null)
            {
                Repeater rptCaracteristicaxClasificacion = (Repeater)textBox.Parent.Parent;
                foreach (RepeaterItem control in rptCaracteristicaxClasificacion.Items)
                {
                    if (control.FindControl("txtValor") != null)
                    {
                        TextBox txtValor = (TextBox)control.FindControl("txtValor");
                        int nuevoValor = 0;
                        if (int.TryParse(txtValor.Text, out nuevoValor))
                        {
                            suma = suma + nuevoValor;
                        }
                        else
                        {
                            txtValor.Text = string.Empty;
                        }
                     }
                }
                lblValorSumaCaracteristica = (Label)rptCaracteristicaxClasificacion.Parent.FindControl("lblValorSumaCaracteristica");
                lblValorSumaCaracteristica.Text = suma.ToString()+"%";
            }
        }
        protected void enviar_Click(object sender, EventArgs e)
        {
            List<Entidades.EscalaValoracion> listEscalaValoracion = new List<RBV_Clases.EscalaValoracion>();
            foreach (RepeaterItem rptItemClasificaciones in rptClasificaciones.Items)
            {
                Repeater rptCaracteristicaxClasificacion = (Repeater)rptItemClasificaciones.FindControl("rptCaracteristicaxClasificacion");
                foreach (RepeaterItem rptItemCaracteristicaxClasificacion in rptCaracteristicaxClasificacion.Items)
                {
                    TextBox txtValor = (TextBox)rptItemCaracteristicaxClasificacion.FindControl("txtValor");                   
                    Entidades.EscalaValoracion escala = new Entidades.EscalaValoracion();
                    escala.IdCaracteristica = short.Parse(((Label)rptItemCaracteristicaxClasificacion.FindControl("lblIdCaracteristica")).Text);
                    escala.Valor = decimal.Parse(txtValor.Text);
                    //TODO: Cambiar empresa
                    escala.IdEmpresa = 5;
                    listEscalaValoracion.Add(escala);
                }
            }
            RBV_Negocio.MaestrosBO.InsertarEscalaValoracion(listEscalaValoracion);
        }
        protected void cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empresa.aspx");
        }
    }
}
