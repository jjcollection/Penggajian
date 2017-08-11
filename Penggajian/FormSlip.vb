Public Class FormSlip

    Private Sub FormSlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GridKaryawanTableAdapter.FillByNomor(Me.dbPenggajianDataSet.GridKaryawan, FGaji.GridKaryawanDataGridView.CurrentRow.Cells(0).FormattedValue)
        Me.gridHakTunjanganTableAdapter.FillByKaryawanTrue(Me.dbPenggajianDataSet.gridHakTunjangan, FGaji.GridKaryawanDataGridView.CurrentRow.Cells(1).FormattedValue)
        Me.GridKewajibanPotonganTableAdapter.FillByKaryawanPotonganTrue(Me.dbPenggajianDataSet.GridKewajibanPotongan, FGaji.GridKaryawanDataGridView.CurrentRow.Cells(1).FormattedValue)

        Me.ReportViewer1.RefreshReport()
    End Sub

    'Public Sub fillPeriode(ByVal no As String)
    '    Me.GridKaryawanTableAdapter.FillByPeriode(Me.dbPenggajianDataSet.GridKaryawan, no)
    '    Dim dt = GridKaryawanTableAdapter.GetDataByPeriode(no)
    '    For i As Integer = 0 To dt.Rows.Count - 1
    '        Me.gridHakTunjanganTableAdapter.FillByKaryawan(Me.dbPenggajianDataSet.gridHakTunjangan, dt.Rows(i).Item("idKaryawan"))
    '        Me.GridKewajibanPotonganTableAdapter.FillByKaryawanPotongan(Me.dbPenggajianDataSet.GridKewajibanPotongan, dt.Rows(i).Item("idKaryawan"))
    '    Next
    '    Me.ReportViewer1.RefreshReport()
    'End Sub

    Private Sub FormSlip_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub

    Private Sub ReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class