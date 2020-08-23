<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="tp2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Please fill out the form:</h3>
            <asp:TextBox ID="LName" runat="server" />&nbsp;Last Name<br />
            <asp:TextBox ID="FName" runat="server" />&nbsp;First Name<br />
            <asp:TextBox ID="Em" runat="server" />&nbsp;Email Address<br />
            <asp:TextBox ID="Donate" runat="server" />&nbsp;Amount of Donation<p />
            <asp:Button ID="Button1" runat="server"
                Text="Send Information"
                OnClick="EnterData" /><p />
            <asp:Label ID="Label1" runat="server"
                Text="Status" />
        </div>
    </form>
</body>
</html>
