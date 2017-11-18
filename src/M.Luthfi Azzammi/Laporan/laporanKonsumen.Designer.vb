<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporanKonsumen
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
        Me.KonsumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KonsumenTableAdapter = New M.Luthfi_Azzammi.LuthfiAzzammiDataSetTableAdapters.KonsumenTableAdapter()
        CType(Me.LuthfiAzzammiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KonsumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Konsumen"
        ReportDataSource1.Value = Me.KonsumenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "M.Luthfi_Azzammi.LprKonsumen.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(646, 262)
        Me.ReportViewer1.TabIndex = 0
        '
        'LuthfiAzzammiDataSet
        '
        Me.LuthfiAzzammiDataSet.DataSetName = "LuthfiAzzammiDataSet"
        Me.LuthfiAzzammiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KonsumenBindingSource
        '
        Me.KonsumenBindingSource.DataMember = "Konsumen"
        Me.KonsumenBindingSource.DataSource = Me.LuthfiAzzammiDataSet
        '
        'KonsumenTableAdapter
        '
        Me.KonsumenTableAdapter.ClearBeforeFill = True
        '
        'laporanKonsumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "laporanKonsumen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "laporanKonsumen"
        CType(Me.LuthfiAzzammiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KonsumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents KonsumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LuthfiAzzammiDataSet As M.Luthfi_Azzammi.LuthfiAzzammiDataSet
    Friend WithEvents KonsumenTableAdapter As M.Luthfi_Azzammi.LuthfiAzzammiDataSetTableAdapters.KonsumenTableAdapter
End Class
