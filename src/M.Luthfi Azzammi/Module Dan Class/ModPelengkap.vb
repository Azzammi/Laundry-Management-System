Imports System.Data
Module ModPelengkap

    Public Tabel As New DataTable
    Public Pelengkap As New clspelengkap
    Public Proses As New ClsKoneksi

    Public Jumlah, Jumlah_Awal, Jumlah_Akhir As Integer
    Public SubTotal As Long

    Public User, varstr, varstr1, varstr2, varstr3 As String
    Public StatusS As Boolean

    Public Sub KosongkanIsi(ByVal x As Grid)
        For Each r As Object In LogicalTreeHelper.GetChildren(x)
            If TypeOf (r) Is TextBox Then
                r.Text = ""
            ElseIf TypeOf (r) Is ComboBox Then
                r.Text = ""
            ElseIf TypeOf (r) Is PasswordBox Then
                r.Password = ""
            End If
        Next
    End Sub
End Module
