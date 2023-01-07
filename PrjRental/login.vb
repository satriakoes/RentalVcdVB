Public Class login
    Sub tampilpelanggan(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = Sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "Pengguna")
        kon.Close()
    End Sub
    Sub prosespelanggan(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Private Sub txtusername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtusername.Text = UCase(txtusername.Text)
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btlogin.Focus()
        End If
    End Sub

    Private Sub btlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlogin.Click
        Dim dt As New DataTable
        Dim db As New Class1
        Dim perintah As String
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Harap isi username atau password anda..", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            perintah = "select Nama_User, Password from Pengguna where Nama_User='" & txtusername.Text & "' and Password='" & txtpassword.Text & "'"
            dt = db.BukaTable(perintah)
            If dt.Rows.Count > 0 Then
                frmmenu.Visible = True
                frmmenu.Enabled = True
                Me.Hide()
                'MessageBox.Show("Login Sukses...", "Pemberiahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Username atau password anda salah...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub login_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtusername.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        txtpassword.Text = ""
        txtusername.Text = ""
    End Sub
End Class