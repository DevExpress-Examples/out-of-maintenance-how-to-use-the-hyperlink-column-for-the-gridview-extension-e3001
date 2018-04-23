<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Example.Models.MyObject>>" %>
<%
    Html.DevExpress().GridView(settings => {
        settings.Name = "grid";
        settings.CallbackRouteValues = new { Controller = "Home", Action = "GridViewPartial" };

        settings.KeyFieldName = "Key";

        settings.Columns.Add("Key");

        var column = settings.Columns.Add("Key", MVCxGridViewColumnType.HyperLink);
        HyperLinkProperties properties = column.PropertiesEdit as HyperLinkProperties;
        String urlFormatString = Url.Action("CustomAction", "Home", new RouteValueDictionary(new { id = "{0}" }));
        properties.NavigateUrlFormatString = HttpUtility.UrlDecode(urlFormatString);
        properties.TextField = "Name";
    })
    .Bind(Model)
    .Render();
%>