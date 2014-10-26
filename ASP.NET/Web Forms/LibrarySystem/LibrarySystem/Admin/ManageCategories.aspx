<%@ Page Title="Manage Categories"
    Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="ManageCategories.aspx.cs"
    Inherits="LibrarySystem.Admin.ManageCategories" %>

<asp:Content ID="ContentManageCategories"
    ContentPlaceHolderID="MainContent" runat="server">
    <h1>Manage Categories</h1>

    <asp:GridView ID="GridViewCategories" runat="server"
        AutoGenerateColumns="false" DataKeyNames="CategoryId"
        ItemType="LibrarySystem.Models.Category"
        AllowPaging="true"
        AllowSorting="true"
        PageSize="3"
        OnPageIndexChanging="GridViewCategories_PageIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Category Name" DataField="Name"/>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button runat="server" Text="Edit" CommandName="EditCategory" CommandArgument="<%#: Item.CategoryId %>" OnCommand="Edit_Command"/>
                    <asp:Button runat="server" Text="Delete" CommandName="DeleteCategory" CommandArgument="<%#: Item.CategoryId %>" OnCommand="Delete_Command"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:LinkButton ID="LinkButtonCreateCategory" runat="server" Text="Create New" OnClick="LinkButtonCreateCategory_Click"/>

    <asp:Panel ID="PanelEditCategory" runat="server" Visible="false">
        <h3>Edit Category</h3>

        <asp:Label runat="server">Category</asp:Label>
        <asp:TextBox ID="TextBoxEditCategory" runat="server"/>
        <asp:Button ID="ButtonSaveCategory" runat="server" Text="Save" OnClick="ButtonSaveCategory_Click"/>
        <asp:Button ID="ButtonCancelEditCategory" runat="server" Text="Cancel" OnClick="ButtonCancelEditCategory_Click"/>
    </asp:Panel>

    <asp:Panel ID="PanelDeleteCategory" runat="server" Visible="false">
        <h3>Confirm Category Deletion?</h3>
        <asp:Button ID="ButtonDeleteCategory" runat="server" Text="Delete" OnClick="ButtonDeleteCategory_Click"/>
        <asp:Button ID="ButtonCancelDeleteCategory" runat="server" Text="Cancel" OnClick="ButtonCancelDeleteCategory_Click"/>
    </asp:Panel>

    <asp:Panel ID="PanelCreateCategory" runat="server" Visible="false">
        <h3>Create New Category</h3>
        <asp:Label runat="server">Category</asp:Label>
        <asp:TextBox ID="TextBoxCreateCategory" runat="server"/>
        <asp:Button ID="ButtonCreateCategory" runat="server" Text="Create" OnClick="ButtonCreateCategory_Click"/>
        <asp:Button ID="ButtonCancelCreateCategory" runat="server" Text="Cancel" OnClick="ButtonCancelCreateCategory_Click"/>
    </asp:Panel>
</asp:Content>