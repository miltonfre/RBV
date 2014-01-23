<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empresa.aspx.cs" Inherits="RBV.Maestros.Empresa"
    MasterPageFile="~/Shared/Master.Master" %>

<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>
<%@ Register src="../Shared/Mensaje.ascx" tagname="Mensaje" tagprefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
    
    <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
    
            <uc1:Mensaje ID="Mensaje1" runat="server" />
            <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>">
            </uc2:Titulo>
            <cc2:ValidationSummary ID="ValidationSummary1" runat="server" MensajeDeIntroduccion="<%$ Resources:vsCorregirErrores %>"
                ValidationGroup="Crear" ShowMessageBox="true" ShowSummary="false" UpdatePanel="UpdatePanel6" />
            <!--<div id="company-right-container">
            <asp:Image runat="server" ImageUrl="~/img/Login/2.png" AlternateText="Image" ImageAlign="Middle" />
        </div>-->
            <div id="company-page" class="page">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblEmpresa" Text="<%$ Resources:lblEmpresa %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtEmpresa" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblNit" Text="<%$ Resources:lblNit %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNIT" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblRepresentante" Text="<%$ Resources:lblRepresentante %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtRepresentante" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblSector" Text="<%$ Resources:lblSector %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:CheckBoxList ID="chklSector" runat="server" DataValueField="IdSector" DataTextField="NombreSector">
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <asp:Button ID="btnGuardar" Text="<%$ Resources:btnGuardar %>" runat="server" OnClick="btnGuardar_Click"
                                CssClass="butt" />
                            <asp:Button ID="btnCancelar" Text="<%$ Resources:btnCancelar %>" runat="server" OnClick="btnCancelar_Click"
                                CssClass="butt" />
                                 
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
                                    <asp:BoundField DataField="nombreEmpresa" HeaderText="<%$ Resources:hdrEmpresa %>" />
                                    <asp:BoundField DataField="nit" HeaderText="<%$ Resources:hdrNit %>" />
                                    <asp:BoundField DataField="represetanteLegal" HeaderText="<%$ Resources:hdrrepresetanteLegal %>" />
                                    <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText="<%$ Resources:hdrEditar %>"
                                        EditImageUrl="~/images/ico_lapiz.gif" />
                                    <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/ico_borrar.gif" HeaderText="<%$ Resources:hdrEliminar %>"
                                        DeleteText="Eliminar" ShowDeleteButton="True" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
