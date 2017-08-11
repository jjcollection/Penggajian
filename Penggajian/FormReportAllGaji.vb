Public Class FormReportAllGaji

    Private Sub FormReportAllGaji_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbPenggajianDataSet.GridKaryawan' table. You can move, or remove it, as needed.
        Me.GridKaryawanTableAdapter.FillByPeriode(Me.dbPenggajianDataSet.GridKaryawan, "8170015")

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class