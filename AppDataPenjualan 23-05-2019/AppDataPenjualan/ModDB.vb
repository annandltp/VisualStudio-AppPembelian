Imports System.Data
Imports System.Data.SqlClient

Module ModDB
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public rd As SqlDataReader
    Public adp As New SqlDataAdapter
    Public sql As String
    'Created by Anandela
    Public Sub open()
        Dim connStr As String = "server=B43-PC; " & _
            "Database=DataPenjualan; " & _
            "Trusted_connection = true;"

        conn = New SqlConnection(connStr)

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub

    Public Sub close()
        conn.Close()
    End Sub

    Public Sub execute(ByVal sql As String)
        '1.insert
        '2. update
        '3. delete
        Try
            open()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("DB Error: " & ex.Message)
        Finally
            close()
        End Try
    End Sub

    Public Function read(ByVal sql As String) As DataTable
        '1. select
        Try
            Dim data As DataTable

            open()
            cmd = New SqlCommand(sql, conn)
            rd = cmd.ExecuteReader

            data = New DataTable
            data.Load(rd)

            Return data
        Catch ex As Exception
            MsgBox("DB Error: " & ex.Message)
        Finally
            close()
        End Try

        Return Nothing
    End Function

    Public Function readOnce(ByVal sql As String) As String
        '1. select satu data saja
        Try

            open()
            cmd = New SqlCommand(sql, conn)
            rd = cmd.ExecuteReader

            rd.Read()
            If rd.HasRows Then
                Return rd(0).ToString
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("DB Error: " & ex.Message)
        Finally
            close()
        End Try

        Return Nothing
    End Function
End Module
