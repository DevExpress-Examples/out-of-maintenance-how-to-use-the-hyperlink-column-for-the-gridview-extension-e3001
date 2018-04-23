<%@ Control Language="vb" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Example.Models.MyObject>>" %>
<%
	Html.DevExpress().GridView(Function(settings) AnonymousMethod1(settings)).Bind(Model).Render()
%>

private bool AnonymousMethod1(object settings)
{
	settings.Name = "grid";
	settings.CallbackRouteValues = New { Controller = "Home", Action = "GridViewPartial" };
	settings.KeyFieldName = "Key";
	settings.Columns.Add("Key");
	var column = settings.Columns.Add("Key", MVCxGridViewColumnType.HyperLink);
	HyperLinkProperties properties = TryCast(column.PropertiesEdit, HyperLinkProperties);
	String urlFormatString = Url.Action("CustomAction", "Home", New RouteValueDictionary(New { id = "{0}" }));
	properties.NavigateUrlFormatString = HttpUtility.UrlDecode(urlFormatString);
	properties.TextField = "Name";
	Return True;
}