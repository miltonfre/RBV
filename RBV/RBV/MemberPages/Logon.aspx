<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="RBV.MemberPages.Logon" Title="Recursos Valiosos" %>
<%--<%@ Register Assembly="Web" Namespace="System.Web.UI.WebControls" TagPrefix="cc1" %>--%>
 <asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
<div>
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"/> 
    <asp:UpdatePanel ID="updatepanel1" RenderMode="Inline" runat="server" UpdateMode="Always">
           <ContentTemplate>
                         <asp:Login ID="Login1" runat="server" 
        FailureText="<%$ Resources:Login1FailureText %>"  CreateUserUrl="~/MemberPages/CrearUsuario.aspx" DestinationPageUrl="~/Default.aspx" CreateUserText="Crear nuevo usuario"
                LoginButtonText="<%$ Resources:Login1LoginButtonText %>" PasswordLabelText="<%$ Resources:Login1PasswordLabelText %>" PasswordRequiredErrorMessage="<%$ Resources:Login1PasswordRequiredErrorMessage %>"
                RememberMeText="<%$ Resources:Login1RememberMeText %>" TitleText="<%$ Resources:Login1TitleText %>" UserNameLabelText="<%$ Resources:Login1UserNameLabelText %>"
                UserNameRequiredErrorMessage="<%$ Resources:Login1UserNameRequiredErrorMessage %>" >
                
               <LabelStyle HorizontalAlign="Center" />
                <LayoutTemplate>
                  
                   <asp:Panel ID="mainLogin" runat="server" DefaultButton="LoginButton">
                   
                    <table border="0" cellpadding="0">
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Literal runat="server" ID="ltlIniciarSesion" Text="<%$ Resources:ltlIniciarSesionText %>" ></asp:Literal>
                               </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" Text="<%$ Resources:Login1UserNameLabelText %>"></asp:Label></td>
                            <td>
                                <asp:TextBox ID="UserName" runat="server" CssClass="input" MaxLength="255" AutoCompleteType="Disabled"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                    ErrorMessage="<%$ Resources:UserNameRequiredErrorMessage %>" ToolTip="<%$ Resources:UserNameRequiredToolTip %>"
                                    ValidationGroup="ctl05$Login1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Text="<%$ Resources:PasswordLabelText %>"></asp:Label></td>
                            <td>
                                <asp:TextBox ID="Password" runat="server" CssClass="input" TextMode="Password" MaxLength="50" AutoCompleteType="Disabled"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                    ErrorMessage="<%$ Resources:PasswordRequiredErrorMessage %>" ToolTip="<%$ Resources:PasswordRequiredToolTip	 %>" ValidationGroup="ctl05$Login1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:CheckBox ID="RememberMe" runat="server" Text="<%$ Resources:RememberMeText %>" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2" style="color: red">
                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" CssClass="input"
                                    Text="<%$ Resources:LoginButtonText %>" ValidationGroup="ctl05$Login1" 
                                    />
                            </td>
                        </tr>
                    </table>
                    </asp:Panel>
                   </LayoutTemplate>
               </asp:Login>
       
        </ContentTemplate>
    </asp:UpdatePanel>
    </asp:Content>
