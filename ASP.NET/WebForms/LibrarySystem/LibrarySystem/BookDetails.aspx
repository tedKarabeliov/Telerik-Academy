<%@ Page Title="Book Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="LibrarySystem.WebForm1" %>
<asp:Content ID="ContentBookDetails" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Book Details</h1>
    <h2><%= Book.Title %></h2>
    <h3>by <%= Book.Authors %></h3>
    <h4>ISBN: <%= Book.ISBN %></h4>
    <h5>Web site: <%= Book.URL %></h5>
    <p><%= Book.Description %></p>

    <asp:HyperLink runat="server" NavigateUrl="~/Default.aspx" Text="Back to books" />
</asp:Content>
