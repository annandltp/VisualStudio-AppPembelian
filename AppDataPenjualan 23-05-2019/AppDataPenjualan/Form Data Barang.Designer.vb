<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Barang
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
        Me.dgv_data_barang = New System.Windows.Forms.DataGridView()
        Me.tb_nama_barang = New System.Windows.Forms.TextBox()
        Me.tb_id_barang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_search = New System.Windows.Forms.Button()
        Me.tb_jenis_barang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_harga_beli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_harga_jual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_stok = New System.Windows.Forms.TextBox()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.bt_save = New System.Windows.Forms.Button()
        Me.bt_edit = New System.Windows.Forms.Button()
        Me.bt_delete = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.dgv_data_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_data_barang
        '
        Me.dgv_data_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_barang.Location = New System.Drawing.Point(15, 123)
        Me.dgv_data_barang.Name = "dgv_data_barang"
        Me.dgv_data_barang.Size = New System.Drawing.Size(667, 127)
        Me.dgv_data_barang.TabIndex = 29
        '
        'tb_nama_barang
        '
        Me.tb_nama_barang.Location = New System.Drawing.Point(97, 43)
        Me.tb_nama_barang.Name = "tb_nama_barang"
        Me.tb_nama_barang.Size = New System.Drawing.Size(192, 20)
        Me.tb_nama_barang.TabIndex = 28
        '
        'tb_id_barang
        '
        Me.tb_id_barang.Location = New System.Drawing.Point(97, 12)
        Me.tb_id_barang.Name = "tb_id_barang"
        Me.tb_id_barang.Size = New System.Drawing.Size(100, 20)
        Me.tb_id_barang.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ID Barang"
        '
        'bt_search
        '
        Me.bt_search.Location = New System.Drawing.Point(214, 11)
        Me.bt_search.Name = "bt_search"
        Me.bt_search.Size = New System.Drawing.Size(75, 23)
        Me.bt_search.TabIndex = 37
        Me.bt_search.Text = "Search"
        Me.bt_search.UseVisualStyleBackColor = True
        '
        'tb_jenis_barang
        '
        Me.tb_jenis_barang.Location = New System.Drawing.Point(97, 73)
        Me.tb_jenis_barang.Name = "tb_jenis_barang"
        Me.tb_jenis_barang.Size = New System.Drawing.Size(192, 20)
        Me.tb_jenis_barang.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Jenis Barang"
        '
        'tb_harga_beli
        '
        Me.tb_harga_beli.Location = New System.Drawing.Point(444, 43)
        Me.tb_harga_beli.Name = "tb_harga_beli"
        Me.tb_harga_beli.Size = New System.Drawing.Size(129, 20)
        Me.tb_harga_beli.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Harga Beli"
        '
        'tb_harga_jual
        '
        Me.tb_harga_jual.Location = New System.Drawing.Point(446, 75)
        Me.tb_harga_jual.Name = "tb_harga_jual"
        Me.tb_harga_jual.Size = New System.Drawing.Size(127, 20)
        Me.tb_harga_jual.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(382, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Harga Jual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(597, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Stok"
        '
        'tb_stok
        '
        Me.tb_stok.Location = New System.Drawing.Point(584, 76)
        Me.tb_stok.Name = "tb_stok"
        Me.tb_stok.Size = New System.Drawing.Size(54, 20)
        Me.tb_stok.TabIndex = 45
        '
        'bt_add
        '
        Me.bt_add.Location = New System.Drawing.Point(15, 267)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(75, 23)
        Me.bt_add.TabIndex = 46
        Me.bt_add.Text = "Add"
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'bt_save
        '
        Me.bt_save.Location = New System.Drawing.Point(96, 267)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(75, 23)
        Me.bt_save.TabIndex = 47
        Me.bt_save.Text = "Save"
        Me.bt_save.UseVisualStyleBackColor = True
        '
        'bt_edit
        '
        Me.bt_edit.Location = New System.Drawing.Point(258, 267)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(75, 23)
        Me.bt_edit.TabIndex = 49
        Me.bt_edit.Text = "Edit"
        Me.bt_edit.UseVisualStyleBackColor = True
        '
        'bt_delete
        '
        Me.bt_delete.Location = New System.Drawing.Point(177, 267)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(75, 23)
        Me.bt_delete.TabIndex = 48
        Me.bt_delete.Text = "Delete"
        Me.bt_delete.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(604, 267)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 50
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form_Data_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 364)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.bt_delete)
        Me.Controls.Add(Me.bt_save)
        Me.Controls.Add(Me.bt_add)
        Me.Controls.Add(Me.tb_stok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_harga_jual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_harga_beli)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_jenis_barang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bt_search)
        Me.Controls.Add(Me.dgv_data_barang)
        Me.Controls.Add(Me.tb_nama_barang)
        Me.Controls.Add(Me.tb_id_barang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Data_Barang"
        Me.Text = "Form_Data_Barang"
        CType(Me.dgv_data_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_data_barang As System.Windows.Forms.DataGridView
    Friend WithEvents tb_nama_barang As System.Windows.Forms.TextBox
    Friend WithEvents tb_id_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_search As System.Windows.Forms.Button
    Friend WithEvents tb_jenis_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_harga_beli As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_harga_jual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_stok As System.Windows.Forms.TextBox
    Friend WithEvents bt_add As System.Windows.Forms.Button
    Friend WithEvents bt_save As System.Windows.Forms.Button
    Friend WithEvents bt_edit As System.Windows.Forms.Button
    Friend WithEvents bt_delete As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
