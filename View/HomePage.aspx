<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="display: flex; flex-direction: column; justify-content: center; align-items:center; padding-top: 30px">
        <h1>Home Page</h1>
        <br />

        <table>
            <tbody>
                <% foreach (var art in artists)
                    { %>
                <tr>
                    <td style="width: 10vw">
                        <img src='<%= "https://localhost:44302/Storage/Public/Images/Artists/" + art.ArtistImage %>' style="width: 10vw; height: auto"/>
                    </td>
                    <td style="padding-left: 50px; width: 20vw"><%= art.ArtistName%></td>
                    <td><asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click"/></td>
                </tr>
                <% } %>
            </tbody>
        </table>
    </div>

</asp:Content>
