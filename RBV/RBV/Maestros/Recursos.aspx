<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recursos.aspx.cs" Inherits="RBV.Maestros.Recursos" %>

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
                    <asp:Label ID="lblEmpresa" Text="Empresa: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEmpresas" runat="server" DataValueField="IdEmpresa"
                        DataTextField="NombreEmpresa" 
                        onselectedindexchanged="ddlEmpresas_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTipoRecurso" Text="Tipo Recurso: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTipoRecurso" runat="server" DataValueField="IdTipoRecurso"
                        DataTextField="NombreTipoRecurso">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNombreRecurso" Text="Recurso: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRecurso" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDescripcion" Text="Descrición: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescripcion" TextMode="MultiLine" runat="server"></asp:TextBox>
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
                    <asp:GridView ID="grdRecurso" runat="server" AutoGenerateColumns="False" OnRowEditing="grdRecurso_RowEditing"
                        OnRowDeleting="grdRecurso_RowDeleting" DataKeyNames="IdRecursoEmpresa">
                        <Columns>
                            <asp:TemplateField HeaderText="Tipo Recurso" >
                                <ItemTemplate>
                                    <asp:Label ID="lblTipoRecursoG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"TipoRecurso.NombreTipoRecurso") %>' ></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField >
                            <asp:BoundField DataField="NombreRecurso" HeaderText="Recurso" />
                            <asp:BoundField DataField="DescripcionRecurso" HeaderText="Descripción" />
                            <asp:TemplateField Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lblIdTipoRecursoG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"TipoRecurso.IdTipoRecurso") %>' ></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField >
                            <asp:TemplateField Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lblIdEmprsaG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Empresa.IdEmpresa") %>'></asp:Label>
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
