<%@ Page Title="Edit Book"
    Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="EditBook.aspx.cs"
    Inherits="LibrarySystem.Admin.EditBook" %>

<asp:Content ID="ContentEditBook" runat="server"
    ContentPlaceHolderID="MainContent">
    <h1>Edit Book</h1>
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
        <asp:LinkButton ID="LinkButtonSaveBook" runat="server" OnClick="LinkButtonSaveBook_Click" Text="Save" />
        <asp:LinkButton ID="LinkButtonCancelSaveBook" runat="server" OnClick="LinkButtonCancelSaveBook_Click" Text="Cancel" />
    </div>
    <asp:HyperLink runat="server" NavigateUrl="~/Admin/ManageBooks.aspx" />
</asp:Content>
