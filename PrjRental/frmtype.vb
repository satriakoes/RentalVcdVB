Public Class frmtype
    Sub tampiltype(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "Type")
        dgtype.DataSource = (ds.Tables("Type"))
        kon.Close()
    End Sub
    Sub prosestype(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Sub setdatagrid()
        dgtype.Columns(0).HeaderText = "NO"
        dgtype.Columns(1).HeaderText = "TYPE FILM"


        dgtype.Columns(0).Width = 70
        dgtype.Columns(1).Width = 300
    End Sub
    Sub bersih()
        txttype.Text = ""
        txtno.Text = ""
        txtno.Enabled = False
    End Sub

    Private Sub frmtype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampiltype("select * from Type")
        setdatagrid()

    End Sub

    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        frmvcd.tampiltype()
        frmvcd.Focus()
        frmvcd.cmbtype.Focus()
        Me.Dispose()
    End Sub

    Private Sub frmtype_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        If btsimpan.Text = "Update" Then
            prosestype("update Type set Type_Film='" & txttype.Text & "' where No='" & txtno.Text & "'")
            MsgBox("Data Telah Diperbahrui", MsgBoxStyle.Information, "Informasi")
        Else
            If txttype.Text = "" Then
                MsgBox("Type Tidak Boleh Kosong", MsgBoxStyle.Critical, "PESAN")
                txttype.Focus()
            Else
                prosestype("insert into Type values('" & txtno.Text & "','" & txttype.Text & "')")
                MsgBox("Data Telah Tersimpan", MsgBoxStyle.Information, "Informasi")
            End If
        End If
        tampiltype("select* from Type")
        setdatagrid()
        bersih()

    End Sub

    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        prosestype("delete from Type where No='" & txtno.Text & "'")
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
        tampiltype("select* from Type")
        setdatagrid()
        bersih()
    End Sub

    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        btsimpan.Text = "Simpan"
        bersih()
        txtno.Enabled = False
        txttype.Focus()

    End Sub

    Private Sub dgtype_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgtype.CellClick
        bersih()
        txtno.Enabled = False
        Dim i As Integer
        i = Me.dgtype.CurrentRow.Index
        With dgtype.Rows.Item(i)
            txtno.Text = .Cells(0).Value
            txttype.Text = .Cells(1).Value
            btsimpan.Text = "Update"
            txttype.Focus()
            bthapus.Enabled = True

        End With

    End Sub

    Private Sub txttype_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttype.KeyPress
        If e.KeyChar = Chr(13) Then
            txttype.Text = UCase(txttype.Text)
            btsimpan.Focus()
        End If

    End Sub
End Class