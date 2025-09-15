Imports System.ComponentModel
Imports System.Reflection

Public Class DataMapper
    Public Shared Function MapDataTableToList(ByVal dt As DataTable) As BindingList(Of KhuVuc)
        Dim khuVucList As New BindingList(Of KhuVuc)
        For Each row As DataRow In dt.Rows
            Dim kv As New KhuVuc With {
                .Ma = DirectCast(row("kv_ma"), Integer),
                .Ten = DirectCast(row("kv_ten"), String),
                .Mota = DirectCast(row("kv_mo_ta"), String),
                .IsXoa = DirectCast(row("kv_xoa"), Boolean),
                .Code = DirectCast(row("kv_code"), String)
            }
            khuVucList.Add(kv)
        Next
        Return khuVucList
    End Function

    Public Shared Function ToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim table As New DataTable()
        If list Is Nothing OrElse list.Count = 0 Then
            Return table
        End If

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        For Each prop As PropertyDescriptor In properties
            Dim columType As Type = If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType)
            table.Columns.Add(prop.Name, columType)
        Next

        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                Dim value As Object = prop.GetValue(item)
                row(prop.Name) = If(value, DBNull.Value)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

    Public Shared Function ToList(Of T As {Class, New})(ByVal table As DataTable) As BindingList(Of T)
        Dim list As New BindingList(Of T)()
        If table Is Nothing OrElse table.Rows.Count = 0 Then
            Return list
        End If

        Dim properties As PropertyInfo() = GetType(T).GetProperties()

        For Each row As DataRow In table.Rows
            Dim obj As New T()
            For Each prop As PropertyInfo In properties
                If table.Columns.Contains(prop.Name) AndAlso Not IsDBNull(row(prop.Name)) Then
                    prop.SetValue(obj, row(prop.Name), Nothing)
                End If
            Next
            list.Add(obj)
        Next
        Return list

    End Function
End Class
