﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding: 50px; display:flex; flex-direction:column; align-items:center; justify-content:center">
        <h1>Home Page</h1>
        <br />
        
        <%String Data = ViewState["Cookie"].ToString(); %>
        <% if (Data == "Admin"){ %>
                <asp:Button ID="InsertArtist_Button" runat="server" Text="Insert Artist" onclick="InsertArtist_Button_Click"/>
        <% } %>

        <table>
            <tbody>
                <asp:DataList runat="server" ID="ArtistDataList" RepeatLayout="Table">
                    <ItemTemplate>
                <tr style="border: 1px solid black" onclick="location.href= 'ArtistDetailPage.aspx?id=<%# Eval("ArtistID") %>'">
                    <td>
                        <img src='<%# "https://localhost:44302/Storage/Public/Images/Artists/" + Eval("ArtistImage") %>' style="width: 10vw; height: auto" />
                    </td>
                    <%String Data = ViewState["Cookie"].ToString(); %>
                    <td  style="padding-left: 50px; width: 20vw"><%# Eval("ArtistName")%></td>
                    <% if (Data == "Admin")
                            { %>
                        <td style="width: auto;">
                            <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click" CommandArgument='<%# Eval("ArtistID") %>'/>
                        </td>
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" CommandArgument='<%# Eval("ArtistID") %>'/>
                        </td>
                    <% } %>
                </tr>
                    </ItemTemplate>
                </asp:DataList>
            </tbody>
        </table>
    </div>
</asp:Content>
