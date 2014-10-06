<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenerarReporte.ascx.cs" Inherits="RBV.Reportes.GenerarReporte" %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>
<%@ Register Src="../Maestros/SeleccionEmpresa.ascx" TagName="SeleccionEmpresa" TagPrefix="uc1" %>

<%@ Register src="../Shared/Mensaje.ascx" tagname="Mensaje" tagprefix="uc3" %>

<p>
    <br />
</p>
 
 <ajaxToolkit:ToolkitScriptManager ID="scriptManager" runat="server"></ajaxToolkit:ToolkitScriptManager>

        <uc3:Mensaje ID="Mensaje1" runat="server" />
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
           <asp:Label ID="Label2" runat="server" 
                Text="<%$ Resources:lblFecha %>"></asp:Label>
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
                            <td>
                                <asp:TextBox ID="txtCalendar1" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" TargetControlID="txtCalendar1" runat="server">
                                </ajaxToolkit:CalendarExtender>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <asp:TextBox ID="txtNombre2" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo2" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCalendar2" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender2" TargetControlID="txtCalendar2" runat="server">
                                </ajaxToolkit:CalendarExtender>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <asp:TextBox ID="txtNombre3" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo3" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                            </td>
                             <td>
                                <asp:TextBox ID="txtCalendar3" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender3" TargetControlID="txtCalendar3" runat="server">
                                </ajaxToolkit:CalendarExtender>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <asp:TextBox ID="txtNombre4" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo4" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCalendar4" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender4" TargetControlID="txtCalendar4" runat="server">
                                </ajaxToolkit:CalendarExtender>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <asp:TextBox ID="txtNombre5" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="txtCargo5" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCalendar5" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender5" TargetControlID="txtCalendar5" runat="server">
                                </ajaxToolkit:CalendarExtender>
                            </td>
                        </tr>
                   
   
        <tr>
            <td align="center" colspan="3">
                <asp:Button ID="btnGenerarReporte" runat="server" CssClass="butt"
                    onclick="btnGenerarReporte_Click" Text="<%$ Resources:btnGenerarReporte %>" />
            </td>
        </tr>
        
    </tr>
</table>
 </div>

