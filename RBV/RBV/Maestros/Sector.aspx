<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sector.aspx.cs" Inherits="RBV.Maestros.Sector" MasterPageFile="~/Master.Master"  %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
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
                    <asp:Button ID="btnGuardar" Text="Guardar" runat="server" OnClick="btnGuardar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" OnClick="btnCancelar_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="grdSector" runat="server" AutoGenerateColumns="False" OnRowDeleting="grdSector_RowDeleting"
                        OnRowEditing="grdSector_RowEditing">
                        <Columns>
                            <asp:BoundField DataField="idSector" HeaderText="Id Sector" />
                            <asp:BoundField DataField="NombreSector" HeaderText="Sector" />
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
