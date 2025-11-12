Imports System.Data.OleDb

Public Class PhieuChiDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SavePhieuChi(ByVal phieuChiToSave As List(Of PhieuChi)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each pn In phieuChiToSave
                    If pn.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertPhieuChi(pn, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdatePhieuChi(pn, conn, transaction)
                    End If
                Next

                ' If all commands succeeded, commit the transaction
                transaction.Commit()
                Return True

            Catch ex As Exception
                ' An error occurred. Roll back all changes in the transaction.
                Console.WriteLine("Error saving data: " & ex.Message)
                Try
                    transaction?.Rollback()
                Catch rollbackEx As Exception
                    Console.WriteLine("Error during rollback: " & rollbackEx.Message)
                End Try
                Return False
            End Try
        End Using
    End Function

    ' --- Helper methods for Insert and Update ---

    Private Shared Sub InsertPhieuChi(ByVal pn As PhieuChi, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO PhieuChi (pc_code, pc_ngay, pc_tong_tien, pc_ghi_chu, pc_xoa, pc_cn_ma)
                            VALUES (?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pCode", pn.Code)
            cmd.Parameters.AddWithValue("pNgay", pn.NgayChi.ToString(Constant.DATETIME_FORMAT))
            cmd.Parameters.AddWithValue("pTT", pn.TongTien)
            cmd.Parameters.AddWithValue("pGhiChu", pn.GhiChu)
            cmd.Parameters.AddWithValue("pXoa", pn.IsXoa)
            cmd.Parameters.AddWithValue("pcnMa", pn.ChiNhanhMa)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY;"
            Dim newId As Integer = CInt(cmd.ExecuteScalar())
            pn.Ma = newId

        End Using
    End Sub

    Private Shared Sub UpdatePhieuChi(ByVal pn As PhieuChi, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE PhieuChi SET pc_ngay = ?,  pc_tong_tien = ?, pc_ghi_chu = ?, pc_xoa = ? WHERE pc_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pNgay", pn.NgayChi.ToString(Constant.DATETIME_FORMAT))
            cmd.Parameters.AddWithValue("pTongTien", pn.TongTien)
            cmd.Parameters.AddWithValue("pGhiChu", pn.GhiChu)
            cmd.Parameters.AddWithValue("pXoa", pn.IsXoa)
            cmd.Parameters.AddWithValue("pMa", pn.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Function GetAll_PhieuChi_By_ChiNhanh(chiNhanhMa As Integer) As List(Of PhieuChi)
        Dim phieuChiList As New List(Of PhieuChi)()

        Dim sql As String = "SELECT pc_ma, pc_code, pc_ngay, pc_tong_tien, pc_ghi_chu, pc_xoa, pc_cn_ma,
                            cn.cn_ma, cn.cn_ten, cn.cn_dia_chi
                            FROM
                            PhieuChi AS pc
                            INNER JOIN ChiNhanh AS cn ON pc.pc_cn_ma = cn.cn_ma
                            WHERE pc_cn_ma = ?  ORDER BY pc_ma DESC"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    cmd.Parameters.AddWithValue("pCN", chiNhanhMa)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim pn As New PhieuChi() With {
                                .Ma = CInt(reader("pc_ma")),
                                .Code = CStr(reader("pc_code")),
                                .NgayChi = CDate(reader("pc_ngay")),
                                .ChiNhanhMa = CInt(reader("pc_cn_ma")),
                                .TongTien = CDbl(reader("pc_tong_tien")),
                                .GhiChu = CStr(reader("pc_ghi_chu")),
                                .IsXoa = CBool(reader("pc_xoa")),
                                .PhieuChi_ChiNhanh = New ChiNhanh() With {
                                    .Ma = CInt(reader("cn_ma")),
                                    .Ten = CStr(reader("cn_ten")),
                                    .DiaChi = CStr(reader("cn_dia_chi"))
                                }
                        }
                        phieuChiList.Add(pn)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return phieuChiList
    End Function

    Public Function Get_ChiTietPhieuChi_By_PhieuChiMa(phieuChiMa As Integer) As List(Of ChiTietPhieuChi)
        Dim ctPhieuChiList As New List(Of ChiTietPhieuChi)()

        Dim sql As String = "SELECT ctpc_ma, ctpc_so_tien, ctpc_xoa, ctpc_pc_ma, ctpc_lydo_ma, ctpc_ghi_chu,
                            pc_ld.lydo_ma, pc_ld.lydo_code, pc_ld.lydo_mota
                            FROM
                            ChiTietPhieuChi AS ctpc
                            INNER JOIN PhieuChi_LyDo AS pc_ld ON pc_ld.lydo_ma = ctpc.ctpc_lydo_ma
                            WHERE ctpc_pc_ma = ? ORDER BY ctpc_ma DESC"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    cmd.Parameters.AddWithValue("pCN", phieuChiMa)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ctpc As New ChiTietPhieuChi() With {
                                .Ma = CInt(reader("ctpc_ma")),
                                .SoTien = CDbl(reader("ctpc_so_tien")),
                                .PhieuChiMa = CInt(reader("ctpc_pc_ma")),
                                .LyDoMa = CInt(reader("ctpc_lydo_ma")),
                                .IsXoa = CBool(reader("ctpc_xoa")),
                                .GhiChu = CStr(reader("ctpc_ghi_chu")),
                                .GetPhieuChiLyDo = New PhieuChiLyDo() With {
                                    .Ma = CInt(reader("lydo_ma")),
                                    .Code = CStr(reader("lydo_code")),
                                    .Mota = CStr(reader("lydo_mota"))
                                }
                        }
                        ctPhieuChiList.Add(ctpc)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return ctPhieuChiList
    End Function

End Class
