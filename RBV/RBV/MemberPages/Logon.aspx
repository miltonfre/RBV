<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="RBV.MemberPages.Login1" Title="Recursos Valiosos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
   
           
        <br />
        <asp:Login ID="login2" runat="server" RememberMeSet="true" RememberMeText="true" DisplayRememberMe="false" >
        </asp:Login>
        <br />
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" >
        </asp:PasswordRecovery>
       
        <br />
    
<asp:CreateUserWizard ID="cuwCrearUsuario" runat="server">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>
</asp:Content>

