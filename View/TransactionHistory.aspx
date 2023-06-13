<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="KpopZtation.View.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding: 50px; display:flex; flex-direction:column; align-items:center; justify-content:center">
        <h1>Home Page</h1>
        <br />
        
        <asp:DataList runat="server" ID="TransactionHistoryDataList" RepeatLayout="Flow">
            <ItemTemplate>
                <asp:Label ID="TransactionIDText" runat="server" Text='Transaction ID: '><%# Eval("TransactionID") %></asp:Label><br />
                <asp:Label ID="TransactionDateText" runat="server" Text='Transaction Date: '><%# ((DateTime)Eval("TransactionDate")).ToString("d") %></asp:Label><br />
                <asp:Label ID="CustomerNameText" runat="server" Text=' Customer Name: '><%# Eval("Customer.CustomerName") %></asp:Label><br />

                <table>
                    <tbody>
                        <asp:Repeater runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                            <ItemTemplate>
                                <tr style="border: 1px solid black" onclick="location.href= 'TransactionDetailPage.aspx?id=<%# Eval("TransactionID") %>&albumid=<%# Eval("AlbumID") %>'">
                                    <td style="width: 15vw; text-align:center">
                                        <img src='<%# "https://localhost:44302/Storage/Public/Images/Albums/" + Eval("Album.AlbumImage") %>' style="width: 10vw; height: auto" />
                                    </td>
                                    <td style="width: 15vw;">
                                        <%# Eval("Album.AlbumName") %>
                                    </td>
                                    <td style="width: 5vw;">
                                        <%# Eval("Qty") %>
                                    </td>
                                    <td style="width: 10vw;">
                                        Rp <%# Eval("Album.AlbumPrice") %>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </ItemTemplate>
        </asp:DataList>

    </div>

</asp:Content>
