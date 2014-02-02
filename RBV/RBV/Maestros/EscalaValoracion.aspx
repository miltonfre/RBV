<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EscalaValoracion.aspx.cs"
    Inherits="RBV.Maestros.EscalaValoracion" MasterPageFile="~/Shared/Master.Master" %>

<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>
<%@ Register Src="SeleccionEmpresa.ascx" TagName="SeleccionEmpresa" TagPrefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
    <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>">
    </uc2:Titulo>
    <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
            <cc2:ValidationSummary ID="ValidationSummary1" runat="server" MensajeDeIntroduccion="<%$ Resources:vsCorregirErrores %>"
                ValidationGroup="CrearEscala" ShowMessageBox="true" ShowSummary="false" UpdatePanel="UpdatePanel6" />
            <div>
                <table>
                    <tr>
                        <td>
                            <uc1:SeleccionEmpresa ID="SeleccionEmpresa1" runat="server" OnEmpresaIndexChange="SeleccionEmpresa1_OnEmpresaIndexChange"/>
                        </td>
                    </tr>
                    <asp:Repeater ID="rptClasificaciones" runat="server" OnItemDataBound="LlenarEscala">
                        <ItemTemplate>
                            <tr>
                                <td style="background-color: #99CCFF">
                                    <asp:Label ID="lblCaracteristica" Font-Bold="true" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"ClasificacionRV") %>'></asp:Label>
                                </td>
                                <td style="background-color: #99CCFF">
                                    <asp:Label ID="lblValorSumaCaracteristica" Font-Bold="true" runat="server" Text='%'
                                        ForeColor="#CC0000"></asp:Label>
                                </td>
                                <asp:Repeater runat="server" ID="rptCaracteristicaxClasificacion" OnItemDataBound="LlenarEscalaValoracion">
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblCaracteristica" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"NombreCaracteristica") %>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lblIdCaracteristica" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"IdCaracteristica") %>'></asp:Label>
                                                <asp:TextBox ID="txtValor" runat="server" class="textbox" Columns="2" MaxLength="3"
                                                    OnTextChanged="txtValor_Changed" AutoPostBack="true"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfvEscalaval" runat="server" ErrorMessage="" Text="*"
                                                    ValidationGroup="CrearEscala" ControlToValidate="txtValor">
                                                </asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidaTalla" runat="server"
                                                    ControlToValidate="txtValor" Text="*" Display="Dynamic" ErrorMessage="Por favor ingrese un porcentaje correcto"
                                                    ValidationExpression="\d*\.?\d*" ValidationGroup="CrearEscala"></asp:RegularExpressionValidator>
                                                <asp:Label ID="lblPorcentaje" runat="server" Text='%'></asp:Label>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                    <tr>
                        <td align="center">
                            <asp:Button ID="btnEnviar" runat="server" Text="<%$ Resources:btnEnviar %>" OnClick="enviar_Click"
                                CausesValidation="true" ValidationGroup="CrearEscala" />
                            <asp:Button ID="btnCancelar" runat="server" Text="<%$ Resources:btnCancelar %>" OnClick="cancelar_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
