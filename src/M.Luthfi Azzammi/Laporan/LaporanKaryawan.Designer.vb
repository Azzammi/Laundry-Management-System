<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanKaryawan
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LuthfiAzzammiDataSet = New M.Luthfi_Azzammi.LuthfiAzzammiDataSet()
        Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KaryawanTableAdapter = New M.Luthfi_Azzammi.LuthfiAzzammiDataSetTableAdapters.KaryawanTableAdapter()
        CType(Me.LuthfiAzzammiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Karyawan"
        ReportDataSource1.Value = Me.KaryawanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "M.Luthfi_Azzammi.Lprkaryawan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(695, 262)
        Me.ReportViewer1.TabIndex = 0
        '
        'LuthfiAzzammiDataSet
        '
        Me.LuthfiAzzammiDataSet.DataSetName = "LuthfiAzzammiDataSet"
        Me.LuthfiAzzammiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KaryawanBindingSource
        '
        Me.KaryawanBindingSource.DataMember = "Karyawan"
        Me.KaryawanBindingSource.DataSource = Me.LuthfiAzzammiDataSet
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'LaporanKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "LaporanKaryawan"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanKaryawan"
        CType(Me.LuthfiAzzammiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents KaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LuthfiAzzammiDataSet As M.Luthfi_Azzammi.LuthfiAzzammiDataSet
    Friend WithEvents KaryawanTableAdapter As M.Luthfi_Azzammi.LuthfiAzzammiDataSetTableAdapters.KaryawanTableAdapter
End Class
