<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Pelanggan
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
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_telepon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_search = New System.Windows.Forms.Button()
        Me.tb_nama_pelanggan = New System.Windows.Forms.TextBox()
        Me.tb_id_pelanggan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_data_pelanggan = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.bt_edit = New System.Windows.Forms.Button()
        Me.bt_delete = New System.Windows.Forms.Button()
        Me.bt_save = New System.Windows.Forms.Button()
        Me.bt_add = New System.Windows.Forms.Button()
        CType(Me.dgv_data_pelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_email
        '
        Me.tb_email.Location = New System.Drawing.Point(427, 53)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(254, 20)
        Me.tb_email.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "E-Mail"
        '
        'tb_telepon
        '
        Me.tb_telepon.Location = New System.Drawing.Point(425, 21)
        Me.tb_telepon.Name = "tb_telepon"
        Me.tb_telepon.Size = New System.Drawing.Size(256, 20)
        Me.tb_telepon.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Telepon"
        '
        'tb_alamat
        '
        Me.tb_alamat.Location = New System.Drawing.Point(110, 86)
        Me.tb_alamat.Multiline = True
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(192, 50)
        Me.tb_alamat.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Alamat"
        '
        'bt_search
        '
        Me.bt_search.Location = New System.Drawing.Point(227, 24)
        Me.bt_search.Name = "bt_search"
        Me.bt_search.Size = New System.Drawing.Size(75, 23)
        Me.bt_search.TabIndex = 50
        Me.bt_search.Text = "Search"
        Me.bt_search.UseVisualStyleBackColor = True
        '
        'tb_nama_pelanggan
        '
        Me.tb_nama_pelanggan.Location = New System.Drawing.Point(110, 56)
        Me.tb_nama_pelanggan.Name = "tb_nama_pelanggan"
        Me.tb_nama_pelanggan.Size = New System.Drawing.Size(192, 20)
        Me.tb_nama_pelanggan.TabIndex = 49
        '
        'tb_id_pelanggan
        '
        Me.tb_id_pelanggan.Location = New System.Drawing.Point(110, 25)
        Me.tb_id_pelanggan.Name = "tb_id_pelanggan"
        Me.tb_id_pelanggan.Size = New System.Drawing.Size(100, 20)
        Me.tb_id_pelanggan.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "ID Pelanggan"
        '
        'dgv_data_pelanggan
        '
        Me.dgv_data_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_pelanggan.Location = New System.Drawing.Point(18, 160)
        Me.dgv_data_pelanggan.Name = "dgv_data_pelanggan"
        Me.dgv_data_pelanggan.Size = New System.Drawing.Size(667, 127)
        Me.dgv_data_pelanggan.TabIndex = 59
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(606, 293)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 64
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'bt_edit
        '
        Me.bt_edit.Location = New System.Drawing.Point(260, 293)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(75, 23)
        Me.bt_edit.TabIndex = 63
        Me.bt_edit.Text = "Edit"
        Me.bt_edit.UseVisualStyleBackColor = True
        '
        'bt_delete
        '
        Me.bt_delete.Location = New System.Drawing.Point(179, 293)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(75, 23)
        Me.bt_delete.TabIndex = 62
        Me.bt_delete.Text = "Delete"
        Me.bt_delete.UseVisualStyleBackColor = True
        '
        'bt_save
        '
        Me.bt_save.Location = New System.Drawing.Point(98, 293)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(75, 23)
        Me.bt_save.TabIndex = 61
        Me.bt_save.Text = "Save"
        Me.bt_save.UseVisualStyleBackColor = True
        '
        'bt_add
        '
        Me.bt_add.Location = New System.Drawing.Point(17, 293)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(75, 23)
        Me.bt_add.TabIndex = 60
        Me.bt_add.Text = "Add"
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'Form_Data_Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 370)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.bt_delete)
        Me.Controls.Add(Me.bt_save)
        Me.Controls.Add(Me.bt_add)
        Me.Controls.Add(Me.dgv_data_pelanggan)
        Me.Controls.Add(Me.tb_email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_telepon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bt_search)
        Me.Controls.Add(Me.tb_nama_pelanggan)
        Me.Controls.Add(Me.tb_id_pelanggan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Data_Pelanggan"
        Me.Text = "Form_Data_Pelanggan"
        CType(Me.dgv_data_pelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_email As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_telepon As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_alamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_search As System.Windows.Forms.Button
    Friend WithEvents tb_nama_pelanggan As System.Windows.Forms.TextBox
    Friend WithEvents tb_id_pelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_data_pelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents bt_edit As System.Windows.Forms.Button
    Friend WithEvents bt_delete As System.Windows.Forms.Button
    Friend WithEvents bt_save As System.Windows.Forms.Button
    Friend WithEvents bt_add As System.Windows.Forms.Button
End Class
