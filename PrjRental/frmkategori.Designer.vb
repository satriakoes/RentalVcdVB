<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkategori
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
        Me.dgkategori = New System.Windows.Forms.DataGridView()
        Me.txtkategori = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgkategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgkategori
        '
        Me.dgkategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgkategori.Location = New System.Drawing.Point(43, 197)
        Me.dgkategori.Name = "dgkategori"
        Me.dgkategori.RowTemplate.Height = 28
        Me.dgkategori.Size = New System.Drawing.Size(439, 215)
        Me.dgkategori.TabIndex = 19
        '
        'txtkategori
        '
        Me.txtkategori.Location = New System.Drawing.Point(136, 86)
        Me.txtkategori.Name = "txtkategori"
        Me.txtkategori.Size = New System.Drawing.Size(301, 26)
        Me.txtkategori.TabIndex = 18
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(136, 27)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(100, 26)
        Me.txtno.TabIndex = 17
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.Image = Global.PrjRental.My.Resources.Resources.delete1
        Me.btkeluar.Location = New System.Drawing.Point(365, 135)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(105, 40)
        Me.btkeluar.TabIndex = 16
        Me.btkeluar.Text = "&Keluar"
        Me.btkeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.Image = Global.PrjRental.My.Resources.Resources.refresh
        Me.btbatal.Location = New System.Drawing.Point(272, 135)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(94, 40)
        Me.btbatal.TabIndex = 15
        Me.btbatal.Text = "&Batal"
        Me.btbatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.Image = Global.PrjRental.My.Resources.Resources.delete_16
        Me.bthapus.Location = New System.Drawing.Point(172, 135)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(102, 40)
        Me.bthapus.TabIndex = 14
        Me.bthapus.Text = "&Hapus"
        Me.bthapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.Image = Global.PrjRental.My.Resources.Resources.Save
        Me.btsimpan.Location = New System.Drawing.Point(62, 135)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(115, 40)
        Me.btsimpan.TabIndex = 13
        Me.btsimpan.Text = "&Simpan"
        Me.btsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "No Terisi Otomatis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Kategori"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "No"
        '
        'frmkategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.PrjRental.My.Resources.Resources.login_bg
        Me.ClientSize = New System.Drawing.Size(524, 439)
        Me.Controls.Add(Me.dgkategori)
        Me.Controls.Add(Me.txtkategori)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmkategori"
        Me.Text = "Tambah Kategori"
        CType(Me.dgkategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgkategori As System.Windows.Forms.DataGridView
    Friend WithEvents txtkategori As System.Windows.Forms.TextBox
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
