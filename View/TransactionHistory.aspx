<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="KpopZtation.View.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding: 50px; display:flex; flex-direction:column; align-items:center; justify-content:center">
        <h1>Home Page</h1>
        <br />
       
        <table>
            <tbody>
                <asp:DataList runat="server" ID="TransactionHistoryDataList" RepeatLayout="Table">
                    <ItemTemplate>
                <tr style="border: 1px solid black" onclick="location.href= 'TransactionDetailPage.aspx?id=<%# Eval("TransactionID") %>'">
                    <td style="width: 10vw; text-align:center"><%# Eval("TransactionID") %></td>
                    <td style="width: 10vw; text-align:center"><%# ((DateTime)Eval("TransactionDate")).ToString("d") %></td>
                    <td style="border-right: 1px solid black; width:20vw; text-align:center"><%# Eval("Customer.CustomerName") %></td>
                    <td style="width: 15vw; text-align:center">
                        <asp:Repeater runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                            <ItemTemplate>
                                <img src='<%# "https://localhost:44302/Storage/Public/Images/Albums/" + Eval("Album.AlbumImage") %>' style="width: 10vw; height: auto" />
                            </ItemTemplate>
                        </asp:Repeater>
                    </td>
                    <td style="width: 15vw;">
                        <asp:Repeater runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                            <ItemTemplate>
                                <%# Eval("Album.AlbumName") %>
                            </ItemTemplate>
                        </asp:Repeater>
                    </td>
                    <td style="width: 5vw;">
                        <asp:Repeater runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                            <ItemTemplate>
                                <%# Eval("Qty") %>
                            </ItemTemplate>
                        </asp:Repeater>
                    </td>
                    <td style="width: 10vw;">
                        <asp:Repeater runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                            <ItemTemplate>
                                Rp <%# Eval("Album.AlbumPrice") %>
                            </ItemTemplate>
                        </asp:Repeater>
                    </td>
                </tr>
                    </ItemTemplate>
                </asp:DataList>
            </tbody>
        </table>

    </div>

</asp:Content>
