﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>

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
                <asp:DataList runat="server" ID="ArtistDataList" RepeatLayout="Table">
                    <ItemTemplate>
                <tr>
                    <td style="width: 10vw">
                        <img src='<%# "https://localhost:44302/Storage/Public/Images/Artists/" + Eval("ArtistImage") %>' style="width: 10vw; height: auto" />
                    </td>
                    <td style="padding-left: 20px"><%# Eval("ArtistName")%></td>
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click" CommandArgument='<%# Eval("ArtistName") %>'/>
                      
                    </td>
                </tr>
                    </ItemTemplate>
                </asp:DataList>
            </tbody>
        </table>
        <asp:Label ID="Test" runat="server" Text="uiwsdfhgwuisdfhw"></asp:Label>
    </div>

</asp:Content>
