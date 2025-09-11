Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class KhuVuc
    Implements INotifyPropertyChanged
    Private _ma As Integer
    Private _ten As String
    Private _mota As String
    Private _xoa As Boolean
    Private _code As String

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
            OnPropertyChanged()
        End Set
    End Property

    Public Property Mota() As String
        Get
            Return _mota
        End Get
        Set(ByVal value As String)
            _mota = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property IsXoa() As Boolean
        Get
            Return _xoa
        End Get
        Set(ByVal value As Boolean)
            _xoa = value
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
