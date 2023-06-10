<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="KpopZtation.View.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding: 50px; display:flex; flex-direction:column; align-items:center; justify-content:center">
        <h1>Home Page</h1>
        <br />
       
        <div style="display: flex; flex-direction: column; width: 90%; align-items:start; font-size:24px">
            <asp:Label ID="TransactionIDText" runat="server" Text="Transaction ID: "></asp:Label>
            <asp:Label ID="TransactionDateText" runat="server" Text="Transaction Date: "></asp:Label>
        </div>

        <div style="display: flex; flex-direction: row; width: 80%; justify-content:space-between; align-items:center;">
            <asp:Image ID="AlbumImage" runat="server" style="width: 10vw; height: auto;"/>
            <asp:Label ID="AlbumNameText" runat="server" Text=""></asp:Label>
            <asp:Label ID="QtyText" runat="server" Text=""></asp:Label>
            <asp:Label ID="AlbumPriceText" runat="server" Text=""></asp:Label>
        </div>

    </div>

</asp:Content>
