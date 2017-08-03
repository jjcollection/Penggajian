<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karyawan
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
        Dim KodeKaryawanLabel As System.Windows.Forms.Label
        Dim NamakaryawanLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim TelpLabel As System.Windows.Forms.Label
        Dim KodebagianLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KaryawanDataGridView = New System.Windows.Forms.DataGridView()
        Me.GridKaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbPenggajianDataSet = New Penggajian.dbPenggajianDataSet()
        Me.IdKaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.TelpTextBox = New System.Windows.Forms.TextBox()
        Me.NamakaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KodebagianComboBox = New System.Windows.Forms.ComboBox()
        Me.JabatanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KaryawanPenggajianMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KaryawanTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.KaryawanTableAdapter()
        Me.PenggajianMasterTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.PenggajianMasterTableAdapter()
        Me.DbPenggajianDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridKaryawanTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter()
        Me.JabatanTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.JabatanTableAdapter()
        Me.clPotongan = New System.Windows.Forms.CheckedListBox()
        Me.clTunjangan = New System.Windows.Forms.CheckedListBox()
        Me.TunjanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TunjanganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.TunjanganTableAdapter()
        Me.TableAdapterManager = New Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager()
        Me.PotonganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.PotonganTableAdapter()
        Me.PotonganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HakBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HakTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.HakTableAdapter()
        Me.KewajibanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KewajibanTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.KewajibanTableAdapter()
        Me.GridHakTunjanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridHakTunjanganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.gridHakTunjanganTableAdapter()
        Me.IdKaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idJabatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaKaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaJabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        KodeKaryawanLabel = New System.Windows.Forms.Label()
        NamakaryawanLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        TelpLabel = New System.Windows.Forms.Label()
        KodebagianLabel = New System.Windows.Forms.Label()
        CType(Me.KaryawanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbPenggajianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JabatanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanPenggajianMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbPenggajianDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TunjanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PotonganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HakBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KewajibanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridHakTunjanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KodeKaryawanLabel
        '
        KodeKaryawanLabel.AutoSize = True
        KodeKaryawanLabel.Location = New System.Drawing.Point(39, 24)
        KodeKaryawanLabel.Name = "KodeKaryawanLabel"
        KodeKaryawanLabel.Size = New System.Drawing.Size(85, 13)
        KodeKaryawanLabel.TabIndex = 1
        KodeKaryawanLabel.Text = "Kode Karyawan:"
        '
        'NamakaryawanLabel
        '
        NamakaryawanLabel.AutoSize = True
        NamakaryawanLabel.Location = New System.Drawing.Point(39, 50)
        NamakaryawanLabel.Name = "NamakaryawanLabel"
        NamakaryawanLabel.Size = New System.Drawing.Size(88, 13)
        NamakaryawanLabel.TabIndex = 3
        NamakaryawanLabel.Text = "Nama Karyawan:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(39, 77)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 5
        AlamatLabel.Text = "Alamat:"
        '
        'TelpLabel
        '
        TelpLabel.AutoSize = True
        TelpLabel.Location = New System.Drawing.Point(420, 20)
        TelpLabel.Name = "TelpLabel"
        TelpLabel.Size = New System.Drawing.Size(31, 13)
        TelpLabel.TabIndex = 7
        TelpLabel.Text = "Telp:"
        '
        'KodebagianLabel
        '
        KodebagianLabel.AutoSize = True
        KodebagianLabel.Location = New System.Drawing.Point(54, 213)
        KodebagianLabel.Name = "KodebagianLabel"
        KodebagianLabel.Size = New System.Drawing.Size(51, 13)
        KodebagianLabel.TabIndex = 17
        KodebagianLabel.Text = "Jabatan :"
        '
        'KaryawanDataGridView
        '
        Me.KaryawanDataGridView.AllowUserToAddRows = False
        Me.KaryawanDataGridView.AllowUserToDeleteRows = False
        Me.KaryawanDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KaryawanDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KaryawanDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.KaryawanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KaryawanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdKaryawanDataGridViewTextBoxColumn, Me.idJabatan, Me.NamaKaryawanDataGridViewTextBoxColumn, Me.NamaJabatanDataGridViewTextBoxColumn, Me.TelpDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn})
        Me.KaryawanDataGridView.DataSource = Me.GridKaryawanBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.KaryawanDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.KaryawanDataGridView.Location = New System.Drawing.Point(11, 250)
        Me.KaryawanDataGridView.Name = "KaryawanDataGridView"
        Me.KaryawanDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KaryawanDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.KaryawanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.KaryawanDataGridView.Size = New System.Drawing.Size(971, 326)
        Me.KaryawanDataGridView.TabIndex = 7
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
        'IdKaryawanTextBox
        '
        Me.IdKaryawanTextBox.Location = New System.Drawing.Point(130, 21)
        Me.IdKaryawanTextBox.Name = "IdKaryawanTextBox"
        Me.IdKaryawanTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IdKaryawanTextBox.TabIndex = 0
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.Location = New System.Drawing.Point(130, 74)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(367, 126)
        Me.AlamatTextBox.TabIndex = 3
        '
        'TelpTextBox
        '
        Me.TelpTextBox.Location = New System.Drawing.Point(458, 17)
        Me.TelpTextBox.Name = "TelpTextBox"
        Me.TelpTextBox.Size = New System.Drawing.Size(257, 20)
        Me.TelpTextBox.TabIndex = 2
        '
        'NamakaryawanTextBox
        '
        Me.NamakaryawanTextBox.Location = New System.Drawing.Point(130, 43)
        Me.NamakaryawanTextBox.Name = "NamakaryawanTextBox"
        Me.NamakaryawanTextBox.Size = New System.Drawing.Size(284, 20)
        Me.NamakaryawanTextBox.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(335, 586)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(254, 586)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(173, 586)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Ubah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(92, 586)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(11, 586)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Baru"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KodebagianComboBox
        '
        Me.KodebagianComboBox.DataSource = Me.JabatanBindingSource
        Me.KodebagianComboBox.DisplayMember = "namaJabatan"
        Me.KodebagianComboBox.FormattingEnabled = True
        Me.KodebagianComboBox.Location = New System.Drawing.Point(130, 210)
        Me.KodebagianComboBox.Name = "KodebagianComboBox"
        Me.KodebagianComboBox.Size = New System.Drawing.Size(254, 21)
        Me.KodebagianComboBox.TabIndex = 4
        Me.KodebagianComboBox.ValueMember = "idJabatan"
        '
        'JabatanBindingSource
        '
        Me.JabatanBindingSource.DataMember = "Jabatan"
        Me.JabatanBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'KaryawanPenggajianMasterBindingSource
        '
        Me.KaryawanPenggajianMasterBindingSource.DataMember = "KaryawanPenggajianMaster"
        Me.KaryawanPenggajianMasterBindingSource.DataSource = Me.KaryawanBindingSource
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
        'PenggajianMasterTableAdapter
        '
        Me.PenggajianMasterTableAdapter.ClearBeforeFill = True
        '
        'DbPenggajianDataSetBindingSource
        '
        Me.DbPenggajianDataSetBindingSource.DataSource = Me.DbPenggajianDataSet
        Me.DbPenggajianDataSetBindingSource.Position = 0
        '
        'GridKaryawanTableAdapter
        '
        Me.GridKaryawanTableAdapter.ClearBeforeFill = True
        '
        'JabatanTableAdapter
        '
        Me.JabatanTableAdapter.ClearBeforeFill = True
        '
        'clPotongan
        '
        Me.clPotongan.FormattingEnabled = True
        Me.clPotongan.Location = New System.Drawing.Point(629, 74)
        Me.clPotongan.Name = "clPotongan"
        Me.clPotongan.Size = New System.Drawing.Size(120, 124)
        Me.clPotongan.TabIndex = 6
        '
        'clTunjangan
        '
        Me.clTunjangan.FormattingEnabled = True
        Me.clTunjangan.Location = New System.Drawing.Point(503, 74)
        Me.clTunjangan.Name = "clTunjangan"
        Me.clTunjangan.Size = New System.Drawing.Size(120, 124)
        Me.clTunjangan.TabIndex = 5
        '
        'TunjanganBindingSource
        '
        Me.TunjanganBindingSource.DataMember = "Tunjangan"
        Me.TunjanganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'TunjanganTableAdapter
        '
        Me.TunjanganTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HakTableAdapter = Nothing
        Me.TableAdapterManager.JabatanTableAdapter = Me.JabatanTableAdapter
        Me.TableAdapterManager.KaryawanTableAdapter = Me.KaryawanTableAdapter
        Me.TableAdapterManager.KewajibanTableAdapter = Nothing
        Me.TableAdapterManager.PenggajianMasterTableAdapter = Me.PenggajianMasterTableAdapter
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
        'PotonganBindingSource
        '
        Me.PotonganBindingSource.DataMember = "Potongan"
        Me.PotonganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'HakBindingSource
        '
        Me.HakBindingSource.DataMember = "Hak"
        Me.HakBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'HakTableAdapter
        '
        Me.HakTableAdapter.ClearBeforeFill = True
        '
        'KewajibanBindingSource
        '
        Me.KewajibanBindingSource.DataMember = "Kewajiban"
        Me.KewajibanBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'KewajibanTableAdapter
        '
        Me.KewajibanTableAdapter.ClearBeforeFill = True
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
        'IdKaryawanDataGridViewTextBoxColumn
        '
        Me.IdKaryawanDataGridViewTextBoxColumn.DataPropertyName = "idKaryawan"
        Me.IdKaryawanDataGridViewTextBoxColumn.HeaderText = "idKaryawan"
        Me.IdKaryawanDataGridViewTextBoxColumn.Name = "IdKaryawanDataGridViewTextBoxColumn"
        Me.IdKaryawanDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdKaryawanDataGridViewTextBoxColumn.Visible = False
        '
        'idJabatan
        '
        Me.idJabatan.DataPropertyName = "idJabatan"
        Me.idJabatan.HeaderText = "idJabatan"
        Me.idJabatan.Name = "idJabatan"
        Me.idJabatan.ReadOnly = True
        Me.idJabatan.Visible = False
        '
        'NamaKaryawanDataGridViewTextBoxColumn
        '
        Me.NamaKaryawanDataGridViewTextBoxColumn.DataPropertyName = "namaKaryawan"
        Me.NamaKaryawanDataGridViewTextBoxColumn.HeaderText = "Nama Karyawan"
        Me.NamaKaryawanDataGridViewTextBoxColumn.Name = "NamaKaryawanDataGridViewTextBoxColumn"
        Me.NamaKaryawanDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaKaryawanDataGridViewTextBoxColumn.Width = 150
        '
        'NamaJabatanDataGridViewTextBoxColumn
        '
        Me.NamaJabatanDataGridViewTextBoxColumn.DataPropertyName = "namaJabatan"
        Me.NamaJabatanDataGridViewTextBoxColumn.HeaderText = "Jabatan"
        Me.NamaJabatanDataGridViewTextBoxColumn.Name = "NamaJabatanDataGridViewTextBoxColumn"
        Me.NamaJabatanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelpDataGridViewTextBoxColumn
        '
        Me.TelpDataGridViewTextBoxColumn.DataPropertyName = "Telp"
        Me.TelpDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TelpDataGridViewTextBoxColumn.Name = "TelpDataGridViewTextBoxColumn"
        Me.TelpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlamatDataGridViewTextBoxColumn.Width = 350
        '
        'Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 617)
        Me.Controls.Add(Me.clPotongan)
        Me.Controls.Add(Me.clTunjangan)
        Me.Controls.Add(KodebagianLabel)
        Me.Controls.Add(Me.KodebagianComboBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NamakaryawanTextBox)
        Me.Controls.Add(KodeKaryawanLabel)
        Me.Controls.Add(Me.IdKaryawanTextBox)
        Me.Controls.Add(NamakaryawanLabel)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(TelpLabel)
        Me.Controls.Add(Me.TelpTextBox)
        Me.Controls.Add(Me.KaryawanDataGridView)
        Me.Name = "Karyawan"
        Me.Text = "Karyawan"
        CType(Me.KaryawanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridKaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbPenggajianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JabatanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanPenggajianMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbPenggajianDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TunjanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PotonganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HakBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KewajibanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridHakTunjanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KaryawanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdKaryawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamakaryawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents KodebagianComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DbPenggajianDataSet As Penggajian.dbPenggajianDataSet
    Friend WithEvents KaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KaryawanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.KaryawanTableAdapter
    Friend WithEvents KaryawanPenggajianMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenggajianMasterTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.PenggajianMasterTableAdapter
    Friend WithEvents DbPenggajianDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridKaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridKaryawanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.GridKaryawanTableAdapter
    Friend WithEvents JabatanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JabatanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.JabatanTableAdapter
    Friend WithEvents clPotongan As System.Windows.Forms.CheckedListBox
    Friend WithEvents clTunjangan As System.Windows.Forms.CheckedListBox
    Friend WithEvents TunjanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TunjanganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.TunjanganTableAdapter
    Friend WithEvents TableAdapterManager As Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PotonganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.PotonganTableAdapter
    Friend WithEvents PotonganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HakBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HakTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.HakTableAdapter
    Friend WithEvents KewajibanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KewajibanTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.KewajibanTableAdapter
    Friend WithEvents GridHakTunjanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridHakTunjanganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.gridHakTunjanganTableAdapter
    Friend WithEvents IdKaryawanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idJabatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaKaryawanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaJabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
