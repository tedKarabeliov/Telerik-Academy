<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_5.Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="PanelMain" runat="server" Width="130px">
            <asp:Panel ID="PanelDisplay" runat="server">
                <asp:TextBox ID="TextBoxDisplay" runat="server" Width="110px"/>
            </asp:Panel>
            <asp:Panel ID="PanelButtons" runat="server">
                <asp:Button ID="ButtonOne" Text="1" runat="server" OnClick="ButtonOne_Click"/>
                <asp:Button ID="ButtonTwo" Text="2" runat="server" OnClick="ButtonTwo_Click"/>
                <asp:Button ID="ButtonThree" Text="3" runat="server" OnClick="ButtonThree_Click"/>
                <asp:Button ID="ButtonPlus" Text="+" runat="server" OnClick="ButtonPlus_Click"/>
                <asp:Button ID="ButtonFour" Text="4" runat="server" OnClick="ButtonFour_Click"/>
                <asp:Button ID="ButtonFive" Text="5" runat="server" OnClick="ButtonFive_Click"/>
                <asp:Button ID="ButtonSix" Text="6" runat="server" OnClick="ButtonSix_Click"/>
                <asp:Button ID="ButtonMinus" Text="-" runat="server" OnClick="ButtonMinus_Click"/>
                <asp:Button ID="ButtonSeven" Text="7" runat="server" OnClick="ButtonSeven_Click"/>
                <asp:Button ID="ButtonEight" Text="8" runat="server" OnClick="ButtonEight_Click"/>
                <asp:Button ID="ButtonNine" Text="9" runat="server" OnClick="ButtonNine_Click"/>
                <asp:Button ID="ButtonMultiply" Text="x" runat="server" OnClick="ButtonMultiply_Click"/>
                <asp:Button ID="ButtonClear" Text="C" runat="server" OnClick="ButtonClear_Click"/>
                <asp:Button ID="ButtonZero" Text="0" runat="server" OnClick="ButtonZero_Click"/>
                <asp:Button ID="ButtonDivide" Text="/" runat="server" OnClick="ButtonDivide_Click"/>
                <asp:Button ID="ButtonSquareRoot" Text="√" runat="server" OnClick="ButtonSquareRoot_Click"/>
            </asp:Panel>
            <asp:Panel ID="PanelBottom" runat="server" Width="90px">
                <asp:Button ID="ButtonCalculate" runat="server" Text="=" Width="70px" OnClick="ButtonCalculate_Click"/> 
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
