<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UserRoles.aspx.cs" Inherits="RBV.MemberPages.UserRoles" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
        <table>
            <tr>
                <td nowrap="nowrap">
                    <asp:Label ID="Label1" runat="server" Text="List of Users :"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList></td>
                <td nowrap="nowrap">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select" Width="73px" />
                </td>
            </tr>
            <tr>
                <td nowrap="nowrap" valign="top">
                    <asp:Label ID="Label2" runat="server" Text="Available Roles :"></asp:Label></td>
                <td style="width: 100px">
                    </td>
                <td nowrap="nowrap" valign="top">
                    <asp:Label ID="Label4" runat="server" Text="User Roles :"></asp:Label></td>
            </tr>
            <tr>
                <td nowrap="nowrap" valign="top">
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox></td>
                <td align="center" valign="top">
                    <asp:Button ID="Button3" runat="server" Text=" >> " OnClick="Button3_Click" />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text=" << " OnClick="Button4_Click" /></td>
                <td nowrap="nowrap" valign="top">
                    <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox></td>
            </tr>
            <tr>
                <td align="center" colspan="3" nowrap="nowrap">
                    <asp:Label ID="Label3" runat="server"></asp:Label></td>
            </tr>
        </table>
    
    </div>
</asp:Content>
