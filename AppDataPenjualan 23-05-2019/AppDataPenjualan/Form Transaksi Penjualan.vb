Public Class Form_Transaksi_Penjualan

    Dim dt_barang, dt_pelanggan As New DataTable

    Sub LoadPelanggan()
        dt_pelanggan = New DataTable
        sql = "select * from T_Pelanggan"
        dt_pelanggan = ModDB.read(sql)

        With cbx_pelanggan
            .DataSource = dt_pelanggan
            .ValueMember = "Id_Pelanggan" 'case sensitive
            .DisplayMember = "Nama"
        End With
    End Sub

    Sub LoadBarang()
        dt_barang = New DataTable
        sql = "select * from T_Barang"
        dt_barang = ModDB.read(sql)

        With cbx_kode_barang
            .DataSource = dt_barang
            .ValueMember = "Id_Barang" 'case sensitive
            .DisplayMember = "Nama"
        End With
    End Sub

    Private Sub cbx_kode_barang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_kode_barang.SelectedIndexChanged
        Try
            tb_nama_barang.Text = dt_barang.Rows(cbx_kode_barang.SelectedIndex)(1).ToString

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Form_Transaksi_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadBarang()
        LoadPelanggan()
    End Sub

    
End Class