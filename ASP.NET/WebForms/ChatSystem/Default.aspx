<%@ Page Title="Home Page" Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="ChatSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Timer ID="TimerMessages" runat="server" Interval="500"></asp:Timer>

    <div class="messages-container jumbotron">
        <h2>Messages</h2>
        <asp:UpdatePanel ID="UpdatePanelMessages" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="TimerMessages" EventName="Tick" />
            </Triggers>
            <ContentTemplate>
                <asp:ListView ID="ListViewMessages" runat="server"
                    ItemType="ChatSystem.Models.Message">
                    <ItemTemplate>
                        <div class="bubble clearfix">
                            <span><%#: Item.AspNetUser.UserName %>: </span>
                            <div class="message-container bubble-content">
                                <div class="point"></div>
                                <p><%#: Item.Text %></p>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <div class="send-message-container form-group">
            <div class="input-group">
                <span class="input-group-addon">$</span>
                <asp:TextBox ID="TextBoxSendMessage" runat="server" placeholder="Message" CssClass="form-control" />
                <asp:Button ID="ButtonSendMessage" runat="server" Text="Send" OnClick="ButtonSendMessage_Click" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>
</asp:Content>
