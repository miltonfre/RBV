<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EscalaCalificacion.aspx.cs" Inherits="RBV.Maestros.EscalaCalificacion" MasterPageFile="~/Shared/Master.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <div>
    <table>
            <tr>
                <td>
                    <asp:Label ID="lblEmpresa" Text="Empresa: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEmpresas" DataValueField="idEmpresa" 
                        DataTextField="nombreEmpresa" runat="server" 
                        onselectedindexchanged="ddlEmpresas_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEscala" Text="Escala: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEscala" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblValor" Text="Valor: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
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
                <asp:GridView ID="grdEscalaCalificaciones" runat="server" 
                    AutoGenerateColumns="False" onrowediting="grdEscalaCalificaciones_RowEditing" 
                    onrowdeleting="grdEscalaCalificaciones_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="IdEscalaCalificacion" HeaderText="Id Empresa" />
                        <asp:BoundField DataField="Escala" HeaderText="Nombre Empresa" />
                        <asp:BoundField DataField="Valor" HeaderText="NIT" />
                        <asp:BoundField DataField="idEmpresa" HeaderText="Empresa" Visible="false" />
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