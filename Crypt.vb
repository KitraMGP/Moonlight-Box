Imports System.IO
Imports System.Security.Cryptography

Public Class Crypt
    '获取MD5
    Function GetMD5(ByVal strSource As String) As String
        Dim result As String = ""

        Try

            Dim fstream As New FileStream(strSource, FileMode.Open, FileAccess.Read)
            Dim dataToHash(fstream.Length - 1) As Byte
            fstream.Read(dataToHash, 0, fstream.Length)
            fstream.Close()
            Dim hashvalue As Byte() = CType(CryptoConfig.CreateFromName("MD5"), HashAlgorithm).ComputeHash(dataToHash)
            Dim i As Integer
            For i = 0 To hashvalue.Length - 1
                result += Microsoft.VisualBasic.Right("00" + Hex(hashvalue(i)).ToLower, 2)
            Next

            Return result
        Catch ex As Exception

            MsgBox(ex.Message)
            Return result
        End Try

    End Function

    '获取SHA1
    Function GetSHA1(ByVal strSource As String) As String
        Dim result As String = ""

        Try

            Dim fstream As New FileStream(strSource, FileMode.Open, FileAccess.Read)
            Dim dataToHash(fstream.Length - 1) As Byte
            fstream.Read(dataToHash, 0, fstream.Length)
            fstream.Close()
            Dim hashvalue As Byte() = CType(CryptoConfig.CreateFromName("SHA1"), HashAlgorithm).ComputeHash(dataToHash)
            Dim i As Integer
            For i = 0 To hashvalue.Length - 1
                result += Microsoft.VisualBasic.Right("00" + Hex(hashvalue(i)).ToLower, 2)
            Next

            Return result
        Catch ex As Exception

            MsgBox(ex.Message)
            Return result
        End Try

    End Function

    '获取SHA256
    Function GetSHA256(ByVal strSource As String) As String
        Dim result As String = ""

        Try

            Dim fstream As New FileStream(strSource, FileMode.Open, FileAccess.Read)
            Dim dataToHash(fstream.Length - 1) As Byte
            fstream.Read(dataToHash, 0, fstream.Length)
            fstream.Close()
            Dim hashvalue As Byte() = CType(CryptoConfig.CreateFromName("SHA256"), HashAlgorithm).ComputeHash(dataToHash)
            Dim i As Integer
            For i = 0 To hashvalue.Length - 1
                result += Microsoft.VisualBasic.Right("00" + Hex(hashvalue(i)).ToLower, 2)
            Next

            Return result
        Catch ex As Exception

            MsgBox(ex.Message)
            Return result
        End Try

    End Function

    '获取CRC32
    Function GetCRC32(ByVal strSource As String) As String
        Dim result As String = ""

        Try

            Dim fstream As New FileStream(strSource, FileMode.Open, FileAccess.Read)
            Dim dataToHash(fstream.Length - 1) As Byte
            fstream.Read(dataToHash, 0, fstream.Length)
            fstream.Close()
            Dim hashvalue As Byte() = CType(CryptoConfig.CreateFromName("CRC32"), HashAlgorithm).ComputeHash(dataToHash)
            Dim i As Integer
            For i = 0 To hashvalue.Length - 1
                result += Microsoft.VisualBasic.Right("00" + Hex(hashvalue(i)).ToLower, 2)
            Next

            Return result
        Catch ex As Exception

            MsgBox(ex.Message)
            Return result
        End Try

    End Function
End Class
