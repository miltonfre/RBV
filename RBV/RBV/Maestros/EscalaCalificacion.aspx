<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EscalaCalificacion.aspx.cs"
    Inherits="RBV.Maestros.EscalaCalificacion" MasterPageFile="~/Shared/Master.Master" %>

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
                            <asp:DropDownList ID="ddlEmpresas" DataValueField="idEmpresa" DataTextField="nombreEmpresa"
                                runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEmpresas_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblEscala" Text="<%$ Resources:lblEscala %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtEscala" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblValor" Text="<%$ Resources:lblValor %>" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnGuardar" Text="<%$ Resources:btnGuardar %>" runat="server" OnClick="btnGuardar_Click"
                                CssClass="butt" />
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" Text="<%$ Resources:btnCancelar %>" runat="server" OnClick="btnCancelar_Click"
                                CssClass="butt" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="grdEscalaCalificaciones" runat="server" AutoGenerateColumns="False"
                                OnRowEditing="grdEscalaCalificaciones_RowEditing" OnRowDeleting="grdEscalaCalificaciones_RowDeleting"
                                DataKeyNames="IdEscalaCalificacion,idEmpresa">
                                <Columns>
                                    <asp:BoundField DataField="Escala" HeaderText="<%$ Resources:hdrEscala %>" />
                                    <asp:BoundField DataField="Valor" HeaderText="<%$ Resources:hdrValor %>" />
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