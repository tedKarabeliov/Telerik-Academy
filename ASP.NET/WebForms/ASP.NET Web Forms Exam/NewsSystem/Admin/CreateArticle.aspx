<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="CreateArticle.aspx.cs" MasterPageFile="~/Site.Master"
    Inherits="NewsSystem.CreateArticle" %>

<asp:Content ID="ContentCreateArticle" runat="server" ContentPlaceHolderID="MainContent">
    <div class="form-group">
        Title:
        <asp:TextBox ID="TextBoxTitle" runat="server" CssClass="form-control"/>
    </div>
    <div class="form-group">
        Category: 
        <asp:DropDownList ID="DropDownListCategories" runat="server"
            DataValueField="Id"
            DataTextField="Name" />
    </div>
    <div class="form-group">
        Content: 
        <asp:TextBox ID="TextBoxContent" runat="server" TextMode="MultiLine" CssClass="form-control"/>
    </div>
    <div>
        <asp:Button ID="ButtonEditArticle" runat="server" Text="Insert" OnClick="ButtonCreateArticle_Click"/>
        <asp:Button ID="ButtonCancelEditArticle" runat="server" Text="Cancel" OnClick="ButtonCancelCreateArticle_Click"/>
    </div>
</asp:Content>
