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
End Module
