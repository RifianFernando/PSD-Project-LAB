<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateAlbumPage.aspx.cs" Inherits="KpopZtation.View.UpdateAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Update Album Data</h1>
        <br />
        <br />

        <asp:Label ID="LabelAlbumImage" runat="server" Text="Album Image"></asp:Label><br />
        <asp:Image ID="AlbumImage" runat="server" style="width: 10vw; height: auto"/><br />
        <asp:FileUpload id="UpdateAlbumImage" runat="server" accept=".jpg, .jpeg, .png, .jfif" /><br />
        <asp:Label ID="AlbumImageName" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="WarningAlbumImage" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />

        <asp:Label ID="LabelAlbumName" runat="server" Text="Album Name"></asp:Label><br />
        <asp:TextBox ID="UpdateAlbumName" runat="server"></asp:TextBox><br />
        <asp:Label ID="WarningAlbumName" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />

        <asp:Label ID="LabelAlbumPrice" runat="server" Text="Album Price"></asp:Label><br />
        <asp:TextBox ID="UpdateAlbumPrice" runat="server" ></asp:TextBox><br />
        <asp:Label ID="WarningAlbumPrice" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />

        <asp:Label ID="LabelAlbumStock" runat="server" Text="Album Stock"></asp:Label><br />
        <asp:TextBox ID="UpdateAlbumStock" runat="server"></asp:TextBox><br />
        <asp:Label ID="WarningAlbumStock" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />

        <asp:Label ID="LabelAlbumDescription" runat="server" Text="Password"></asp:Label><br />
        <asp:TextBox ID="UpdateAlbumDescription" runat="server"></asp:TextBox><br />
        <asp:Label ID="WarningAlbumDescription" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />

        <asp:Button ID="SaveUpdateButton" runat="server" Text="Save Update" OnClick="SaveUpdateButton_Click" />
        <asp:Label ID="SuccessLabel" runat="server" Text="" ForeColor="Green"></asp:Label><br />
    </div>
</asp:Content>
