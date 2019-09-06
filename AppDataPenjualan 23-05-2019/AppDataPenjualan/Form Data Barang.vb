Public Class Form_Data_Barang
    Dim editData As Boolean
    Dim sql As String

    Sub showGrid()
        Dim dt As New DataTable
        sql = "select * from T_Barang order by Id_Barang"
        dt = ModDB.read(sql)
        dgv_data_barang.DataSource = dt
    End Sub

    Public Sub kosong()
        tb_id_barang.Text = ""
        tb_nama_barang.Text = ""
        tb_jenis_barang.Text = ""
        tb_harga_beli.Text = ""
        tb_harga_jual.Text = ""
        tb_stok.Text = ""

        dgv_data_barang.DataSource = Nothing
    End Sub

    Private Sub Form_Data_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bt_delete.Enabled = False
        bt_edit.Enabled = False
        bt_save.Enabled = False
        tb_id_barang.Enabled = False
        tb_nama_barang.Enabled = False
        tb_jenis_barang.Enabled = False
        tb_harga_beli.Enabled = False
        tb_harga_jual.Enabled = False
        tb_stok.Enabled = False
        showGrid()
        
    End Sub

    Private Sub bt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_add.Click
        bt_save.Enabled = True
        bt_edit.Enabled = True
        bt_delete.Enabled = True
        tb_id_barang.Enabled = True
        tb_nama_barang.Enabled = True
        tb_jenis_barang.Enabled = True
        tb_harga_beli.Enabled = True
        tb_harga_jual.Enabled = True
        tb_stok.Enabled = True

        tb_id_barang.Clear()
        tb_nama_barang.Clear()
        tb_jenis_barang.Clear()
        tb_harga_beli.Clear()
        tb_harga_jual.Clear()
        tb_stok.Clear()


    End Sub

    Private Sub bt_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_save.Click
        If tb_id_barang.TextLength > 0 And tb_nama_barang.TextLength > 0 Then
            Try
                If tb_id_barang.ReadOnly = False Then
                    sql = "insert into T_Barang (Id_Barang, Nama_Barang, Jenis_Barang, Harga_Beli, Harga_jual, Stok) values ('" & tb_id_barang.Text & "','" & tb_nama_barang.Text & "','" & tb_jenis_barang.Text & "', '" & tb_harga_beli.Text & "','" & tb_harga_jual.Text & "','" & tb_stok.Text & "')"
                Else


                    sql = "update Nama_Barang set Nama_Barang = '" & tb_nama_barang.Text & "',Jenis_Barang = '" & tb_jenis_barang.Text & "',Harga_Beli = '" & tb_harga_beli.Text & "', Harga_Jual ='" & tb_harga_jual.Text & "',Stock ='" & tb_stok.Text & "' where Id_Barang = " & tb_id_barang.Text & ""
                End If
                ModDB.execute(sql)
                tb_id_barang.Text = "" : tb_nama_barang.Text = "" 'kosongkan
                tb_jenis_barang.Text = ""
                tb_harga_beli.Text = ""
                tb_harga_jual.Text = ""
                tb_stok.Text = ""
                MsgBox(tb_id_barang.Text & " Disimpan!")
                showGrid()
            Catch ex As Exception
                MsgBox("Error : " & ex.Message)
            End Try
        Else
            MsgBox("Lengkapi Data")
            Exit Sub
        End If
        showGrid()
    End Sub

    Private Sub bt_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_delete.Click
        If MsgBox("Hapus data " & tb_id_barang.Text & "?", vbYesNo, "Pesan") = MsgBoxResult.Yes Then

            Try

                sql = "delete T_Barang where Id_Barang = '" & tb_id_barang.Text & "'"

                ModDB.execute(sql)

                tb_id_barang.Text = "" : tb_nama_barang.Text = "" 'kosongkan
                tb_jenis_barang.Text = ""
                tb_harga_beli.Text = ""
                tb_harga_jual.Text = ""
                tb_stok.Text = ""
                MsgBox(tb_id_barang.Text & " Dihapus!")
                showGrid()
            Catch ex As Exception
                MsgBox("Error : " & ex.Message)
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub dgv_data_barang_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_data_barang.CellClick
        Dim idx As Integer = dgv_data_barang.CurrentRow.Index

        'ambil kolom sesuai kebutuhan
        With dgv_data_barang


            tb_id_barang.Text = .Rows(idx).Cells(0).Value.ToString
            tb_nama_barang.Text = .Rows(idx).Cells(1).Value.ToString
            tb_jenis_barang.Text = .Rows(idx).Cells(2).Value.ToString
            tb_harga_beli.Text = .Rows(idx).Cells(4).Value.ToString
            tb_harga_jual.Text = .Rows(idx).Cells(5).Value.ToString
            tb_stok.Text = .Rows(idx).Cells(6).Value.ToString
            'kunci id bahannya agar tak dapat diubah

        End With
    End Sub

    Private Sub bt_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_edit.Click
        Try
            Dim HB As Integer = tb_harga_beli.Text.Substring(0, tb_harga_beli.TextLength - 5)
            Dim HJ As Integer = tb_harga_jual.Text.Substring(0, tb_harga_jual.TextLength - 5)

            sql = "update T_Barang set Nama_Barang ='" & tb_nama_barang.Text & "', Jenis_Barang ='" & tb_jenis_barang.Text & "', Harga_Beli =" & HB & ", Harga_Jual =" & HJ & ", Stok='" & tb_stok.Text & "' where Id_Barang = '" & tb_id_barang.Text & "'"
            ModDB.execute(sql)

            kosong()
            showGrid()

            MsgBox(tb_id_barang.Text & " Diedit!")
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub bt_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_search.Click
        Dim dt As New DataTable
        sql = "select * from T_Barang where Id_Barang like'%" & tb_id_barang.Text & "%' order by Id_Barang"
        dt = ModDB.read(sql)
        dgv_data_barang.DataSource = dt
    End Sub

    
End Class