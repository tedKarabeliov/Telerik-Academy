<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlEscaping.aspx.cs" Inherits="_3.HtmlEscaping.HtmlEscaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="htmlEscaping" runat="server">
        Enter text:
        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSendText" runat="server" Text="Show text" OnClick="ButtonSendText_Click"/>
        <br />
        <br />
        Result text box:
        <br />
        <asp:TextBox ID="TextBoxResult" runat="server"></asp:TextBox>
        <br />
        Result label:
        <br />
        <asp:Label ID="LabelResult" runat="server" />
    </form>
</body>
</html>
