Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Text
Imports BCrypt.Net.BCrypt

Module Util
    Public Function getHash(ByVal str As String) As String
        Dim hasher As MD5 = MD5.Create()
        Dim dbytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(str))
        Dim builder As StringBuilder = New StringBuilder()
        For n As Integer = 0 To dbytes.Length - 1
            builder.Append(dbytes(n).ToString("X2"))
        Next
        Return builder.ToString()
    End Function

    Public Function GetRandomString(ByVal length As Integer) As String
        Dim rand As New Random()
        If length <= 0 Then
            Return String.Empty
        End If

        Const characterPool As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim result As New StringBuilder(length)

        For i As Integer = 1 To length
            Dim charIndex As Integer = rand.Next(0, characterPool.Length)
            result.Append(characterPool(charIndex))
        Next

        Return result.ToString()
    End Function

    Public Function HashPwd(ByVal plainTextPassword As String) As String
        Dim hashedPassword As String = HashPassword(plainTextPassword, GenerateSalt(12))

        Return hashedPassword
    End Function

    Public Function VerifyPassword(ByVal plainTextPassword As String, ByVal storedHash As String) As Boolean

        Dim isPasswordCorrect As Boolean = Verify(plainTextPassword, storedHash)

        Return isPasswordCorrect
    End Function

    Public Function GenUUID() As String
        Return Guid.NewGuid.ToString("N")
    End Function

    Public Function Gen_6Chars_UUID() As String
        Return GenUUID.Substring(0, 6).ToUpper()
    End Function

    Public Function Gen_12Chars_UUID() As String
        Return GenUUID.Substring(0, 12).ToUpper()
    End Function

    Function TimForm(type As Type, dsForm As List(Of Form))
        For Each frm As Form In dsForm
            If frm.GetType() Is type Then
                If frm.IsDisposed Then
                    dsForm.Remove(frm)
                    frm = Nothing

                End If
                Return frm
            End If
        Next
        Return Nothing
    End Function

    Function CurrencyFormat(amount As Double)
        Dim vietnamCulture As New CultureInfo("vi-VN")
        Dim formattedCurrency As String = amount.ToString("C", vietnamCulture)
        Return formattedCurrency
    End Function
End Module
