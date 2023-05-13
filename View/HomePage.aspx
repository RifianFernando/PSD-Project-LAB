<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="padding = 50px">

        <h1>Home Page</h1>
        <br />

        <table style="width: 50vw" border="1">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>Name</th>
                </tr>
            </thead>
            <tbody>
                <%foreach (var art in artists)
                    { %>
                <tr>
                    <td></td>
                    <td><%= art.ArtistName%></td>
                </tr>
                <%}%>
            </tbody>
        </table>

    </div>

</asp:Content>
