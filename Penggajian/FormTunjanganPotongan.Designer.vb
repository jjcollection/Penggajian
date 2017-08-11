<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTunjanganPotongan
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
        Dim NamaTunjanganLabel As System.Windows.Forms.Label
        Dim BesarTunjanganLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DbPenggajianDataSet = New Penggajian.dbPenggajianDataSet()
        Me.TunjanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TunjanganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.TunjanganTableAdapter()
        Me.TableAdapterManager = New Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager()
        Me.TunjanganDataGridView = New System.Windows.Forms.DataGridView()
        Me.PotonganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PotonganTableAdapter = New Penggajian.dbPenggajianDataSetTableAdapters.PotonganTableAdapter()
        Me.PotonganDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NamaPotonganTextBox = New System.Windows.Forms.TextBox()
        Me.BesarPotonganTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTunjanganTextBox = New System.Windows.Forms.TextBox()
        Me.BesarTunjanganTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NamaTunjanganLabel = New System.Windows.Forms.Label()
        BesarTunjanganLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DbPenggajianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TunjanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TunjanganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PotonganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PotonganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DbPenggajianDataSet
        '
        Me.DbPenggajianDataSet.DataSetName = "dbPenggajianDataSet"
        Me.DbPenggajianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.JabatanTableAdapter = Nothing
        Me.TableAdapterManager.KaryawanTableAdapter = Nothing
        Me.TableAdapterManager.KewajibanTableAdapter = Nothing
        Me.TableAdapterManager.PenggajianMasterTableAdapter = Nothing
        Me.TableAdapterManager.PeriodeTableAdapter = Nothing
        Me.TableAdapterManager.PotonganTableAdapter = Me.PotonganTableAdapter
        Me.TableAdapterManager.TunjanganTableAdapter = Me.TunjanganTableAdapter
        Me.TableAdapterManager.UpdateOrder = Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TunjanganDataGridView
        '
        Me.TunjanganDataGridView.AllowUserToAddRows = False
        Me.TunjanganDataGridView.AllowUserToDeleteRows = False
        Me.TunjanganDataGridView.AutoGenerateColumns = False
        Me.TunjanganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TunjanganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TunjanganDataGridView.DataSource = Me.TunjanganBindingSource
        Me.TunjanganDataGridView.Location = New System.Drawing.Point(4, 149)
        Me.TunjanganDataGridView.Name = "TunjanganDataGridView"
        Me.TunjanganDataGridView.ReadOnly = True
        Me.TunjanganDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TunjanganDataGridView.Size = New System.Drawing.Size(357, 220)
        Me.TunjanganDataGridView.TabIndex = 1
        '
        'PotonganBindingSource
        '
        Me.PotonganBindingSource.DataMember = "Potongan"
        Me.PotonganBindingSource.DataSource = Me.DbPenggajianDataSet
        '
        'PotonganTableAdapter
        '
        Me.PotonganTableAdapter.ClearBeforeFill = True
        '
        'PotonganDataGridView
        '
        Me.PotonganDataGridView.AllowUserToAddRows = False
        Me.PotonganDataGridView.AllowUserToDeleteRows = False
        Me.PotonganDataGridView.AutoGenerateColumns = False
        Me.PotonganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PotonganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PotonganDataGridView.DataSource = Me.PotonganBindingSource
        Me.PotonganDataGridView.Location = New System.Drawing.Point(367, 149)
        Me.PotonganDataGridView.Name = "PotonganDataGridView"
        Me.PotonganDataGridView.ReadOnly = True
        Me.PotonganDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PotonganDataGridView.Size = New System.Drawing.Size(363, 220)
        Me.PotonganDataGridView.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(655, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NamaPotonganTextBox
        '
        Me.NamaPotonganTextBox.Location = New System.Drawing.Point(427, 64)
        Me.NamaPotonganTextBox.Name = "NamaPotonganTextBox"
        Me.NamaPotonganTextBox.Size = New System.Drawing.Size(303, 20)
        Me.NamaPotonganTextBox.TabIndex = 7
        '
        'BesarPotonganTextBox
        '
        Me.BesarPotonganTextBox.Location = New System.Drawing.Point(427, 90)
        Me.BesarPotonganTextBox.Name = "BesarPotonganTextBox"
        Me.BesarPotonganTextBox.Size = New System.Drawing.Size(303, 20)
        Me.BesarPotonganTextBox.TabIndex = 9
        '
        'NamaTunjanganLabel
        '
        NamaTunjanganLabel.AutoSize = True
        NamaTunjanganLabel.Location = New System.Drawing.Point(9, 67)
        NamaTunjanganLabel.Name = "NamaTunjanganLabel"
        NamaTunjanganLabel.Size = New System.Drawing.Size(61, 13)
        NamaTunjanganLabel.TabIndex = 12
        NamaTunjanganLabel.Text = "Tunjangan:"
        '
        'NamaTunjanganTextBox
        '
        Me.NamaTunjanganTextBox.Location = New System.Drawing.Point(71, 64)
        Me.NamaTunjanganTextBox.Name = "NamaTunjanganTextBox"
        Me.NamaTunjanganTextBox.Size = New System.Drawing.Size(290, 20)
        Me.NamaTunjanganTextBox.TabIndex = 13
        '
        'BesarTunjanganLabel
        '
        BesarTunjanganLabel.AutoSize = True
        BesarTunjanganLabel.Location = New System.Drawing.Point(22, 93)
        BesarTunjanganLabel.Name = "BesarTunjanganLabel"
        BesarTunjanganLabel.Size = New System.Drawing.Size(48, 13)
        BesarTunjanganLabel.TabIndex = 14
        BesarTunjanganLabel.Text = "Nominal:"
        '
        'BesarTunjanganTextBox
        '
        Me.BesarTunjanganTextBox.Location = New System.Drawing.Point(71, 90)
        Me.BesarTunjanganTextBox.Name = "BesarTunjanganTextBox"
        Me.BesarTunjanganTextBox.Size = New System.Drawing.Size(290, 20)
        Me.BesarTunjanganTextBox.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(4, 120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Baru"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(85, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Ubah"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(166, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(370, 120)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Baru"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(451, 120)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Ubah"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(532, 120)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = "Hapus"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 43)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(367, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 43)
        Me.Panel2.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TUNJANGAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 43)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "POTONGAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(379, 93)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(48, 13)
        Label3.TabIndex = 14
        Label3.Text = "Nominal:"
        AddHandler Label3.Click, AddressOf Me.Label3_Click
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(366, 67)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(61, 13)
        Label4.TabIndex = 12
        Label4.Text = "Tunjangan:"
        AddHandler Label4.Click, AddressOf Me.Label4_Click
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idTunjangan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idTunjangan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "namaTunjangan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tunjangan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "besarTunjangan"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nominal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 160
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idPotongan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idPotongan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "namaPotongan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Potongan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "besarPotongan"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nominal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 160
        '
        'FormTunjanganPotongan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(737, 399)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(NamaTunjanganLabel)
        Me.Controls.Add(Me.NamaTunjanganTextBox)
        Me.Controls.Add(Label3)
        Me.Controls.Add(BesarTunjanganLabel)
        Me.Controls.Add(Me.BesarTunjanganTextBox)
        Me.Controls.Add(Me.NamaPotonganTextBox)
        Me.Controls.Add(Me.BesarPotonganTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PotonganDataGridView)
        Me.Controls.Add(Me.TunjanganDataGridView)
        Me.MaximizeBox = False
        Me.Name = "FormTunjanganPotongan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTunjanganPotongan"
        CType(Me.DbPenggajianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TunjanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TunjanganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PotonganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PotonganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbPenggajianDataSet As Penggajian.dbPenggajianDataSet
    Friend WithEvents TunjanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TunjanganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.TunjanganTableAdapter
    Friend WithEvents TableAdapterManager As Penggajian.dbPenggajianDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TunjanganDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PotonganTableAdapter As Penggajian.dbPenggajianDataSetTableAdapters.PotonganTableAdapter
    Friend WithEvents PotonganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PotonganDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NamaPotonganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BesarPotonganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTunjanganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BesarTunjanganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
