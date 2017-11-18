Public Class konsumen

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
                NmKonsumenxt.Focus()

                Judul.Content = "Tambah Konsumen"

            Case False
                KodeKonsumenTxt.IsReadOnly = True
                NmKonsumenxt.Focus()

                Judul.Content = "Edit Konsumen"
        End Select
    End Sub
    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        If Pelengkap.Isi(KodeKonsumenTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(NmKonsumenxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(TelponTxt.Text) = False Then Exit Sub

        Select Case StatusS
            Case True
                Try

                    SQL = "INSERT INTO Konsumen (KdKonsumen, NmKonsumen, AlmtKonsumen, TelpKonsumen) VALUES ('" & KodeKonsumenTxt.Text & "','" & NmKonsumenxt.Text & "','" & AlamatTxt.Text & _
                        "','" & Val(TelponTxt.Text) & "')"
                    Proses.ExecuteNonQuery(SQL)

                    MessageBox.Show("Penambahan Data Baru Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                    StatusS = True
                    Call Pengaturan()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                    Exit Sub
                End Try
            Case False

                SQL = "UPDATE Konsumen SET NmKonsumen = '" & NmKonsumenxt.Text & "', AlmtKonsumen = '" & AlamatTxt.Text & "', TelpKonsumen = '" & Val(TelponTxt.Text) & _
                    "'WHERE KdKonsumen = '" & KodeKonsumenTxt.Text & "'"
                Proses.ExecuteNonQuery(SQL)

                MessageBox.Show("Perubahan Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                StatusS = True
                Call Pengaturan()
                Me.Close()

        End Select
    End Sub
End Class
