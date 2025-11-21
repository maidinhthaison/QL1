Imports System.Runtime.Intrinsics.X86

Public Class ChiNhanh
    Private _ma As Integer

    Private _ten As String

    Private _diachi As String

    Public Sub New()
        Me.Ma = 0
    End Sub

    Public Property Ma() As Integer
        Get
            Return _ma
        End Get
        Set(ByVal value As Integer)
            _ma = value
        End Set
    End Property

    Public Property Ten() As String
        Get
            Return _ten
        End Get
        Set(ByVal value As String)
            _ten = value
        End Set
    End Property

    Public Property DiaChi() As String
        Get
            Return _diachi
        End Get
        Set(ByVal value As String)
            _diachi = value
        End Set
    End Property
End Class
