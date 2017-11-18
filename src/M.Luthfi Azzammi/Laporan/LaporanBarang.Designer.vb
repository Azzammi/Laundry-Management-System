<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LuthfiAzzammiDataSet = New M.Luthfi_Azzammi.LuthfiAzzammiDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BarangTableAdapter = New M.Luthfi_Azzammi.LuthfiAzzammiDataSetTableAdapters.BarangTableAdapter()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LuthfiAzzammiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.LuthfiAzzammiDataSet
        '
        'LuthfiAzzammiDataSet
        '
        Me.LuthfiAzzammiDataSet.DataSetName = "LuthfiAzzammiDataSet"
        Me.LuthfiAzzammiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Barang"
        ReportDataSource1.Value = Me.BarangBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "M.Luthfi_Azzammi.LprBarang.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(745, 262)
        Me.ReportViewer1.TabIndex = 0
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Laporan"
        Me.ShowInTaskbar = False
        Me.Text = "Laporan"
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LuthfiAzzammiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LuthfiAzzammiDataSet As M.Luthfi_Azzammi.LuthfiAzzammiDataSet
    Friend WithEvents BarangTableAdapter As M.Luthfi_Azzammi.LuthfiAzzammiDataSetTableAdapters.BarangTableAdapter
End Class
