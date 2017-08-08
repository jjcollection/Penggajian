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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPeriode = New System.Windows.Forms.TextBox()
        Me.rdPeriode = New System.Windows.Forms.RadioButton()
        Me.rdTanggal = New System.Windows.Forms.RadioButton()
        Me.cariPeriode = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idPenggajianMaster = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalGaji = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kehadiran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridKewajibanPotonganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbPenggajianDataSet = New Penggajian.dbPenggajianDataSet()
        Me.GridHakTunjanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdKaryawanDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaKaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaJabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiPokokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalTunjanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPotonganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JmlKehadiranDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.statusHak = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NamaTunjanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BesarTunjanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Penambahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.StatusKewajibanDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NamaPotonganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BesarPotonganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.GridKaryawanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridHakTunjanganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(108, 18)
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
        Me.GridKaryawanDataGridView.Size = New System.Drawing.Size(932, 536)
        Me.GridKaryawanDataGridView.TabIndex = 28
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(15, 18)
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
        Me.GridHakTunjanganDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridHakTunjanganDataGridView.AutoGenerateColumns = False
        Me.GridHakTunjanganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridHakTunjanganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.statusHak, Me.NamaTunjanganDataGridViewTextBoxColumn, Me.BesarTunjanganDataGridViewTextBoxColumn, Me.Penambahan, Me.ubah})
        Me.GridHakTunjanganDataGridView.DataSource = Me.GridHakTunjanganBindingSource
        Me.GridHakTunjanganDataGridView.Location = New System.Drawing.Point(949, 67)
        Me.GridHakTunjanganDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridHakTunjanganDataGridView.Name = "GridHakTunjanganDataGridView"
        Me.GridHakTunjanganDataGridView.ReadOnly = True
        Me.GridHakTunjanganDataGridView.Size = New System.Drawing.Size(402, 191)
        Me.GridHakTunjanganDataGridView.TabIndex = 37
        '
        'tanggalPeriode
        '
        Me.tanggalPeriode.CustomFormat = ""
        Me.tanggalPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tanggalPeriode.Location = New System.Drawing.Point(200, 21)
        Me.tanggalPeriode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tanggalPeriode.Name = "tanggalPeriode"
        Me.tanggalPeriode.Size = New System.Drawing.Size(221, 25)
        Me.tanggalPeriode.TabIndex = 38
        '
        'BtnCari
        '
        Me.BtnCari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCari.Location = New System.Drawing.Point(444, 18)
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
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StatusKewajibanDataGridViewCheckBoxColumn, Me.NamaPotonganDataGridViewTextBoxColumn, Me.BesarPotonganDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn8, Me.DataGridViewButtonColumn1})
        Me.DataGridView1.DataSource = Me.GridKewajibanPotonganBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(949, 296)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(402, 193)
        Me.DataGridView1.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lbTunjangan)
        Me.Panel1.Location = New System.Drawing.Point(949, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 31)
        Me.Panel1.TabIndex = 39
        '
        'lbTunjangan
        '
        Me.lbTunjangan.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbTunjangan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTunjangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbTunjangan.Location = New System.Drawing.Point(28, 0)
        Me.lbTunjangan.Name = "lbTunjangan"
        Me.lbTunjangan.Size = New System.Drawing.Size(374, 31)
        Me.lbTunjangan.TabIndex = 0
        Me.lbTunjangan.Text = "0"
        Me.lbTunjangan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.lbPotongan)
        Me.Panel2.Location = New System.Drawing.Point(949, 489)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 31)
        Me.Panel2.TabIndex = 39
        '
        'lbPotongan
        '
        Me.lbPotongan.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbPotongan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPotongan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbPotongan.Location = New System.Drawing.Point(28, 0)
        Me.lbPotongan.Name = "lbPotongan"
        Me.lbPotongan.Size = New System.Drawing.Size(374, 31)
        Me.lbPotongan.TabIndex = 0
        Me.lbPotongan.Text = "0"
        Me.lbPotongan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPeriode)
        Me.GroupBox1.Controls.Add(Me.rdPeriode)
        Me.GroupBox1.Controls.Add(Me.rdTanggal)
        Me.GroupBox1.Controls.Add(Me.cariPeriode)
        Me.GroupBox1.Controls.Add(Me.BtnCari)
        Me.GroupBox1.Location = New System.Drawing.Point(460, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 55)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian"
        '
        'txtPeriode
        '
        Me.txtPeriode.Location = New System.Drawing.Point(290, 21)
        Me.txtPeriode.Name = "txtPeriode"
        Me.txtPeriode.Size = New System.Drawing.Size(134, 25)
        Me.txtPeriode.TabIndex = 40
        '
        'rdPeriode
        '
        Me.rdPeriode.AutoSize = True
        Me.rdPeriode.Location = New System.Drawing.Point(256, 27)
        Me.rdPeriode.Name = "rdPeriode"
        Me.rdPeriode.Size = New System.Drawing.Size(14, 13)
        Me.rdPeriode.TabIndex = 39
        Me.rdPeriode.TabStop = True
        Me.rdPeriode.UseVisualStyleBackColor = True
        '
        'rdTanggal
        '
        Me.rdTanggal.AutoSize = True
        Me.rdTanggal.Location = New System.Drawing.Point(25, 27)
        Me.rdTanggal.Name = "rdTanggal"
        Me.rdTanggal.Size = New System.Drawing.Size(14, 13)
        Me.rdTanggal.TabIndex = 39
        Me.rdTanggal.TabStop = True
        Me.rdTanggal.UseVisualStyleBackColor = True
        '
        'cariPeriode
        '
        Me.cariPeriode.CustomFormat = ""
        Me.cariPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cariPeriode.Location = New System.Drawing.Point(59, 21)
        Me.cariPeriode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cariPeriode.Name = "cariPeriode"
        Me.cariPeriode.Size = New System.Drawing.Size(177, 25)
        Me.cariPeriode.TabIndex = 38
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tanggalPeriode)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 55)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Location = New System.Drawing.Point(949, 525)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(402, 78)
        Me.Panel3.TabIndex = 42
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(949, 489)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(402, 31)
        Me.Panel4.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(949, 525)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(402, 78)
        Me.Panel5.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 78)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'idPenggajianMaster
        '
        Me.idPenggajianMaster.DataPropertyName = "idPenggajianMaster"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.idPenggajianMaster.DefaultCellStyle = DataGridViewCellStyle15
        Me.idPenggajianMaster.HeaderText = "Nomor"
        Me.idPenggajianMaster.Name = "idPenggajianMaster"
        Me.idPenggajianMaster.Width = 70
        '
        'TotalGaji
        '
        Me.TotalGaji.DataPropertyName = "TotalGaji"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "C2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.TotalGaji.DefaultCellStyle = DataGridViewCellStyle16
        Me.TotalGaji.HeaderText = "Total Gaji"
        Me.TotalGaji.Name = "TotalGaji"
        '
        'kehadiran
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.NullValue = "0"
        Me.kehadiran.DefaultCellStyle = DataGridViewCellStyle17
        Me.kehadiran.HeaderText = "Input Kehadiran"
        Me.kehadiran.Name = "kehadiran"
        Me.kehadiran.Width = 70
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
        'GridHakTunjanganBindingSource
        '
        Me.GridHakTunjanganBindingSource.DataMember = "gridHakTunjangan"
        Me.GridHakTunjanganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'IdKaryawanDataGridViewTextBoxColumn2
        '
        Me.IdKaryawanDataGridViewTextBoxColumn2.DataPropertyName = "idKaryawan"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        Me.IdKaryawanDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle18
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
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "C2"
        DataGridViewCellStyle19.NullValue = "0"
        Me.GajiPokokDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle19
        Me.GajiPokokDataGridViewTextBoxColumn.HeaderText = "Gaji Pokok"
        Me.GajiPokokDataGridViewTextBoxColumn.Name = "GajiPokokDataGridViewTextBoxColumn"
        '
        'TotalTunjanganDataGridViewTextBoxColumn
        '
        Me.TotalTunjanganDataGridViewTextBoxColumn.DataPropertyName = "totalTunjangan"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "C2"
        DataGridViewCellStyle20.NullValue = "0"
        Me.TotalTunjanganDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle20
        Me.TotalTunjanganDataGridViewTextBoxColumn.HeaderText = "Tunjangan"
        Me.TotalTunjanganDataGridViewTextBoxColumn.Name = "TotalTunjanganDataGridViewTextBoxColumn"
        '
        'TotalPotonganDataGridViewTextBoxColumn
        '
        Me.TotalPotonganDataGridViewTextBoxColumn.DataPropertyName = "totalPotongan"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "C2"
        DataGridViewCellStyle21.NullValue = "0"
        Me.TotalPotonganDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle21
        Me.TotalPotonganDataGridViewTextBoxColumn.HeaderText = "Potongan"
        Me.TotalPotonganDataGridViewTextBoxColumn.Name = "TotalPotonganDataGridViewTextBoxColumn"
        '
        'JmlKehadiranDataGridViewTextBoxColumn
        '
        Me.JmlKehadiranDataGridViewTextBoxColumn.DataPropertyName = "jmlKehadiran"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.JmlKehadiranDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle22
        Me.JmlKehadiranDataGridViewTextBoxColumn.HeaderText = "Jml. Kehadiran"
        Me.JmlKehadiranDataGridViewTextBoxColumn.Name = "JmlKehadiranDataGridViewTextBoxColumn"
        Me.JmlKehadiranDataGridViewTextBoxColumn.Width = 70
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
        'statusHak
        '
        Me.statusHak.DataPropertyName = "statusHak"
        Me.statusHak.HeaderText = ""
        Me.statusHak.Name = "statusHak"
        Me.statusHak.ReadOnly = True
        Me.statusHak.Width = 30
        '
        'NamaTunjanganDataGridViewTextBoxColumn
        '
        Me.NamaTunjanganDataGridViewTextBoxColumn.DataPropertyName = "namaTunjangan"
        Me.NamaTunjanganDataGridViewTextBoxColumn.HeaderText = "Tunjangan"
        Me.NamaTunjanganDataGridViewTextBoxColumn.Name = "NamaTunjanganDataGridViewTextBoxColumn"
        Me.NamaTunjanganDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaTunjanganDataGridViewTextBoxColumn.Width = 80
        '
        'BesarTunjanganDataGridViewTextBoxColumn
        '
        Me.BesarTunjanganDataGridViewTextBoxColumn.DataPropertyName = "besarTunjangan"
        DataGridViewCellStyle23.Format = "C2"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.BesarTunjanganDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle23
        Me.BesarTunjanganDataGridViewTextBoxColumn.HeaderText = "Nominal"
        Me.BesarTunjanganDataGridViewTextBoxColumn.Name = "BesarTunjanganDataGridViewTextBoxColumn"
        Me.BesarTunjanganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Penambahan
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "C2"
        DataGridViewCellStyle24.NullValue = "0"
        Me.Penambahan.DefaultCellStyle = DataGridViewCellStyle24
        Me.Penambahan.HeaderText = "Tambah"
        Me.Penambahan.Name = "Penambahan"
        Me.Penambahan.ReadOnly = True
        Me.Penambahan.Width = 80
        '
        'ubah
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.NullValue = "+"
        Me.ubah.DefaultCellStyle = DataGridViewCellStyle25
        Me.ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ubah.HeaderText = "Aksi"
        Me.ubah.Name = "ubah"
        Me.ubah.ReadOnly = True
        Me.ubah.Text = "Update"
        Me.ubah.Width = 50
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
        Me.NamaPotonganDataGridViewTextBoxColumn.Width = 80
        '
        'BesarPotonganDataGridViewTextBoxColumn
        '
        Me.BesarPotonganDataGridViewTextBoxColumn.DataPropertyName = "besarPotongan"
        DataGridViewCellStyle26.Format = "C2"
        DataGridViewCellStyle26.NullValue = Nothing
        Me.BesarPotonganDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle26
        Me.BesarPotonganDataGridViewTextBoxColumn.HeaderText = "Nominal"
        Me.BesarPotonganDataGridViewTextBoxColumn.Name = "BesarPotonganDataGridViewTextBoxColumn"
        Me.BesarPotonganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "C2"
        DataGridViewCellStyle27.NullValue = "0"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn8.HeaderText = "Kurangi"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewButtonColumn1
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle28.NullValue = "+"
        Me.DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewButtonColumn1.HeaderText = "Aksi"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Text = "Update"
        Me.DataGridViewButtonColumn1.Width = 50
        '
        'FGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1354, 610)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GridHakTunjanganDataGridView)
        Me.Controls.Add(Me.GridKaryawanDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FGaji"
        Me.Text = "Penggajian"
        CType(Me.GridKaryawanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridHakTunjanganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
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

    End Sub
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
    Friend WithEvents PeriodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodeTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.PeriodeTableAdapter
    Friend WithEvents KaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KaryawanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.KaryawanTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPeriode As System.Windows.Forms.TextBox
    Friend WithEvents rdPeriode As System.Windows.Forms.RadioButton
    Friend WithEvents rdTanggal As System.Windows.Forms.RadioButton
    Friend WithEvents cariPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
End Class
