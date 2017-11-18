Public Class laporanKonsumen

    Private Sub laporanKonsumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LuthfiAzzammiDataSet.Konsumen' table. You can move, or remove it, as needed.
        Me.KonsumenTableAdapter.Fill(Me.LuthfiAzzammiDataSet.Konsumen)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class