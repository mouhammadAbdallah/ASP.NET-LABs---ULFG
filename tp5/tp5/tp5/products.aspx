<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="tp5.products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Height="370px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="705px">
            <Columns>
                <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
                <asp:BoundField DataField="pdescription" HeaderText="pdescription" SortExpression="pdescription" />
                <asp:ImageField DataImageUrlField="img">
                    <ControlStyle Height="100px" Width="100px" />
                </asp:ImageField>
            </Columns>
        </asp:GridView>
        <br />
        add an item:<br />
        name:<br />
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        description:<br />
        <asp:TextBox ID="desc" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        image:<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tempdbConnectionString %>" SelectCommand="SELECT * FROM [product] WHERE ([psupplier] = @psupplier)">
            <SelectParameters>
                <asp:QueryStringParameter Name="psupplier" QueryStringField="sId" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="add" />
    </form>
</body>
</html>
