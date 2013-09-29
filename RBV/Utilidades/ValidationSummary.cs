using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Utilidades
{
           /// <summary>
        /// This control inheirits the ASP.NET ValidationSummary control but adds
        /// the ability to dynamically add error messages without requiring 
        /// validation controls.
        /// </summary>
        /// <author>Scott Juranek</author>
        /// <remarks>3/4/2002: Original Implementation
        /// Modificado por Alejandro Diaz Betancourt 28/02/2007
        /// Modificado por Jefferson Muñoz 21/06/2007
        /// Modificado por Daniel Arbeláez 22/06/2007
        /// Modificado por Jefferson Muñoz 05/09/2007
        /// </remarks>
        public class ValidationSummary : System.Web.UI.WebControls.ValidationSummary
        {



            protected override void AddAttributesToRender(HtmlTextWriter writer)
            {
                base.AddAttributesToRender(writer);
                if (EnableClientScript /*&& Page.AreValidatorsUplevel()*/)
                {
                    /* force an ID here if we weren't assigned one */
                    if (ID == null)
                        writer.AddAttribute(HtmlTextWriterAttribute.Id, ClientID);



                    if (HeaderText != string.Empty && HeaderText != null)
                        writer.AddAttribute("headertext", HeaderText);
                    else
                    {
                        if (_mensajeDeIntroduccion == string.Empty || _mensajeDeIntroduccion == null)
                        {

                            writer.AddAttribute("headertext", "Mensaje no configurado");
                        }
                        else
                        {

                            writer.AddAttribute("headertext", _mensajeDeIntroduccion);

                        }
                    }

                    if (ShowMessageBox)
                        writer.AddAttribute("showmessagebox", ShowMessageBox.ToString());

                    if (ShowSummary == false)
                        writer.AddAttribute("showsummary", ShowSummary.ToString());

                    if (DisplayMode != ValidationSummaryDisplayMode.BulletList)
                        writer.AddAttribute("displaymode", DisplayMode.ToString());

                    /*if (!has_errors)
                        writer.AddStyleAttribute("display", "none");*/

                }
            }



            protected override void Render(HtmlTextWriter writer)
            {


                base.Render(writer);

                ValidatorCollection validators;
                ArrayList errors;
                ArrayList realMessage;



                // First, figure out if there's even data to deal with

                validators = Page.GetValidators(ValidationGroup);

                if (validators.Count == 0)
                {
                    return;
                }

                // We have validators
                errors = new ArrayList();
                realMessage = new ArrayList();
                for (int i = 0; i < validators.Count; i++)
                {
                    if (!validators[i].IsValid)
                    {

                        errors.Add(validators[i].ErrorMessage);


                    }
                }
                has_errors = errors.Count > 0;



                if (has_errors)
                {
                    if (HeaderText == "")
                        this.HeaderText = _mensajeDeIntroduccion;

                    string listado = String.Empty;
                    if (_mensajeDeIntroduccion != null && _mensajeDeIntroduccion != String.Empty)
                    {
                        listado += _mensajeDeIntroduccion + @"\n";
                    }
                    switch (DisplayMode)
                    {
                        case ValidationSummaryDisplayMode.BulletList:
                            {
                                if (_pre == null)
                                {
                                    _pre = "- ";
                                }
                                if (_post == null)
                                {
                                    _post = @"\n";
                                }
                                break;
                            }
                        case ValidationSummaryDisplayMode.List:
                            {
                                if (_pre == null)
                                {
                                    _pre = String.Empty;
                                }
                                if (_post == null)
                                {
                                    _post = @"\n";
                                }
                                break;
                            }
                        case ValidationSummaryDisplayMode.SingleParagraph:
                            {
                                if (_pre == null)
                                {
                                    _pre = String.Empty;
                                }
                                if (_post == null)
                                {
                                    _post = "; ";
                                }
                                break;
                            }
                        default:
                            {
                                if (_pre == null)
                                {
                                    _pre = "- ";
                                }
                                if (_post == null)
                                {
                                    _post = @"\n";
                                }
                                break;
                            }
                    }
                    for (int i = 0; i < errors.Count; i++)
                    {
                        listado += _pre + errors[i] + _post;
                    }

                    // Se Debe adicionar la alerta
                   // Comunes.ShowAsyncMessageBox(Page, "scriptShowSummaryAlert", listado);
                    //Comunes.ShowAsyncMessageBox(Page.Master.FindControl("DefaultContent").FindControl(_updatePanel), "scriptShowSummaryAlert", listado);
                }

            }


            bool has_errors;
            private string _updatePanel;
            public string UpdatePanel
            {
                get { return _updatePanel; }
                set { _updatePanel = value; }
            }
            private string _pre;
            public string Pre
            {
                get { return _pre; }
                set { _pre = value; }
            }
            private string _post;
            public string Post
            {
                get { return _post; }
                set { _post = value; }
            }
            private string _mensajeDeIntroduccion;
            public string MensajeDeIntroduccion
            {
                get { return _mensajeDeIntroduccion; }
                set { _mensajeDeIntroduccion = value; }
            }
        }
}
