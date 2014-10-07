<%@ Page Language="C#" MasterPageFile="~/Shared/Master.Master" AutoEventWireup="true" CodeBehind="GenerarReporte.aspx.cs" Inherits="RBV.Reportes.GenerarReporte1" Title="Untitled Page" %>
<%@ Register Src="GenerarReporte.ascx" TagName="GenerarReporte" TagPrefix="uc1" %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>

<%@ Register src="Mensaje.ascx" tagname="Mensaje" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContenidoPaginas" runat="server">

 <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>">
    </uc2:Titulo>    
    <uc1:GenerarReporte ID="GenerarReporte1" runat="server"/>
    <uc3:Mensaje ID="Mensaje1" runat="server" />
</asp:Content>
