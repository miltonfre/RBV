<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SeleccionEmpresa.ascx.cs"
    Inherits="RBV.Maestros.SeleccionEmpresa" %>
<table>
    <tr>
        <td>
            <asp:Label ID="lblEmpresaUsr" runat="server" Text="Empresa:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlEmpresaUsr" runat="server" DataValueField="IdEmpresa" 
                DataTextField="NombreEmpresa" AutoPostBack="true"
                onselectedindexchanged="ddlEmpresaUsr_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
</table>
