﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetailPage.aspx.cs" Inherits="KpopZtation.View.ArtistDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Artist Detail</h1>

        <div>
            <asp:Image ID="ArtistImage" runat="server" /><br />
            <asp:Label ID="ArtistName" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <table>
                <tbody>
                    <asp:DataList runat="server" ID="AlbumDataList" RepeatLayout="Table">
                        <ItemTemplate>
                            <tr>
                                <td style="width: 10vw">
                                    <img src='<%# "https://localhost:44302/Storage/Public/Images/Albums/" + Eval("AlbumImage") %>' style="width: 10vw; height: auto" />
                                </td>
                                <td  style="padding-left: 50px; width: 20vw"><%# Eval("AlbumName")%></td>
                                <td>
                                    <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click" CommandArgument='<%# Eval("AlbumID") %>'/>
                                </td>
                                <td>
                                    <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" CommandArgument='<%# Eval("AlbumID") %>'/>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:DataList>
                </tbody>
            </table>
        </div>

    </div>
</asp:Content>
