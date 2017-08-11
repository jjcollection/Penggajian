<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSlip
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GridKaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbPenggajianDataSet = New Penggajian.dbPenggajianDataSet()
        Me.gridHakTunjanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridKewajibanPotonganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GridKaryawanTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter()
        Me.gridHakTunjanganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.gridHakTunjanganTableAdapter()
        Me.GridKewajibanPotonganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.GridKewajibanPotonganTableAdapter()
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbPenggajianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridHakTunjanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridKewajibanPotonganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridKaryawanBindingSource
        '
        Me.GridKaryawanBindingSource.DataMember = "GridKaryawan"
        Me.GridKaryawanBindingSource.DataSource = Me.dbPenggajianDataSet
        '
        'dbPenggajianDataSet
        '
        Me.dbPenggajianDataSet.DataSetName = "dbPenggajianDataSet"
        Me.dbPenggajianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridHakTunjanganBindingSource
        '
        Me.gridHakTunjanganBindingSource.DataMember = "gridHakTunjangan"
        Me.gridHakTunjanganBindingSource.DataSource = Me.dbPenggajianDataSet
        '
        'GridKewajibanPotonganBindingSource
        '
        Me.GridKewajibanPotonganBindingSource.DataMember = "GridKewajibanPotongan"
        Me.GridKewajibanPotonganBindingSource.DataSource = Me.dbPenggajianDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetPenggajian"
        ReportDataSource1.Value = Me.GridKaryawanBindingSource
        ReportDataSource2.Name = "DataSetTunjangan"
        ReportDataSource2.Value = Me.gridHakTunjanganBindingSource
        ReportDataSource3.Name = "DataSetPotongan"
        ReportDataSource3.Value = Me.GridKewajibanPotonganBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Penggajian.ReportSlip.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(487, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'GridKaryawanTableAdapter
        '
        Me.GridKaryawanTableAdapter.ClearBeforeFill = True
        '
        'gridHakTunjanganTableAdapter
        '
        Me.gridHakTunjanganTableAdapter.ClearBeforeFill = True
        '
        'GridKewajibanPotonganTableAdapter
        '
        Me.GridKewajibanPotonganTableAdapter.ClearBeforeFill = True
        '
        'FormSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormSlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSlip"
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbPenggajianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridHakTunjanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridKewajibanPotonganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GridKaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbPenggajianDataSet As Penggajian.dbPenggajianDataSet
    Friend WithEvents gridHakTunjanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridKewajibanPotonganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridKaryawanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter
    Friend WithEvents gridHakTunjanganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.gridHakTunjanganTableAdapter
    Friend WithEvents GridKewajibanPotonganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.GridKewajibanPotonganTableAdapter
End Class
