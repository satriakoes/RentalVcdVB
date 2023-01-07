<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RENTALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTERDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PELANGGANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENGGUNAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VCDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOKOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RENTALToolStripMenuItem, Me.MASTERDATAToolStripMenuItem, Me.TOKOToolStripMenuItem, Me.KELUARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1430, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RENTALToolStripMenuItem
        '
        Me.RENTALToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RENTALToolStripMenuItem.Name = "RENTALToolStripMenuItem"
        Me.RENTALToolStripMenuItem.Size = New System.Drawing.Size(121, 32)
        Me.RENTALToolStripMenuItem.Text = "RENTAL"
        '
        'MASTERDATAToolStripMenuItem
        '
        Me.MASTERDATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PELANGGANToolStripMenuItem, Me.PENGGUNAToolStripMenuItem, Me.VCDToolStripMenuItem})
        Me.MASTERDATAToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASTERDATAToolStripMenuItem.Name = "MASTERDATAToolStripMenuItem"
        Me.MASTERDATAToolStripMenuItem.Size = New System.Drawing.Size(198, 32)
        Me.MASTERDATAToolStripMenuItem.Text = "MASTER DATA"
        '
        'PELANGGANToolStripMenuItem
        '
        Me.PELANGGANToolStripMenuItem.Name = "PELANGGANToolStripMenuItem"
        Me.PELANGGANToolStripMenuItem.Size = New System.Drawing.Size(238, 32)
        Me.PELANGGANToolStripMenuItem.Text = "PELANGGAN"
        '
        'PENGGUNAToolStripMenuItem
        '
        Me.PENGGUNAToolStripMenuItem.Name = "PENGGUNAToolStripMenuItem"
        Me.PENGGUNAToolStripMenuItem.Size = New System.Drawing.Size(238, 32)
        Me.PENGGUNAToolStripMenuItem.Text = "PENGGUNA"
        '
        'VCDToolStripMenuItem
        '
        Me.VCDToolStripMenuItem.Name = "VCDToolStripMenuItem"
        Me.VCDToolStripMenuItem.Size = New System.Drawing.Size(238, 32)
        Me.VCDToolStripMenuItem.Text = "VCD"
        '
        'TOKOToolStripMenuItem
        '
        Me.TOKOToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOKOToolStripMenuItem.Name = "TOKOToolStripMenuItem"
        Me.TOKOToolStripMenuItem.Size = New System.Drawing.Size(95, 32)
        Me.TOKOToolStripMenuItem.Text = "TOKO"
        '
        'KELUARToolStripMenuItem
        '
        Me.KELUARToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KELUARToolStripMenuItem.Image = Global.PrjRental.My.Resources.Resources.close
        Me.KELUARToolStripMenuItem.Name = "KELUARToolStripMenuItem"
        Me.KELUARToolStripMenuItem.Size = New System.Drawing.Size(140, 32)
        Me.KELUARToolStripMenuItem.Text = "KELUAR"
        Me.KELUARToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PrjRental.My.Resources.Resources.login_bg
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1430, 693)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(-26, -96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 0
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1430, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmenu"
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RENTALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERDATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PELANGGANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENGGUNAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VCDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOKOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
