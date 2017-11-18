Imports Microsoft.Win32
Imports System.Data
Public Class ClsPelengkap

    Public Function Generate(ByVal Nama_Tabel As String, ByVal Nama_Field As String) As String
        Try
            Tabel = Proses.ExecuteQuery("SELECT " & Nama_Field & " FROM " & Nama_Tabel & " WHERE " & Nama_Field & " IN(SELECT MAX (" & Nama_Field & ")FROM  " & Nama_Tabel & ") ORDER BY " & Nama_Field & " DESC")
            If Tabel.Rows.Count = 0 Then
                Generate = "0001"
            Else
                Dim Hitung = Val(Strings.Right(Tabel.Rows(0).Item("" & Nama_Field & ""), 4) + 1)
                Generate = Strings.Right(Hitung, 4)
            End If
        Catch ex As Exception
            MessageBox.Show("Error " + ex.ToString())
            Return 0
        End Try
    End Function
    Public Function Isi(ByVal Teks As Object) As Boolean
        If Teks.ToString = "" Then
            MessageBox.Show("Data " + Teks + " Tidak Boleh Kosong !", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error)
            Isi = False
        Else
            Return True
        End If
    End Function
End Class
