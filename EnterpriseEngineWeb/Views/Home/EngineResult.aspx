<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page - Enterprise Engine Result
</asp:Content>
<asp:Content ID="indexFeatured" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Engine result.</h1>
                <h2><%: ViewBag.Message %></h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Decision engine</h3>
    <p><%: ViewBag.Result %></p>
    <p><%: ViewBag.RandomString %></p>
</asp:Content>