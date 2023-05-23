<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertAlbumPage.aspx.cs" Inherits="KpopZtation.View.InsertAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div>
            <h1>Insert Album Page</h1>
            <br />

            <asp:Label ID="LabelName" runat="server" Text="Album Name"></asp:Label><br />
            <asp:TextBox ID="InsertAlbumName" runat="server"></asp:TextBox><br />
            <asp:Label ID="WarningAlbumName" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <br />

            <asp:Label ID="LabelDescription" runat="server" Text="Album Description"></asp:Label><br />
            <asp:TextBox ID="InsertAlbumDescription" runat="server"></asp:TextBox><br />
            <asp:Label ID="WarningAlbumDescription" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <br />

            <asp:Label ID="LabelPrice" runat="server" Text="Album Price"></asp:Label><br />
            <asp:TextBox ID="InsertAlbumPrice" runat="server"></asp:TextBox><br />
            <asp:Label ID="WarningAlbumPrice" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <br />

            <asp:Label ID="LabelStock" runat="server" Text="Album Stock"></asp:Label><br />
            <asp:TextBox ID="InsertAlbumStock" runat="server"></asp:TextBox><br />
            <asp:Label ID="WarningAlbumStock" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <br />

            <asp:Label ID="LabelImage" runat="server" Text="Album Image"></asp:Label><br />
            <asp:FileUpload id="InsertAlbumImage" runat="server" data-max-size="32154" />
            <asp:Label ID="WarningAlbumImage" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <br />
            
            
            <asp:Button ID="InsertAlbumButton" runat="server" Text="Insert Album" OnClick="InsertAlbumButton_Click"/><br />
            <asp:Label ID="SuccessLabel" runat="server" Text="" ForeColor="Green"></asp:Label><br />

        </div>
</asp:Content>
