<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RoleManager.aspx.cs" Inherits="RBV.MemberPages.RoleManager" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
        <table>
            <tr>
                <td nowrap="nowrap">
                    <asp:Label ID="Label1" runat="server" Text="Enter new role to add :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td nowrap="nowrap">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" Width="73px" />
                </td>
            </tr>
            <tr>
                <td nowrap="nowrap" valign="top">
                    <asp:Label ID="Label2" runat="server" Text="Available Roles :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:ListBox ID="ListBox1" runat="server" Width="100%"></asp:ListBox></td>
                <td nowrap="nowrap" valign="top">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="DELETE" /></td>
            </tr>
            <tr>
                <td align="center" colspan="3" nowrap="nowrap">
                    <asp:Label ID="Label3" runat="server"></asp:Label></td>
            </tr>
        </table>
    
    </div>
</asp:Content>
