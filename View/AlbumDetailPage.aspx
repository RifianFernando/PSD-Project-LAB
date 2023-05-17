<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="AlbumDetailPage.aspx.cs" Inherits="KpopZtation.View.AlbumDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding: 50px; display:flex; flex-direction:column; align-items:center; justify-content:center">
        <h1>Home Page</h1>
        <br />

        <table>
            <tbody>
                <asp:DataList runat="server" ID="AlbumDataList" RepeatLayout="Table">
                    <ItemTemplate>
                <tr style="border: 1px solid black;">
                    <td  style="padding-left: 50px; width: 20vw"><%# Eval("AlbumName")%></td>

                    <td  style="padding-left: 50px; width: 20vw"><%# Eval("AlbumDescription")%></td>

                    <td  style="padding-left: 50px; width: 20vw"><%# Eval("AlbumPrice")%></td>

                    <td  style="padding-left: 50px; width: 20vw"><%# Eval("AlbumStock")%></td>

                    <td style="width: 5vw;">
                        <asp:Button ID="CartButton" runat="server" Text="Add to Cart" OnClick="CartButton_Click" CommandArgument='<%# Eval("AlbumID") %>'/>
                    </td>
                    <td style="width: 5vw;">
                        <asp:Button ID="ConfirmButton" runat="server" Text="Confirm" OnClick="ConfirmButton_Click" CommandArgument='<%# Eval("AlbumID") %>'/>
                    </td>
                </tr>
                    </ItemTemplate>
                </asp:DataList>
            </tbody>
        </table>

    </div>
</asp:Content>
