<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="tp2.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 382px">
    <form runat="server" style="height: 640px">
        <p>

            &nbsp;</p>
        <p>

            username:</p>

        <asp:TextBox ID="username" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidatorusr" runat="server" ControlToValidate="username" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <br />
        <br />
        password:<p>

        <asp:TextBox ID="password" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidatorpass" runat="server" ControlToValidate="password" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>

        </p>
        <p>

            &nbsp;</p>

        <p>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="logIn" runat="server" Text="logIn" ValidationGroup="AllValidators" OnClick="buttonSubmit_Click" />

        </p>
        <p>

            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="clear" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="signUp" />
        </p>

    </form>
</body>
</html>
