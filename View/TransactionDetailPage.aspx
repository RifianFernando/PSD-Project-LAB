<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="KpopZtation.View.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding: 50px; display:flex; flex-direction:column; align-items:center; justify-content:center">
        <h1>Home Page</h1>
        <br />
       
        <div>
            <asp:Label ID="TransactionID" runat="server" Text='Transaction ID: + <%#Eval("TransactionID") %>'></asp:Label>
            <asp:Label ID="TransactionDate" runat="server" Text='Transaction Date + <%# ((DateTime)Eval("TransactionDate")).ToString("d") %>'></asp:Label>
        </div>

        <div style="display: flex; flex-direction: row; width: 90%; justify-content:space-between">
            <img src='<%# "https://localhost:44302/Storage/Public/Images/Albums/" + Eval("Album.AlbumImage") %>' style="width: 10vw; height: auto" />
            <asp:Label ID="AlbumName" runat="server" Text='<%#Eval("Album.AlbumName") %>'></asp:Label>
            <asp:Label ID="Qty" runat="server" Text='<%#Eval("Qty") %>'></asp:Label>
            <asp:Label ID="AlbumPrice" runat="server" Text='Transaction ID: + <%#Eval("Album.AlbumPrice") %>'></asp:Label>
        </div>

    </div>

</asp:Content>
