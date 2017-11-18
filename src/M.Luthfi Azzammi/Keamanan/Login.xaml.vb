Imports System.Data.SqlServerCe
Public Class Login
    Dim Counter As Integer = 0

    Private Sub LoginBtn_Click(sender As Object, e As RoutedEventArgs) Handles LoginBtn.Click
        If Pelengkap.Isi(UsernameTxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(PasswordTxt.Password) = False Then Exit Sub

        Try
            If Not Con_Open() Then

            End If
            Using Perintah As New SqlCeCommand("SELECT Password FROM Login WHERE UserName = '" + UsernameTxt.Text.Replace("'", "").Replace("--", "") + "'", Koneksi)
                Dim Pass As String
                Pass = Perintah.ExecuteScalar
                If Pass <> Nothing Then
                    If Pass = PasswordTxt.Password Then
                        MessageBox.Show("SELAMAT DATANG ! ", "Login Success", MessageBoxButton.OK, MessageBoxImage.Information)
                        User = UsernameTxt.Text

                        Dim MenuUtama As New MainWindow
                        With MenuUtama
                            .WindowState = Windows.WindowState.Maximized
                            .PenggunaLbl.Content = "Logged As " & User
                            .ShowDialog()
                        End With

                        Me.Close()
                    Else
                        Counter += 1
                        If Counter <> 3 Then
                            MessageBox.Show("Password Salah ! ", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error)
                            PasswordTxt.Clear()
                            PasswordTxt.Focus()
                        Else
                            MessageBox.Show("Password Salah ! Anda Sudah 3X melakukan kesalah silahkan keluar ", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error)
                            End
                        End If
                    End If
                Else
                    Counter += 1
                    If Counter <> 3 Then
                        MessageBox.Show("Username Salah ! ", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error)
                        UsernameTxt.Clear()
                        PasswordTxt.Clear()
                        UsernameTxt.Focus()
                    Else
                        MessageBox.Show("Username Salah ! Anda Sudah 3X melakukan kesalah silahkan keluar  ", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error)
                        End
                    End If
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan Pada Sistem " + ex.Message())
        End Try
    End Sub

    Private Sub BatalBtn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBtn.Click
        End
    End Sub

    Private Sub UsernameTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameTxt.KeyDown
        If e.Key = Key.Enter Then PasswordTxt.Focus()
    End Sub

    Private Sub PasswordTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTxt.KeyDown
        If e.Key = Key.Enter Then Call LoginBtn_Click(LoginBtn, New RoutedEventArgs)
    End Sub
End Class
