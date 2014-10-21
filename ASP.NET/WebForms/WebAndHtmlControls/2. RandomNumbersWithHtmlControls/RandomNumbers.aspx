<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumbers.aspx.cs" Inherits="_2.RandomNumbersWithHtmlControls.RandomNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="randomGenerator" runat="server">
        <h1>Random numbers:</h1>
        First number:
        <span id="SpanStartRange" runat="server"></span>
        <input type="text" id="InputStartRange" runat="server" />
        Second number:
        <span id="SpanEndRange" runat="server"></span>
        <input type="text" id="InputEndRange" runat="server" />
        <br />
        Result:
        <span type="submit" id="SpanResult" runat="server" onserverclick="SpanResult_Click"/>
    </form>
</body>
</html>
