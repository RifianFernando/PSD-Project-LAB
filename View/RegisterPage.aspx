<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="KpopZtation.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h1>Register</h1>
    <br />

    <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label><br />
    <asp:TextBox ID="RegisterName" runat="server"></asp:TextBox><br />
    <asp:Label ID="WarningName" runat="server" Text="" ForeColor="Red"></asp:Label><br />
    <br />

    <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label><br />
    <asp:TextBox ID="RegisterEmail" runat="server"></asp:TextBox><br />
    <asp:Label ID="WarningEmail" runat="server" Text="" ForeColor="Red"></asp:Label><br />
    <br />

    <asp:Label ID="LabelGender" runat="server" Text="Gender"></asp:Label><br />
    <asp:RadioButtonList id="RegisterGender" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="WarningGender" runat="server" Text="" ForeColor="Red"></asp:Label><br />
    <br />

    <asp:Label ID="LabelAddress" runat="server" Text="Address"></asp:Label><br />
    <asp:TextBox ID="RegisterAddress" runat="server"></asp:TextBox><br />
    <asp:Label ID="WarningAddress" runat="server" Text="" ForeColor="Red"></asp:Label><br />
    <br />

    <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label><br />
    <asp:TextBox ID="RegisterPassword" runat="server"></asp:TextBox><br />
    <asp:Label ID="WarningPassword" runat="server" Text="" ForeColor="Red"></asp:Label><br />
    <br />
    <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" />
    <asp:Label ID="SuccessLabel" runat="server" Text="" ForeColor="Green"></asp:Label><br />

</div>
</asp:Content>