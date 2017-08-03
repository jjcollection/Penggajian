Public Class Karyawan

    Dim tbl As New DataTable
    Dim tgl, tahun, digit As String
   
    Sub kode_otomatis()
        tgl = Date.Now.Day
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = Me.KaryawanTableAdapter.GetDataByDesc
        If tbl.Rows.Count = 0 Then
            IdKaryawanTextBox.Text = tgl + digit + "0001"
        Else
            With tbl.Rows(0)
                IdKaryawanTextBox.Text = .Item("idKaryawan")
            End With
            IdKaryawanTextBox.Text = Val(Microsoft.VisualBasic.Mid(IdKaryawanTextBox.Text, 5, 4)) + 1
            If Len(IdKaryawanTextBox.Text) = 1 Then
                IdKaryawanTextBox.Text = tgl + digit + "000" & IdKaryawanTextBox.Text & ""
            ElseIf Len(IdKaryawanTextBox.Text) = 2 Then
                IdKaryawanTextBox.Text = tgl + digit + "00" & IdKaryawanTextBox.Text & ""
            ElseIf Len(IdKaryawanTextBox.Text) = 3 Then
                IdKaryawanTextBox.Text = tgl + digit + "0" & IdKaryawanTextBox.Text & ""
            ElseIf Len(IdKaryawanTextBox.Text) = 4 Then
                IdKaryawanTextBox.Text = tgl + digit + IdKaryawanTextBox.Text
            End If

        End If
    End Sub

    Private Sub Karyawan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.gridHakTunjangan' table. You can move, or remove it, as needed.
        Me.GridHakTunjanganTableAdapter.Fill(Me.DbPenggajianDataSet.gridHakTunjangan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Kewajiban' table. You can move, or remove it, as needed.
        Me.KewajibanTableAdapter.Fill(Me.DbPenggajianDataSet.Kewajiban)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Hak' table. You can move, or remove it, as needed.
        Me.HakTableAdapter.Fill(Me.DbPenggajianDataSet.Hak)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Potongan' table. You can move, or remove it, as needed.
        Me.PotonganTableAdapter.Fill(Me.DbPenggajianDataSet.Potongan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Tunjangan' table. You can move, or remove it, as needed.
        Me.TunjanganTableAdapter.Fill(Me.DbPenggajianDataSet.Tunjangan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Jabatan' table. You can move, or remove it, as needed.
        Me.JabatanTableAdapter.Fill(Me.DbPenggajianDataSet.Jabatan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.GridKaryawan' table. You can move, or remove it, as needed.
        Me.GridKaryawanTableAdapter.Fill(Me.DbPenggajianDataSet.GridKaryawan)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.PenggajianMaster' table. You can move, or remove it, as needed.
        Me.PenggajianMasterTableAdapter.Fill(Me.DbPenggajianDataSet.PenggajianMaster)
        'TODO: This line of code loads data into the 'DbPenggajianDataSet.Karyawan' table. You can move, or remove it, as needed.
        Me.KaryawanTableAdapter.Fill(Me.DbPenggajianDataSet.Karyawan)
        'TODO: This line of code loads data into the 'PenggajianDataSet.bagian' table. You can move, or remove it, as needed.
        ' Me.BagianTableAdapter.Fill(Me.PenggajianDataSet.bagian)
        'TODO: This line of code loads data into the 'PenggajianDataSet.karyawan' table. You can move, or remove it, as needed.
        'Me.KaryawanTableAdapter.Fill(Me.PenggajianDataSet.karyawan)
        Dim ds = TunjanganTableAdapter.GetData()
        With clTunjangan
            .DataSource = ds
            .DisplayMember = "namaTunjangan"
            .ValueMember = "idTunjangan"
        End With
        Dim dsPotongan = PotonganTableAdapter.GetData()
        With clPotongan
            .DataSource = dsPotongan
            .DisplayMember = "namaPotongan"
            .ValueMember = "idPotongan"
        End With
    End Sub
    'Sub kode_otomatis()
    '    Dim tbl As New DataTable
    '    tbl = Me.KaryawanTableAdapter.GetDataByDesc
    '    If tbl.Rows.Count = 0 Then
    '        KodeKaryawanTextBox.Text = "KRY-0001"
    '    Else
    '        With tbl.Rows(0)
    '            KodeKaryawanTextBox.Text = .Item("KodeKaryawan")
    '        End With
    '        KodeKaryawanTextBox.Text = Val(Microsoft.VisualBasic.Mid(KodeKaryawanTextBox.Text, 5, 4)) + 1
    '        If Len(KodeKaryawanTextBox.Text) = 1 Then
    '            KodeKaryawanTextBox.Text = "KRY-000" & KodeKaryawanTextBox.Text & ""
    '        ElseIf Len(KodeKaryawanTextBox.Text) = 2 Then
    '            KodeKaryawanTextBox.Text = "KRY-00" & KodeKaryawanTextBox.Text & ""
    '        ElseIf Len(KodeKaryawanTextBox.Text) = 3 Then
    '            KodeKaryawanTextBox.Text = "KRY-0" & KodeKaryawanTextBox.Text & ""
    '        ElseIf Len(KodeKaryawanTextBox.Text) = 4 Then
    '            KodeKaryawanTextBox.Text = "KRY-" & KodeKaryawanTextBox.Text & ""
    '        End If

    '    End If
    'End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        kode_otomatis()
        NamakaryawanTextBox.Text = ""
        NamakaryawanTextBox.Focus()
        KodebagianComboBox.SelectedValue = 1
        TelpTextBox.Text = ""
        AlamatTextBox.Text = ""
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Me.KaryawanTableAdapter.InsertKaryawan(IdKaryawanTextBox.Text, NamakaryawanTextBox.Text, TelpTextBox.Text, AlamatTextBox.Text, KodebagianComboBox.SelectedValue)
            Dim tnj = TunjanganTableAdapter.GetData
            Dim ptg = PotonganTableAdapter.GetData
            For i As Integer = 0 To tnj.Rows.Count - 1
                HakTableAdapter.InsertQuery(IdKaryawanTextBox.Text, tnj.Rows(i).Item("idTunjangan"), False)
            Next

            For Each item As DataRowView In clTunjangan.CheckedItems
                HakTableAdapter.UpdateHak(True, IdKaryawanTextBox.Text, item.Row("idTunjangan"))
            Next

            For j As Integer = 0 To tnj.Rows.Count - 1
                KewajibanTableAdapter.InsertQuery(IdKaryawanTextBox.Text, ptg.Rows(j).Item("idPotongan"), False)
            Next

            For Each item As DataRowView In clPotongan.CheckedItems
                KewajibanTableAdapter.UpdateKewajiban(True, IdKaryawanTextBox.Text, item.Row("idPotongan"))
            Next


            Me.KaryawanTableAdapter.Fill(Me.DbPenggajianDataSet.Karyawan)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            'Me.KaryawanTableAdapter.UpdateQuery(KodeKaryawanTextBox.Text, NamakaryawanTextBox.Text, AlamatTextBox.Text, TelpTextBox.Text, EmailTextBox.Text, KodebagianComboBox.SelectedValue)
            'MsgBox("data telah diubah.", MsgBoxStyle.Information, "Informasi")
            'Me.KaryawanTableAdapter.FillByDesc(Me.PenggajianDataSet.karyawan)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            'Me.KaryawanTableAdapter.DeleteQuery(KodeKaryawanTextBox.Text)
            'MsgBox("data telah dihapus.", MsgBoxStyle.Information, "Informasi")
            'Me.KaryawanTableAdapter.FillByDesc(Me.PenggajianDataSet.karyawan)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub KaryawanDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KaryawanDataGridView.CellClick
        Try
            IdKaryawanTextBox.Text = KaryawanDataGridView.SelectedCells(0).Value
            NamakaryawanTextBox.Text = KaryawanDataGridView.SelectedCells(2).Value
            KodebagianComboBox.SelectedValue = KaryawanDataGridView.SelectedCells(1).Value
            TelpTextBox.Text = KaryawanDataGridView.SelectedCells(4).Value
            AlamatTextBox.Text = KaryawanDataGridView.SelectedCells(5).Value


            Dim dt = GridHakTunjanganTableAdapter.GetDataByKaryawan(IdKaryawanTextBox.Text)

            With clTunjangan
                .DataSource = dt
                .DisplayMember = "namaTunjangan"
                .ValueMember = "idTunjangan"
            End With

            Dim checked As Boolean '= True   ' Set to True or False, as required.

            For i As Integer = 0 To clTunjangan.Items.Count - 1
                checked = dt.Rows(i).Item("statusHak")
                clTunjangan.SetItemChecked(i, checked)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class