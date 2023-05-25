<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="KpopZtation.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label><br />
        <asp:TextBox ID="LoginEmail" runat="server"></asp:TextBox><br />
        <asp:Label ID="WarningLoginEmail" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />
        <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label><br />
        <asp:TextBox ID="LoginPassword" runat="server"></asp:TextBox><br />
        <asp:Label ID="WarningLoginPassword" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
    </div>
</asp:Content>
