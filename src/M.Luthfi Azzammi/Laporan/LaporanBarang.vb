Public Class Laporan

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LuthfiAzzammiDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.LuthfiAzzammiDataSet.Barang)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class