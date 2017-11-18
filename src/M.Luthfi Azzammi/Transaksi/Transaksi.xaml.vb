Imports System.Data

Public Class Transaksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Call Pengaturan()
    End Sub

    Sub Record()
        Try
            Tabel = Proses.ExecuteQuery("SELECT JenisLaundry.NmJenisLaundry, Tarif.NmPakaian, Tarif.Tarif, RincianTransaksi.Jumlah FROM RincianTransaksi INNER JOIN Tarif ON RincianTransaksi.IDJenisPakaian = Tarif.IDJenisPakaian INNER JOIN JenisLaundry ON RincianTransaksi.IDJenisLaundry = JenisLaundry.IDJenisLaundry WHERE RincianTransaksi.No_Transaksi = '" & NoTransaksiTxt.Text & "'")

            'If Tabel.Rows.Count = 0 Then
            '    StatusS = True
            'Else
            '    StatusS = False
            'End If

            DG1.ItemsSource = Nothing
            DG1.ItemsSource = Tabel.DefaultView

            ' Call Hitung()
        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message())
        End Try
    End Sub

    Sub Hitung()
        Try
            Dim RowView As DataRowView = DG1.Items(2)
            Dim TotalSemua As Long = 0
            For t As Integer = 0 To DG1.Items.Count - 1
                TotalSemua = TotalSemua + Val(Replace(RowView.Row(2).ToString, ",", ""))
            Next
            '.Content = Val(TotalSemua).ToString("#,#")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Sub Pengaturan()
        Select Case StatusS
            Case True
                KosongkanIsi(GridIsian)
                NoTransaksiTxt.Text = Pelengkap.Generate("Transaksi", "NoTransaksi")

                Call Record()
                HapusBtn.IsEnabled = False
            Case False
                KosongkanIsi(GridIsian)
                NoTransaksiTxt.Text = Pelengkap.Generate("Transaksi", "NoTransaksi")

                Call Record()
                IDJenislaundryCmb.Focus()
                HapusBtn.IsEnabled = True
        End Select

        PenggunaTxt.Text = User
        TarifTxt.Text = "0"
        JumlahTxtTxt.Text = "0"
        SubTotalTxt.Text = "0"
    End Sub

    Sub Simpan()
        Try
            Tabel = Proses.ExecuteQuery("SELECT * FROM RincianTransaksi WHERE IdJenisPakaian = '" & IdJenisPakaianCmb.Text & "'")
            If Tabel.Rows.Count = 0 Then
                SQL = "INSERT INTO RincianTransaksi VALUES ('" & Pelengkap.Generate("RincianTransaksi", "IdRincian") & _
                    "','" & Val(JumlahTxtTxt.Text) & "','" & NoTransaksiTxt.Text & "','" & IdJenisPakaianCmb.Text & "','" & IDJenislaundryCmb.Text & _
                    "','" & SubTotalTxt.Text & "')"
                Proses.ExecuteNonQuery(SQL)

                Call Record()
            Else
                Tabel = Proses.ExecuteQuery("SELECT Tarif FROM Tarif WHERE IDJenisPakaian = '" & IdJenisPakaianCmb.Text & "'")
                Jumlah_Awal = Tabel.Rows(0).Item("Tarif")
                Jumlah = Val(SubTotalTxt.Text)

                Jumlah_Akhir = Val(Jumlah_Awal) + Jumlah
                SQL = "UPDATE RincianTransaksi SET Tarif = '" & JumlahTxtTxt.Text & "' WHERE IDJenisPakaian = '" & IDJenislaundryCmb.Text & "'"
                Proses.ExecuteNonQuery(SQL)

                Call Record()
            End If
            Call Hitung()
        Catch ex As Exception
            MessageBox.Show("Error Di " & ex.ToString())
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

    Private Sub JumlahTxtTxt_TextChanged(sender As Object, e As TextChangedEventArgs) Handles JumlahTxtTxt.TextChanged
        If JumlahTxtTxt.Text = "0" Then Exit Sub
        SubTotalTxt.Text = Val(Replace(TarifTxt.Text, ",", "") * Val(JumlahTxtTxt.Text)).ToString("#,#")
    End Sub

    Private Sub JumlahTxtTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles JumlahTxtTxt.KeyDown
        If e.Key = Key.Enter Then SubTotalTxt.Focus()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        varstr = NoTransaksiTxt.Text
        varstr1 = Format(CDate(Now), "yyyy-MM-dd")

        Dim NOta As New Nota
        NOta.Judul.Content = "Bayar Transaksi"
        With NOta
            .Pengaturan()
            '.TotalKotorTxt.Text = TotalLbl.Content
            .DiskonTxt.Text = "0"
        End With
        NOta.ShowDialog()
    End Sub

    Private Sub IdJenisPakaianCmb_KeyDown(sender As Object, e As KeyEventArgs) Handles IdJenisPakaianCmb.KeyDown
        If e.Key = Key.Enter Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * FROM Tarif WHERE IDJenisPakaian = '" & IdJenisPakaianCmb.Text & "'")
                NmPakaianTxt.Text = Tabel.Rows(0).Item("NmPakaian")
                TarifTxt.Text = Tabel.Rows(0).Item("Tarif")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub KdkonsumenCmb_KeyDown(sender As Object, e As KeyEventArgs) Handles KdkonsumenCmb.KeyDown
        If e.Key = Key.Enter Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * FROM Konsumen WHERE KdKonsumen = '" & KdkonsumenCmb.Text & "'")
                NmkonsumenTxt.Text = Tabel.Rows(0).Item("NmKonsumen")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub IDJenislaundryCmb_KeyDown(sender As Object, e As KeyEventArgs) Handles IDJenislaundryCmb.KeyDown
        If e.Key = Key.Enter Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * FROM JenisLaundry WHERE IDJenisLaundry = '" & IDJenislaundryCmb.Text & "'")
                NmJenisLaundry.Text = Tabel.Rows(0).Item("NmJenisLaundry")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SubTotalTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles SubTotalTxt.KeyDown
        If e.Key = Key.Enter Then
            Call Simpan()
        End If
    End Sub

    Private Sub NoTransaksiTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles NoTransaksiTxt.KeyDown
        If e.Key = Key.Enter Then
            StatusS = True
            Call Pengaturan()
        End If
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As RoutedEventArgs) Handles HapusBtn.Click
        Try
            Dim Rowview As DataRowView = DG1.SelectedItem

            Dim Pesan = MessageBox.Show("Yakin Ingin Menghapus " + NoTransaksiTxt.Text + " ? ", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question)
            If Pesan = MessageBoxResult.Yes Then
                SQL = "DELETE FROM RincianTransaksi WHERE No_Transaksi = '" + NoTransaksiTxt.Text + "'"
                Proses.ExecuteNonQuery(SQL)

                MessageBox.Show("Penghapusan Data Berhasil !", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                StatusS = True
                Call Pengaturan()
            End If

            Rowview = Nothing
        Catch ex As Exception
            MessageBox.Show("Anda belum memilih data")
        End Try
    End Sub

    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub
End Class
