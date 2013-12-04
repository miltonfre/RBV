<%@ Page Language="C#" MasterPageFile="~/Shared/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RBV.Shared.Default" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
 <script language="javascript" type="text/javascript">
    function mpeSeleccionOnOk()
    {        
        var ddlCiudades = document.getElementById("ddlCiudades");
        var ddlMeses = document.getElementById("ddlMeses");
        var ddlAnualidades = document.getElementById("ddlAnualidades");        
        var txtSituacion = document.getElementById("txtSituacion");
        
        txtSituacion.value = ddlCiudades.options[ddlCiudades.selectedIndex].value + ", " +
            ddlMeses.options[ddlMeses.selectedIndex].value + " de " +
            ddlAnualidades.options[ddlAnualidades.selectedIndex].value;        
    }    
    function mpeSeleccionOnCancel()
    {
        var txtSituacion = document.getElementById("txtSituacion");
        txtSituacion.value = "";
        txtSituacion.style.backgroundColor = "#FFFF99";
    }    
    </script>
 <div>
        <table border="2">
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="Label1" runat="server" Text="Datos de solicitud" Font-Bold="True"
                        Font-Underline="True" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Nombre:" />
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="e-mail:" />
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Situación:" />
                </td>
                <td>
                    <asp:TextBox ID="txtSituacion" runat="server" Width="300" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAsistente" runat="server" Text="Asistente de selección" Width="150" />
                </td>
                <td>
                    <asp:Button ID="btnGrabar" runat="server" Text="Grabar datos" Width="125" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Panel ID="pnlSeleccionarDatos" runat="server" CssClass="CajaDialogo" Style="display: none;">
            <div style="padding: 10px; background-color: #0033CC; color: #FFFFFF;">
                <asp:Label ID="Label4" runat="server" Text="Seleccionar datos" />
            </div>
            <div>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Ciudad:" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCiudades" runat="server">
                                <asp:ListItem>Zamora</asp:ListItem>
                                <asp:ListItem>Teruel</asp:ListItem>
                                <asp:ListItem>Salamanca</asp:ListItem>
                                <asp:ListItem>Sevilla</asp:ListItem>
                                <asp:ListItem>Lugo</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Mes:" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlMeses" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Año:" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlAnualidades" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                &nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            </div>
        </asp:Panel>
        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
</ajaxToolkit:ToolkitScriptManager>
        <ajaxToolkit:ModalPopupExtender ID="mpeSeleccion" runat="server" TargetControlID="btnAsistente"
            PopupControlID="pnlSeleccionarDatos" OkControlID="btnAceptar" CancelControlID="btnCancelar"
            OnOkScript="mpeSeleccionOnOk()" OnCancelScript="mpeSeleccionOnCancel()" DropShadow="True"
            BackgroundCssClass="FondoAplicacion" />
    </div>
</asp:Content>
