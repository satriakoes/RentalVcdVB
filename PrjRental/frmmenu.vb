Public Class frmmenu
    Private Sub PELANGGANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PELANGGANToolStripMenuItem.Click
        'frmpelanggan.Show()'
        frmpelanggan.TopLevel = False
        Panel1.Controls.Add(frmpelanggan)
        frmpelanggan.Show()
    End Sub

    Private Sub PENGGUNAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENGGUNAToolStripMenuItem.Click
        'frmuser.Show()'
        frmuser.TopLevel = False
        Panel1.Controls.Add(frmuser)
        frmuser.Show()
    End Sub

    Private Sub VCDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VCDToolStripMenuItem.Click
        'frmvcd.Show()'
        frmvcd.TopLevel = False
        Panel1.Controls.Add(frmvcd)
        frmvcd.Show()
    End Sub

    Private Sub KELUARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Panel1.Dock = DockStyle.Fill
    End Sub
End Class