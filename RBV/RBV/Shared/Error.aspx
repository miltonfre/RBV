<%@ Page Language="C#" AutoEventWireup="true" Inherits="Error"  MasterPageFile="~/Shared/Default.master" Codebehind="Error.aspx.cs" Title="" %>

<asp:Content ID="content" ContentPlaceHolderID="DefaultContent" Runat="Server">

    <div id="seccErrorBase">
		<div id="seccErrorTitulo">
		  <table border="0">
            <tr width="80%">
            <td style="width: 100%" >
           <asp:Literal ID="ltrError" runat="server" Text="<%$ Resources:ltrError %>"></asp:Literal>
            </td>
            <td style="width: 186px" >
              <a href="javascript: history.back();"><img border="0"  src="../imagenes/bFlechasIzq.jpg" title="Ir a la p&aacute;gina anterior" alt=""/> 
                        </a>
            </td>
            </tr>
            </table>
		
		
		</div>
		<img src="../imagenes/imgSeccError.gif" align="left"/>
		<asp:Literal ID="ltrmsgError" runat="server" Text="<%$ Resources:ltrmsgError %>"></asp:Literal>
		
		
</div>
    
</asp:Content>
