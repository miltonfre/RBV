<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Logon.aspx.cs"
    Inherits="RBV.MemberPages.Logon" Title="Recursos Valiosos" %>

<%--<%@ Register Assembly="Web" Namespace="System.Web.UI.WebControls" TagPrefix="cc1" %>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <div id="login-background">
        <div id="login-register">
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
            <asp:UpdatePanel ID="updatepanel1" RenderMode="Inline" runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <asp:Login ID="Login1" runat="server" FailureText="<%$ Resources:Login1FailureText %>"
                        CreateUserUrl="~/MemberPages/CrearUsuario.aspx"  OnAuthenticate="Login1_LoggedIn" DestinationPageUrl="~/Default.aspx"
                        CreateUserText="Crear nuevo usuario" LoginButtonText="<%$ Resources:Login1LoginButtonText %>"
                        PasswordLabelText="<%$ Resources:Login1PasswordLabelText %>" PasswordRequiredErrorMessage="<%$ Resources:Login1PasswordRequiredErrorMessage %>"
                        RememberMeText="<%$ Resources:Login1RememberMeText %>" TitleText="<%$ Resources:Login1TitleText %>"
                        UserNameLabelText="<%$ Resources:Login1UserNameLabelText %>" UserNameRequiredErrorMessage="<%$ Resources:Login1UserNameRequiredErrorMessage %>">
                        <LabelStyle HorizontalAlign="Center" />
                        <LayoutTemplate>
                            <asp:Panel ID="mainLogin" runat="server" DefaultButton="LoginButton">
                                <table id="login-table" border="0" cellpadding="0">
                                    <tr>
                                        <td align="center" colspan="2">
                                            <h1>
                                                <asp:Literal runat="server" ID="ltlIniciarSesion" Text="<%$ Resources:ltlIniciarSesionText %>"></asp:Literal>
                                                <div id="space">
                                                </div>
                                            </h1>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label CssClass="label" ID="UserNameLabel" runat="server" AssociatedControlID="UserName"
                                                Text="<%$ Resources:Login1UserNameLabelText %>"></asp:Label>
                                            <asp:TextBox ID="UserName" runat="server" CssClass="login-register input" MaxLength="255"
                                                AutoCompleteType="Disabled"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                ErrorMessage="<%$ Resources:UserNameRequiredErrorMessage %>" ToolTip="<%$ Resources:UserNameRequiredToolTip %>"
                                                ValidationGroup="ctl05$Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label ID="PasswordLabel" runat="server" CssClass="label" AssociatedControlID="Password"
                                                Text="<%$ Resources:PasswordLabelText %>"></asp:Label>
                                            <asp:TextBox ID="Password" runat="server" CssClass="input" TextMode="Password" MaxLength="50"
                                                AutoCompleteType="Disabled"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                                ErrorMessage="<%$ Resources:PasswordRequiredErrorMessage %>" ToolTip="<%$ Resources:PasswordRequiredToolTip	 %>"
                                                ValidationGroup="ctl05$Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:CheckBox ID="RememberMe" CssClass="remember-btn" runat="server" Text="<%$ Resources:RememberMeText %>" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2">
                                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" CssClass="butt" Text="<%$ Resources:LoginButtonText %>"
                                                ValidationGroup="ctl05$Login1" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color: red">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </LayoutTemplate>
                    </asp:Login>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
