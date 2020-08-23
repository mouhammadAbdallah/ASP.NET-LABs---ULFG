<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="tp2.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Precise Delete: A Record Smart Bomb</h3>
            Last Name of Record to Delete:<br />
            <asp:TextBox ID="LName" runat="server" /><p />
            First Name of Record to Delete:<br />
            <asp:TextBox ID="FName" runat="server" /><p />
            <asp:Button ID="Button1" runat="server"
                Text="Wipe Out Record"
                OnClick="WipeOut" /><p />
            <asp:Label ID="Label1" runat="server" Text="Status" />
        </div>
    </form>
</body>
</html>
