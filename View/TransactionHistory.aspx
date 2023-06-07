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
                <tr style="border: 1px solid black">
                    <td><%# Eval("TransactionID") %></td>
                    <td><%# ((DateTime)Eval("TransactionDate")).ToString("d") %></td>
                    <td><%# Eval("Customer.CustomerName") %></td>
                    <td>
                        <asp:Repeater runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                            <ItemTemplate>
                                <img src='<%# "https://localhost:44302/Storage/Public/Images/Albums/" + Eval("Album.AlbumImage") %>' style="width: 5vw; height: auto" />
                            </ItemTemplate>
                        </asp:Repeater>
                    </td>
                    <td>
                        <asp:Repeater runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                            <ItemTemplate>
                                <%# Eval("Album.AlbumName") %>
                            </ItemTemplate>
                        </asp:Repeater>
                    </td>
                    <td>
                        <asp:Repeater runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                            <ItemTemplate>
                                <%# Eval("Qty") %>
                            </ItemTemplate>
                        </asp:Repeater>
                    </td>
                    <td>
                        <asp:Repeater runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                            <ItemTemplate>
                                <%# Eval("Album.AlbumPrice") %>
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
