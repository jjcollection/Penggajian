Imports System.Data.SqlClient

Public Class FGaji
    Dim l As String
    Dim lbidgaji As New Label
    Dim bn As Double
    Dim tbl As New DataTable
    Dim tgl, tahun, digit As String

    Public Function kode_otomatis()
        tgl = Date.Now.Day
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = Me.PenggajianMasterTableAdapter.GetDataByDesc
        If tbl.Rows.Count = 0 Then
            lbidgaji.Text = tgl + digit + "0001"
        Else
            With tbl.Rows(0)
                lbidgaji.Text = .Item("idPenggajianMaster")
            End With
            lbidgaji.Text = Val(Microsoft.VisualBasic.Mid(lbidgaji.Text, 5, 4)) + 1
            If Len(lbidgaji.Text) = 1 Then
                lbidgaji.Text = tgl + digit + "000" & lbidgaji.Text & ""
            ElseIf Len(lbidgaji.Text) = 2 Then
                lbidgaji.Text = tgl + digit + "00" & lbidgaji.Text & ""
            ElseIf Len(lbidgaji.Text) = 3 Then
                lbidgaji.Text = tgl + digit + "0" & lbidgaji.Text & ""
            ElseIf Len(lbidgaji.Text) = 4 Then
                lbidgaji.Text = tgl + digit + lbidgaji.Text
            End If

        End If
        Return lbidgaji.Text
    End Function
    Public Sub kode_otomatis_periode()
        tgl = Date.Now.Month
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = Me.PeriodeTableAdapter.GetData
        If tbl.Rows.Count = 0 Then
            Label1.Text = tgl + digit + "0001"
        Else
            With tbl.Rows(0)
                Label1.Text = .Item("idPeriode")
            End With
            Label1.Text = Val(Microsoft.VisualBasic.Mid(Label1.Text, 5, 4)) + 1
            If Len(Label1.Text) = 1 Then
                Label1.Text = tgl + digit + "000" & Label1.Text & ""
            ElseIf Len(Label1.Text) = 2 Then
                Label1.Text = tgl + digit + "00" & Label1.Text & ""
            ElseIf Len(Label1.Text) = 3 Then
                Label1.Text = tgl + digit + "0" & Label1.Text & ""
            ElseIf Len(Label1.Text) = 4 Then
                Label1.Text = tgl + digit + Label1.Text
            End If

        End If

    End Sub
    'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    '    Dim con As New SqlConnection(My.Settings.penggajianConnectionString)
    '    Dim sql As String
    '    Dim dt As New DataTable
    '    sql = "select kodebarang,KodeKaryawan,Namakaryawan,NamaBarang,TargetPj,sum(total) as Realiasi , (sum(total/TargetPj))*100 as Persen from vw_detil "
    '    sql &= "WHERE (KodeKaryawan = '" & ComboBox1.SelectedValue & "') AND (Tanggal >= '" & tgla.Value.ToString("yyyy-MM-dd") & "') AND (Tanggal <= '" & tglb.Value.ToString("yyyy-MM-dd") & "')"
    '    sql &= " group by Kodebarang ,KodeKaryawan,Namakaryawan ,NamaBarang,TargetPj  order by Persen DESC"

    '    Dim adp As New SqlDataAdapter(sql, con)
    '    adp.Fill(dt)
    '    With DataGridView1
    '        .DataSource = dt

    '    End With

    '    Try
    '        PersenTableAdapter.FillByKode(PenggajianDataSet.persen, DataGridView1.SelectedCells(0).Value)
    '        Dim prs = DataGridView1.SelectedCells(6).Value
    '        Dim dtprs As DataTable
    '        dtprs = PersenTableAdapter.GetDataByKode(DataGridView1.SelectedCells(0).Value)
    '        Dim pawal As Decimal
    '        Dim pakhir As Decimal

    '        For i As Integer = 0 To dtprs.Rows.Count - 1
    '            pawal = dtprs.Rows(i).Item("dariPersen")
    '            pakhir = dtprs.Rows(i).Item("sampaiPersen")

    '            If CDec(prs) >= CDec(pawal) And CDec(prs) <= CDec(pakhir) Then
    '                '            Dim chk As DataGridViewCheckBoxCell = .row.Cells("Pilih")
    '                'if (chk.Value  == chk.TrueValue)
    '                '{
    '                '    chk.Value = chk.FalseValue;
    '                '}
    '                '            Else
    '                '{
    '                '    chk.Value = chk.TrueValue;
    '                '}

    '                '--------------------------------------------------------------------------------
    '                'mencari bonus penjualan
    '                '--------------------------------------------------------------------------------
    '                PersenDataGridView.BeginEdit(True)
    '                bn = dtprs.Rows(i).Item("Bonus")
    '                ' PersenDataGridView.Rows(i).Selected = True
    '                PersenDataGridView.CurrentCell = PersenDataGridView.Item("Bonus", i)
    '                LbBonus.Text = Format(CDbl(bn), "Currency")
    '                ' LbBonus.Text = bn
    '                'MsgBox(bn)
    '            End If
    '        Next

    '        '--------------------------------------------------------------------------------
    '        'mencari gaji pokok dll
    '        '--------------------------------------------------------------------------------
    '        Dim jumlahhari As Integer = tglb.Value.Day - tgla.Value.Day
    '        Dim jml = CInt(jumlahhari) - (CInt(txtAplha.Text) - CInt(txtSakit.Text))

    '        Dim dtgpk = GapokTableAdapter.GetDataByKodeKar(ComboBox1.SelectedValue)
    '        LbGajiPokok.Text = Format(CDbl(dtgpk.Rows(0).Item("Besargapok")), "Currency")
    '        LbTmakan.Text = Format(CDbl(dtgpk.Rows(0).Item("TMakan")) * jml, "Currency")
    '        LbTransportasi.Text = Format(CDbl(dtgpk.Rows(0).Item("TTransportasi")) * jml, "Currency")
    '        Dim total As Double = CDbl(LbBonus.Text) + CDbl(LbGajiPokok.Text) + CDbl(LbTmakan.Text) + CDbl(LbTransportasi.Text) - CDbl(txtPinjaman.Text) + CDbl(Lbdis.Text)
    '        LBTOTAL.Text = Format(total, "Currency")

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub
   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            'For i As Integer = 0 To GridKaryawanDataGridView.Rows.Count - 1
            '    '  PenggajianMasterTableAdapter.InsertQuery(GridKaryawanDataGridView.Rows(i).Cells(0).Value, tanggalPeriode.Value, 0, 0, 0, CInt(GridKaryawanDataGridView.Rows(i).Cells(8).Value), kode_otomatis, tanggalPeriode.Value.Month, tanggalPeriode.Value.Year)
            'Next

            For j As Integer = 0 To GridKaryawanDataGridView.Rows.Count - 1
                Dim jml = GridHakTunjanganTableAdapter.getTunjangan(GridKaryawanDataGridView.Rows(j).Cells(1).Value)
                PenggajianMasterTableAdapter.UpdateTunjangan(CDbl(jml), CDbl(GridKaryawanDataGridView.Rows(j).Cells(9).Value), GridKaryawanDataGridView.Rows(j).Cells(1).Value, GridKaryawanDataGridView.Rows(j).Cells(0).Value, GridKaryawanDataGridView.Rows(j).Cells(1).Value)
            Next

            For k As Integer = 0 To GridKaryawanDataGridView.Rows.Count - 1
                Dim jml As Double
                Try
                    jml = GridKewajibanPotonganTableAdapter.ScalarTotalPotongan(GridKaryawanDataGridView.Rows(k).Cells(1).Value)
                Catch ex As Exception
                    jml = 0
                Finally
                    PenggajianMasterTableAdapter.UpdatePotongan(CDbl(jml), GridKaryawanDataGridView.Rows(k).Cells(0).Value, GridKaryawanDataGridView.Rows(k).Cells(1).Value)
                End Try

               


            Next
            '    kode_otomatis()
            '    GajiMasterTableAdapter.InsertQuery(l, Date.Now, ComboBox1.SelectedValue, CDbl(LBTOTAL.Text), CDbl(LbBonus.Text), CDbl(LbGajiPokok.Text), CDbl(LbTmakan.Text), CDbl(LbTransportasi.Text), txtAbsen.Text, txtSakit.Text, txtMC.Text, txtAplha.Text, txtPinjaman.Text, CDbl(Lbdis.Text))
            MsgBox("data telah disimpan.", MsgBoxStyle.Information, "Informasi")
            Me.GridKaryawanTableAdapter.FillByPeriode(Me.DbPenggajianDataSet.GridKaryawan, Label1.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FGaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Karyawan' table. You can move, or remove it, as needed.
        Me.KaryawanTableAdapter.Fill(Me.DbPenggajianDataSet.Karyawan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Periode' table. You can move, or remove it, as needed.
        Me.PeriodeTableAdapter.Fill(Me.DbPenggajianDataSet.Periode)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Potongan' table. You can move, or remove it, as needed.
        Me.PotonganTableAdapter.Fill(Me.DbPenggajianDataSet.Potongan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Tunjangan' table. You can move, or remove it, as needed.
        Me.TunjanganTableAdapter.Fill(Me.DbPenggajianDataSet.Tunjangan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.PenggajianMaster' table. You can move, or remove it, as needed.
        Me.PenggajianMasterTableAdapter.Fill(Me.DbPenggajianDataSet.PenggajianMaster)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet2.GridKewajibanPotongan' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DbPenggajianDataSet1.GridKaryawan' table. You can move, or remove it, as needed.
        Me.GridKaryawanTableAdapter.Fill(Me.DbPenggajianDataSet.GridKaryawan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.PenggajianMaster' table. You can move, or remove it, as needed.
        Me.PenggajianMasterTableAdapter.Fill(Me.DbPenggajianDataSet.PenggajianMaster)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.gridHakTunjangan' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Potongan' table. You can move, or remove it, as needed.
        Me.PotonganTableAdapter.Fill(Me.DbPenggajianDataSet.Potongan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.TunjanganDetil' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Tunjangan' table. You can move, or remove it, as needed.
        Me.TunjanganTableAdapter.Fill(Me.DbPenggajianDataSet.Tunjangan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.GridKaryawan' table. You can move, or remove it, as needed.
        Me.GridKaryawanTableAdapter.Fill(Me.DbPenggajianDataSet.GridKaryawan)
        Dim ds = TunjanganTableAdapter.GetData()
        tanggalPeriode.ShowUpDown = True
        tanggalPeriode.CustomFormat = " MMMM, yyyy"
        tanggalPeriode.Format = DateTimePickerFormat.Custom
        ' GridHakTunjanganTableAdapter.FillByKaryawan(DbPenggajianDataSet.gridHakTunjangan, GridKaryawanDataGridView.SelectedCells(0).Value)
        'GridKewajibanPotonganTableAdapter.FillByKaryawanPotongan(DbPenggajianDataSet.GridKewajibanPotongan, GridKaryawanDataGridView.SelectedCells(0).Value)
    End Sub

    'Private Sub clTunjangan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For Each item As DataRowView In clTunjangan.CheckedItems
    '        MessageBox.Show(item.Row("idtunjangan"))
    '    Next
    'End Sub

   
    Private Sub GridKaryawanDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridKaryawanDataGridView.CellClick
        GridHakTunjanganTableAdapter.FillByKaryawan(DbPenggajianDataSet.gridHakTunjangan, GridKaryawanDataGridView.SelectedCells(1).Value)
        GridKewajibanPotonganTableAdapter.FillByKaryawanPotongan(DbPenggajianDataSet.GridKewajibanPotongan, GridKaryawanDataGridView.SelectedCells(1).Value)
        Dim jml = GridHakTunjanganTableAdapter.ScalarTotalTunjangan(GridKaryawanDataGridView.SelectedCells(1).Value)
        lbTunjangan.Text = "Total Tunjangan : " & Format(jml, "Currency")

        Dim potongan = GridKewajibanPotonganTableAdapter.ScalarTotalPotongan(GridKaryawanDataGridView.SelectedCells(1).Value)
        lbPotongan.Text = "Total Potongan : " & Format(potongan, "Currency")
    End Sub

    Private Sub GridKaryawanDataGridView_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles GridKaryawanDataGridView.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kode_otomatis_periode()
        PeriodeTableAdapter.InsertQuery(Label1.Text, tanggalPeriode.Value.Month, tanggalPeriode.Value.Year)
        For i As Integer = 0 To KaryawanTableAdapter.GetData.Rows.Count - 1
            Dim kr = KaryawanTableAdapter.GetData
            PenggajianMasterTableAdapter.InsertQueryMasterPeriode(0, kode_otomatis, Label1.Text, kr.Rows(i).Item("idKaryawan"))
        Next
        Me.GridKaryawanTableAdapter.FillByPeriode(Me.DbPenggajianDataSet.GridKaryawan, Label1.Text)
    End Sub
End Class