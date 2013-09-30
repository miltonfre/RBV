<%@ Control Language="C#" AutoEventWireup="true" Codebehind="Titulo.ascx.cs" Inherits="Shared_Titulo" %>
<asp:Table ID="Table2" runat="server" CellPadding="0" CellSpacing="0" class="fondoTitulo" Width="100%" >
    <asp:TableRow ID="TableRow6" runat="server">       
        <asp:TableCell ID="TableCell11"  runat="server">
            <asp:Label ID="lblTitulo" runat="server"></asp:Label>
        </asp:TableCell>
       <%-- <asp:TableCell ID="TableCell2" CssClass="TdCeldaTituloSeccion" HorizontalAlign="Right"
            runat="server">
                        <%--<a href="javascript: history.back();"><img border="0"  src="../imagenes/bFlechasIzq.jpg" title="Ir a la p&aacute;gina anterior" alt=""/> 
                        </a>
        </asp:TableCell>--%>
    </asp:TableRow>
</asp:Table>
