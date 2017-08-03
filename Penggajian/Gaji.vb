Imports System.Data.SqlClient

Public Class FGaji
    Dim l As String
    Dim bn As Double
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
            '    kode_otomatis()
            '    GajiMasterTableAdapter.InsertQuery(l, Date.Now, ComboBox1.SelectedValue, CDbl(LBTOTAL.Text), CDbl(LbBonus.Text), CDbl(LbGajiPokok.Text), CDbl(LbTmakan.Text), CDbl(LbTransportasi.Text), txtAbsen.Text, txtSakit.Text, txtMC.Text, txtAplha.Text, txtPinjaman.Text, CDbl(Lbdis.Text))
            '    MsgBox("data telah disimpan.", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub FGaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.gridHakTunjangan' table. You can move, or remove it, as needed.
        Me.GridHakTunjanganTableAdapter.Fill(Me.DbPenggajianDataSet.gridHakTunjangan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Potongan' table. You can move, or remove it, as needed.
        Me.PotonganTableAdapter.Fill(Me.DbPenggajianDataSet.Potongan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.TunjanganDetil' table. You can move, or remove it, as needed.
        Me.TunjanganDetilTableAdapter.Fill(Me.DbPenggajianDataSet.TunjanganDetil)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Tunjangan' table. You can move, or remove it, as needed.
        Me.TunjanganTableAdapter.Fill(Me.DbPenggajianDataSet.Tunjangan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.GridKaryawan' table. You can move, or remove it, as needed.
        Me.GridKaryawanTableAdapter.Fill(Me.DbPenggajianDataSet.GridKaryawan)
        Dim ds = TunjanganTableAdapter.GetData()
        
    End Sub

    'Private Sub clTunjangan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For Each item As DataRowView In clTunjangan.CheckedItems
    '        MessageBox.Show(item.Row("idtunjangan"))
    '    Next
    'End Sub
End Class