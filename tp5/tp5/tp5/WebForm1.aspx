<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="tp5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="sname" HeaderText="sname" SortExpression="sname" />
                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="products.aspx?sId={0}" Text="View Products" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tempdbConnectionString %>" SelectCommand="SELECT * FROM [supplier]"></asp:SqlDataSource>
    </form>
</body>
</html>
