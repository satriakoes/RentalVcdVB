Public Class frmuser
    Sub tampilpengguna(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "Pengguna")
        dgpengguna.DataSource = (ds.Tables("Pengguna"))
        kon.Close()
    End Sub
    Sub prosespengguna(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Sub setdatagrid()
        dgpengguna.Columns(0).HeaderText = "Id User"
        dgpengguna.Columns(1).HeaderText = "NAMA"
        dgpengguna.Columns(2).HeaderText = "Status"
        dgpengguna.Columns(3).HeaderText = "Password"

        dgpengguna.Columns(0).Width = 70
        dgpengguna.Columns(1).Width = 100
        dgpengguna.Columns(2).Width = 200
        dgpengguna.Columns(3).Width = 100
    End Sub
    Sub tidakaktif()
        txtid.Enabled = False
        txtuser.Enabled = False
        cmbpilihan.Enabled = False
        txtpassword.Enabled = False
        btnsimpan.Enabled = False
        btnbatal.Enabled = False
        btnhapus.Enabled = False
        btnedit.Enabled = False
        txtid.BackColor = Color.Gray
        txtuser.BackColor = Color.Gray
        cmbpilihan.BackColor = Color.Gray
        txtpassword.BackColor = Color.Gray
    End Sub
    Sub aktif()
        txtid.Enabled = True
        txtuser.Enabled = True
        cmbpilihan.Enabled = True
        txtpassword.Enabled = True
        txtid.BackColor = Color.White
        txtuser.BackColor = Color.White
        cmbpilihan.BackColor = Color.White
        txtpassword.BackColor = Color.White
    End Sub
    Sub bersih()
        txtid.Text = ""
        txtuser.Text = ""
        cmbpilihan.Text = ""
        txtpassword.Text = ""
    End Sub
    Private Sub frmuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilpengguna("select * from pengguna")
        setdatagrid()
        tidakaktif()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub txtid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        If e.KeyChar = Chr(13) Then
            txtid.Text = UCase(txtid.Text)
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select * from Pengguna WHERE Id_User='" &
            txtid.Text & "'"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                txtid.Enabled = False
                txtid.Text = cek.Item("Id User")
                txtuser.Text = cek.Item("Nama User")
                cmbpilihan = cek.Item("Status User")
                txtpassword.Text = cek.Item("Password")
                btnedit.Enabled = True
                btnsimpan.Enabled = False
            Else
                btnsimpan.Enabled = True
            End If
            cek.Close()
            kon.Close()
            aktif()
            txtuser.Focus()
        End If
    End Sub

    Private Sub frmuser_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        tidakaktif()
        bersih()
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtuser.Text = UCase(txtuser.Text)
            cmbpilihan.Focus()
        End If
    End Sub

    Private Sub cmbpilihan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbpilihan.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbpilihan.Items.Add("Admin")
            cmbpilihan.Items.Add("User")
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpassword.Text = UCase(txtpassword.Text)
            btnsimpan.Focus()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        bersih()
        aktif()

        btntambah.Enabled = False
        btnbatal.Enabled = True
        btnsimpan.Enabled = True
        btnHapus.Enabled = False
        txtid.Focus()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        prosespengguna("insert into pengguna values('" & txtid.Text & "','" &
                        txtuser.Text & "','" & cmbpilihan.Text & "','" & txtpassword.Text & "')")
        MsgBox("Data Telah Tersimpan", MsgBoxStyle.Information, "Informasi")

        tampilpengguna("select* from pengguna")
        setdatagrid()
        bersih()
        tidakaktif()
        btnsimpan.Enabled = False
        btntambah.Enabled = True
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        prosespengguna("update pengguna set Nama_User='" & txtuser.Text & "',Status_User='" &
                        cmbpilihan.Text & "',Password='" & txtpassword.Text & "' where Id_User='" & txtid.Text & "'")
        MsgBox("Data Telah Diperbahrui", MsgBoxStyle.Information, "Informasi")

        tampilpengguna("select* from pengguna")
        setdatagrid()
        bersih()
        tidakaktif()
        btnsimpan.Enabled = False
        btntambah.Enabled = True
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        prosespengguna("delete from pengguna where Id_User='" & txtid.Text & "'")

        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
        tampilpengguna("select* from pengguna")
        setdatagrid()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        btntambah.Enabled = True
        btnbatal.Enabled = False
        btntambah.Focus()
        btnHapus.Enabled = False
        bersih()
        tidakaktif()
        btnsimpan.Enabled = False
    End Sub

    Private Sub dgpengguna_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpengguna.CellClick
        aktif()
        txtid.Enabled = False
        Dim i As Integer
        i = Me.dgpengguna.CurrentRow.Index
        With dgpengguna.Rows.Item(i)
            txtid.Text = .Cells(0).Value
            txtuser.Text = .Cells(1).Value
            cmbpilihan.Text = .Cells(2).Value
            txtpassword.Text = .Cells(3).Value
            txtid.Focus()
            btnHapus.Enabled = True
            btnsimpan.Enabled = False
            btnbatal.Enabled = True
            btntambah.Enabled = False
            btnedit.Enabled = True
        End With
    End Sub
End Class