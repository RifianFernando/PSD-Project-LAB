<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtation.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="padding: 50px; display:flex; flex-direction:column; align-items:center; justify-content:center">
            <table>
                <tbody>
                    <asp:DataList runat="server" ID="CartDataList" RepeatLayout="Table">
                        <ItemTemplate>
                            <tr style="border: 1px solid black; width: 10vw">
                                <td>
                                    <img src='<%# "https://localhost:44302/Storage/Public/Images/Albums/" + Eval("Album.AlbumImage") %>' style="width: 10vw; height: auto" />
                                </td>
                                <td style="padding-left: 50px; width: 10vw;"><%# Eval("Album.AlbumName") %></td>
                                <td style="text-align: center; width: 5vw;"><%# Eval("Qty")%></td>
                                <td style="padding-left: 50px; width: 10vw;""><%# Eval("Album.AlbumPrice")%></td>
                                <td style="width: auto;">
                                <asp:Button ID="RemoveButton" runat="server" Text="Remove" OnClick="RemoveButton_Click" CommandArgument='<%# Eval("AlbumID") %>'/>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:DataList>
                </tbody>
            </table>

         <asp:Button ID="CheckOutButton" runat="server" Text="Check Out" OnClick="CheckOutButton_Click"/>

        </div>
</asp:Content>
