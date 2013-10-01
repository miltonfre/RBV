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
        public short idEmpresa
        {
            set { Session["idEmpresa"] = value; }
            get { return (short)Session["idEmpresa"]; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //TODO: Cambiar empresa
                this.idEmpresa = 5;
                rptClasificaciones.DataSource = RBV_Negocio.MaestrosBO.ConsultarClasificaciones();
                rptClasificaciones.DataBind();

                foreach (RepeaterItem rptItemClasificaciones in rptClasificaciones.Items)
                {
                    Repeater rptCaracteristicaxClasificacion = (Repeater)rptItemClasificaciones.FindControl("rptCaracteristicaxClasificacion");
                    foreach (RepeaterItem rptItemCaracteristicaxClasificacion in rptCaracteristicaxClasificacion.Items)
                    {
                        TextBox txtValor = (TextBox)rptItemCaracteristicaxClasificacion.FindControl("txtValor");
                        CalcularClasificacion(txtValor);
                    }
                }
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
                List<Entidades.EscalaValoracion> lstEscalaxEmpresa = RBV_Negocio.MaestrosBO.ConsultarEscalaValoracion(this.idEmpresa, caracteristica.IdCaracteristica);
                if (lstEscalaxEmpresa.Count > 0)
                {
                    TextBox txtValor = (TextBox)e.Item.FindControl("txtValor");
                    txtValor.Text = lstEscalaxEmpresa[0].Valor.ToString();
                }
            }
        }

        protected void txtValor_Changed(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            CalcularClasificacion(textBox);
        }

        private static void CalcularClasificacion(TextBox textBox)
        {
           
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
                lblValorSumaCaracteristica.Text = suma.ToString() + "%";
            }
        }
        protected void enviar_Click(object sender, EventArgs e)
        {
            try
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
                        escala.IdEmpresa = this.idEmpresa;
                        listEscalaValoracion.Add(escala);
                    }
                }
                RBV_Negocio.MaestrosBO.InsertarEscalaValoracion(listEscalaValoracion);
                ScriptManager.RegisterClientScriptBlock(this.Page, typeof(Page), "MensajeValidaciones", "ALERT('Escala de valoración guardada satisfactoriamente')", true);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadLogs.RegistrarError(ex, this.GetType());
                ScriptManager.RegisterClientScriptBlock(this.Page, typeof(Page), "MensajeValidaciones", "ALERT('Ocurrió un error guardando la escala de valoración')", true);
            }
          
        }
        protected void cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empresa.aspx");
        }
    }
}
