Imports System.Runtime.Intrinsics.X86

Public Class BaseForm
    Private listForms As List(Of Form)
    Public Sub New()
        Me.listForms = New List(Of Form)
    End Sub

    Public Property GetForms() As List(Of Form)
        Get
            Return listForms
        End Get
        Set(ByVal value As List(Of Form))
            listForms = value
        End Set
    End Property
End Class
