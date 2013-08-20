<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TipoRecurso.aspx.cs" Inherits="RBV.Maestros.TipoRecurso" %>

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
                    <asp:Label ID="lblTipoRecurso" Text="Tipo Recurso: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTipoRecurso" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGuardar" Text="Guardar" runat="server" OnClick="btnGuardar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" OnClick="btnCancelar_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="grdTipoRecurso" runat="server" AutoGenerateColumns="False" 
                        onrowdeleting="grdTipoRecurso_RowDeleting" onrowediting="grdTipoRecurso_RowEditing" 
                        >
                        <Columns>
                            <asp:BoundField DataField="IdTipoRecurso" HeaderText="Id Sector" />
                            <asp:BoundField DataField="NombreTipoRecurso" HeaderText="Sector" />
                            <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText="Editar" EditImageUrl="~/images/ico_lapiz.gif" />
                            <asp:CommandField DeleteText="Eliminar" ShowDeleteButton="True" HeaderText="Eliminar"
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
