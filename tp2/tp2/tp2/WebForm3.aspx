<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="tp2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Enter Your Old and New Name</h3>
            Old Name:
    <asp:TextBox ID="LName" runat="server" /><p />
            New Name:
            <asp:TextBox ID="NewName" runat="server" /><p />
            <asp:Button ID="Button1" runat="server" OnClick="UpdateData" Text="Make Change" /><p />
            <asp:Label ID="Label1" runat="server" Text="Status" />
        </div>
    </form>
</body>
</html>
