<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenerarReporte.ascx.cs" Inherits="RBV.Reportes.GenerarReporte" %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>
<%@ Register Src="../Maestros/SeleccionEmpresa.ascx" TagName="SeleccionEmpresa" TagPrefix="uc1" %>

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
 <uc1:SeleccionEmpresa ID="SeleccionEmpresa1" runat="server" />
<table>
    <tr>
          <td style="background-color: #99CCFF" colspan="3">
              Equipo de Trabajo</td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Label ID="lblCantidadParticipantes" runat="server" 
                Text="<%$ Resources:lblNombre %>"></asp:Label>
        </td>
        <td>
           <asp:Label ID="Label1" runat="server" 
                Text="<%$ Resources:lblCargo %>"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
   
                        <tr>
                            <td class="style1">
                                <asp:TextBox ID="txtNombre1" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo1" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="style1">
                                <asp:TextBox ID="txtNombre2" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo2" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="style1">
                                <asp:TextBox ID="txtNombre3" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo3" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="style1">
                                <asp:TextBox ID="txtNombre4" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo4" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="style1">
                                <asp:TextBox ID="txtNombre5" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo5" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                            </td>
                            
                        </tr>
                   
   
        <tr>
            <td align="center" colspan="3">
                <asp:Button ID="btnGenerarReporte" runat="server" 
                    onclick="btnGenerarReporte_Click" Text="<%$ Resources:btnGenerarReporte %>" />
            </td>
        </tr>
        
    </tr>
</table>
 </div>
  </ContentTemplate>
    </asp:UpdatePanel>

