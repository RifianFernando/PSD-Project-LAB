<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateArtistPage.aspx.cs" Inherits="KpopZtation.View.UpdateArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <div>

        <asp:Label ID="LabelArtistName" runat="server" Text="Arist Name"></asp:Label><br />
        <asp:TextBox ID="UpdateArtistName" runat="server"></asp:TextBox><br />
        <asp:Label ID="WarningArtistName" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />

        <asp:Label ID="LabelArtistImage" runat="server" Text="Artist Image"></asp:Label><br />
        <asp:Image ID="ArtistImage" runat="server" style="width: 10vw; height: auto"/><br />
        <asp:FileUpload id="UpdateArtistImage" runat="server" accept=".jpg, .jpeg, .png, .jfif" /><br />
        <asp:Label ID="ArtistImageName" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="WarningArtistImage" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />
            
            
        <asp:Button ID="UpdateArtistButton" runat="server" Text="Update Artist" OnClick="UpdateArtistButton_Click"/><br />
        <asp:Label ID="SuccessLabel" runat="server" Text="" ForeColor="Green"></asp:Label><br />

    </div>

</asp:Content>
