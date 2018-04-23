Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports Example.Models

Namespace Example.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

			Return View(HomeController.GetObjects())
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView("GridViewPartial", HomeController.GetObjects())
		End Function

		<HttpGet> _
		Public Function CustomAction(ByVal id As Int32) As String
			Return String.Format("A row with the {0} key was selected", id)
		End Function

		Public Shared Function GetObjects() As List(Of MyObject)
			Dim list As New List(Of MyObject) (New MyObject() {New MyObject With {.Key = 1, .Name = "Name 1"}, New MyObject With {.Key = 2, .Name = "Test 2"}, New MyObject With {.Key = 3, .Name = "Something 3"}})

			Return list
		End Function
	End Class
End Namespace
