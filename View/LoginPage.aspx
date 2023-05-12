<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="KpopZtation.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="LoginEmail" runat="server"></asp:TextBox><br />
            <asp:Label ID="WarningLoginEmail" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="LoginPassword" runat="server"></asp:TextBox><br />
            <asp:Label ID="WarningLoginPassword" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click"/>
        </div>
    </form>
</body>
</html>
