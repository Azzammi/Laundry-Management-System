Imports System.Data.SqlServerCe
Imports System.Data

Module ModKoneksi
    Public Koneksi As New SqlCeConnection(My.Settings.KoneksiString.ToString)
    Public Perintah As New SqlCeCommand
    Public Da As New SqlCeDataAdapter
    Public Ds As New DataSet
    Public Dt As DataTable

    Public SQL As String

    Public Function Con_Open() As Boolean
        Try
            Koneksi = New SqlCeConnection(My.Settings.KoneksiString.ToString)
            Koneksi.Open()

            If Koneksi.State <> ConnectionState.Open Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !", "Connetion Error", MessageBoxButton.OK, MessageBoxImage.Error)
            Return False
        End Try
    End Function

    Public Sub Con_Close()
        If Not IsNothing(Koneksi) Then
            Koneksi.Close()
            Koneksi = Nothing
        End If
    End Sub
End Module
