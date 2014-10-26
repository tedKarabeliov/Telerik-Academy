<%@ Page Title="Manage Books"
    Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="ManageBooks.aspx.cs"
    Inherits="LibrarySystem.Admin.ManageBooks" %>

<asp:Content ID="ContentManageBooks" runat="server"
    ContentPlaceHolderID="MainContent">
    <h1>Manage Books</h1>

    <asp:GridView ID="GridViewBooks" runat="server"
        AutoGenerateColumns="false" DataKeyNames="BookId"
        ItemType="LibrarySystem.Models.Book"
        AllowPaging="true"
        AllowSorting="true"
        PageSize="5"
        OnPageIndexChanging="GridViewBooks_PageIndexChanging">
        <Columns>
            <asp:BoundField HeaderText="Title" DataField="Title" />
            <asp:BoundField HeaderText="Author" DataField="Authors" />
            <asp:BoundField HeaderText="ISBN" DataField="ISBN" />
            <asp:HyperLinkField HeaderText="Web Site" DataNavigateUrlFields="URL" DataTextField="URL"/>
            <asp:BoundField HeaderText="Category" DataField="Category.Name" />
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button runat="server" Text="Edit" CommandName="EditBook" CommandArgument="<%#: Item.BookId %>" OnCommand="EditBook_Command"/>
                    <asp:Button runat="server" Text="Delete"
                        CommandName="DeleteBook" CommandArgument="<%#: Item.BookId %>"
                        OnCommand="ButtonDeleteBook_Command"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:HyperLink ID="HyperLinkButtonCreateBook" runat="server" NavigateUrl="~/Admin/CreateBook.aspx" Text="Create New"/>

    <asp:Panel ID="PanelDeleteBook" runat="server" Visible="false">
        <h3>Confirm Book Deletion?</h3>
        <asp:Button ID="ButtonDeleteBook" runat="server" Text="Delete" OnClick="ButtonDeleteBook_Click"/>
        <asp:Button ID="ButtonCancelDeleteBook" runat="server" Text="Cancel" OnClick="ButtonCancelDeleteBook_Click"/>
    </asp:Panel>

</asp:Content>
