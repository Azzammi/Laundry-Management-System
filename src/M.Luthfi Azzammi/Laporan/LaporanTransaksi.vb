Public Class LaporanTransaksi

    Private Sub LaporanTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LuthfiAzzammiDataSet.Transaksi' table. You can move, or remove it, as needed.
        Me.TransaksiTableAdapter.Fill(Me.LuthfiAzzammiDataSet.Transaksi)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class