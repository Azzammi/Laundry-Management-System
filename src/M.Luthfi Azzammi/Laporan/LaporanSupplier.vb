Public Class LaporanSupplier

    Private Sub LaporanSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LuthfiAzzammiDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.LuthfiAzzammiDataSet.Supplier)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class