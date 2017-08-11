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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
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
        Me.GridKewajibanPotonganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridKewajibanPotonganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.GridKewajibanPotonganTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdJabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiPokokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiPokokTextBox = New System.Windows.Forms.TextBox()
        KodeKaryawanLabel = New System.Windows.Forms.Label()
        NamakaryawanLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        TelpLabel = New System.Windows.Forms.Label()
        KodebagianLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
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
        CType(Me.GridKewajibanPotonganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KodeKaryawanLabel
        '
        KodeKaryawanLabel.AutoSize = True
        KodeKaryawanLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KodeKaryawanLabel.Location = New System.Drawing.Point(17, 15)
        KodeKaryawanLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        KodeKaryawanLabel.Name = "KodeKaryawanLabel"
        KodeKaryawanLabel.Size = New System.Drawing.Size(107, 17)
        KodeKaryawanLabel.TabIndex = 1
        KodeKaryawanLabel.Text = "Kode Karyawan:"
        '
        'NamakaryawanLabel
        '
        NamakaryawanLabel.AutoSize = True
        NamakaryawanLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamakaryawanLabel.Location = New System.Drawing.Point(12, 45)
        NamakaryawanLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NamakaryawanLabel.Name = "NamakaryawanLabel"
        NamakaryawanLabel.Size = New System.Drawing.Size(112, 17)
        NamakaryawanLabel.TabIndex = 3
        NamakaryawanLabel.Text = "Nama Karyawan:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlamatLabel.Location = New System.Drawing.Point(68, 74)
        AlamatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(56, 17)
        AlamatLabel.TabIndex = 5
        AlamatLabel.Text = "Alamat:"
        '
        'TelpLabel
        '
        TelpLabel.AutoSize = True
        TelpLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelpLabel.Location = New System.Drawing.Point(86, 184)
        TelpLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelpLabel.Name = "TelpLabel"
        TelpLabel.Size = New System.Drawing.Size(38, 17)
        TelpLabel.TabIndex = 7
        TelpLabel.Text = "Telp:"
        '
        'KodebagianLabel
        '
        KodebagianLabel.AutoSize = True
        KodebagianLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KodebagianLabel.Location = New System.Drawing.Point(60, 212)
        KodebagianLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        KodebagianLabel.Name = "KodebagianLabel"
        KodebagianLabel.Size = New System.Drawing.Size(64, 17)
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
        Me.KaryawanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KaryawanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IdJabatanDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.GajiPokokDataGridViewTextBoxColumn})
        Me.KaryawanDataGridView.DataSource = Me.KaryawanBindingSource
        Me.KaryawanDataGridView.Location = New System.Drawing.Point(7, 247)
        Me.KaryawanDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KaryawanDataGridView.Name = "KaryawanDataGridView"
        Me.KaryawanDataGridView.ReadOnly = True
        Me.KaryawanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.KaryawanDataGridView.Size = New System.Drawing.Size(1170, 330)
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
        Me.IdKaryawanTextBox.Location = New System.Drawing.Point(128, 12)
        Me.IdKaryawanTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IdKaryawanTextBox.Name = "IdKaryawanTextBox"
        Me.IdKaryawanTextBox.Size = New System.Drawing.Size(140, 25)
        Me.IdKaryawanTextBox.TabIndex = 0
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.Location = New System.Drawing.Point(128, 72)
        Me.AlamatTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(428, 104)
        Me.AlamatTextBox.TabIndex = 3
        '
        'TelpTextBox
        '
        Me.TelpTextBox.Location = New System.Drawing.Point(128, 182)
        Me.TelpTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TelpTextBox.Name = "TelpTextBox"
        Me.TelpTextBox.Size = New System.Drawing.Size(299, 25)
        Me.TelpTextBox.TabIndex = 2
        '
        'NamakaryawanTextBox
        '
        Me.NamakaryawanTextBox.Location = New System.Drawing.Point(128, 42)
        Me.NamakaryawanTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NamakaryawanTextBox.Name = "NamakaryawanTextBox"
        Me.NamakaryawanTextBox.Size = New System.Drawing.Size(330, 25)
        Me.NamakaryawanTextBox.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(357, 581)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 30)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(270, 581)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 30)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(182, 581)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 30)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Ubah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(94, 581)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 30)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 581)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Baru"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KodebagianComboBox
        '
        Me.KodebagianComboBox.DataSource = Me.JabatanBindingSource
        Me.KodebagianComboBox.DisplayMember = "namaJabatan"
        Me.KodebagianComboBox.FormattingEnabled = True
        Me.KodebagianComboBox.Location = New System.Drawing.Point(128, 209)
        Me.KodebagianComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KodebagianComboBox.Name = "KodebagianComboBox"
        Me.KodebagianComboBox.Size = New System.Drawing.Size(299, 25)
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
        Me.clPotongan.Location = New System.Drawing.Point(708, 72)
        Me.clPotongan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clPotongan.Name = "clPotongan"
        Me.clPotongan.Size = New System.Drawing.Size(140, 104)
        Me.clPotongan.TabIndex = 6
        '
        'clTunjangan
        '
        Me.clTunjangan.FormattingEnabled = True
        Me.clTunjangan.Location = New System.Drawing.Point(562, 72)
        Me.clTunjangan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clTunjangan.Name = "clTunjangan"
        Me.clTunjangan.Size = New System.Drawing.Size(140, 104)
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
        Me.TableAdapterManager.PeriodeTableAdapter = Nothing
        Me.TableAdapterManager.PotonganTableAdapter = Me.PotonganTableAdapter
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
        'GridKewajibanPotonganBindingSource
        '
        Me.GridKewajibanPotonganBindingSource.DataSource = Me.DbPenggajianDataSet
        Me.GridKewajibanPotonganBindingSource.Position = 0
        '
        'GridKewajibanPotonganTableAdapter
        '
        Me.GridKewajibanPotonganTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idKaryawan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idKaryawan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IdJabatanDataGridViewTextBoxColumn
        '
        Me.IdJabatanDataGridViewTextBoxColumn.DataPropertyName = "idJabatan"
        Me.IdJabatanDataGridViewTextBoxColumn.HeaderText = "idJabatan"
        Me.IdJabatanDataGridViewTextBoxColumn.Name = "IdJabatanDataGridViewTextBoxColumn"
        Me.IdJabatanDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdJabatanDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "namaKaryawan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "namaKaryawan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telp"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telp"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "alamat"
        Me.DataGridViewTextBoxColumn4.HeaderText = "alamat"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'GajiPokokDataGridViewTextBoxColumn
        '
        Me.GajiPokokDataGridViewTextBoxColumn.DataPropertyName = "gajiPokok"
        Me.GajiPokokDataGridViewTextBoxColumn.HeaderText = "gajiPokok"
        Me.GajiPokokDataGridViewTextBoxColumn.Name = "GajiPokokDataGridViewTextBoxColumn"
        Me.GajiPokokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GajiPokokTextBox
        '
        Me.GajiPokokTextBox.BackColor = System.Drawing.Color.Navy
        Me.GajiPokokTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GajiPokokTextBox.ForeColor = System.Drawing.Color.White
        Me.GajiPokokTextBox.Location = New System.Drawing.Point(434, 188)
        Me.GajiPokokTextBox.Name = "GajiPokokTextBox"
        Me.GajiPokokTextBox.Size = New System.Drawing.Size(414, 43)
        Me.GajiPokokTextBox.TabIndex = 19
        Me.GajiPokokTextBox.Text = "0"
        Me.GajiPokokTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(559, 50)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(81, 17)
        Label1.TabIndex = 5
        Label1.Text = "Tunjangan :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(705, 50)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(76, 17)
        Label2.TabIndex = 5
        Label2.Text = "Potongan :"
        '
        'Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 612)
        Me.Controls.Add(Me.GajiPokokTextBox)
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
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(TelpLabel)
        Me.Controls.Add(Me.TelpTextBox)
        Me.Controls.Add(Me.KaryawanDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        CType(Me.GridKewajibanPotonganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NamaKaryawanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaJabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridKewajibanPotonganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridKewajibanPotonganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.GridKewajibanPotonganTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdJabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GajiPokokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GajiPokokTextBox As System.Windows.Forms.TextBox
End Class
