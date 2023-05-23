<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtation.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display:flex; flex-direction:column; align-items:center; justify-content:center">
            <asp:Image ID="ArtistImage" runat="server" style="width: 25vw; height: auto;"/><br />
            <asp:Label ID="ArtistName" runat="server" Text="" style="padding-bottom: 10px"></asp:Label>
      </div>
     <div>
            <table>
                <tbody>
                    <asp:DataList runat="server" ID="AlbumDataList" RepeatLayout="Table">
                        <ItemTemplate>
                            <tr style="border: 1px solid black; width: 10vw" onclick="rowClicked(<%# Eval("AlbumID")%>)">
                                <td>
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
</asp:Content>
