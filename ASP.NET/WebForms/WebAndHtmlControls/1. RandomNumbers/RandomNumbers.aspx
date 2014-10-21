<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumbers.aspx.cs" Inherits="_1.RandomNumbers.RandomNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="randomGenerator" runat="server">
        <h1>Random Numbers</h1>
        Start range:
        <asp:TextBox ID="TextBoxStartRange" runat="server"></asp:TextBox>
        End range:
        <asp:TextBox ID="TextBoxEndRange" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click"/>
        <br />
        Result: 
        <asp:Label ID="LabelResult" runat="server"></asp:Label>
    </form>
</body>
</html>
