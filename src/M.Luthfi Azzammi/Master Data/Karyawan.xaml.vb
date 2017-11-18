Public Class Karyawan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Call Pengaturan()
    End Sub

    Sub Pengaturan()
        Select Case StatusS
            Case True
                ' KodeBarangTxt.IsReadOnly = True
                KosongkanIsi(Grid1)
                'KodeKaryawanTxt.Text = Pelengkap.Generate("Karyawan", "NIK")
                KodeKaryawanTxt.Focus()

                Judul.Content = "Tambah Karyawan"

            Case False
                KodeKaryawanTxt.IsReadOnly = True
                NmKaryawanTxt.Focus()

                Judul.Content = "Edit Karyawan"
        End Select
        GenderCmb.Items.Add("L")
        GenderCmb.Items.Add("P")
    End Sub
    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        If Pelengkap.Isi(KodeKaryawanTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(NmKaryawanTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(TeleponTxt.Text) = False Then Exit Sub

        Select Case StatusS
            Case True
                Try
                    SQL = "INSERT INTO Karyawan (NIK, NmKaryawan, AlmtKaryawan, TelpKaryawan, GenderKaryawan) VALUES ('" & KodeKaryawanTxt.Text & "','" & NmKaryawanTxt.Text & "','" & AlamatTxt.Text & _
                        "','" & Val(TeleponTxt.Text) & "','" & GenderCmb.Text & "')"
                    Proses.ExecuteNonQuery(SQL)

                    MessageBox.Show("Penambahan Data Baru Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                    StatusS = True
                    Call Pengaturan()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                    Exit Sub
                End Try
            Case False

                SQL = "UPDATE Karyawan SET NmKaryawan = '" & NmKaryawanTxt.Text & "', AlmtKaryawan = '" & AlamatTxt.Text & "', TelpKaryawan = '" & Val(TeleponTxt.Text) & _
                    "',GenderKaryawan = '" & GenderCmb.Text & "' WHERE NIK = '" & KodeKaryawanTxt.Text & "'"
                Proses.ExecuteNonQuery(SQL)

                MessageBox.Show("Perubahan Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                StatusS = True
                Call Pengaturan()
                Me.Close()

        End Select
    End Sub
End Class
