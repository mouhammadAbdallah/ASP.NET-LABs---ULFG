<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="client.aspx.cs" Inherits="tp4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button id="UploadBtn" Text="Upload File" OnClick="UploadBtn_Click" runat="server" Width="105px" />

        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
