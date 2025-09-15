Imports System.Security.Cryptography
Imports System.Text

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
End Module
