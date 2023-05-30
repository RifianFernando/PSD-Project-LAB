<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtation.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
            <table>
                <tbody>
                    <asp:DataList runat="server" ID="CartDataList" RepeatLayout="Table">
                        <ItemTemplate>
                            <tr style="border: 1px solid black; width: 10vw">
                                <td>
                                    <img src='<%# "https://localhost:44302/Storage/Public/Images/Albums/" + Eval("Album.AlbumImage") %>' style="width: 10vw; height: auto" />
                                </td>
                                <td><%# Eval("Album.AlbumName") %></td>
                                <td><%# Eval("Qty")%></td>
                                <td><%# Eval("Album.AlbumPrice")%></td>
                                <td style="width: auto;">
                                <asp:Button ID="RemoveButton" runat="server" Text="Delete" OnClick="RemoveButton_Click" CommandArgument='<%# Eval("AlbumID") %>'/>
                                </td>
                                <td>
                                    <asp:Button ID="CheckOutButton" runat="server" Text="Update" OnClick="CheckOutButton_Click" CommandArgument='<%# Eval("AlbumID") %>'/>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:DataList>
                </tbody>
            </table>
        </div>
</asp:Content>
