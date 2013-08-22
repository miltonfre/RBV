<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empresa.aspx.cs" Inherits="RBV.Maestros.Empresa" MasterPageFile="~/Shared/Master.Master" %>

    <asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <div>
    <table>
            <tr>
                <td>
                    <asp:Label ID="lblEmpresa" Text="Nombre Empresa: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmpresa" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNit" Text="NIT: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNIT" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRepresentante" Text="Representante Legal: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRepresentante" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSector" Text="Sector: *" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:CheckBoxList ID="chklSector" runat="server" DataValueField="IdSector" DataTextField="NombreSector"></asp:CheckBoxList>
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
                <asp:GridView ID="grdEmpresas" runat="server" 
                    AutoGenerateColumns="False" onrowediting="grdEmpresas_RowEditing" 
                    onrowdeleting="grdEmpresas_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="idEmpresa" HeaderText="Id Empresa" />
                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Nombre Empresa" />
                        <asp:BoundField DataField="nit" HeaderText="NIT" />
                        <asp:BoundField DataField="represetanteLegal" HeaderText="Representante Legal" />
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