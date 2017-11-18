Public Class LaporanKaryawan

    Private Sub LaporanKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LuthfiAzzammiDataSet.Karyawan' table. You can move, or remove it, as needed.
        Me.KaryawanTableAdapter.Fill(Me.LuthfiAzzammiDataSet.Karyawan)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class