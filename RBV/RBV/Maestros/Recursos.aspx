<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recursos.aspx.cs" Inherits="RBV.Maestros.Recursos"
    MasterPageFile="~/Shared/Master.Master" %>

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
                            <asp:Label ID="lblEmpresa" Text="<%$ Resources:lblEmpresa %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlEmpresas" runat="server" DataValueField="IdEmpresa" DataTextField="NombreEmpresa"
                                OnSelectedIndexChanged="ddlEmpresas_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTipoRecurso" Text="<%$ Resources:lblTipoRecurso %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTipoRecurso" runat="server" DataValueField="IdTipoRecurso"
                                DataTextField="NombreTipoRecurso">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblNombreRecurso" Text="<%$ Resources:lblNombreRecurso %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtRecurso" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvRecurso" runat="server" ErrorMessage="<%$ Resources:rfvRecurso %>" Text="*" ValidationGroup="CrearROl" ControlToValidate="txtRecurso">
                        </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblDescripcion" Text="<%$ Resources:lblDescripcion %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDescripcion" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnGuardar" Text="<%$ Resources:btnGuardar %>" runat="server" OnClick="btnGuardar_Click" CssClass="butt" />
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" Text="<%$ Resources:btnCancelar %>" runat="server" OnClick="btnCancelar_Click" CssClass="butt" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="grdRecurso" runat="server" AutoGenerateColumns="False" OnRowEditing="grdRecurso_RowEditing"
                                OnRowDeleting="grdRecurso_RowDeleting" DataKeyNames="IdRecursoEmpresa">
                                <Columns>
                                    <asp:TemplateField HeaderText="<%$ Resources:hdrTipoRecurso %>">
                                        <ItemTemplate>
                                            <asp:Label ID="lblTipoRecursoG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"TipoRecurso.NombreTipoRecurso") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="NombreRecurso" HeaderText="<%$ Resources:hdrNombreRecurso %>" />
                                    <asp:BoundField DataField="DescripcionRecurso" HeaderText="<%$ Resources:hdrDescripcionRecurso %>" />
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblIdTipoRecursoG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"TipoRecurso.IdTipoRecurso") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblIdEmprsaG" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Empresa.IdEmpresa") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText="<%$ Resources:hdrEditar %>" EditImageUrl="~/images/ico_lapiz.gif" />
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