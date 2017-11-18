Public Class Pengguna

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tipeUserCmb.Items.Add("Admin")
        tipeUserCmb.Items.Add("User")

        Call Pengaturan()
    End Sub

    Sub Pengaturan()
        Select Case StatusS
            Case True
                UsernameTxt.IsReadOnly = False
                KosongkanIsi(Grid1)
                UsernameTxt.Focus()

                Judul.Content = "Tambah Pengguna"

            Case False
                UsernameTxt.IsReadOnly = True
                PasswordTxt.Focus()

                Judul.Content = "Edit Pengguna"
        End Select
    End Sub
    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        If Pelengkap.Isi(UsernameTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(PasswordTxt.Password) = False Then Exit Sub
        If Pelengkap.Isi(UlPasswordTxt.Password) = False Then Exit Sub
        If Pelengkap.Isi(tipeUserCmb.Text) = False Then Exit Sub

        Select Case StatusS
            Case True
                Try
                    If UlPasswordTxt.Password = PasswordTxt.Password Then
                        SQL = "INSERT INTO Login (username, Password, TypeUser) VALUES ('" + UsernameTxt.Text + "','" + PasswordTxt.Password + "','" + tipeUserCmb.Text + "')"
                        Proses.ExecuteNonQuery(SQL)

                        MessageBox.Show("Penambahan User Baru Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                        StatusS = True
                        Call Pengaturan()
                    Else
                        MsgBox("Password Tidak Cocok !")
                        UlPasswordTxt.Clear()
                        PasswordTxt.Clear()

                        PasswordTxt.Focus()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            Case False
                If UlPasswordTxt.Password = PasswordTxt.Password Then
                    SQL = "UPDATE Login SET Password = '" + PasswordTxt.Password + "',TypeUser = '" + tipeUserCmb.Text + "' WHERE Username = '" + UsernameTxt.Text + "'"
                    Proses.ExecuteNonQuery(SQL)

                    MessageBox.Show("Perubahan User Berhasil ! ", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information)

                    StatusS = True
                    Call Pengaturan()
                    Me.Close()
                Else
                    MsgBox("Password Tidak Cocok !")
                    UlPasswordTxt.Clear()
                    PasswordTxt.Clear()

                    PasswordTxt.Focus()
                End If
        End Select
    End Sub
End Class
