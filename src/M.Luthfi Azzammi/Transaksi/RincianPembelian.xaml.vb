Imports System.Data

Public Class RincianPembelian
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Sub Record()
        Try
            Tabel = Proses.ExecuteQuery("SELECT * FROM Pembelian WHERE TglPembelian <= '" & Format(CDate(Tgl1.Text), "yyyy-MM-dd") & "' AND TglPembelian >= '" & Format(CDate(Tgl2.Text), "yyyy-MM-dd") & "'")
            DG1.ItemsSource = Nothing

            DG1.ItemsSource = Tabel.DefaultView

        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message())
        End Try
    End Sub

    'Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
    '    Dim Barang As New Barang

    '    StatusS = True
    '    Barang.ShowDialog()
    'End Sub

    'Private Sub EditBtn_Click(sender As Object, e As RoutedEventArgs) Handles EditBtn.Click
    '    Try
    '        Dim Rowview As DataRowView = DG1.SelectedItem
    '        StatusS = False
    '        Dim Login As New Barang
    '        With Login
    '            .KodeBarangTxt.Text = Rowview.Row(0).ToString
    '            .NmBarangTxt.Text = Rowview.Row(1).ToString
    '            .StokTxt.Text = Rowview.Row(2).ToString
    '            .TglUpdateStok.Text = Rowview.Row(3).ToString
    '        End With

    '        Rowview = Nothing
    '        Login.ShowDialog()
    '    Catch ex As Exception
    '        MessageBox.Show("Anda Belum Memilih Data")
    '    End Try
    'End Sub

    'Private Sub HapusBtn_Click(sender As Object, e As RoutedEventArgs) Handles HapusBtn.Click
    '    Try
    '        Dim Rowview As DataRowView = DG1.SelectedItem

    '        Dim Pesan = MessageBox.Show("Yakin Ingin Menghapus " + Rowview.Row(0).ToString + " ? ", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question)
    '        If Pesan = MessageBoxResult.Yes Then
    '            SQL = "DELETE FROM Barang WHERE KodeBarang = '" + Rowview.Row(0).ToString + "'"
    '            Proses.ExecuteNonQuery(SQL)

    '            MessageBox.Show("Penghapusan User Berhasil !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)
    '            Call Record()
    '        Else

    '        End If

    '        Rowview = Nothing
    '    Catch ex As Exception
    '        MessageBox.Show("Anda belum memilih data")
    '    End Try
    'End Sub

    'Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
    '    Me.Close()
    'End Sub

    Private Sub CariBtn_Click(sender As Object, e As RoutedEventArgs) Handles CariBtn.Click
        Call Record()
    End Sub
End Class
