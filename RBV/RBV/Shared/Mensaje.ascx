<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Mensaje.ascx.cs" Inherits="RBV.Shared.Mensaje" %>
<%@ Register Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<Table style="padding:0;width:100%" >
    <tr>
        <td>
            <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
            <asp:Timer ID="tmtMensaje" runat="server" Enabled="false" ontick="Timer1_Tick">
            
            </asp:Timer>
        </td>
    </tr>
</Table>
