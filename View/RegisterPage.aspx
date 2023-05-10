<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="KpopZtation.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
            <asp:Button ID="Register" runat="server" Text="Button" OnClick="Register_Click" />
        </div>
    </form>
</body>
</html>
