<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MensajeConfirmacion.ascx.cs" Inherits="WebApplication.Shared.MensajeConfirmacion" %>
 <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

 <asp:HiddenField ID="hdfMensaje" runat="server" />
 <ajaxToolkit:ModalPopupExtender ID="PopupMensajePersonalizado" runat="server" PopupControlID="PanelMensaje"  CancelControlID="hdfMensaje" TargetControlID="hdfMensaje"/>

 <asp:Panel  ID="PanelMensaje" runat="server" >
    <div id="popupMensaje">
			<div id="popupMensajeTitulo">CERO</div>
			<div id="popupMensajeTexto"> <asp:Label ID="lblMensaje" runat="server" Font-Bold="true"/></div>
			<div id="popupMensajeIco"></div>
			
			<table>
			    <tr>
			        <td >
                        <asp:Button ID="btnSi" runat="server"  Text="<%$ Resources:btnSi %>"  OnClick="HacerClickSi" /></td>
			        <td>
                    <asp:Button ID="btnNo" runat="server" Text="<%$ Resources:btnNo %>" OnClick="HacerClickNo" /></td>
			    </tr>
			</table>
			
			
	</div>
  </asp:Panel>
<ajaxToolkit:DragPanelExtender ID="Movedor" runat ="server" TargetControlID="PanelMensaje"  DragHandleID="PanelMensaje"/>