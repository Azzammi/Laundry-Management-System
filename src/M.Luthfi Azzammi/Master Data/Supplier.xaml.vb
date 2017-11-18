Public Class Supplier

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
                NmSuppTxt.Focus()

                Judul.Content = "Tambah Supplier"

            Case False
                KodeSuppTxt.IsReadOnly = True
                NmSuppTxt.Focus()

                Judul.Content = "Edit Supplier"
        End Select
    End Sub
    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        If Pelengkap.Isi(KodeSuppTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(NmSuppTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(TelpSuppTxt.Text) = False Then Exit Sub

        Select Case StatusS
            Case True
                Try

                    SQL = "INSERT INTO Supplier (IDSupplier, NmSupplier, AlmtSupplier, TelpSupplier) VALUES ('" & KodeSuppTxt.Text & "','" & NmSuppTxt.Text & "','" & AlamatSUppTxt.Text & _
                        "','" & Val(TelpSuppTxt.Text) & "')"
                    Proses.ExecuteNonQuery(SQL)

                    MessageBox.Show("Penambahan Data Baru Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                    StatusS = True
                    Call Pengaturan()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                    Exit Sub
                End Try
            Case False

                SQL = "UPDATE Supplier SET NmSupplier = '" + NmSuppTxt.Text + "', AlmtSupplier = '" + AlamatSUppTxt.Text + "', TelpSupplier = '" + TelpSuppTxt.Text + _
                    "'WHERE IDSupplier = '" + KodeSuppTxt.Text + "'"
                Proses.ExecuteNonQuery(SQL)

                MessageBox.Show("Perubahan Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                StatusS = True
                Call Pengaturan()
                Me.Close()

        End Select
    End Sub
End Class
