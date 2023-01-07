Public Class frmkategori
    Sub tampilkategori(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "Kategori")
        dgkategori.DataSource = (ds.Tables("Kategori"))
        kon.Close()
    End Sub
    Sub proseskategori(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Sub setdatagrid()
        dgkategori.Columns(0).HeaderText = "NO"
        dgkategori.Columns(1).HeaderText = "KATEGORI"


        dgkategori.Columns(0).Width = 70
        dgkategori.Columns(1).Width = 300
    End Sub
    Sub bersih()
        txtkategori.Text = ""
        txtno.Text = ""
        txtno.Enabled = False
    End Sub
    Private Sub frmkategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilkategori("select * from Kategori")
        setdatagrid()
    End Sub

    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        frmvcd.tampilkategori()
        frmvcd.Focus()
        frmvcd.cmbtype.Focus()
        Me.Dispose()
    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        If btsimpan.Text = "Update" Then
            proseskategori("update Kategori set Kategori_Film='" & txtkategori.Text & "' where No='" & txtno.Text & "'")
            MsgBox("Data Telah Diperbahrui", MsgBoxStyle.Information, "Informasi")
        Else
            If txtkategori.Text = "" Then
                MsgBox("Type Tidak Boleh Kosong", MsgBoxStyle.Critical, "PESAN")
                txtkategori.Focus()
            Else
                proseskategori("insert into Kategori values('" & txtno.Text & "','" & txtkategori.Text & "')")
                MsgBox("Data Telah Tersimpan", MsgBoxStyle.Information, "Informasi")
            End If
        End If
        tampilkategori("select* from Kategori")
        setdatagrid()
        bersih()
    End Sub

    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        proseskategori("delete from Kategori where No='" & txtno.Text & "'")
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
        tampilkategori("select* from Kategori")
        setdatagrid()
        bersih()
    End Sub

    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        btsimpan.Text = "Simpan"
        bersih()
        txtno.Enabled = False
        txtkategori.Focus()
    End Sub

    Private Sub dgkategori_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgkategori.CellClick
        bersih()
        txtno.Enabled = False
        Dim i As Integer
        i = Me.dgkategori.CurrentRow.Index
        With dgkategori.Rows.Item(i)
            txtno.Text = .Cells(0).Value
            txtkategori.Text = .Cells(1).Value
            btsimpan.Text = "Update"
            txtkategori.Focus()
            bthapus.Enabled = True

        End With
    End Sub

    Private Sub txtkategori_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkategori.KeyPress
        If e.KeyChar = Chr(13) Then
            txtkategori.Text = UCase(txtkategori.Text)
            btsimpan.Focus()
        End If
    End Sub
End Class