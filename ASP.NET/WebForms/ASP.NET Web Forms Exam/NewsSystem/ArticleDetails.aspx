<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ArticleDetails.aspx.cs" MasterPageFile="~/Site.Master"
    Inherits="NewsSystem.ArticleDetails" %>

<asp:Content ID="ContentArticleDetails" runat="server"
    ContentPlaceHolderID="MainContent">

    <asp:FormView ID="FormViewArticle" runat="server"
        ItemType="NewsSystem.Models.Article"
        SelectMethod="FormViewArticleDetails_GetItem">

        <ItemTemplate>
            <h2>
                <%#: Item.Title %>
                <small>Category: <%#: Item.Category.Name %></small>
            </h2>
            <p><%#: Item.Content %></p>
            <p>
                <span>Author: <%#: Item.User.UserName %></span>
                <span class="pull-right"><%#: Item.DateCreated %></span>
            </p>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
