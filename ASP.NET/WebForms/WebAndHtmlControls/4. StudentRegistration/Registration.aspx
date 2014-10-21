<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="_4.StudentRegistration.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="StudentRegistration" runat="server">
        First name:
        <asp:TextBox ID="TextBoxFirstName" runat="server" />
        <br />

        Last name:
        <asp:TextBox ID="TextBoxLastName" runat="server" />
        <br />

        Faculty number:
        <asp:TextBox ID="TextBoxFacultyNumber" type="Number" runat="server" />
        <br />

        Speciality:
        <asp:DropDownList ID="DropDownListSpecialties" runat="server" >
            <asp:ListItem Value="Math">Math</asp:ListItem>
            <asp:ListItem Value="Physics">Physics</asp:ListItem>
            <asp:ListItem Value="Computer Science">Computer science</asp:ListItem>
        </asp:DropDownList>
        <br />

        Univercity:
        <asp:DropDownList ID="DropDownListUnivercities" runat="server">
            <asp:ListItem Value="Sofia Univercity">Sofia Univercity</asp:ListItem>
            <asp:ListItem Value="Technical Univercity">Technical Univercity</asp:ListItem>
            <asp:ListItem Value="Medical Univercity">Medical Univercity</asp:ListItem>
        </asp:DropDownList>
        <br />

        Course:
        <asp:CheckBoxList ID="CheckBoxCourses" runat="server">
            <asp:ListItem Value="Hard Course">Hard Course</asp:ListItem>
            <asp:ListItem Value="Easy course">Easy course</asp:ListItem>
            <asp:ListItem Value="Fun Course">Fun Course</asp:ListItem>
            <asp:ListItem Value="Challenging Course">Challenging Course</asp:ListItem>
        </asp:CheckBoxList>
        <br />

        <asp:Button ID="ButtonRegister" Text="Register" runat="server" OnClick="ButtonRegister_Click"/>
    </form>
</body>
</html>
