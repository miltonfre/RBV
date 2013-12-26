<%@ Page Language="C#" MasterPageFile="~/Shared/Popup.Master" AutoEventWireup="true" CodeBehind="Seleccionarempresa.aspx.cs" Inherits="RBV.Shared.SeleccionarEmpresas" Title="Untitled Page" %>
<%@ Register src="SeleccionarEmpresa.ascx" tagname="SeleccionarEmpresa" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:SeleccionarEmpresa ID="SeleccionarEmpresa1" runat="server" />
</asp:Content>
