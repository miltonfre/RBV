<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sector.aspx.cs" Inherits="RBV.Maestros.Sector" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <table>
            <tr>
                <td>
                    <asp:Label ID="lblSector" Text="Sector: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSector" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID ="btnGuardar" Text="Guardar" runat="server" onclick="btnGuardar_Click" 
                         />
                </td>
                <td>
                    <asp:Button ID ="btnCancelar" Text="Cancelar" runat="server" onclick="btnCancelar_Click" 
                         />
                </td>
            </tr>
            <tr>
            <td colspan="2">
                <asp:GridView ID="grdSector" runat="server" 
                    AutoGenerateColumns="False" onrowdeleting="grdSector_RowDeleting" 
                    onrowediting="grdSector_RowEditing" >
                    <Columns>
                        <asp:BoundField DataField="idSector" HeaderText="Id Sector" />
                        <asp:BoundField DataField="NombreSector" HeaderText="Sector" />
                        <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText ="Editar" 
                            EditImageUrl="~/images/ico_lapiz.gif" />
                        <asp:CommandField DeleteText="Eliminar" ShowDeleteButton="True" HeaderText ="Eliminar" 
                            ButtonType="Image" DeleteImageUrl="~/images/ico_borrar.gif" />
                    </Columns>
                </asp:GridView>
            </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
