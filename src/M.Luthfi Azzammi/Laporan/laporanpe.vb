Public Class laporanpe

    Private Sub laporanpe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LuthfiAzzammiDataSet.Pembelian' table. You can move, or remove it, as needed.
        Me.PembelianTableAdapter.Fill(Me.LuthfiAzzammiDataSet.Pembelian)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class