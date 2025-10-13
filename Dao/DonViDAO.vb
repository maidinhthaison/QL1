Imports System.Data.OleDb

Public Class DonViDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO LOAD DATA FROM DATABASE INTO A LIST OF OBJECTS
    '========================================================================
    Public Function GetAllDonVi() As List(Of DonVi)
        Dim donViList As New List(Of DonVi)()
        Dim sql As String = "SELECT * FROM DonVi WHERE dv_xoa = False ORDER BY dv_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim dv As New DonVi() With {
                                .Ma = CInt(reader("dv_ma")),
                                .Ten = CStr(reader("dv_ten")),
                                .Mota = CStr(reader("dv_mota")),
                                .IsXoa = CBool(reader("dv_xoa")),
                                .Code = CStr(reader("dv_code"))
                        }
                        donViList.Add(dv)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return donViList
    End Function

End Class
