Public Class Form_Menu

    Private Sub Form_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem.Click
        Form_Data_Barang.Show()
        Form_Data_Barang.MdiParent = Me
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPelangganToolStripMenuItem.Click
        Form_Data_Pelanggan.Show()
        Form_Data_Pelanggan.MdiParent = Me
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        Form_Transaksi_Penjualan.Show()
        Form_Transaksi_Penjualan.MdiParent = Me
    End Sub
End Class