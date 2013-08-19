using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ArquitecturaCERO.Web;
using ArquitecturaCERO.Web.Services;
using ObjetosTO;
using ArquitecturaCERO.Interfaces;
using System.Collections.Generic;
using Telerik.Web.UI;
using Spring.Context;
using Spring.Context.Support;
using ArquitecturaCERO.Administracion;
using Utilidades.Logs;

namespace WebApplication.Shared
{
    public partial class Popup : System.Web.UI.MasterPage
    {
        private AdministracionController AdministracionController
        {
            get
            {
                IApplicationContext context = ContextRegistry.GetContext();
                return (AdministracionController)context["AdministracionController"];
            }
        }


        /// <summary>
        /// Identificador de la página que invocó este popup
        /// </summary>
        private string IdPadre
        {
            set
            {
                this.hIdPadre.Value = value;
            }
            get
            {
                return this.hIdPadre.Value;
            }
        }

        /// <summary>
        /// Nombre de la página invocada en este popup
        /// </summary>
        private string NombrePagina
        {
            set
            {
                this.hNombrePagina.Value = value;
            }
            get
            {
                return this.hNombrePagina.Value;
            }
        }

        /// <summary>
        /// Propiedad para almacenar los parametros que se retornaran como resultado al control que invocó el popup
        /// </summary>
        public Hashtable Resultado
        {
            get
            {
                if (string.IsNullOrEmpty(IdPadre))
                {
                    throw new Exception("Pagina inicializada incorrectamente");
                }

                if (Session[IdPadre + "_" + NombrePagina] == null)
                {
                    Session[IdPadre + "_" + NombrePagina] = new Hashtable();
                }
                return (Hashtable)Session[IdPadre + "_" + NombrePagina];
            }
        }

        /// <summary>
        /// Propiedad que recibe los parametros de entrada enviados por la pagina que invocó el popup
        /// </summary>
        private Hashtable parametrosEntrada;

        public Hashtable ParametrosEntrada
        {
            get { return parametrosEntrada; }
            set { parametrosEntrada = value; }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (string.IsNullOrEmpty(Request["idPadre"]))
                {
                    Response.Redirect("../Accion/MisAccionesPendientes.aspx");
                }
                IdPadre = Request["idPadre"];
                NombrePagina = this.Page.GetType().BaseType.FullName;
                parametrosEntrada = (Hashtable)Session[this.IdPadre + "_ParametrosPopup"];
                Session[this.IdPadre + "_ParametrosPopup"] = null;
            }
        }
     


        protected void Page_Load(object sender, EventArgs e)
        {
            ExpirePageCache();
            if (HttpContext.Current.Session != null && HttpContext.Current.Session["NombreUsuarioAutenticado"] != null)
            {
                if (!Page.IsPostBack)
                {
                    mostrarOcultarCampos(this.Page.AppRelativeVirtualPath, this);
                    ObjetosTO.MembershipUser usuario = null;

                    try
                    {
                        usuario = Comunes.UsuarioActual();

                    }
                    catch (Exception)
                    {
                    }
                    //Habilitar/Dehabilitar control de administración de etiquetas
                    if (Session["AdministradorEtiquetas"] == null)
                    {
                        if (usuario != null)
                        {
                            if (System.Web.Security.Roles.IsUserInRole(usuario.Name, "AdministradorEtiquetas"))
                            {
                                DbResourceControl1.Visible = true;
                                CheckBox chkShowIcons = (CheckBox)DbResourceControl1.FindControl("chkShowIcons");
                                if (chkShowIcons != null)
                                {
                                    chkShowIcons.Checked = false;
                                }
                                Session["AdministradorEtiquetas"] = true;
                            }
                            else
                            {
                                DbResourceControl1.Visible = false;
                                Session["AdministradorEtiquetas"] = false;
                            }
                        }
                    }
                    else
                    {
                        DbResourceControl1.Visible = Convert.ToBoolean(Session["AdministradorEtiquetas"]);
                        CheckBox chkShowIcons = (CheckBox)DbResourceControl1.FindControl("chkShowIcons");
                        if (chkShowIcons != null)
                        {
                            chkShowIcons.Checked = false;
                        }
                    }
                }
            }
            else
            {
                Telerik.Web.UI.RadScriptManager.RegisterStartupScript(this.Page, typeof(Page), "SesionFinalizada", "ControlarSesionFinalizada();", true);
            }
        }

        private void ExpirePageCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now - new TimeSpan(1, 0, 0));
            Response.Cache.SetLastModified(DateTime.Now);
            Response.Cache.SetAllowResponseInBrowserHistory(false);
        }

        public System.Web.UI.Control EncontrarControlRecursivo(System.Web.UI.Control padre, string nombreCompleto)
        {
            string elemento, resto;
            int indice;

            indice = nombreCompleto.IndexOf("_");

            if (indice >= 0)
            {
                elemento = nombreCompleto.Substring(0, indice);
                resto = nombreCompleto.Substring(indice + 1);

                System.Web.UI.Control resultado = padre.FindControl(elemento);
                if (resultado != null)
                {
                    return EncontrarControlRecursivo(resultado, resto);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return padre.FindControl(nombreCompleto);
            }
        }

        public void mostrarOcultarCampos(string url, MasterPage page)
        {
            string nombreControl;
            ContentPlaceHolder cph = (ContentPlaceHolder)page.FindControl("ContentPlaceHolder1");
            IList<PaginasAtributos> pagatr = AdministracionController.ConsultarAtributosPagina(url);
            foreach (PaginasAtributos atr in pagatr)
            {
                if (atr.IdAtributo.Input != null && atr.IdAtributo.Input != String.Empty)// && cph.FindControl(atr.IdAtributo.Input) != null)
                {
                    nombreControl = atr.IdAtributo.Input;

                    System.Web.UI.Control resultado = EncontrarControlRecursivo(cph, nombreControl);
                    if (resultado != null)
                    {
                        resultado.Visible = atr.Visible;
                    }
                }

                if (atr.IdAtributo.Label != null && atr.IdAtributo.Label != String.Empty)// && cph.FindControl(atr.IdAtributo.Label) != null)
                {
                    nombreControl = atr.IdAtributo.Label;

                    System.Web.UI.Control resultado = EncontrarControlRecursivo(cph, nombreControl);
                    if (resultado != null)
                    {
                        resultado.Visible = atr.Visible;
                    }
                }
                if (!atr.Visible)
                {
                    if (atr.IdAtributo.Rfv != null && atr.IdAtributo.Rfv != String.Empty)// && cph.FindControl(atr.IdAtributo.Rfv) != null)
                    {
                        if (atr.Requerido.HasValue)
                        {
                            nombreControl = atr.IdAtributo.Rfv;

                            BaseValidator resultado = (BaseValidator)EncontrarControlRecursivo(cph, nombreControl);
                            if (resultado != null)
                            {
                                resultado.Enabled = false;
                            }
                        }
                    }
                    if ((atr.IdAtributo.Rev != null) && (atr.IdAtributo.Rev != String.Empty))// && (cph.FindControl(atr.IdAtributo.Rev) != null))
                    {
                        if (atr.Requerido.HasValue)
                        {
                            nombreControl = atr.IdAtributo.Rev;

                            BaseValidator resultado = (BaseValidator)EncontrarControlRecursivo(cph, nombreControl);
                            if (resultado != null)
                            {
                                resultado.Enabled = false;
                            }
                        }
                    }
                }
                else
                {

                    if (atr.IdAtributo.Rfv != null && atr.IdAtributo.Rfv != String.Empty)// && cph.FindControl(atr.IdAtributo.Rfv) != null)
                    {
                        if (atr.Requerido.HasValue)
                        {
                            nombreControl = atr.IdAtributo.Rfv;

                            BaseValidator resultado = (BaseValidator)EncontrarControlRecursivo(cph, nombreControl);
                            if (resultado != null)
                            {
                                resultado.Enabled = atr.Requerido.Value;
                            }
                        }
                    }
                    if ((atr.IdAtributo.Rev != null) && (atr.IdAtributo.Rev != String.Empty))// && (cph.FindControl(atr.IdAtributo.Rev) != null))
                    {
                        nombreControl = atr.IdAtributo.Rev;
                        BaseValidator resultado = (BaseValidator)EncontrarControlRecursivo(cph, nombreControl);
                        if (resultado != null)
                        {
                            resultado.Enabled = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// abre un popup que funcione bien en IE6
        /// </summary>
        /// <param name="mpe">el modal popup extender del pop up</param>
        /// <param name="up">el update pane que contiene el mpe</param>
        public void abrirPopUp(AjaxControlToolkit.ModalPopupExtender mpe, UpdatePanel up)
        {
            abrirPopUp(mpe);
            up.Update();
        }

        public void abrirPopUp(AjaxControlToolkit.ModalPopupExtender mpe)
        {
            //Panel p = (Panel)this.FindControl("popUpBloqueo");
           // p.Style["display"] = "block";
           // Panel IF = (Panel)this.FindControl("iframeB");
//IF.Style["display"] = "block";
           // this.RadAjaxManager1.ResponseScripts.Add("MostrarDivsBloqueo()");
            mpe.Show();
        }

        public event EventoPopupCerrado PopupCerrado;

        /// <summary>
        /// Evento que ocurre cuando un popup invocado desde este popup ha sido cerrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void bPopupCerrado_Click(object sender, EventArgs e)
        {
            if (PopupCerrado != null)
            {
                // sacar variables de sesion y pasarlas como eventos y eliminarlas
                // sacar accion
                EventoPopupCerradoArgs argumentos;

                if (!string.IsNullOrEmpty(this.hResultadoPopupCerrado.Value))
                {
                    argumentos = new EventoPopupCerradoArgs(this.hAccionPopupCerrado.Value, this.hNombrePopupCerrado.Value, (Hashtable)Session[this.hResultadoPopupCerrado.Value]);
                }
                else
                {
                    argumentos = new EventoPopupCerradoArgs(this.hAccionPopupCerrado.Value, this.hNombrePopupCerrado.Value);
                }
                PopupCerrado(this, argumentos);

                Session[this.hResultadoPopupCerrado.Value] = null;
                this.hResultadoPopupCerrado.Value = "";
                this.hNombrePopupCerrado.Value = "";
                this.hAccionPopupCerrado.Value = "";
            }
        }

        /// <summary>
        /// Método que se debe invocar para cerrar este popup
        /// </summary>
        /// <param name="pagina"></param>
        /// <param name="accion">Acción </param>
        public void CerrarPopup(Page pagina, string accion)
        {
            string script = "cerrarPopup('" + accion + "', '" + pagina.GetType().BaseType.Name + "', '" + IdPadre + "_" + NombrePagina + "');";
            Comunes.EjecutarScriptAsincrono(pagina, "ScriptCerrarPopup", script);
        }

        /// <summary>
        /// Método que se debe invocar para abrir un popup desde este popup
        /// </summary>
        /// <param name="pagina"></param>
        /// <param name="url"></param>
        /// <param name="parametrosUrl"></param>
        /// <param name="ancho"></param>
        /// <param name="alto"></param>
        public void AbrirPopupRadWindow(Page pagina, string url, string parametrosUrl, string ancho, string alto)
        {
            Session[this.IdPadre + "_" + NombrePagina + "_ParametrosPopup"] = null;
            url = Page.ResolveUrl(url) + "?idPadre=" + IdPadre + "_" + NombrePagina + "&" + parametrosUrl;
            string script = "abrirRadWindow('" + url + "', " + ancho + ", " + alto + ");";
            Comunes.EjecutarScriptAsincrono(pagina, "ScriptAbrirPopup", script);
        }

        /// <summary>
        /// Método que se debe invocar para abrir un popup desde este popup incluyendo parametros por sesion
        /// </summary>
        /// <param name="pagina"></param>
        /// <param name="url"></param>
        /// <param name="parametrosUrl"></param>
        /// <param name="ancho"></param>
        /// <param name="alto"></param>
        public void AbrirPopupRadWindow(Page pagina, string url, string parametrosUrl, string ancho, string alto, Hashtable parametrosSesion)
        {
            AbrirPopupRadWindow(pagina, url, parametrosUrl, ancho, alto);
            Session[this.IdPadre + "_" + NombrePagina + "_ParametrosPopup"] = parametrosSesion;
        }

        public void MostrarMensaje(string mensaje)
        {
            Mensaje.MostrarMensaje(mensaje);
        }

        public int NumeroRegistrosPagina()
        {
            return Comunes.NumeroRegistrosPagina();
        }

        protected void RadScriptManager1_AsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            UtilidadLogs.RegistrarError(e.Exception, this.Page.GetType());
        }
    }
}
