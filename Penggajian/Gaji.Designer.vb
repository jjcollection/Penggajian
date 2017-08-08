<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FGaji
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtno = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GridKaryawanDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GridHakTunjanganDataGridView = New System.Windows.Forms.DataGridView()
        Me.tanggalPeriode = New System.Windows.Forms.DateTimePicker()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbTunjangan = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbPotongan = New System.Windows.Forms.Label()
        Me.statusHak = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Penambahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusKewajibanDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NamaPotonganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BesarPotonganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridKewajibanPotonganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbPenggajianDataSet = New Penggajian.dbPenggajianDataSet()
        Me.NamaTunjanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BesarTunjanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridHakTunjanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridKaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridHakTunjanganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.gridHakTunjanganTableAdapter()
        Me.GridKewajibanPotonganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.GridKewajibanPotonganTableAdapter()
        Me.GridKaryawanTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter()
        Me.PenggajianMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenggajianMasterTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.PenggajianMasterTableAdapter()
        Me.TableAdapterManager = New Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager()
        Me.PotonganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.PotonganTableAdapter()
        Me.TunjanganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.TunjanganTableAdapter()
        Me.TunjanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PotonganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodeTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.PeriodeTableAdapter()
        Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KaryawanTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.KaryawanTableAdapter()
        Me.idPenggajianMaster = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdKaryawanDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaKaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaJabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiPokokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalTunjanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPotonganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalGaji = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JmlKehadiranDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kehadiran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridKaryawanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridHakTunjanganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridKewajibanPotonganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbPenggajianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridHakTunjanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggajianMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TunjanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PotonganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtno
        '
        Me.txtno.AutoSize = True
        Me.txtno.Location = New System.Drawing.Point(193, 10)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(56, 17)
        Me.txtno.TabIndex = 21
        Me.txtno.Text = "Periode :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(105, 29)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 30)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GridKaryawanDataGridView
        '
        Me.GridKaryawanDataGridView.AllowUserToAddRows = False
        Me.GridKaryawanDataGridView.AllowUserToDeleteRows = False
        Me.GridKaryawanDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridKaryawanDataGridView.AutoGenerateColumns = False
        Me.GridKaryawanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridKaryawanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPenggajianMaster, Me.IdKaryawanDataGridViewTextBoxColumn2, Me.NamaKaryawanDataGridViewTextBoxColumn, Me.NamaJabatanDataGridViewTextBoxColumn, Me.GajiPokokDataGridViewTextBoxColumn, Me.TotalTunjanganDataGridViewTextBoxColumn, Me.TotalPotonganDataGridViewTextBoxColumn, Me.TotalGaji, Me.JmlKehadiranDataGridViewTextBoxColumn, Me.kehadiran})
        Me.GridKaryawanDataGridView.DataSource = Me.GridKaryawanBindingSource
        Me.GridKaryawanDataGridView.Location = New System.Drawing.Point(11, 67)
        Me.GridKaryawanDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridKaryawanDataGridView.Name = "GridKaryawanDataGridView"
        Me.GridKaryawanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridKaryawanDataGridView.Size = New System.Drawing.Size(932, 628)
        Me.GridKaryawanDataGridView.TabIndex = 28
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 29)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 30)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Baru"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GridHakTunjanganDataGridView
        '
        Me.GridHakTunjanganDataGridView.AllowUserToAddRows = False
        Me.GridHakTunjanganDataGridView.AllowUserToDeleteRows = False
        Me.GridHakTunjanganDataGridView.AutoGenerateColumns = False
        Me.GridHakTunjanganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridHakTunjanganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.statusHak, Me.NamaTunjanganDataGridViewTextBoxColumn, Me.BesarTunjanganDataGridViewTextBoxColumn, Me.Penambahan, Me.ubah})
        Me.GridHakTunjanganDataGridView.DataSource = Me.GridHakTunjanganBindingSource
        Me.GridHakTunjanganDataGridView.Location = New System.Drawing.Point(949, 67)
        Me.GridHakTunjanganDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridHakTunjanganDataGridView.Name = "GridHakTunjanganDataGridView"
        Me.GridHakTunjanganDataGridView.ReadOnly = True
        Me.GridHakTunjanganDataGridView.Size = New System.Drawing.Size(371, 191)
        Me.GridHakTunjanganDataGridView.TabIndex = 37
        '
        'tanggalPeriode
        '
        Me.tanggalPeriode.CustomFormat = ""
        Me.tanggalPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tanggalPeriode.Location = New System.Drawing.Point(197, 32)
        Me.tanggalPeriode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tanggalPeriode.Name = "tanggalPeriode"
        Me.tanggalPeriode.Size = New System.Drawing.Size(177, 25)
        Me.tanggalPeriode.TabIndex = 38
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(380, 29)
        Me.BtnCari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(83, 30)
        Me.BtnCari.TabIndex = 25
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StatusKewajibanDataGridViewCheckBoxColumn, Me.NamaPotonganDataGridViewTextBoxColumn, Me.BesarPotonganDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn8, Me.DataGridViewButtonColumn1})
        Me.DataGridView1.DataSource = Me.GridKewajibanPotonganBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(949, 296)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(388, 193)
        Me.DataGridView1.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lbTunjangan)
        Me.Panel1.Location = New System.Drawing.Point(949, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 31)
        Me.Panel1.TabIndex = 39
        '
        'lbTunjangan
        '
        Me.lbTunjangan.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbTunjangan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTunjangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbTunjangan.Location = New System.Drawing.Point(14, 0)
        Me.lbTunjangan.Name = "lbTunjangan"
        Me.lbTunjangan.Size = New System.Drawing.Size(374, 31)
        Me.lbTunjangan.TabIndex = 0
        Me.lbTunjangan.Text = "0"
        Me.lbTunjangan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.lbPotongan)
        Me.Panel2.Location = New System.Drawing.Point(949, 489)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(388, 31)
        Me.Panel2.TabIndex = 39
        '
        'lbPotongan
        '
        Me.lbPotongan.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbPotongan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPotongan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbPotongan.Location = New System.Drawing.Point(14, 0)
        Me.lbPotongan.Name = "lbPotongan"
        Me.lbPotongan.Size = New System.Drawing.Size(374, 31)
        Me.lbPotongan.TabIndex = 0
        Me.lbPotongan.Text = "0"
        Me.lbPotongan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'statusHak
        '
        Me.statusHak.DataPropertyName = "statusHak"
        Me.statusHak.HeaderText = ""
        Me.statusHak.Name = "statusHak"
        Me.statusHak.ReadOnly = True
        Me.statusHak.Width = 30
        '
        'Penambahan
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.Penambahan.DefaultCellStyle = DataGridViewCellStyle12
        Me.Penambahan.HeaderText = "Tambah"
        Me.Penambahan.Name = "Penambahan"
        Me.Penambahan.ReadOnly = True
        '
        'ubah
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.NullValue = "+"
        Me.ubah.DefaultCellStyle = DataGridViewCellStyle13
        Me.ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ubah.HeaderText = "Aksi"
        Me.ubah.Name = "ubah"
        Me.ubah.ReadOnly = True
        Me.ubah.Text = "Update"
        Me.ubah.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = "0"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn8.HeaderText = "Kurangi"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewButtonColumn1
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.NullValue = "+"
        Me.DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewButtonColumn1.HeaderText = "Aksi"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Text = "Update"
        Me.DataGridViewButtonColumn1.Width = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(469, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "0"
        '
        'StatusKewajibanDataGridViewCheckBoxColumn
        '
        Me.StatusKewajibanDataGridViewCheckBoxColumn.DataPropertyName = "statusKewajiban"
        Me.StatusKewajibanDataGridViewCheckBoxColumn.HeaderText = ""
        Me.StatusKewajibanDataGridViewCheckBoxColumn.Name = "StatusKewajibanDataGridViewCheckBoxColumn"
        Me.StatusKewajibanDataGridViewCheckBoxColumn.ReadOnly = True
        Me.StatusKewajibanDataGridViewCheckBoxColumn.Width = 30
        '
        'NamaPotonganDataGridViewTextBoxColumn
        '
        Me.NamaPotonganDataGridViewTextBoxColumn.DataPropertyName = "namaPotongan"
        Me.NamaPotonganDataGridViewTextBoxColumn.HeaderText = "Potongan"
        Me.NamaPotonganDataGridViewTextBoxColumn.Name = "NamaPotonganDataGridViewTextBoxColumn"
        Me.NamaPotonganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BesarPotonganDataGridViewTextBoxColumn
        '
        Me.BesarPotonganDataGridViewTextBoxColumn.DataPropertyName = "besarPotongan"
        Me.BesarPotonganDataGridViewTextBoxColumn.HeaderText = "Nominal"
        Me.BesarPotonganDataGridViewTextBoxColumn.Name = "BesarPotonganDataGridViewTextBoxColumn"
        Me.BesarPotonganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GridKewajibanPotonganBindingSource
        '
        Me.GridKewajibanPotonganBindingSource.DataMember = "GridKewajibanPotongan"
        Me.GridKewajibanPotonganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'DbPenggajianDataSet
        '
        Me.DbPenggajianDataSet.DataSetName = "dbPenggajianDataSet"
        Me.DbPenggajianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamaTunjanganDataGridViewTextBoxColumn
        '
        Me.NamaTunjanganDataGridViewTextBoxColumn.DataPropertyName = "namaTunjangan"
        Me.NamaTunjanganDataGridViewTextBoxColumn.HeaderText = "Tunjangan"
        Me.NamaTunjanganDataGridViewTextBoxColumn.Name = "NamaTunjanganDataGridViewTextBoxColumn"
        Me.NamaTunjanganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BesarTunjanganDataGridViewTextBoxColumn
        '
        Me.BesarTunjanganDataGridViewTextBoxColumn.DataPropertyName = "besarTunjangan"
        Me.BesarTunjanganDataGridViewTextBoxColumn.HeaderText = "Nominal"
        Me.BesarTunjanganDataGridViewTextBoxColumn.Name = "BesarTunjanganDataGridViewTextBoxColumn"
        Me.BesarTunjanganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GridHakTunjanganBindingSource
        '
        Me.GridHakTunjanganBindingSource.DataMember = "gridHakTunjangan"
        Me.GridHakTunjanganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'GridKaryawanBindingSource
        '
        Me.GridKaryawanBindingSource.DataMember = "GridKaryawan"
        Me.GridKaryawanBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'GridHakTunjanganTableAdapter
        '
        Me.GridHakTunjanganTableAdapter.ClearBeforeFill = True
        '
        'GridKewajibanPotonganTableAdapter
        '
        Me.GridKewajibanPotonganTableAdapter.ClearBeforeFill = True
        '
        'GridKaryawanTableAdapter
        '
        Me.GridKaryawanTableAdapter.ClearBeforeFill = True
        '
        'PenggajianMasterBindingSource
        '
        Me.PenggajianMasterBindingSource.DataMember = "PenggajianMaster"
        Me.PenggajianMasterBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'PenggajianMasterTableAdapter
        '
        Me.PenggajianMasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HakTableAdapter = Nothing
        Me.TableAdapterManager.JabatanTableAdapter = Nothing
        Me.TableAdapterManager.KaryawanTableAdapter = Nothing
        Me.TableAdapterManager.KewajibanTableAdapter = Nothing
        Me.TableAdapterManager.PenggajianMasterTableAdapter = Me.PenggajianMasterTableAdapter
        Me.TableAdapterManager.PeriodeTableAdapter = Nothing
        Me.TableAdapterManager.PotonganDetilTableAdapter = Nothing
        Me.TableAdapterManager.PotonganTableAdapter = Me.PotonganTableAdapter
        Me.TableAdapterManager.TunjanganDetilTableAdapter = Nothing
        Me.TableAdapterManager.TunjanganTableAdapter = Me.TunjanganTableAdapter
        Me.TableAdapterManager.UpdateOrder = Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PotonganTableAdapter
        '
        Me.PotonganTableAdapter.ClearBeforeFill = True
        '
        'TunjanganTableAdapter
        '
        Me.TunjanganTableAdapter.ClearBeforeFill = True
        '
        'TunjanganBindingSource
        '
        Me.TunjanganBindingSource.DataMember = "Tunjangan"
        Me.TunjanganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'PotonganBindingSource
        '
        Me.PotonganBindingSource.DataMember = "Potongan"
        Me.PotonganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'PeriodeBindingSource
        '
        Me.PeriodeBindingSource.DataMember = "Periode"
        Me.PeriodeBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'PeriodeTableAdapter
        '
        Me.PeriodeTableAdapter.ClearBeforeFill = True
        '
        'KaryawanBindingSource
        '
        Me.KaryawanBindingSource.DataMember = "Karyawan"
        Me.KaryawanBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'idPenggajianMaster
        '
        Me.idPenggajianMaster.DataPropertyName = "idPenggajianMaster"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.idPenggajianMaster.DefaultCellStyle = DataGridViewCellStyle16
        Me.idPenggajianMaster.HeaderText = "Nomor"
        Me.idPenggajianMaster.Name = "idPenggajianMaster"
        Me.idPenggajianMaster.Width = 70
        '
        'IdKaryawanDataGridViewTextBoxColumn2
        '
        Me.IdKaryawanDataGridViewTextBoxColumn2.DataPropertyName = "idKaryawan"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        Me.IdKaryawanDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle17
        Me.IdKaryawanDataGridViewTextBoxColumn2.HeaderText = "ID Karyawan"
        Me.IdKaryawanDataGridViewTextBoxColumn2.Name = "IdKaryawanDataGridViewTextBoxColumn2"
        Me.IdKaryawanDataGridViewTextBoxColumn2.Width = 70
        '
        'NamaKaryawanDataGridViewTextBoxColumn
        '
        Me.NamaKaryawanDataGridViewTextBoxColumn.DataPropertyName = "namaKaryawan"
        Me.NamaKaryawanDataGridViewTextBoxColumn.HeaderText = "Nama Karyawan"
        Me.NamaKaryawanDataGridViewTextBoxColumn.Name = "NamaKaryawanDataGridViewTextBoxColumn"
        '
        'NamaJabatanDataGridViewTextBoxColumn
        '
        Me.NamaJabatanDataGridViewTextBoxColumn.DataPropertyName = "namaJabatan"
        Me.NamaJabatanDataGridViewTextBoxColumn.HeaderText = "Jabatan"
        Me.NamaJabatanDataGridViewTextBoxColumn.Name = "NamaJabatanDataGridViewTextBoxColumn"
        Me.NamaJabatanDataGridViewTextBoxColumn.Width = 80
        '
        'GajiPokokDataGridViewTextBoxColumn
        '
        Me.GajiPokokDataGridViewTextBoxColumn.DataPropertyName = "gajiPokok"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "C2"
        DataGridViewCellStyle18.NullValue = "0"
        Me.GajiPokokDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.GajiPokokDataGridViewTextBoxColumn.HeaderText = "Gaji Pokok"
        Me.GajiPokokDataGridViewTextBoxColumn.Name = "GajiPokokDataGridViewTextBoxColumn"
        '
        'TotalTunjanganDataGridViewTextBoxColumn
        '
        Me.TotalTunjanganDataGridViewTextBoxColumn.DataPropertyName = "totalTunjangan"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "C2"
        DataGridViewCellStyle19.NullValue = "0"
        Me.TotalTunjanganDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle19
        Me.TotalTunjanganDataGridViewTextBoxColumn.HeaderText = "Tunjangan"
        Me.TotalTunjanganDataGridViewTextBoxColumn.Name = "TotalTunjanganDataGridViewTextBoxColumn"
        '
        'TotalPotonganDataGridViewTextBoxColumn
        '
        Me.TotalPotonganDataGridViewTextBoxColumn.DataPropertyName = "totalPotongan"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "C2"
        DataGridViewCellStyle20.NullValue = "0"
        Me.TotalPotonganDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle20
        Me.TotalPotonganDataGridViewTextBoxColumn.HeaderText = "Potongan"
        Me.TotalPotonganDataGridViewTextBoxColumn.Name = "TotalPotonganDataGridViewTextBoxColumn"
        '
        'TotalGaji
        '
        Me.TotalGaji.DataPropertyName = "TotalGaji"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "C2"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.TotalGaji.DefaultCellStyle = DataGridViewCellStyle21
        Me.TotalGaji.HeaderText = "Total Gaji"
        Me.TotalGaji.Name = "TotalGaji"
        '
        'JmlKehadiranDataGridViewTextBoxColumn
        '
        Me.JmlKehadiranDataGridViewTextBoxColumn.DataPropertyName = "jmlKehadiran"
        Me.JmlKehadiranDataGridViewTextBoxColumn.HeaderText = "Jml. Kehadiran"
        Me.JmlKehadiranDataGridViewTextBoxColumn.Name = "JmlKehadiranDataGridViewTextBoxColumn"
        Me.JmlKehadiranDataGridViewTextBoxColumn.Width = 70
        '
        'kehadiran
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.NullValue = "0"
        Me.kehadiran.DefaultCellStyle = DataGridViewCellStyle22
        Me.kehadiran.HeaderText = "Input Kehadiran"
        Me.kehadiran.Name = "kehadiran"
        Me.kehadiran.Width = 70
        '
        'FGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1354, 697)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tanggalPeriode)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GridHakTunjanganDataGridView)
        Me.Controls.Add(Me.GridKaryawanDataGridView)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtno)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FGaji"
        Me.Text = "Penggajian"
        CType(Me.GridKaryawanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridHakTunjanganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridKewajibanPotonganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbPenggajianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridHakTunjanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggajianMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TunjanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PotonganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtno As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridKaryawanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GridHakTunjanganDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents tanggalPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbTunjangan As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbPotongan As System.Windows.Forms.Label
    Friend WithEvents DbPenggajianDataSet As Penggajian.dbPenggajianDataSet
    Friend WithEvents GridHakTunjanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridHakTunjanganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.gridHakTunjanganTableAdapter
    Friend WithEvents GridKewajibanPotonganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridKewajibanPotonganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.GridKewajibanPotonganTableAdapter
    Friend WithEvents GridKaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridKaryawanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter
    Friend WithEvents PenggajianMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenggajianMasterTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.PenggajianMasterTableAdapter
    Friend WithEvents TableAdapterManager As Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TunjanganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.TunjanganTableAdapter
    Friend WithEvents TunjanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PotonganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.PotonganTableAdapter
    Friend WithEvents PotonganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents statusHak As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NamaTunjanganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BesarTunjanganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Penambahan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents StatusKewajibanDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NamaPotonganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BesarPotonganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PeriodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodeTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.PeriodeTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KaryawanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.KaryawanTableAdapter
    Friend WithEvents idPenggajianMaster As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdKaryawanDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaKaryawanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaJabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GajiPokokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalTunjanganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPotonganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalGaji As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JmlKehadiranDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kehadiran As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
