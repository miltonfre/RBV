<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenerarReporte.ascx.cs" Inherits="RBV.Reportes.GenerarReporte" %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>
<%@ Register Src="SeleccionEmpresa.ascx" TagName="SeleccionEmpresa" TagPrefix="uc1" %>

<p>
    <br />
</p>
 <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
 <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
            <cc2:ValidationSummary ID="vsCargarRoles" runat="server" MensajeDeIntroduccion="<%$ Resources:vsCorregirErrores %>"
                ValidationGroup="CargarRoles" ShowMessageBox="true" ShowSummary="false" UpdatePanel="UpdatePanel6" />
                 <cc2:ValidationSummary ID="vsGenerarInforme" runat="server" MensajeDeIntroduccion="<%$ Resources:vsCorregirErrores %>"
                ValidationGroup="GenerarInforme" ShowMessageBox="true" ShowSummary="false" UpdatePanel="UpdatePanel6" />
                
 <div id="company-page" class="page">
  <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>">
    </uc2:Titulo>
 <uc1:SeleccionEmpresa ID="SeleccionEmpresa1" runat="server" OnEmpresaIndexChange="SeleccionEmpresa1_OnEmpresaIndexChange"/>
<table>
    <tr>
        <td class="style2">
            <asp:Label ID="lblCantidadParticipantes" runat="server" Text="<%$ Resources:lblCantidadParticipantes %>"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvCantidad" runat="server" ErrorMessage="<%$ Resources:rfvCantidad %>" Text="*" ValidationGroup="CargarRoles" ControlToValidate="txtCantidad">
                        </asp:RequiredFieldValidator>
                         <asp:RangeValidator ValidationGroup="CargarRoles" ID="rgCantidad" ControlToValidate="txtCantidad"
                            MaximumValue="5" Display="Dynamic" ErrorMessage="<%$ Resources:rgCantidad %>"
                            Text="*" MinimumValue="1" Type="Integer" runat="server"></asp:RangeValidator>
            </td>
        <td >
            <asp:Button ID="btnCargar" runat="server" Text="<%$ Resources:btnCargar %>" 
                CausesValidation="true" ValidationGroup="CargarRoles" 
                onclick="btnCargar_Click" />
            </td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="3" align="center">
<asp:Button ID="btnGenerarReporte" runat="server" 
    onclick="btnGenerarReporte_Click" Text="<%$ Resources:btnGenerarReporte %>" />
        </td>
        
    </tr>
</table>
 </div>
  </ContentTemplate>
    </asp:UpdatePanel>

