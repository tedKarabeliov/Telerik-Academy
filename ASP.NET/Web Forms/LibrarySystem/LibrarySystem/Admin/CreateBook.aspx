<%@ Page Title="Create Book"
    Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="CreateBook.aspx.cs"
    Inherits="LibrarySystem.Admin.CreateBook" %>

<asp:Content ID="ContentCreateBook" runat="server"
    ContentPlaceHolderID="MainContent">
    <h1>Create New Book</h1>
    <div class="form-horizontal">
        <div class="form-group">
            <asp:Label runat="server">Title: </asp:Label>
            <asp:TextBox ID="TextBoxTitle" runat="server" CssClass="form-control"/>
        </div>

        <div class="form-group">
            <asp:Label runat="server">Author(s): </asp:Label>
            <asp:TextBox ID="TextBoxAuthor" runat="server" CssClass="form-control"/>
        </div>


        <div class="form-group">
            <asp:Label runat="server">ISBN: </asp:Label>
            <asp:TextBox ID="TextBoxISBN" runat="server" CssClass="form-control"/>
        </div>


        <div class="form-group">
            <asp:Label runat="server">Web site: </asp:Label>
            <asp:TextBox ID="TextBoxURL" runat="server" CssClass="form-control"/>
        </div>


        <div class="form-group">
            <asp:Label runat="server">Description: </asp:Label>
            <asp:TextBox ID="TextAreaDescription" TextMode="multiline" Columns="50" Rows="5" runat="server" CssClass="form-control"/>
        </div>

        <div class="form-group">
            <asp:Label runat="server">Category: </asp:Label>
            <asp:DropDownList ID="DropDownListCategories" runat="server"
                DataValueField="CategoryId"
                DataTextField="Name" CssClass="form-control"/>
        </div>
        <asp:LinkButton ID="LinkButtonCreateBook" runat="server" OnClick="LinkButtonCreateBook_Click" Text="Create" />
        <asp:LinkButton ID="LinkButtonCancelCreateBook" runat="server" OnClick="LinkButtonCancelCreateBook_Click" Text="Cancel" />
    </div>
</asp:Content>
