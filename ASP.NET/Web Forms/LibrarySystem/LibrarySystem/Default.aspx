<%@ Page Title="Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LibrarySystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="search-container">
        <asp:TextBox ID="TextBoxSearchBooks" runat="server" />
        <asp:Button ID="ButtonSearchBooks" runat="server" Text="Search" OnClick="ButtonSearchBooks_Click" />
    </div>

    <h1>Books</h1>
    <asp:ListView ID="ListViewCategories" runat="server" ItemType="LibrarySystem.Models.Category" GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>
        <Itemtemplate>
            <div class="col-md-4">
                <h2><%#: Item.Name %></h2>
                <asp:ListView runat="server" ItemType="LibrarySystem.Models.Book" DataSource="<%# Item.Books %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:LinkButton runat="server" CommandName="BookDetails" CommandArgument="<%# Item.BookId %>" OnCommand="BookDetails_Command"><%#: Item.Title %> by <%#: Item.Authors %></asp:LinkButton>
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No books in this category.
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </Itemtemplate>
    </asp:ListView>
</asp:Content>
