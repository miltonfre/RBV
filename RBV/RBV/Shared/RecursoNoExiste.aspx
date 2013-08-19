<%@ Page Language="C#" AutoEventWireup="true" Inherits="RecursoNoExiste
"  MasterPageFile="~/Shared/Publico.master" Codebehind="RecursoNoExiste.aspx.cs" title="" %>

<%@ Register Src="TituloPopup.ascx" TagName="TituloPopup" TagPrefix="uc1" %>
<%@ Register Src="Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>

<asp:Content ID="content" ContentPlaceHolderID="DefaultContent" Runat="Server">
    &nbsp;

    <div id="seccErrorBase">
		<div id="seccErrorTitulo">
            <table border="0">
            <tr width="80%">
            <td style="width: 100%" >
            No se encuentra el recurso
            </td>
            <td style="width: 186px" >
              <a href="javascript: history.back();"><img border="0"  src="../imagenes/bFlechasIzq.jpg" title="Ir a la p&aacute;gina anterior" alt=""/> 
                        </a>
            </td>
            </tr>
            </table>
          <div>
                    &nbsp;</div>
		</div>

		<img src="../imagenes/imgSeccError.gif" align="left"/>
		El recurso no existe.
</div>
    
</asp:Content>
