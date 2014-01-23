<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recursos.aspx.cs" Inherits="RBV.Maestros.Recursos"
    MasterPageFile="~/Shared/Master.Master" %>

<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>
<%@ Register Src="../Shared/Mensaje.ascx" TagName="Mensaje" TagPrefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
    <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
            <uc1:Mensaje ID="Mensaje1" runat="server" />
            <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>">
            </uc2:Titulo>
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
                            <asp:DropDownList ID="ddlTipoRecurso" runat="server" AutoPostBack="true" DataValueField="IdTipoRecurso"
                                DataTextField="NombreTipoRecurso" OnSelectedIndexChanged="ddlTipoRecurso_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblDescripcionTipo" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblNombreRecurso" runat="server" Text="<%$ Resources:lblNombreRecurso %>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtRecurso" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvRecurso" runat="server" ControlToValidate="txtRecurso"
                                ErrorMessage="<%$ Resources:rfvRecurso %>" Text="*" ValidationGroup="CrearROl">
                            </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblDescripcion" runat="server" Text="<%$ Resources:lblDescripcion %>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnGuardar" runat="server" CssClass="butt" OnClick="btnGuardar_Click"
                                Text="<%$ Resources:btnGuardar %>" />
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" runat="server" CssClass="butt" OnClick="btnCancelar_Click"
                                Text="<%$ Resources:btnCancelar %>" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="grdRecurso" runat="server" AutoGenerateColumns="False" DataKeyNames="IdRecursoEmpresa"
                                OnRowDeleting="grdRecurso_RowDeleting" OnRowEditing="grdRecurso_RowEditing">
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
                                    <asp:CommandField ButtonType="Image" EditImageUrl="~/images/ico_lapiz.gif" HeaderText="<%$ Resources:hdrEditar %>"
                                        ShowEditButton="True" />
                                    <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/ico_borrar.gif" DeleteText="Eliminar"
                                        HeaderText="<%$ Resources:hdrEliminar %>" ShowDeleteButton="True" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
