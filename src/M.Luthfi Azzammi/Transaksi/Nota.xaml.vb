Public Class Nota

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Call Pengaturan()
    End Sub

    Sub Pengaturan()
        KosongkanIsi(Grid1)
    End Sub
    Private Sub BatalBTn_Click(sender As Object, e As RoutedEventArgs) Handles BatalBTn.Click
        Me.Close()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As RoutedEventArgs) Handles SimpanBtn.Click
        If Val(BayarTxt.Text) <= Val(Replace(TotalKotorTxt.Text, ",", "")) Then
            MsgBox("Uang Tidak Cukup !")
            BayarTxt.Focus()
        Else
            'Dim Kembalian As New Kembalian
            'Kembalian.KembalianLbl.Content = Val(Replace(TotalKotorTxt.Text, ",", "")) - Val(BayarTxt.Text)

            Select Case Judul.Content
                Case "Bayar Transaksi"
                    Try
                        SQL = "INSERT INTO Transaksi VALUES ('" & varstr & "','" & varstr1 & "','" & varstr1 & "','" & DiskonTxt.Text & "')"
                        Proses.ExecuteNonQuery(SQL)

                    Catch ex As Exception
                        MessageBox.Show("Error " + ex.ToString())
                    End Try
                Case "Bayar Pembelian"
                    Try
                        SQL = "INSERT INTO Pembelian VALUES ('" & varstr & "','" & varstr1 & "','" & Val(TotalBersihTxt.Text) & "')"
                        Proses.ExecuteNonQuery(SQL)

                    Catch ex As Exception
                        MessageBox.Show("Error" + ex.ToString())
                    End Try

            End Select

            Dim Nota As New Kembalian
            With Nota
                .KembalianLbl.Content = Val(Replace(TotalKotorTxt.Text, ",", "")) - Val(BayarTxt.Text)
            End With
        End If
    End Sub

    Private Sub TotalBersihTxt_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TotalBersihTxt.TextChanged
        TotalBersihTxt.Text = Val(Replace(TotalBersihTxt.Text, ",", "") * 100) / Val(DiskonTxt.Text)
    End Sub

    Private Sub TotalKotorTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles TotalKotorTxt.KeyDown
        If e.Key = Key.Enter Then DiskonTxt.Focus()
    End Sub

    Private Sub DiskonTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles DiskonTxt.KeyDown
        ' If ((e.Key <= Key.D0 And e.Key >= Key.D9) Or e.Key = vbBack) Then e.Handled = False
        If e.Key = Key.Enter Then BayarTxt.Focus()
    End Sub

    Private Sub BayarTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles BayarTxt.KeyDown
        If e.Key = Key.Enter Then SimpanBtn_Click(SimpanBtn, New RoutedEventArgs)
    End Sub
End Class
