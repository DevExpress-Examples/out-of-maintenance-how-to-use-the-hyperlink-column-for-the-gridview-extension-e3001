Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace Example.Models
	Public Class MyObject
		Private privateKey As Integer
		Public Property Key() As Integer
			Get
				Return privateKey
			End Get
			Set(ByVal value As Integer)
				privateKey = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class
End Namespace