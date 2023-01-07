Public Class frmvcd
        Sub tampilvcd(ByVal sql As String)
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = sql
            mda.SelectCommand = perintah
            ds.Tables.Clear()
            mda.Fill(ds, "Vcd")
            dgvcd.DataSource = (ds.Tables("Vcd"))
            kon.Close()
        End Sub
        Sub tampiltype()
            cmbtype.Items.Clear()
        kon.Open()
        perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select Type_Film from Type order by No"
            cek = perintah.ExecuteReader
            While cek.Read
                cmbtype.Items.Add(cek.Item("Type_Film"))
            End While
            cek.Close()
            kon.Close()
        End Sub
        Sub tampilkategori()
            cmbkategori.Items.Clear()
        kon.Open()
        perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select Kategori_Film from Kategori order by No"
            cek = perintah.ExecuteReader
            While cek.Read
                cmbkategori.Items.Add(cek.Item("Kategori_Film"))
            End While
            cek.Close()
            kon.Close()
        End Sub
        Sub prosesvcd(ByVal sql As String)
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = sql
            perintah.ExecuteNonQuery()
            kon.Close()
        End Sub
        Sub setdatagrid()
            dgvcd.Columns(0).HeaderText = "KODE FILM"
            dgvcd.Columns(1).HeaderText = "JUDUL FILM"
            dgvcd.Columns(2).HeaderText = "NEGARA ASAL"
            dgvcd.Columns(3).HeaderText = "TYPE FILM"
            dgvcd.Columns(4).HeaderText = "KATEGORI FILM"
            dgvcd.Columns(5).HeaderText = "STOCK"

            dgvcd.Columns(0).Width = 70
            dgvcd.Columns(1).Width = 300
            dgvcd.Columns(2).Width = 200
            dgvcd.Columns(3).Width = 100
            dgvcd.Columns(4).Width = 100
            dgvcd.Columns(5).Width = 70

        End Sub


        Sub tidakaktif()
            txtkode.Enabled = False
            txtjudul.Enabled = False
            txtnegara.Enabled = False
            cmbtype.Enabled = False
            cmbkategori.Enabled = False
            txtstock.Enabled = False
            btsimpan.Enabled = False
            btbatal.Enabled = False
            bthapus.Enabled = False
            btedit.Enabled = False
            btkategori.Enabled = False
            bttype.Enabled = False
            txtkode.BackColor = Color.Gray
            txtjudul.BackColor = Color.Gray
            cmbtype.BackColor = Color.Gray
            txtstock.BackColor = Color.Gray
        End Sub
        Sub aktif()
            txtkode.Enabled = True
            txtjudul.Enabled = True
            txtnegara.Enabled = True
            cmbtype.Enabled = True
            cmbkategori.Enabled = True
            txtstock.Enabled = True
            btkategori.Enabled = True
            bttype.Enabled = True

            txtkode.BackColor = Color.White
            txtjudul.BackColor = Color.White
            cmbtype.BackColor = Color.White
            txtstock.BackColor = Color.White
        End Sub
    Sub bersih()
        txtkode.Text = ""
        txtjudul.Text = ""
        txtnegara.Text = ""
        cmbtype.Text = "--Pilih Type--"
        cmbkategori.Text = "--Pilih Kategori--"
        txtstock.Text = ""
        txtcari.Text = ""
    End Sub


        Private Sub frmvcd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilvcd("select * from vcd")
        setdatagrid()
        tidakaktif()
        bersih()
        tampiltype()
        tampilkategori()
        End Sub

    Private Sub btkategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkategori.Click
        frmkategori.Show()
    End Sub

    Private Sub bttype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttype.Click
        frmtype.Show()
    End Sub

    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        Me.Dispose()
    End Sub

    
    Private Sub txtkode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtkode.Text = "" Then
                MsgBox("Data Kode Tidak Boleh Kosong", MsgBoxStyle.Critical, "WARNING!!!")
            Else
                txtkode.Text = UCase(txtkode.Text)
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "select * from Vcd WHERE Kode='" & txtkode.Text & "'"

                cek = perintah.ExecuteReader
                cek.Read()
                If cek.HasRows Then
                    aktif()
                    txtkode.Enabled = False
                    txtjudul.Text = cek.Item("Judul_Film")
                    txtnegara.Text = cek.Item("Negara")
                    cmbtype.Text = cek.Item("Type_Film")
                    cmbkategori.Text = cek.Item("Kategori_Film")
                    txtstock.Text = cek.Item("Stock")
                    btedit.Enabled = True
                    btsimpan.Enabled = False
                Else
                    txtjudul.Enabled = True
                    txtjudul.BackColor = Color.White
                    txtjudul.Focus()

                End If
                cek.Close()
                kon.Close()


            End If

        End If

    End Sub

    Private Sub txtjudul_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjudul.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtjudul.Text = "" Then
                MsgBox("Data Judul Film Tidak Boleh Kosong", MsgBoxStyle.Critical, "WARNING!!!")
            Else
                txtjudul.Text = UCase(txtjudul.Text)
                txtnegara.Enabled = True
                txtnegara.BackColor = Color.White
                txtnegara.Focus()
                bttype.Enabled = True
                btkategori.Enabled = True
            End If

        End If

    End Sub

    Private Sub txtnegara_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnegara.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtnegara.Text = "" Then
                MsgBox("Data Negara Tidak Boleh Kosong", MsgBoxStyle.Critical, "WARNING!!!")
            Else
                txtnegara.Text = UCase(txtnegara.Text)
                cmbtype.Enabled = True
                cmbtype.BackColor = Color.White
                cmbkategori.Enabled = True
                cmbkategori.BackColor = Color.White
                txtstock.Enabled = True
                txtstock.BackColor = Color.White
                cmbtype.Focus()

            End If

        End If

    End Sub

    Private Sub cmbtype_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtype.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbkategori.Focus()
            cmbkategori.Enabled = True
            cmbkategori.BackColor = Color.White
        End If

    End Sub

    Private Sub cmbkategori_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbkategori.KeyPress
        If e.KeyChar = Chr(13) Then

            txtstock.Focus()
        End If

    End Sub

    Private Sub txtstock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstock.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtstock.Text = "" Then
                MsgBox("Stock Tidak Boleh Kosong", MsgBoxStyle.Critical, "WARNING!!!")
            ElseIf btsimpan.Enabled = False Then
                txtstock.Text = UCase(txtstock.Text)
                btedit.Focus()
            Else
                txtstock.Text = UCase(txtstock.Text)
                btsimpan.Focus()
            End If

        End If

    End Sub

    Private Sub bttambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttambah.Click
        bersih()
        txtkode.Enabled = True
        txtkode.BackColor = Color.White
        txtkode.Focus()
        'pilihan()'
        bttambah.Enabled = False
        btbatal.Enabled = True
        btsimpan.Enabled = True
        bthapus.Enabled = False

    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        prosesvcd("insert into Vcd values('" & txtkode.Text & "','" & txtjudul.Text & "','" & txtnegara.Text & "','" & cmbtype.Text & "','" & cmbkategori.Text & "','" & txtstock.Text & "')")
        MsgBox("Data Telah Tersimpan", MsgBoxStyle.Information, "Informasi")

        tampilvcd("select* from Vcd")
        setdatagrid()
        bersih()
        tidakaktif()
        btsimpan.Enabled = False
        bttambah.Enabled = True
        bttambah.Focus()

    End Sub

    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        prosesvcd("delete from Vcd where Kode='" & txtkode.Text & "'")
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
        tampilvcd("select* from Vcd")
        setdatagrid()
        bttambah.Enabled = True
        bersih()
        tidakaktif()

    End Sub

    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        bttambah.Enabled = True
        btbatal.Enabled = False
        bttambah.Focus()
        bthapus.Enabled = False
        bersih()
        tidakaktif()
        btsimpan.Enabled = False

    End Sub

    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        prosesvcd("update Vcd set Judul_Film='" & txtjudul.Text & "',Negara='" & txtnegara.Text & "',Type_Film='" & cmbtype.Text & "',Kategori_Film='" & cmbkategori.Text & "' ,Stock='" & txtstock.Text & "'where Kode='" & txtkode.Text & "'")
        MsgBox("Data Telah Diperbahrui", MsgBoxStyle.Information, "Informasi")

        tampilvcd("select* from Vcd")
        setdatagrid()
        bersih()
        tidakaktif()
        btsimpan.Enabled = False
        bttambah.Enabled = True

    End Sub

 
    Private Sub dgvcd_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcd.CellClick
        aktif()
        'pilihan()’
        bersih()
        txtkode.Enabled = False
        Dim i As Integer
        i = Me.dgvcd.CurrentRow.Index
        With dgvcd.Rows.Item(i)

            txtkode.Text = .Cells(0).Value
            txtjudul.Text = .Cells(1).Value
            txtnegara.Text = .Cells(2).Value
            cmbtype.Text = .Cells(3).Value
            cmbkategori.Text = .Cells(4).Value
            txtstock.Text = .Cells(5).Value
            txtjudul.Focus()
            bthapus.Enabled = True
            btsimpan.Enabled = False
            btbatal.Enabled = True
            bttambah.Enabled = False
            btedit.Enabled = True
            bttype.Enabled = True
            btkategori.Enabled = True

        End With

    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        tampilvcd("SELECT * from Vcd WHERE Kode like '%" & txtcari.Text & "%' or Judul_Film like '%" & txtcari.Text & "%'or Negara like '%" & txtcari.Text & "%'")

        setdatagrid()
    End Sub
End Class