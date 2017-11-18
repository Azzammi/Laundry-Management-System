Imports System.Data

Public Class ViewKaryawan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Call Record()
    End Sub

    Sub Record()
        Try
            Tabel = Proses.ExecuteQuery("SELECT * FROM Karyawan")
            DG1.ItemsSource = Nothing

            DG1.ItemsSource = Tabel.DefaultView

        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message())
        End Try
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        StatusS = True

        Dim Barang As New Karyawan
        Barang.ShowDialog()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As RoutedEventArgs) Handles EditBtn.Click
        Try
            Dim Rowview As DataRowView = DG1.SelectedItem
            StatusS = False
            Dim Login As New Karyawan
            With Login
                .KodeKaryawanTxt.Text = Rowview.Row(0).ToString
                .NmKaryawanTxt.Text = Rowview.Row(1).ToString
                .AlamatTxt.Text = Rowview.Row(2).ToString
                .TeleponTxt.Text = Rowview.Row(3).ToString
                .GenderCmb.Text = Rowview.Row(4).ToString
            End With

            Rowview = Nothing
            Login.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Anda Belum Memilih Data")
        End Try
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As RoutedEventArgs) Handles HapusBtn.Click
        Try
            Dim Rowview As DataRowView = DG1.SelectedItem

            Dim Pesan = MessageBox.Show("Yakin Ingin Menghapus " + Rowview.Row(0).ToString + " ? ", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question)
            If Pesan = MessageBoxResult.Yes Then
                SQL = "DELETE FROM karyawan WHERE NIK = '" + Rowview.Row(0).ToString + "'"
                Proses.ExecuteNonQuery(SQL)

                MessageBox.Show("Penghapusan Data Berhasil !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)
                Call Record()
            Else

            End If

            Rowview = Nothing
        Catch ex As Exception
            MessageBox.Show("Anda belum memilih data")
        End Try
    End Sub

    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub

    Private Sub CariTxt_TextChanged(sender As Object, e As TextChangedEventArgs) Handles CariTxt.TextChanged
        Try
            Tabel = Proses.ExecuteQuery("SELECT * FROM Karyawan WHERE NIK like '%" & CariTxt.Text & "%'")
            DG1.ItemsSource = Nothing

            DG1.ItemsSource = Tabel.DefaultView

        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message())
        End Try
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As RoutedEventArgs) Handles RefreshBtn.Click
        Call Record()
    End Sub
End Class
