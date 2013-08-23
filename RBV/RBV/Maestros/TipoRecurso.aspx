<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Shared/Master.Master" CodeBehind="TipoRecurso.aspx.cs" Inherits="RBV.Maestros.TipoRecurso" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
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
                        DataKeyNames="IdTipoRecurso">
                        <Columns>
                            
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
  </asp:Content>
