<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sector.aspx.cs" Inherits="RBV.Maestros.Sector" MasterPageFile="~/Shared/Master.Master"  %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>

<%@ Register Assembly="Utilidades" Namespace="Utilidades" TagPrefix="cc2" %>
<%--<%@ Register Assembly="Validators" Namespace="Sample.Web.UI.Compatibility" TagPrefix="cc2" %>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
 <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"/> 
 <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>"></uc2:Titulo>
    <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
            <cc2:validationsummary ID="ValidationSummary1" runat="server" MensajeDeIntroduccion="<%$ Resources:vsCorregirErrores %>"
                ValidationGroup="CrearROl" ShowMessageBox="true" ShowSummary="false"
                UpdatePanel="UpdatePanel6" />
    <div>
        <table>         
            <tr>
                <td align="right">
                    <asp:Label ID="lblSector" Text="<%$ Resources:lblSector %>" runat="server"></asp:Label>
                </td>
                <td >
                    <asp:TextBox ID="txtSector" runat="server"></asp:TextBox>
                     <%--<cc2:RequiredFieldValidator ID="rfvSector" runat="server" ControlToValidate="txtSector"
                            ErrorMessage="<%$ Resources:rfvSector %>" Text="*" ValidationGroup="CrearROl" ></cc2:RequiredFieldValidator>--%>
                </td>
            </tr>
            <tr>
                <td  align="center"> 
                    <asp:Button ID="btnGuardar" Text="<%$ Resources:btnGuardar %>" runat="server" OnClick="btnGuardar_Click"  CausesValidation="true" ValidationGroup="CrearROl"/>
                    <asp:Button ID="btnCancelar" Text="<%$ Resources:btnCancelar %>" runat="server" OnClick="btnCancelar_Click" CausesValidation="false"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="grdSector" runat="server" AutoGenerateColumns="False" OnRowDeleting="grdSector_RowDeleting"
                        OnRowEditing="grdSector_RowEditing" DataKeyNames="IdSector">
                        <Columns>
                            <asp:BoundField DataField="NombreSector" HeaderText="<%$ Resources:hdrSector %>" />
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
