Imports MySql.Data.MySqlClient
Public Class Class1
    Dim conn As MySqlConnection
    Dim dr As MySqlDataReader
    Dim cmd As MySqlCommand
    Dim dt As New DataTable
    Dim strkoneksi As String = "server=localhost;uid=root;database=rentalvcd;"
    Public Function BukaTable(ByVal strperintah As String) As DataTable
        conn = New MySqlConnection(strkoneksi)
        Try
            conn.Open()
            cmd = New MySqlCommand(strperintah, conn)
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        dt.Load(dr)
        dr.Close()
        conn.Close()
        Return dt
    End Function
End Class
