<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding: 50px">
        <h1>Home Page</h1>
        <br />

        <table style="width: 50vw">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>Name</th>
                </tr>
            </thead>
            <tbody>
                <% foreach (var art in artists)
                    { %>
                <tr>
                    <td style="width: 10vw">
                        <img src='<%= "https://localhost:44302/Storage/Public/Images/Artists/" + art.ArtistImage %>' style="width: 10vw; height: auto" />
                    </td>
                    <td style="padding-left: 20px"><%= art.ArtistName%></td>
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" Text="Delete" CommandName="Delete" OnClick="DeleteButton_Click" />
                        <%
                            DeleteButton.CommandArgument = art.ArtistID.ToString();
                        %>
                    </td>
                </tr>
                <% } %>
            </tbody>
        </table>
        <asp:Label ID="Test" runat="server" Text="uiwsdfhgwuisdfhw"></asp:Label>
    </div>

</asp:Content>
