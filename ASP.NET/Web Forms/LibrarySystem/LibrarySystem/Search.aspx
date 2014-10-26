<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="LibrarySystem.Search" %>
<asp:Content ID="ContentSearchBooks" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Search results for query "<%= this.Request.QueryString["q"] %>"</h1>
    <asp:Repeater ID="ListViewBooks" runat="server" ItemType="LibrarySystem.Models.Book">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <div>
                <li><a href="<%#: Item.URL %>">"<%#: Item.Title %>" by <%#: Item.Authors %> (Category: <%#: Item.Category.Name %>)</a></li>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
    <asp:HyperLink runat="server" NavigateUrl="~/Default.aspx" Text="Back to books" />
</asp:Content>
