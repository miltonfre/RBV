<%@ Page Language="C#" AutoEventWireup="true" Inherits="AccessDenied" 
MasterPageFile="~/Shared/Publico.master" Codebehind="AccessDenied.aspx.cs" %>

<asp:Content ID="content" ContentPlaceHolderID="DefaultContent" Runat="Server">

    <div id="seccErrorBase">
		<div id="seccErrorTitulo">
		  <table border="0">
            <tr width="80%">
            <td style="width: 100%" >
            Permisos insuficientes
            </td>
            <td style="width: 186px" >
              <a href="javascript: history.back();"><img border="0"  src="../imagenes/bFlechasIzq.jpg" title="Ir a la p&aacute;gina anterior" alt=""/> 
                        </a>
            </td>
            </tr>
            </table>
		
		
		</div>
		<img src="../imagenes/imgSeccError.gif" align="left"/>
		Usted no tiene permiso para acceder al recurso<asp:Literal runat="server" ID="lRecurso" Text=""></asp:Literal>, si cree que esto es incorrecto por favor contacte al administrador del sistema.
Gracias.
</div>
    
</asp:Content>
