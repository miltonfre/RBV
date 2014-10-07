<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenerarReporte.ascx.cs"
    Inherits="RBV.Reportes.GenerarReporte" %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>
<%@ Register Src="../Maestros/SeleccionEmpresa.ascx" TagName="SeleccionEmpresa" TagPrefix="uc1" %>
<%@ Register Src="../Shared/Mensaje.ascx" TagName="Mensaje" TagPrefix="uc3" %>
<p>
    <br />
</p>
<ajaxToolkit:ToolkitScriptManager ID="scriptManager" runat="server">
</ajaxToolkit:ToolkitScriptManager>
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
                Equipo de Trabajo
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblCantidadParticipantes" runat="server" Text="<%$ Resources:lblNombre %>"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="<%$ Resources:lblCargo %>"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="<%$ Resources:lblFecha %>"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
            <tr>
                <td class="style1">
                    <asp:TextBox ID="txtNombre1" runat="server" Width="270" MaxLength="100"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtCargo1" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtCalendar1" runat="server" Width="150" MaxLength="100"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" TargetControlID="txtCalendar1"
                        runat="server">
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
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" TargetControlID="txtCalendar2"
                        runat="server">
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
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender3" TargetControlID="txtCalendar3"
                        runat="server">
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
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender4" TargetControlID="txtCalendar4"
                        runat="server">
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
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender5" TargetControlID="txtCalendar5"
                        runat="server">
                    </ajaxToolkit:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:Button ID="btnGenerarReporte" runat="server" CssClass="butt" OnClick="btnGenerarReporte_Click"
                        Text="<%$ Resources:btnGenerarReporte %>" />
                </td>
            </tr>
        </tr>
    </table>
    <style type="text/css">
        .modalBackground
        {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
        }
        .modalPopup
        {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 15px;
            padding-left: 10px;
            width: 900px;
            height: 550px;
        }
    </style>
    <asp:Button ID="btnShow" runat="server" Text="Show Modal Popup" Visible="false" />
    <ajaxToolkit:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panel1" TargetControlID="btnGenerarReporte"
        CancelControlID="btnClose" BackgroundCssClass="modalBackground">
    </ajaxToolkit:ModalPopupExtender>
    <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center" Style="display: none">
        <table>
            <tr>
                <td align="center">
                    <asp:Label ID="lblMensaje" runat="server" Text="Esta funcionalidad se encuentra en construcción"
                        Style="text-align: left"></asp:Label>
                </td>
                <td align="right" style="padding-top:10px">
                        <img src="../img/lock.jpg" style="text-align: center;width:50%" />
                </td>
            </tr>
            <tr>
            <td align="center" style="padding-left:15">
            <asp:Button ID="btnClose" runat="server" Text="Aceptar" CssClass="butt" />
            </td>
            </tr>
        </table>

        
    </asp:Panel>
</div>
