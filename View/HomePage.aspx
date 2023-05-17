<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding: 50px; display:flex; flex-direction:column; align-items:center; justify-content:center">
        <h1>Home Page</h1>
        <br />
       
        <table>
            <tbody>
                <asp:DataList runat="server" ID="ArtistDataList" RepeatLayout="Table">
                    <ItemTemplate>
                <tr style="border: 1px solid black;">
                    <td style="width: 10vw">
                        <img src='<%# "https://localhost:44302/Storage/Public/Images/Artists/" + Eval("ArtistImage") %>' style="width: 10vw; height: auto" />
                    </td>
                    <td  style="padding-left: 50px; width: 20vw"><%# Eval("ArtistName")%></td>
                    <%String Data = ViewState["Cookie"].ToString(); %>
                    <% if (Data == "Admin")
                            { %>
                        <td style="width: 5vw;">
                            <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click" CommandArgument='<%# Eval("ArtistID") %>'/>
                        </td>
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" CommandArgument='<%# Eval("ArtistID") %>'/>
                        </td>
                    <% } %>
                </tr>
                    </ItemTemplate>
                </asp:DataList>
            </tbody>
        </table>

    </div>

</asp:Content>
