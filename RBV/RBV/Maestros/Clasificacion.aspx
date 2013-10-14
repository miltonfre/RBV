<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clasificacion.aspx.cs" MasterPageFile="~/Shared/Master.Master"
    Inherits="RBV.Maestros.Clasificacion" %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"/> 
 <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>"></uc2:Titulo>
    <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
            <cc2:validationsummary ID="ValidationSummary1" runat="server" MensajeDeIntroduccion="<%$ Resources:vsCorregirErrores %>"
                ValidationGroup="Crear" ShowMessageBox="true" ShowSummary="false"
                UpdatePanel="UpdatePanel6" />
    <div id="company-page" class="page">
    <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblClasificacion" Text="<%$ Resources:lblClasificacion %>" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtClasificacion" runat="server" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvClasificacion" runat="server" ErrorMessage="<%$ Resources:rfvClasificacion %>" Text="*" 
                        ValidationGroup="Crear" ControlToValidate="txtClasificacion">
                        </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID ="btnGuardar" Text="<%$ Resources:btnGuardar %>" runat="server" CssClass="butt"
                        onclick="btnGuardar_Click" CausesValidation="true" ValidationGroup="Crear"/>
                </td>
                <td>
                    <asp:Button ID ="btnCancelar" Text="<%$ Resources:btnCancelar %>" runat="server" 
                        onclick="btnCancelar_Click" CssClass="butt" />
                </td>
            </tr>
            <tr>
            <td colspan="2">
                <asp:GridView ID="grdClasificaciones" runat="server" 
                    AutoGenerateColumns="False" onrowediting="grdClasificaciones_RowEditing" 
                    onrowdeleting="grdClasificaciones_RowDeleting" DataKeyNames="IdClasificacionRV">
                    <Columns>
                        <asp:BoundField DataField="ClasificacionRV" HeaderText="<%$ Resources:hdrClasificacion %>"  />
                        <asp:CommandField ShowEditButton="True" ButtonType="Image" HeaderText ="<%$ Resources:hdrEditar %>" 
                            EditImageUrl="~/images/ico_lapiz.gif" />
                        <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/ico_borrar.gif" HeaderText ="<%$ Resources:hdrEliminar %>" 
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
