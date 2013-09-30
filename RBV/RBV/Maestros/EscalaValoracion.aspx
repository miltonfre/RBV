<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EscalaValoracion.aspx.cs" Inherits="RBV.Maestros.EscalaValoracion" MasterPageFile="~/Shared/Master.Master"  %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
 <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"/> 
 <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>"></uc2:Titulo>

 <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
            <cc2:validationsummary ID="ValidationSummary1" runat="server" MensajeDeIntroduccion="<%$ Resources:vsCorregirErrores %>"
                ValidationGroup="CrearEscala" ShowMessageBox="true" ShowSummary="false"
                UpdatePanel="UpdatePanel6" />
   
    <div>
        <table>
            <asp:Repeater ID="rptClasificaciones" runat="server" OnItemDataBound="LlenarEscala"  >
            <itemtemplate>
                <tr>
                    <td  style="background-color:#99CCFF">
                        <asp:Label ID="lblCaracteristica" Font-Bold="true" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"ClasificacionRV") %>'></asp:Label>
                         </td>
                                        <td style="background-color:#99CCFF"    >
                        <asp:Label ID="lblValorSumaCaracteristica" Font-Bold="true" runat="server" Text='%' ForeColor="#CC0000"></asp:Label>
                    </td>
                    <asp:Repeater runat="server"  id="rptCaracteristicaxClasificacion" OnItemDataBound="LlenarEscalaValoracion">
                                  <ItemTemplate >
                                  <tr>
                                        <td>
                                            <asp:Label ID="lblCaracteristica" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"NombreCaracteristica") %>'></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtValor" runat="server" class="textbox" Columns="2" MaxLength="3" OnTextChanged="txtValor_Changed" AutoPostBack="true" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvEscalaval" runat="server" ErrorMessage="" Text="*" ValidationGroup="CrearEscala" ControlToValidate="txtValor">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidaTalla" runat="server" ControlToValidate="txtValor" Text="*" Display="Dynamic" ErrorMessage="Por favor ingrese un porcentaje correcto" ValidationExpression="^\d+$" ValidationGroup="CrearEscala"></asp:RegularExpressionValidator>
                                            <asp:Label ID="lblPorcentaje" runat="server" Text='%'></asp:Label>
                                        </td>
                                    </tr>
                                   </itemtemplate>
                    </asp:Repeater>
                </tr>
                </itemtemplate>
            </asp:Repeater>
            <tr>
            <td align="center">
            <asp:Button ID="btnEnviar" runat="server" Text="<%$ Resources:btnEnviar %>" onclick="enviar_Click" CausesValidation="true" ValidationGroup="CrearEscala"   />
            <asp:Button ID="btnCancelar" runat="server" Text="<%$ Resources:btnCancelar %>" onclick="cancelar_Click"   />
            </td>
            </tr>
        </table>
    </div>
     </ContentTemplate>
    </asp:UpdatePanel>
 </asp:Content>
