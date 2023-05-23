<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="AlbumDetailPage.aspx.cs" Inherits="KpopZtation.View.AlbumDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding: 50px; display:flex; flex-direction:column; align-items:center; justify-content:center">
        <h1>Album Detail</h1>
        <br />

        <asp:Image ID="AlbumImage" runat="server" style="width: 15vw; height: auto;"/><br />
        <br />

        <table>
            <tbody>
                <tr">
                    <td><asp:Label ID="Label1" runat="server" Text="Album:"></asp:Label></td>
                    <td><asp:Label ID="AlbumName" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Description:"></asp:Label></td>
                    <td><asp:Label ID="AlbumDesc" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Price:"></asp:Label></td>
                    <td><asp:Label ID="AlbumPrice" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Stock:"></asp:Label></td>
                    <td><asp:Label ID="AlbumStock" runat="server" Text=""></asp:Label></td>
                </tr>
            </tbody>
        </table>

        <br />

        
        <%String Data = ViewState["Cookie"].ToString(); %>
        <% if (Data != "Admin"){ %>
                <asp:Button ID="CartButton" runat="server" Text="Add to Cart" OnClick="CartButton_Click"/>
        <% } %>
        <br />
        <asp:Label ID="QtyText" runat="server" Text="Insert Quantity" Visible="false"></asp:Label>
        <asp:TextBox ID="Quantity" runat="server" Visible="false"></asp:TextBox>
        <br />
        <asp:Button ID="ConfirmButton" Visible="false" runat="server" Text="Confirm" OnClick="ConfirmButton_Click"/>
        <asp:Label ID="Success" runat="server" Text=""></asp:Label>

    </div>
</asp:Content>
