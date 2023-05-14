<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetailPage.aspx.cs" Inherits="KpopZtation.View.ArtistDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Artist Kpopz List</h1>
        <asp:DataList runat="server">
            <ItemTemplate>
                <div class="card-container">
                    <div> </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
