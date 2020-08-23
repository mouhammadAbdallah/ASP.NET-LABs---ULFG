<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="tp_1.WebForm1" %>

<!DOCTYPE html>

<html>
<body style="height: 382px">
    <form runat="server" style="height: 640px">
        <h3>
            <asp:Label ID="dtn" runat="server" />
        </h3>

        <asp:TextBox ID="firstName" runat="server">mohamad</asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstName" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>

        <p>

        <asp:TextBox ID="lastName" runat="server">abdallah</asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastName" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>

        </p>

        <asp:TextBox ID="dateOfBirth" runat="server">10-03-1998</asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dateOfBirth" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="dateOfBirth" ErrorMessage="RegularExpressionValidator" ValidationExpression="\d{2}-\d{2}-\d{4}" ValidationGroup="AllValidators">Enter a valid Date!</asp:RegularExpressionValidator>

        <p>

        <asp:TextBox ID="placeOfBirth" runat="server">Dennyeh</asp:TextBox>

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
            &nbsp;</p>

    </form>
</body>
</html>
