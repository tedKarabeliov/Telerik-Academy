<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Categories.aspx.cs" MasterPageFile="~/Site.Master"
    Inherits="NewsSystem.Categories" %>

<asp:Content ID="ContentCategories" runat="server"
    ContentPlaceHolderID="MainContent">
    <h2>Edit categories</h2>
    
    <asp:GridView ID="GridViewCategories" runat="server"
        AutoGenerateColumns="false" DataKeyNames="Id"
        ItemType="NewsSystem.Models.Category"
        AllowPaging="true"
        PageSize="5"
        AllowSorting="true"
        OnPageIndexChanging="GridViewCategories_PageIndexChanging"
        OnSorting="GridViewCategories_Sorting">
        <Columns>
            <asp:BoundField HeaderText="Category Name" DataField="Name" SortExpression="Name"/>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" Text="Edit" CommandName="EditCategory"
                        CommandArgument="<%#: Item.Id %>" OnCommand="ButtonOpenEditPanel_Command"/>
                    <asp:Button runat="server" Text="Delete"
                        CommandName="DeleteCategory"
                        CommandArgument="<%#: Item.Id %>" OnCommand="ButtonDeleteCategory_Command"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div class="create-category">
        <asp:TextBox ID="TextBoxCreateCategory" runat="server" />
        <asp:Button ID="ButtonCreateCategory" runat="server" Text="Save" OnClick="ButtonCreateCategory_Click" />
    </div>
    <asp:Panel ID="PanelEditCategory" runat="server" Visible="false">
        <asp:TextBox ID="TextBoxEditCategory" runat="server" />
        <asp:Button ID="ButtonEditCategory" runat="server" Text="Edit" OnClick="ButtonEditCategory_Click" />
    </asp:Panel>

</asp:Content>
