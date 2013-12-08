<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Caracteristica.aspx.cs"
    MasterPageFile="~/Shared/Master.Master" Inherits="RBV.Maestros.Caracteristica" %>

<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
    <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>">
    </uc2:Titulo>
    <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
            <cc2:ValidationSummary ID="ValidationSummary1" runat="server" MensajeDeIntroduccion="<%$ Resources:vsCorregirErrores %>"
                ValidationGroup="Crear" ShowMessageBox="true" ShowSummary="false" UpdatePanel="UpdatePanel6" />
            <div id="company-page" class="page">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblClasificacion" Text="<%$ Resources:lblClasificacion %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlClasificacion" runat="server" DataValueField="IdClasificacionRV"
                                DataTextField="ClasificacionRV">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCaracteristica" Text="<%$ Resources:lblCaracteristica %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCaracteristica" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblDescripcion" Text="<%$ Resources:lblDescripcion %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnGuardar" Text="<%$ Resources:btnGuardar %>" runat="server" OnClick="btnGuardar_Click" CssClass="butt"/>
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" Text="<%$ Resources:btnCancelar %>" runat="server" OnClick="btnCancelar_Click" CssClass="butt"/>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="grdCaracteristica" runat="server" AutoGenerateColumns="False" OnRowEditing="grdCaracteristica_RowEditing"
                                OnRowDeleting="grdCaracteristica_RowDeleting" DataKeyNames="IdCaracteristica">
                                <Columns>
                                    <asp:BoundField DataField="NombreCaracteristica" HeaderText="<%$ Resources:hdrCaracteristica %>" />
                                    <asp:BoundField DataField="Descripcion" HeaderText="<%$ Resources:hdrDescripcion %>" />
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblIdClasificionG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"ClasificacionAsociada.IdClasificacionRV") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="<%$ Resources:hdrClasificacion %>">
                                        <ItemTemplate>
                                            <asp:Label ID="lblNomClasificionG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"ClasificacionAsociada.ClasificacionRV") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText="<%$ Resources:hdrEditar %>" EditImageUrl="~/images/ico_lapiz.gif" />
                                    <asp:CommandField ButtonType="Image" Visible="false" DeleteImageUrl="~/images/ico_borrar.gif" HeaderText="<%$ Resources:hdrEliminar %>"
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
