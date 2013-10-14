<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Shared/Master.Master"
    CodeBehind="TipoRecurso.aspx.cs" Inherits="RBV.Maestros.TipoRecurso" %>

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
                            <asp:Label ID="lblTipoRecurso" Text="<%$ Resources:lblTipoRecurso %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTipoRecurso" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvTipoRecurso" runat="server" ErrorMessage="<%$ Resources:rfvTipoRecurso %>" Text="*" ValidationGroup="CrearROl" ControlToValidate="txtTipoRecurso">
                        </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnGuardar" Text="<%$ Resources:btnGuardar %>" runat="server" OnClick="btnGuardar_Click" CssClass="butt"/>
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" Text="<%$ Resources:btnCancelar %>" runat="server" OnClick="btnCancelar_Click" CssClass="butt" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="grdTipoRecurso" runat="server" AutoGenerateColumns="False" OnRowDeleting="grdTipoRecurso_RowDeleting"
                                OnRowEditing="grdTipoRecurso_RowEditing" DataKeyNames="IdTipoRecurso">
                                <Columns>
                                    <asp:BoundField DataField="NombreTipoRecurso" HeaderText="<%$ Resources:hdrTipoRecurso %>" />
                                    <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText="<%$ Resources:hdrEditar %>" EditImageUrl="~/images/ico_lapiz.gif" />
                                    <asp:CommandField DeleteText="Eliminar" ShowDeleteButton="True" HeaderText="<%$ Resources:hdrEliminar %>"
                                        ButtonType="Image" DeleteImageUrl="~/images/ico_borrar.gif" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
