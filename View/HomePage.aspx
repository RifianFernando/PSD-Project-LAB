<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="padding = 50px">

        <h1>Home Page</h1>
        <br />
        <asp:Label ID="ArtistName" runat="server" Text="Label"></asp:Label>
        <asp:Image ID="ArtistImage" runat="server"/>
        
    </div>

</asp:Content>
