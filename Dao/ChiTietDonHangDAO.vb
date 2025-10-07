Imports System.Data.OleDb

Public Class ChiTietDonHangDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveChiTietDonHang(ByVal chiTietPbh As List(Of ChiTietDonHang)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each ctPbh In chiTietPbh
                    If ctPbh.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertCTDonHang(ctPbh, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateCTDonHang(ctPbh, conn, transaction)
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

    Private Shared Sub InsertCTDonHang(ByVal ctpbh As ChiTietDonHang, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO ChiTietPhieuBanHang (ctpbh_pbh_ma, ctpbh_ma_san_pham, ctpbh_so_luong,
            ctpbh_gia, ctpbh_khuyen_mai, ctpbh_thanh_tien, ctpbh_xoa)
                            VALUES (?, ?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pMa", ctpbh.Pbh_Ma)
            cmd.Parameters.AddWithValue("pSpMa", ctpbh.Sp_Ma)
            cmd.Parameters.AddWithValue("pSl", ctpbh.SoLuong)
            cmd.Parameters.AddWithValue("TGia", ctpbh.Gia)
            cmd.Parameters.AddWithValue("pKm", ctpbh.KhuyenMai)
            cmd.Parameters.AddWithValue("pTT", ctpbh.ThanhTien)
            cmd.Parameters.AddWithValue("pXoa", ctpbh.IsXoa)
            cmd.ExecuteNonQuery()

            ' Optional: Get the new ID of the inserted record
            cmd.CommandText = "SELECT @@IDENTITY;"
            ctpbh.Ma = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Private Shared Sub UpdateCTDonHang(ByVal ctpbh As ChiTietDonHang, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE ChiTietPhieuBanHang SET ctpbh_so_luong = ?,
            ctpbh_khuyen_mai = ?, ctpbh_thanh_tien = ? WHERE ctpbh_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pSl", ctpbh.SoLuong)
            cmd.Parameters.AddWithValue("pKm", ctpbh.KhuyenMai)
            cmd.Parameters.AddWithValue("pTT", ctpbh.ThanhTien)
            cmd.Parameters.AddWithValue("pMa", ctpbh.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class
