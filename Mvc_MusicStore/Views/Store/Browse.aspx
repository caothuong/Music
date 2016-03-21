<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Mvc_MusicStore.ViewModels.StoreBrowseViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Browse Albums
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Browse Genre:<%:Model.Genres.Name %></h2>
    <ul>
        <%foreach(var album in Model.Album) { %>
        <li><%:album.Title %></li>
        <%} %>
    </ul>

</asp:Content>
