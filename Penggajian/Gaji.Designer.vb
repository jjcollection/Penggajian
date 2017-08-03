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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtno = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBTOTAL = New System.Windows.Forms.Label()
        Me.LbGajiPokok = New System.Windows.Forms.Label()
        Me.LbTransportasi = New System.Windows.Forms.Label()
        Me.LbTmakan = New System.Windows.Forms.Label()
        Me.LbBonus = New System.Windows.Forms.Label()
        Me.GridKaryawanDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridKaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbPenggajianDataSet = New Penggajian.dbPenggajianDataSet()
        Me.GridKaryawanTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter()
        Me.TableAdapterManager = New Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager()
        Me.PotonganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.PotonganTableAdapter()
        Me.TunjanganDetilTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.TunjanganDetilTableAdapter()
        Me.TunjanganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.TunjanganTableAdapter()
        Me.TunjanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TunjanganDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PotonganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridHakTunjanganDataGridView = New System.Windows.Forms.DataGridView()
        Me.GridHakTunjanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridHakTunjanganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.gridHakTunjanganTableAdapter()
        Me.IdHakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdKaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTunjanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusHakDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NamaTunjanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BesarTunjanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridKaryawanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbPenggajianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TunjanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TunjanganDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PotonganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridHakTunjanganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridHakTunjanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtno
        '
        Me.txtno.AutoSize = True
        Me.txtno.Location = New System.Drawing.Point(12, 22)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(85, 13)
        Me.txtno.TabIndex = 21
        Me.txtno.Text = "Nama Karyawan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(85, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Tampilkan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "KodeKaryawan"
        Me.ComboBox1.Location = New System.Drawing.Point(114, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 27
        Me.ComboBox1.ValueMember = "KodeKaryawan"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(162, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.LBTOTAL)
        Me.GroupBox1.Controls.Add(Me.LbGajiPokok)
        Me.GroupBox1.Controls.Add(Me.LbTransportasi)
        Me.GroupBox1.Controls.Add(Me.LbTmakan)
        Me.GroupBox1.Controls.Add(Me.LbBonus)
        Me.GroupBox1.Location = New System.Drawing.Point(865, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 601)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detil Gaji"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(15, 385)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(242, 42)
        Me.Panel5.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 42)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TOTAL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(15, 289)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(242, 42)
        Me.Panel4.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 42)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TNJ. TRANSPORTASI"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Location = New System.Drawing.Point(15, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 42)
        Me.Panel3.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Lime
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(242, 42)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "TNJ. MAKAN"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(15, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(242, 42)
        Me.Panel2.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Lime
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(242, 42)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "BONUS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(15, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 42)
        Me.Panel1.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(242, 42)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "GAJI POKOK"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBTOTAL
        '
        Me.LBTOTAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBTOTAL.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LBTOTAL.ForeColor = System.Drawing.Color.Fuchsia
        Me.LBTOTAL.Location = New System.Drawing.Point(15, 431)
        Me.LBTOTAL.Name = "LBTOTAL"
        Me.LBTOTAL.Size = New System.Drawing.Size(242, 42)
        Me.LBTOTAL.TabIndex = 0
        Me.LBTOTAL.Text = "0 "
        Me.LBTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbGajiPokok
        '
        Me.LbGajiPokok.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbGajiPokok.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGajiPokok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbGajiPokok.Location = New System.Drawing.Point(15, 59)
        Me.LbGajiPokok.Name = "LbGajiPokok"
        Me.LbGajiPokok.Size = New System.Drawing.Size(242, 42)
        Me.LbGajiPokok.TabIndex = 0
        Me.LbGajiPokok.Text = "0"
        Me.LbGajiPokok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbTransportasi
        '
        Me.LbTransportasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbTransportasi.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LbTransportasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbTransportasi.Location = New System.Drawing.Point(15, 335)
        Me.LbTransportasi.Name = "LbTransportasi"
        Me.LbTransportasi.Size = New System.Drawing.Size(242, 42)
        Me.LbTransportasi.TabIndex = 0
        Me.LbTransportasi.Text = "0 "
        Me.LbTransportasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbTmakan
        '
        Me.LbTmakan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbTmakan.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LbTmakan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbTmakan.Location = New System.Drawing.Point(15, 243)
        Me.LbTmakan.Name = "LbTmakan"
        Me.LbTmakan.Size = New System.Drawing.Size(242, 42)
        Me.LbTmakan.TabIndex = 0
        Me.LbTmakan.Text = "0 "
        Me.LbTmakan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbBonus
        '
        Me.LbBonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbBonus.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LbBonus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbBonus.Location = New System.Drawing.Point(15, 151)
        Me.LbBonus.Name = "LbBonus"
        Me.LbBonus.Size = New System.Drawing.Size(242, 42)
        Me.LbBonus.TabIndex = 0
        Me.LbBonus.Text = "0 "
        Me.LbBonus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridKaryawanDataGridView
        '
        Me.GridKaryawanDataGridView.AllowUserToAddRows = False
        Me.GridKaryawanDataGridView.AllowUserToDeleteRows = False
        Me.GridKaryawanDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridKaryawanDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridKaryawanDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridKaryawanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridKaryawanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8})
        Me.GridKaryawanDataGridView.DataSource = Me.GridKaryawanBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridKaryawanDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridKaryawanDataGridView.Location = New System.Drawing.Point(10, 96)
        Me.GridKaryawanDataGridView.Name = "GridKaryawanDataGridView"
        Me.GridKaryawanDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridKaryawanDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridKaryawanDataGridView.Size = New System.Drawing.Size(455, 506)
        Me.GridKaryawanDataGridView.TabIndex = 28
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(4, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idKaryawan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idKaryawan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "namaKaryawan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nama Karyawan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "namaJabatan"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Jabatan"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'GridKaryawanBindingSource
        '
        Me.GridKaryawanBindingSource.DataMember = "GridKaryawan"
        Me.GridKaryawanBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'DbPenggajianDataSet
        '
        Me.DbPenggajianDataSet.DataSetName = "dbPenggajianDataSet"
        Me.DbPenggajianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridKaryawanTableAdapter
        '
        Me.GridKaryawanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HakTableAdapter = Nothing
        Me.TableAdapterManager.JabatanTableAdapter = Nothing
        Me.TableAdapterManager.KaryawanTableAdapter = Nothing
        Me.TableAdapterManager.KewajibanTableAdapter = Nothing
        Me.TableAdapterManager.PenggajianMasterTableAdapter = Nothing
        Me.TableAdapterManager.PotonganDetilTableAdapter = Nothing
        Me.TableAdapterManager.PotonganTableAdapter = Me.PotonganTableAdapter
        Me.TableAdapterManager.TunjanganDetilTableAdapter = Me.TunjanganDetilTableAdapter
        Me.TableAdapterManager.TunjanganTableAdapter = Me.TunjanganTableAdapter
        Me.TableAdapterManager.UpdateOrder = Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PotonganTableAdapter
        '
        Me.PotonganTableAdapter.ClearBeforeFill = True
        '
        'TunjanganDetilTableAdapter
        '
        Me.TunjanganDetilTableAdapter.ClearBeforeFill = True
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
        'TunjanganDetilBindingSource
        '
        Me.TunjanganDetilBindingSource.DataMember = "TunjanganDetil"
        Me.TunjanganDetilBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'PotonganBindingSource
        '
        Me.PotonganBindingSource.DataMember = "Potongan"
        Me.PotonganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'GridHakTunjanganDataGridView
        '
        Me.GridHakTunjanganDataGridView.AllowUserToAddRows = False
        Me.GridHakTunjanganDataGridView.AllowUserToDeleteRows = False
        Me.GridHakTunjanganDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridHakTunjanganDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridHakTunjanganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridHakTunjanganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHakDataGridViewTextBoxColumn, Me.IdKaryawanDataGridViewTextBoxColumn, Me.IdTunjanganDataGridViewTextBoxColumn, Me.StatusHakDataGridViewCheckBoxColumn, Me.NamaTunjanganDataGridViewTextBoxColumn, Me.BesarTunjanganDataGridViewTextBoxColumn})
        Me.GridHakTunjanganDataGridView.DataSource = Me.GridHakTunjanganBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridHakTunjanganDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.GridHakTunjanganDataGridView.Location = New System.Drawing.Point(471, 96)
        Me.GridHakTunjanganDataGridView.Name = "GridHakTunjanganDataGridView"
        Me.GridHakTunjanganDataGridView.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridHakTunjanganDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GridHakTunjanganDataGridView.Size = New System.Drawing.Size(228, 201)
        Me.GridHakTunjanganDataGridView.TabIndex = 37
        '
        'GridHakTunjanganBindingSource
        '
        Me.GridHakTunjanganBindingSource.DataMember = "gridHakTunjangan"
        Me.GridHakTunjanganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'GridHakTunjanganTableAdapter
        '
        Me.GridHakTunjanganTableAdapter.ClearBeforeFill = True
        '
        'IdHakDataGridViewTextBoxColumn
        '
        Me.IdHakDataGridViewTextBoxColumn.DataPropertyName = "idHak"
        Me.IdHakDataGridViewTextBoxColumn.HeaderText = "idHak"
        Me.IdHakDataGridViewTextBoxColumn.Name = "IdHakDataGridViewTextBoxColumn"
        Me.IdHakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdKaryawanDataGridViewTextBoxColumn
        '
        Me.IdKaryawanDataGridViewTextBoxColumn.DataPropertyName = "idKaryawan"
        Me.IdKaryawanDataGridViewTextBoxColumn.HeaderText = "idKaryawan"
        Me.IdKaryawanDataGridViewTextBoxColumn.Name = "IdKaryawanDataGridViewTextBoxColumn"
        Me.IdKaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdTunjanganDataGridViewTextBoxColumn
        '
        Me.IdTunjanganDataGridViewTextBoxColumn.DataPropertyName = "idTunjangan"
        Me.IdTunjanganDataGridViewTextBoxColumn.HeaderText = "idTunjangan"
        Me.IdTunjanganDataGridViewTextBoxColumn.Name = "IdTunjanganDataGridViewTextBoxColumn"
        Me.IdTunjanganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusHakDataGridViewCheckBoxColumn
        '
        Me.StatusHakDataGridViewCheckBoxColumn.DataPropertyName = "statusHak"
        Me.StatusHakDataGridViewCheckBoxColumn.HeaderText = "statusHak"
        Me.StatusHakDataGridViewCheckBoxColumn.Name = "StatusHakDataGridViewCheckBoxColumn"
        Me.StatusHakDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'NamaTunjanganDataGridViewTextBoxColumn
        '
        Me.NamaTunjanganDataGridViewTextBoxColumn.DataPropertyName = "namaTunjangan"
        Me.NamaTunjanganDataGridViewTextBoxColumn.HeaderText = "namaTunjangan"
        Me.NamaTunjanganDataGridViewTextBoxColumn.Name = "NamaTunjanganDataGridViewTextBoxColumn"
        Me.NamaTunjanganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BesarTunjanganDataGridViewTextBoxColumn
        '
        Me.BesarTunjanganDataGridViewTextBoxColumn.DataPropertyName = "besarTunjangan"
        Me.BesarTunjanganDataGridViewTextBoxColumn.HeaderText = "besarTunjangan"
        Me.BesarTunjanganDataGridViewTextBoxColumn.Name = "BesarTunjanganDataGridViewTextBoxColumn"
        Me.BesarTunjanganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 614)
        Me.Controls.Add(Me.GridHakTunjanganDataGridView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GridKaryawanDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FGaji"
        Me.Text = "Penggajian"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridKaryawanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbPenggajianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TunjanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TunjanganDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PotonganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridHakTunjanganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridHakTunjanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtno As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbGajiPokok As System.Windows.Forms.Label
    Friend WithEvents LbBonus As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LbTransportasi As System.Windows.Forms.Label
    Friend WithEvents LbTmakan As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBTOTAL As System.Windows.Forms.Label
    Friend WithEvents DbPenggajianDataSet As Penggajian.dbPenggajianDataSet
    Friend WithEvents GridKaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridKaryawanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter
    Friend WithEvents TableAdapterManager As Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GridKaryawanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TunjanganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.TunjanganTableAdapter
    Friend WithEvents TunjanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TunjanganDetilTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.TunjanganDetilTableAdapter
    Friend WithEvents TunjanganDetilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PotonganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.PotonganTableAdapter
    Friend WithEvents PotonganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridHakTunjanganDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GridHakTunjanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridHakTunjanganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.gridHakTunjanganTableAdapter
    Friend WithEvents IdHakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdKaryawanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTunjanganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusHakDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NamaTunjanganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BesarTunjanganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
