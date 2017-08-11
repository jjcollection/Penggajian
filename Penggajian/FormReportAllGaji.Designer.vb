<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportAllGaji
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
        Me.dbPenggajianDataSet = New Penggajian.dbPenggajianDataSet()
        Me.GridKaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridKaryawanTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter()
        CType(Me.dbPenggajianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetGridKaryawan"
        ReportDataSource1.Value = Me.GridKaryawanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Penggajian.ReportAllGaji.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(284, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbPenggajianDataSet
        '
        Me.dbPenggajianDataSet.DataSetName = "dbPenggajianDataSet"
        Me.dbPenggajianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridKaryawanBindingSource
        '
        Me.GridKaryawanBindingSource.DataMember = "GridKaryawan"
        Me.GridKaryawanBindingSource.DataSource = Me.dbPenggajianDataSet
        '
        'GridKaryawanTableAdapter
        '
        Me.GridKaryawanTableAdapter.ClearBeforeFill = True
        '
        'FormReportAllGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReportAllGaji"
        Me.Text = "FormReportAllGaji"
        CType(Me.dbPenggajianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GridKaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbPenggajianDataSet As Penggajian.dbPenggajianDataSet
    Friend WithEvents GridKaryawanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter
End Class
