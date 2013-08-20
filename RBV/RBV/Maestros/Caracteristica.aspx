﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Caracteristica.aspx.cs"
    Inherits="RBV.Maestros.Caracteristica" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblClasificion" Text="Clasificación: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlClasificacion" runat="server" DataValueField="IdClasificacionRV"
                        DataTextField="ClasificacionRV">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCaracteristica" Text="Caracteristica: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCaracteristica" runat="server"></asp:TextBox>
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
                    <asp:GridView ID="grdCaracteristica" runat="server" AutoGenerateColumns="False" OnRowEditing="grdCaracteristica_RowEditing"
                        OnRowDeleting="grdCaracteristica_RowDeleting">
                        <Columns>
                            <asp:BoundField DataField="IdCaracteristica" HeaderText="Id Caracteristica" />
                            <asp:BoundField DataField="NombreCaracteristica" HeaderText="Caracteristica" />
                            <asp:TemplateField Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lblIdClasificionG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"ClasificacionAsociada.IdClasificacionRV") %>' ></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Clasificacion">
                                <ItemTemplate>
                                    <asp:Label ID="lblNomClasificionG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"ClasificacionAsociada.ClasificacionRV") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText="Editar" EditImageUrl="~/images/ico_lapiz.gif" />
                            <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/ico_borrar.gif" HeaderText="Eliminar"
                                DeleteText="Eliminar" ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
