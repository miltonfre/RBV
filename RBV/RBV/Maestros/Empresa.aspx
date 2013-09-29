<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empresa.aspx.cs" Inherits="RBV.Maestros.Empresa"
    MasterPageFile="~/Shared/Master.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <!--<div id="company-right-container">
            <asp:Image runat="server" ImageUrl="~/img/Login/2.png" AlternateText="Image" ImageAlign="Middle" />
        </div>-->
    <div id="company-page" class="page">
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
                    <asp:CheckBoxList ID="chklSector" runat="server" DataValueField="IdSector" DataTextField="NombreSector">
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnGuardar" Text="Guardar" runat="server" OnClick="btnGuardar_Click" CssClass="butt"/>
                    <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" OnClick="btnCancelar_Click" CssClass="butt"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="grdEmpresas" runat="server" AutoGenerateColumns="False" OnRowEditing="grdEmpresas_RowEditing"
                        OnRowDeleting="grdEmpresas_RowDeleting" DataKeyNames="idEmpresa" CssClass="GridViewStyle">
                        <FooterStyle CssClass="GridViewFooterStyle" />
                        <RowStyle CssClass="GridViewRowStyle" />    
                        <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                        <PagerStyle CssClass="GridViewPagerStyle" />
                        <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                        <HeaderStyle CssClass="GridViewHeaderStyle" />
                        <Columns>
                            <asp:BoundField DataField="nombreEmpresa" HeaderText="Nombre Empresa" />
                            <asp:BoundField DataField="nit" HeaderText="NIT" />
                            <asp:BoundField DataField="represetanteLegal" HeaderText="Representante Legal" />
                            <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText="Editar" EditImageUrl="~/images/ico_lapiz.gif" />
                            <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/ico_borrar.gif" HeaderText="Eliminar"
                                DeleteText="Eliminar" ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
