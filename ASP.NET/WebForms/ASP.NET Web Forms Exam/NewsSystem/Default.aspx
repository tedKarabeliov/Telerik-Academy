<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NewsSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>News</h1>
    <h2>Most popular articles</h2>

    <asp:ListView ID="ListViewArticles" runat="server"
        ItemType="NewsSystem.Models.Article"
        DataKeyNames="Id">

        <ItemTemplate>
            <h3>
                <asp:LinkButton ID="LinkButtonTitle" runat="server"
                    CommandArgument="<%#: Item.Id %>"
                    OnCommand="ShowArticleDetails_Command">
                <%#: Item.Title %>
                </asp:LinkButton>
                <small><%#: Item.Category.Name %></small>
            </h3>
            <p><%#: Item.Content %></p>
            <p>Likes: <%#: Item.Likes.Count %></p>
            <div>
                <i>by <%#: Item.User.UserName %></i>
                <i>created on: <%#: Item.DateCreated %></i>
            </div>
        </ItemTemplate>
    </asp:ListView>

    <asp:ListView ID="ListViewCategories" runat="server" ItemType="NewsSystem.Models.Category" GroupItemCount="2">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>
        <ItemTemplate>
            <div class="col-md-4">
                <h2><%#: Item.Name %></h2>
                <asp:ListView runat="server"
                    ItemType="NewsSystem.Models.Article"
                    DataSource="<%# Item.Articles.OrderByDescending(a => a.DateCreated).Take(3).ToList() %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:LinkButton runat="server">
                                <asp:LinkButton runat="server" CommandArgument="<%#: Item.Id %>" OnCommand="ShowArticleDetails_Command">
                                    <strong><%#: Item.Title %></strong>
                                    <i>by <%#: Item.User.UserName %></i>
                                </asp:LinkButton>
                            </asp:LinkButton>

                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No articles in this category.
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
