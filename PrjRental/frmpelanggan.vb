Public Class frmpelanggan
    Sub tampilpelanggan(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "Pelanggan")
        dgpelanggan.DataSource = (ds.Tables("Pelanggan"))
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
    Sub setdatagrid()
        dgpelanggan.Columns(0).HeaderText = "ID"
        dgpelanggan.Columns(1).HeaderText = "NAMA"
        dgpelanggan.Columns(2).HeaderText = "ALAMAT"
        dgpelanggan.Columns(3).HeaderText = "NO.HP"

        dgpelanggan.Columns(0).Width = 70
        dgpelanggan.Columns(1).Width = 100
        dgpelanggan.Columns(2).Width = 200
        dgpelanggan.Columns(3).Width = 100
    End Sub
    Sub tidakaktif()
        txtid.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txthp.Enabled = False
        btnsimpan.Enabled = False
        btnbatal.Enabled = False
        btnhapus.Enabled = False
        btnedit.Enabled = False
        txtid.BackColor = Color.Gray
        txtnama.BackColor = Color.Gray
        txtalamat.BackColor = Color.Gray
        txthp.BackColor = Color.Gray
    End Sub
    Sub aktif()
        txtid.Enabled = True
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txthp.Enabled = True
        txtid.BackColor = Color.White
        txtnama.BackColor = Color.White
        txtalamat.BackColor = Color.White
        txthp.BackColor = Color.White
    End Sub
    Sub bersih()
        txtid.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txthp.Text = ""
        txtcari.Text = ""
    End Sub


    Private Sub frmpelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilpelanggan("select * from Pelanggan")
        setdatagrid()
        tidakaktif()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub frmpelanggan_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        tidakaktif()
        bersih()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        bersih()
        aktif()

        btntambah.Enabled = False
        btnbatal.Enabled = True
        btnsimpan.Enabled = True
        btnhapus.Enabled = False
        txtid.Focus()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        btntambah.Enabled = True
        btnbatal.Enabled = False
        btntambah.Focus()
        btnhapus.Enabled = False
        bersih()
        tidakaktif()
        btnsimpan.Enabled = False
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        prosespelanggan("insert into pelanggan values('" & txtid.Text & "','" &
                        txtnama.Text & "','" & txtalamat.Text & "','" & txthp.Text & "')")
        MsgBox("Data Telah Tersimpan", MsgBoxStyle.Information, "Informasi")

        tampilpelanggan("select* from pelanggan")
        setdatagrid()
        bersih()
        tidakaktif()
        btnsimpan.Enabled = False
        btntambah.Enabled = True
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        prosespelanggan("delete from Pelanggan where Id_Pelanggan='" & txtid.Text & "'")

        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
        tampilpelanggan("select* from Pelanggan")
        setdatagrid()
    End Sub

    Private Sub txtid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        If e.KeyChar = Chr(13) Then
            txtid.Text = UCase(txtid.Text)
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select * from Pelanggan WHERE Id_Pelanggan='" &
            txtid.Text & "'"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                txtid.Enabled = False
                txtnama.Text = cek.Item("Nama")
                txtalamat.Text = cek.Item("Alamat")
                txthp.Text = cek.Item("No_Hp")
                btnedit.Enabled = True
                btnsimpan.Enabled = False
            Else
                btnsimpan.Enabled = True
            End If
            cek.Close()
            kon.Close()
            aktif()
            txtnama.Focus()
        End If

    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtnama.Text = UCase(txtnama.Text)
            txtalamat.Focus()
        End If
    End Sub

    Private Sub txtalamat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtalamat.KeyPress
        If e.KeyChar = Chr(13) Then
            txthp.Focus()
        End If
    End Sub

    Private Sub txthp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthp.KeyPress
        If e.KeyChar = Chr(13) Then
            btnsimpan.Focus()
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        prosespelanggan("update Pelanggan set Nama='" & txtnama.Text & "',Alamat='" &
                        txtalamat.Text & "',No_Hp='" & txthp.Text & "' where Id_Pelanggan='" & txtid.Text & "'")
        MsgBox("Data Telah Diperbahrui", MsgBoxStyle.Information, "Informasi")

        tampilpelanggan("select* from pelanggan")
        setdatagrid()
        bersih()
        tidakaktif()
        btnsimpan.Enabled = False
        btntambah.Enabled = True
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        txtcari.Text = UCase(txtcari.Text)
        tampilpelanggan("SELECT * from Pelanggan WHERE Id_Pelanggan like '%" &
        txtcari.Text & "%' or Nama like '%" & txtcari.Text & "%'")
        setdatagrid()
    End Sub

    Private Sub dgpelanggan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpelanggan.CellClick
        aktif()
        txtid.Enabled = False
        Dim i As Integer
        i = Me.dgpelanggan.CurrentRow.Index
        With dgpelanggan.Rows.Item(i)
            txtid.Text = .Cells(0).Value
            txtnama.Text = .Cells(1).Value
            txtalamat.Text = .Cells(2).Value
            txthp.Text = .Cells(3).Value
            txtid.Focus()
            btnhapus.Enabled = True
            btnsimpan.Enabled = False
            btnbatal.Enabled = True
            btntambah.Enabled = False
            btnedit.Enabled = True
        End With

    End Sub

End Class
