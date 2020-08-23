<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ass2.aspx.cs" Inherits="tp2.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 382px">
    <form runat="server" style="height: 640px">
        <h3>
            <asp:Label ID="dtn" runat="server" />
        </h3>

        <asp:TextBox ID="firstName" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstName" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>

        <p>

        <asp:TextBox ID="lastName" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastName" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>

        </p>

        <asp:TextBox ID="dateOfBirth" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dateOfBirth" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="dateOfBirth" ErrorMessage="RegularExpressionValidator" ValidationExpression="\d{2}-\d{2}-\d{4}" ValidationGroup="AllValidators">Enter a valid Date!</asp:RegularExpressionValidator>

        <p>

        <asp:TextBox ID="placeOfBirth" runat="server" OnTextChanged="placeOfBirth_TextChanged"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="placeOfBirth" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>

        </p>

        <p>
            <asp:RadioButtonList ID="mOF" runat="server" Width="235px">
                <asp:ListItem Value="0">male</asp:ListItem>
                <asp:ListItem Value="1">female</asp:ListItem>
            </asp:RadioButtonList>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="mOF" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
        </p>
        <p>

            <asp:DropDownList ID="nationality" runat="server">
                <asp:ListItem>Lebanon</asp:ListItem>
                <asp:ListItem>France</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>KSA</asp:ListItem>
            </asp:DropDownList>

        </p>

        <p>
            <asp:DropDownList ID="familysatus" runat="server">
                <asp:ListItem>single</asp:ListItem>
                <asp:ListItem>married</asp:ListItem>
                <asp:ListItem>relationship</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>

        <asp:Button ID="buttonSubmit" runat="server" Text="Submit Request" ValidationGroup="AllValidators" OnClick="buttonSubmit_Click" />

        </p>
        <p>

        <asp:Label ID="labelMessage" runat="server" Text=""></asp:Label>

        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="clear" />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="delete" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="&lt;" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="&gt;" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tempdbConnectionString %>" SelectCommand="SELECT concat([name], [lastname]) as name,id FROM [person]"></asp:SqlDataSource>
        </p>

    </form>
</body>
</html>
