<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Articles.aspx.cs" MasterPageFile="~/Site.Master"
    Inherits="NewsSystem.Articles" %>

<asp:Content ID="ContentArticles" runat="server"
    ContentPlaceHolderID="MainContent">

    <asp:Button ID="SortByTitle" runat="server" Text="Sort By Title" OnClick="SortByTitle_Click" />
    <asp:Button ID="SortByDate" runat="server" Text="Sort By Date" OnClick="SortByDate_Click" />
    <asp:Button ID="SortByCategory" runat="server" Text="Sort By Category" OnClick="SortByCategory_Click" />
    <asp:Button ID="SortByLikes" runat="server" Text="Sort By Likes" OnClick="SortByLikes_Click" />

    <asp:ListView ID="ListViewArticles" runat="server"
        ItemType="NewsSystem.Models.Article"
        DataKeyNames="Id">
        <ItemTemplate>
            <h3>
                <%#: Item.Title %>
                <asp:Button ID="ButtonEditArticle" runat="server" Text="Edit"
                    CommandName="CommandEdit" CommandArgument="<%#: Item.Id %>"
                    OnCommand="ButtonEditArticle_Command" />
                <asp:Button ID="ButtonDeleteArticle" runat="server" Text="Delete"
                    CommandName="CommandDelete" CommandArgument="<%#: Item.Id %>"
                    OnCommand="ButtonDeleteArticle_Command" />
            </h3>
            <p><%#: Item.Category.Name %></p>
            <p><%#: Item.Content.Length > 300 ? (Item.Content.Substring(0, 299) + "...") : Item.Content %></p>
            <p>Likes count: <%#: Item.Likes.Count %></p>
            <div>
                <i>by <%#: Item.User.UserName %></i>
                <i>created on <%#: Item.DateCreated %></i>
            </div>
        </ItemTemplate>
    </asp:ListView>

    <asp:DataPager ID="DataPagerArticles" runat="server"
        PagedControlID="ListViewArticles" PageSize="5">
        <Fields>
            <asp:NumericPagerField ButtonType="Link" />
        </Fields>
    </asp:DataPager>

    <asp:Panel ID="PanelEditArticle" runat="server" Visible="false">
        <div>
            Title: 
        <asp:TextBox ID="TextBoxTitle" runat="server" />
        </div>
        <div>
            Category: 
        <asp:DropDownList ID="DropDownListCategories" runat="server"
            DataValueField="Id"
            DataTextField="Name" />
        </div>
        <div>
            Content: 
            <asp:TextBox ID="TextBoxContent" runat="server" TextMode="MultiLine" />
        </div>
        <div>
            <asp:Button ID="ButtonEditArticle" runat="server" Text="Edit" OnClick="ButtonEditArticle_Click" />
            <asp:Button ID="ButtonCancelEditArticle" runat="server" Text="Cancel" OnClick="ButtonCancelEditArticle_Click" />
        </div>
    </asp:Panel>
    <div>
        <asp:HyperLink ID="HyperLinkCreateArticle" runat="server" NavigateUrl="~/Admin/CreateArticle.aspx" Text="Insert new article" />
    </div>
</asp:Content>
