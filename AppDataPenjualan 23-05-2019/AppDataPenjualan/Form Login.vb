Public Class Form1

    Private Sub bt_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_login.Click
        'Try
        'Dim sql, username As String
        'sql = "select username from pengguna where username = '" & tb_username.Text & "' and password = '" & tb_password.Text & "'"

        '        username = ModDB.readOnce(sql)
        If tb_username.Text = "admin" And tb_password.Text = "admin" Then

            MsgBox("Welcome!!")
            Form_Menu.Show()
            Me.Hide()
        Else

            '        If username = Nothing Then
            'MsgBox("Maaf " & tb_username.Text & " Belum Terdaftar")
            'Else

        End If
        'Catch ex As Exception
        ' Console.WriteLine(ex.Message)
        ' End Try
    End Sub

    Private Sub bt_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_close.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
