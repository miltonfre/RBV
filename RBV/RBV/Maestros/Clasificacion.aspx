<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clasificacion.aspx.cs" MasterPageFile="~/Master.Master"
    Inherits="RBV.Maestros.Clasificacion" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblClasificion" Text="Clasificación: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtClasificacion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID ="btnGuardar" Text="Guardar" runat="server" 
                        onclick="btnGuardar_Click" />
                </td>
                <td>
                    <asp:Button ID ="btnCancelar" Text="Cancelar" runat="server" 
                        onclick="btnCancelar_Click" />
                </td>
            </tr>
            <tr>
            <td colspan="2">
                <asp:GridView ID="grdClasificaciones" runat="server" 
                    AutoGenerateColumns="False" onrowediting="grdClasificaciones_RowEditing" 
                    onrowdeleting="grdClasificaciones_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="IdClasificacionRV" HeaderText="Id Clasificacion" />
                        <asp:BoundField DataField="ClasificacionRV" HeaderText="ClasificacionRV" />
                        <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText ="Editar" 
                            EditImageUrl="~/images/ico_lapiz.gif" />
                        <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/ico_borrar.gif" HeaderText ="Eliminar" 
                            DeleteText="Eliminar" ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            </tr>
        </table>
    </div>
  </asp:Content>
