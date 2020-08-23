<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="tp_1.WebForm1" %>

<!DOCTYPE html>

<html>
<body style="height: 382px">
    <form runat="server">
        <h3>
            <asp:Label ID="dtn" runat="server" />
        </h3>

        <asp:TextBox ID="textEmail" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textEmail" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="textEmail" Display="Dynamic" ErrorMessage="E-mail addresses must be in the format of name@domain.xyz" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="AllValidators">Invalid format!</asp:RegularExpressionValidator>

        <p>

        <asp:TextBox ID="textNumberInParty" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textNumberInParty" Display="Dynamic" ErrorMessage="Please indicate how many people are in your party" ValidationGroup="AllValidators">how many people are in your party</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="textNumberInParty" Display="Dynamic" ErrorMessage="Enter a number between 1 and 20 for the number of people in your party" MaximumValue="20" MinimumValue="1" Type="Integer" ValidationGroup="AllValidators">Enter a number between 1 and 20</asp:RangeValidator>

        </p>

        <asp:TextBox ID="textPreferredDate" runat="server"></asp:TextBox>

        <p>

            <asp:CheckBox ID="checkPhoneConfirmation" runat="server" AutoPostBack="True" OnCheckedChanged="checkPhoneConfirmation_CheckedChanged" Text="Confirm reservation by telephone" />

        </p>

        <p>
            <asp:TextBox ID="textPhoneNumber" runat="server" Enabled="False"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="phone number"></asp:Label>
            <asp:RequiredFieldValidator ID="validatorRequiredPhoneNumber" runat="server" ControlToValidate="textPhoneNumber" Display="Dynamic" ErrorMessage="You must provide a phone number">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="validatorRegExPhoneNumber" runat="server" ControlToValidate="textPhoneNumber" Display="Dynamic" ErrorMessage="Phone number format is invalid" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Invalid format</asp:RegularExpressionValidator>
        </p>
        <p>

        <asp:Button ID="buttonSubmit" runat="server" Text="Submit Request" ValidationGroup="AllValidators" OnClick="buttonSubmit_Click" />

        </p>
        <p>

        <asp:Label ID="labelMessage" runat="server" Text=""></asp:Label>

        </p>

    </form>
</body>
</html>
