Public Class Form_Data_Pelanggan

    Sub showGrid()
        Dim dt As New DataTable
        sql = "select * from T_Pelanggan order by Id_Pelanggan"
        dt = ModDB.read(sql)
        dgv_data_pelanggan.DataSource = dt
    End Sub

    Private Sub dgv_data_barang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_data_pelanggan.CellClick
        Dim idx As Integer = dgv_data_pelanggan.CurrentRow.Index

        'ambil kolom sesuai kebutuhan
        With dgv_data_pelanggan

            tb_id_pelanggan.Text = .Rows(idx).Cells(0).Value.ToString
            tb_nama_pelanggan.Text = .Rows(idx).Cells(1).Value.ToString
            tb_alamat.Text = .Rows(idx).Cells(2).Value.ToString
            tb_telepon.Text = .Rows(idx).Cells(4).Value.ToString
            tb_email.Text = .Rows(idx).Cells(5).Value.ToString
            'kunci id bahannya agar tak dapat diubah

        End With
    End Sub

    
    Private Sub Form_Data_Pelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showgrid()
    End Sub
End Class