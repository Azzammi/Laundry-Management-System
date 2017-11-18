Public Class Barang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Call Pengaturan()
    End Sub

    Sub Pengaturan()
        Select Case StatusS
            Case True
                KosongkanIsi(Grid1)

                KodeBarangTxt.IsReadOnly = False

                NmBarangTxt.Focus()

                Judul.Content = "Tambah Barang"

            Case False
                KodeBarangTxt.IsReadOnly = True
                NmBarangTxt.Focus()

                Judul.Content = "Edit Barang"
        End Select
    End Sub
    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        If Pelengkap.Isi(KodeBarangTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(NmBarangTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(StokTxt.Text) = False Then Exit Sub

        Select Case StatusS
            Case True
                Try

                    SQL = "INSERT INTO Barang (KodeBarang, NmBarang, Stok, TglUpdateStok) VALUES ('" & KodeBarangTxt.Text & "','" & NmBarangTxt.Text & "','" & Val(StokTxt.Text) & _
                        "','" & Format(CDate(TglUpdateStok.Text), "yyyy-MM-dd") & "')"
                    Proses.ExecuteNonQuery(SQL)

                    MessageBox.Show("Penambahan User Baru Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                    StatusS = True
                    Call Pengaturan()
                  
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                    Exit Sub
                End Try
            Case False

                SQL = "UPDATE Barang SET NmBarang = '" & NmBarangTxt.Text & "', Stok = '" & Val(StokTxt.Text) & "', TglUpdateStok = '" & Format(CDate(TglUpdateStok.Text), "yyyy-MM-dd") & _
                    "'WHERE KodeBarang = '" & KodeBarangTxt.Text & "'"
                Proses.ExecuteNonQuery(SQL)

                MessageBox.Show("Perubahan User Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                StatusS = True
                Call Pengaturan()
                Me.Close()
             
        End Select
    End Sub
End Class
