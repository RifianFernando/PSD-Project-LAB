<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="KpopZtation.View.UpdateProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h1>Update Profile</h1>
        <br />
        <br />
        <asp:Button ID="DeleteButton" runat="server" Text="Delete Account" onclick="DeleteButton_Click"/>
        <br />
        <br />

        <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label><br />
        <asp:TextBox ID="UpdateName" runat="server"></asp:TextBox><br />
        <asp:Label ID="WarningName" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />

        <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label><br />
        <asp:TextBox ID="UpdateEmail" runat="server" ></asp:TextBox><br />
        <asp:Label ID="WarningEmail" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />

        <asp:Label ID="LabelGender" runat="server" Text="Gender" ></asp:Label><br />
        <asp:RadioButtonList id="UpdateGender" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="WarningGender" runat="server" Text="" ForeColor="Red" ></asp:Label><br />
        <br />

        <asp:Label ID="LabelAddress" runat="server" Text="Address"></asp:Label><br />
        <asp:TextBox ID="UpdateAddress" runat="server"></asp:TextBox><br />
        <asp:Label ID="WarningAddress" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />

        <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label><br />
        <asp:TextBox ID="UpdatePassword" runat="server"></asp:TextBox><br />
        <asp:Label ID="WarningPassword" runat="server" Text="" ForeColor="Red"></asp:Label><br />
        <br />
        <asp:Button ID="SaveUpdateButton" runat="server" Text="Save Update" OnClick="SaveUpdateButton_Click" />
        <asp:Label ID="SuccessLabel" runat="server" Text="" ForeColor="Green"></asp:Label><br />
    </div>

</asp:Content>
