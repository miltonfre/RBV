<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EscalaValoracion.aspx.cs" Inherits="RBV.Maestros.EscalaValoracion" MasterPageFile="~/Shared/Master.Master"  %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>

<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
 <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"/> 
 <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>"></uc2:Titulo>

    <script src="../js/jquery-1.10.2.js" type="text/javascript"></script>

        <script type="text/javascript">

            $(document).ready(function() {

            $("#enviar").click(function() {

                    send();
                });


            });

            function send() {

               var valor = 0;

               $(".textbox").each(function(index) {

                   if ($(this).val() == "") {
                       valor = valor + 0;
                   }
                   else {
                       valor = valor + eval($(this).val());
                   }
               });
               if (valor > 100) {
                   alert("La sumatoria de los valores no puede superar el 100%, valor: " + valor);
               }
               else if (valor < 100) {
                   alert("La sumatoria de los valores esta por debajo del 100%, valor: " + valor);
               }            
            }
        
        </script>
<asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
            <cc2:validationsummary ID="ValidationSummary1" runat="server" MensajeDeIntroduccion="<%$ Resources:vsCorregirErrores %>"
                ValidationGroup="CrearROl" ShowMessageBox="true" ShowSummary="false"
                UpdatePanel="UpdatePanel6" />
   
    <div>
        <table>
            <asp:Repeater ID="rptValoracion" runat="server">
            <itemtemplate>
                <tr>
                    <td>
                        
                            <asp:Label ID="lblCaracteristica" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"NombreCaracteristica") %>'></asp:Label>
                        
                    </td>
                    <td>
                        <asp:TextBox ID="txtValor" runat="server" class="textbox" ></asp:TextBox>
                    </td>
                </tr>
                </itemtemplate>
            </asp:Repeater>
            <tr>
            <td>
            <asp:Button ID="enviar" runat="server" Text="enviar" onclick="enviar_Click"   />
            </td>
            </tr>
        </table>
    </div>
     </ContentTemplate>
    </asp:UpdatePanel>
 </asp:Content>
