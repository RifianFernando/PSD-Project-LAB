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
                <tr>
                    
                </tr>
                    </ItemTemplate>
                </asp:DataList>
            </tbody>
        </table>

    </div>

</asp:Content>
