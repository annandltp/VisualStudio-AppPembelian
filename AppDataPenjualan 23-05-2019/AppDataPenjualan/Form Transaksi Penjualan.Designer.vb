<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Transaksi_Penjualan
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv_barang = New System.Windows.Forms.DataGridView()
        Me.tb_id_barang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbx_kode_barang = New System.Windows.Forms.ComboBox()
        Me.cbx_pelanggan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_nama_barang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_harga_jual = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_sub = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_jumlah = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_diskon = New System.Windows.Forms.TextBox()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Nama Supplier"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv_barang
        '
        Me.dgv_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barang.Location = New System.Drawing.Point(12, 170)
        Me.dgv_barang.Name = "dgv_barang"
        Me.dgv_barang.Size = New System.Drawing.Size(667, 127)
        Me.dgv_barang.TabIndex = 55
        '
        'tb_id_barang
        '
        Me.tb_id_barang.Location = New System.Drawing.Point(97, 13)
        Me.tb_id_barang.Name = "tb_id_barang"
        Me.tb_id_barang.Size = New System.Drawing.Size(100, 20)
        Me.tb_id_barang.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Tanggal Faktur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "No Faktur"
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.Location = New System.Drawing.Point(97, 46)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(192, 20)
        Me.dtp_tanggal.TabIndex = 70
        '
        'cbx_kode_barang
        '
        Me.cbx_kode_barang.FormattingEnabled = True
        Me.cbx_kode_barang.Location = New System.Drawing.Point(18, 136)
        Me.cbx_kode_barang.Name = "cbx_kode_barang"
        Me.cbx_kode_barang.Size = New System.Drawing.Size(90, 21)
        Me.cbx_kode_barang.TabIndex = 71
        '
        'cbx_pelanggan
        '
        Me.cbx_pelanggan.FormattingEnabled = True
        Me.cbx_pelanggan.Location = New System.Drawing.Point(97, 72)
        Me.cbx_pelanggan.Name = "cbx_pelanggan"
        Me.cbx_pelanggan.Size = New System.Drawing.Size(192, 21)
        Me.cbx_pelanggan.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Kode Barang"
        '
        'tb_nama_barang
        '
        Me.tb_nama_barang.Location = New System.Drawing.Point(114, 137)
        Me.tb_nama_barang.Name = "tb_nama_barang"
        Me.tb_nama_barang.Size = New System.Drawing.Size(90, 20)
        Me.tb_nama_barang.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Nama Barang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Harga Jual"
        '
        'tb_harga_jual
        '
        Me.tb_harga_jual.Location = New System.Drawing.Point(213, 137)
        Me.tb_harga_jual.Name = "tb_harga_jual"
        Me.tb_harga_jual.Size = New System.Drawing.Size(90, 20)
        Me.tb_harga_jual.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(408, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Sub Total"
        '
        'tb_sub
        '
        Me.tb_sub.Location = New System.Drawing.Point(411, 137)
        Me.tb_sub.Name = "tb_sub"
        Me.tb_sub.Size = New System.Drawing.Size(90, 20)
        Me.tb_sub.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(309, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Jumlah"
        '
        'tb_jumlah
        '
        Me.tb_jumlah.Location = New System.Drawing.Point(312, 137)
        Me.tb_jumlah.Name = "tb_jumlah"
        Me.tb_jumlah.Size = New System.Drawing.Size(90, 20)
        Me.tb_jumlah.TabIndex = 78
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(507, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Discount"
        '
        'tb_diskon
        '
        Me.tb_diskon.Location = New System.Drawing.Point(510, 137)
        Me.tb_diskon.Name = "tb_diskon"
        Me.tb_diskon.Size = New System.Drawing.Size(90, 20)
        Me.tb_diskon.TabIndex = 82
        '
        'tb_total
        '
        Me.tb_total.Location = New System.Drawing.Point(496, 303)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.Size = New System.Drawing.Size(183, 20)
        Me.tb_total.TabIndex = 85
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(459, 306)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Total"
        '
        'Form_Transaksi_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 414)
        Me.Controls.Add(Me.tb_total)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_diskon)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tb_sub)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tb_jumlah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_harga_jual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_nama_barang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbx_pelanggan)
        Me.Controls.Add(Me.cbx_kode_barang)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_barang)
        Me.Controls.Add(Me.tb_id_barang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Transaksi_Penjualan"
        Me.Text = "Form_Transaksi_Penjualan"
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgv_barang As System.Windows.Forms.DataGridView
    Friend WithEvents tb_id_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbx_kode_barang As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_pelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_nama_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_harga_jual As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_sub As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_diskon As System.Windows.Forms.TextBox
    Friend WithEvents tb_total As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
