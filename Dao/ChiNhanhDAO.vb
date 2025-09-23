Imports System.Data.OleDb

Public Class ChiNhanhDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO LOAD DATA FROM DATABASE INTO A LIST OF OBJECTS
    '========================================================================
    Public Function GetAllChiNhanh() As List(Of ChiNhanh)
        Dim chiNhanhList As New List(Of ChiNhanh)()
        Dim sql As String = "SELECT cn_ma, cn_ten, cn_dia_chi
                FROM ChiNhanh ORDER BY cn_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim cn As New ChiNhanh() With {
                                .Ma = CInt(reader("cn_ma")),
                                .Ten = CStr(reader("cn_ten")),
                                .DiaChi = CStr(reader("cn_dia_chi"))
                        }
                        chiNhanhList.Add(cn)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return chiNhanhList
    End Function
End Class
