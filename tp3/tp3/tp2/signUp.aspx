<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="tp2.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 382px">
    <form runat="server" style="height: 640px">
        <br />
        <br />
        first name:<br />

        <asp:TextBox ID="firstName" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstName" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>

        <br />
        <br />
        last name:<p>

        <asp:TextBox ID="lastName" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastName" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>

        </p>
        <p>

            username:</p>

        <asp:TextBox ID="username" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="username" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <br />
        <br />
        password:<p>

        <asp:TextBox ID="password" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="password" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>

        </p>
        <p>

            &nbsp;</p>

        <p>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="register" runat="server" Text="register" ValidationGroup="AllValidators" OnClick="buttonSubmit_Click" />

        </p>
        <p>

            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>

    </form>
</body>
</html>
