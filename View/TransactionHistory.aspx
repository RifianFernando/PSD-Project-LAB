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
                    <td><%# Eval("TransactionDate") %></td>
                    <td><%# Eval("CustomerName") %></td>
                    <td>
                        <img src='<%# "https://localhost:44302/Storage/Public/Images/Albums/" + Eval("AlbumImage") %>' style="width: 5vw; height: auto" />
                    </td>
                    <td><%# Eval("AlbumName") %></td>
                    <td><%# Eval("Qty") %></td>
                    <td><%# Eval("AlbumPrice") %></td>
                </tr>
                    </ItemTemplate>
                </asp:DataList>
            </tbody>
        </table>

    </div>

</asp:Content>
