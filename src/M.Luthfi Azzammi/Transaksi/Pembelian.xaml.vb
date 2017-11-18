Imports System.Data

Public Class Pembelian
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Call Pengaturan()
    End Sub

    Sub Record()
        Try
            Tabel = Proses.ExecuteQuery("SELECT RincianPembelian.NoRincian, Barang.Nmbarang, Barang.TglUpdateStok, RincianPembelian.Jumlah, RincianPembelian.Total FROM Barang INNER JOIN RincianPembelian ON Barang.KodeBarang = RincianPembelian.KodeBarang WHERE RincianPembelian.No_Pembelian = '" & NoPembelianTxt.Text & "'")
            DG1.ItemsSource = Nothing
            DG1.ItemsSource = Tabel.DefaultView

        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message())
        End Try
    End Sub

    Sub Hitung()
        Dim RowView As DataRowView = DG1.Items(3)
        Dim TotalSemua As Long
        For t As Integer = 0 To DG1.Items.Count - 1
            TotalSemua = TotalSemua + Val(Replace(RowView.Row(3).ToString, ",", ""))
        Next
        TotalTxt.Text = Val(TotalSemua).ToString("#,#")
    End Sub

    Sub Pengaturan()
        Select Case StatusS
            Case True
                KosongkanIsi(GridIsian)
                NoPembelianTxt.Text = Pelengkap.Generate("Pembelian", "NoPembelian")

                Call Record()
                HapusBtn.IsEnabled = False
            Case False
                KosongkanIsi(GridIsian)
                NoPembelianTxt.Text = Pelengkap.Generate("Pembelian", "NoPembelian")

                HapusBtn.IsEnabled = True
                Call Record()
        End Select
    End Sub

    Sub Simpan()
        Try
            Tabel = Proses.ExecuteQuery("SELECT * FROM RincianPembelian WHERE KodeBarang = '" & IdJenisBarangCmb.Text & "'")
            If Tabel.Rows.Count = 0 Then
                SQL = "INSERT INTO RincianPembelian VALUES ('" & Pelengkap.Generate("RincianPembelian", "NoRincian") & "','" & Val(JumlahTxtTxt.Text) & "','" & IdJenisBarangCmb.Text & _
                    "','" & NoPembelianTxt.Text & "','" & Val(Replace(SubTotalTxt.Text, ",", "")) & "')"
                Proses.ExecuteNonQuery(SQL)

                Call Record()
            Else
                Tabel = Proses.ExecuteQuery("SELECT Jumlah FROM RincianPembelian WHERE KodeBarang = '" & IdJenisBarangCmb.Text & "'")
                Jumlah_Awal = Tabel.Rows(0).Item("Jumlah")
                Jumlah = Val(Replace(JumlahTxtTxt.Text, ",", ""))
                Jumlah_Akhir = Val(Jumlah_Awal) + Val(Jumlah_Akhir)
                SQL = "UPDATE RincianPembelian SET Jumlah = '" & Val(Jumlah_Akhir) & "',Total = '" & Val(Replace(SubTotalTxt.Text, ",", "")) & _
                    "' WHERE KodeBarang = '" & IdJenisBarangCmb.Text & "'"
                Proses.ExecuteNonQuery(SQL)

                Call Record()
            End If
        Catch ex As Exception

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

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        varstr = NoPembelianTxt.Text
        varstr1 = Format(CDate(Now), "yyyy-MM-dd")

        Dim Nota As New Nota
        With Nota
            .Pengaturan()
            .TotalKotorTxt.Text = TotalTxt.Text
            .DiskonTxt.Text = "0"
            .Judul.Content = "Bayar Pembelian"
            .ShowDialog()
        End With
    End Sub

    Private Sub JumlahTxtTxt_TextChanged(sender As Object, e As TextChangedEventArgs) Handles JumlahTxtTxt.TextChanged
        If JumlahTxtTxt.Text = "0" Then Exit Sub
        SubTotalTxt.Text = Val(Replace(HargaTxt.Text, ",", "") * Val(JumlahTxtTxt.Text)).ToString("#,#")
    End Sub

    Private Sub JumlahTxtTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles JumlahTxtTxt.KeyDown
        If e.Key = Key.Enter Then SubTotalTxt.Focus()
    End Sub

    Private Sub IdJenisBarangCmb_KeyDown(sender As Object, e As KeyEventArgs) Handles IdJenisBarangCmb.KeyDown
        If e.Key = Key.Enter Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * FROM Barang WHERE KodeBarang = '" & IdJenisBarangCmb.Text & "'")
                NmPBarangTxt.Text = Tabel.Rows(0).Item("NmBarang")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub KdSupplierCmb_KeyDown(sender As Object, e As KeyEventArgs) Handles KdSupplierCmb.KeyDown
        If e.Key = Key.Enter Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * FROM Supplier WHERE IDSupplier = '" & KdSupplierCmb.Text & "'")
                NmSupplierTxt.Text = Tabel.Rows(0).Item("NmSupplier")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As RoutedEventArgs) Handles HapusBtn.Click
        Try
            Dim Rowview As DataRowView = DG1.SelectedItem

            Dim Pesan = MessageBox.Show("Yakin Ingin Menghapus " + Rowview.Row(0).ToString + " ? ", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question)
            If Pesan = MessageBoxResult.Yes Then
                SQL = "DELETE FROM RincianPembelian WHERE NoRincian = '" + Rowview.Row(0).ToString + "'"
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

    Private Sub SubTotalTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles SubTotalTxt.KeyDown
        If e.Key = Key.Enter Then
            Call Simpan()
        End If
    End Sub

    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub
End Class
