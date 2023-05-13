<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertArtistPage.aspx.cs" Inherits="KpopZtation.View.InsertArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <asp:Label ID="LabelArtistName" runat="server" Text="Album Image"></asp:Label><br />
            <asp:TextBox ID="InsertArtistName" runat="server"></asp:TextBox><br />
            <asp:Label ID="WarningArtistName" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <br />

            <asp:Label ID="LabelArtistImage" runat="server" Text="Album Image"></asp:Label><br />
            <asp:FileUpload id="InsertArtistImage" runat="server" accept=".jpg, .jpeg, .png, .jfif" />
            <asp:Label ID="WarningArtistImage" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <br />
            
            
            <asp:Button ID="InsertArtistButton" runat="server" Text="Insert Artist" OnClick="InsertArtistButton_Click"/><br />
            <asp:Label ID="SuccessLabel" runat="server" Text="" ForeColor="Green"></asp:Label><br />

            <asp:Image ID="ArtistImage1" runat="server" />
</asp:Content>
