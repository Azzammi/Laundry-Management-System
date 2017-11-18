Public Class PemakaianBarang2
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Call Pengaturan()
    End Sub

    Sub Pengaturan()
        Select Case StatusS
            Case True
                'KodeBarangTxt.Text = Pelengkap.Generate("Barang", "KodeBarang")
                ' KodeBarangTxt.IsReadOnly = True
                KosongkanIsi(Grid1)
                NmJenisTxt.Focus()

                Judul.Content = "Tambah Pemakaian Barang"

            Case False
                KodeJenisTxt.IsReadOnly = True
                NmJenisTxt.Focus()

                Judul.Content = "Edit Pemakaian Barang"
        End Select
    End Sub
    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        If Pelengkap.Isi(KodeJenisTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(NmJenisTxt.Text) = False Then Exit Sub
        'If Pelengkap.Isi(StokTxt.Text) = False Then Exit Sub

        Select Case StatusS
            Case True
                Try

                    SQL = "INSERT INTO PemakaianBarang (KodePengeluaran, Jumlah) VALUES ('" & KodeJenisTxt.Text & "','" & Val(NmJenisTxt.Text) & "')"
                    Proses.ExecuteNonQuery(SQL)

                    MessageBox.Show("Penambahan Baru Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                    StatusS = True
                    Call Pengaturan()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                    Exit Sub
                End Try
            Case False

                SQL = "UPDATE PemakaianBarang SET Jumlah = '" & Val(NmJenisTxt.Text) & "'WHERE KodePengeluaran = '" & KodeJenisTxt.Text & "'"
                Proses.ExecuteNonQuery(SQL)

                MessageBox.Show("Perubahan Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                StatusS = True
                Call Pengaturan()
                Me.Close()

        End Select
    End Sub
End Class
