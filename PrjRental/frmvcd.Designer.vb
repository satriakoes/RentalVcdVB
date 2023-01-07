<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvcd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmvcd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtnegara = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.cmbkategori = New System.Windows.Forms.ComboBox()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.bttype = New System.Windows.Forms.Button()
        Me.dgvcd = New System.Windows.Forms.DataGridView()
        Me.btkategori = New System.Windows.Forms.Button()
        CType(Me.dgvcd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Judul Film" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/ Tahun Rilis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Negara Asal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Type Film"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kategori"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 454)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Proses"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(838, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(379, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Cari data berdasarkan Kode/Judul Film/Negara"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(170, 33)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(207, 26)
        Me.txtkode.TabIndex = 8
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(170, 95)
        Me.txtjudul.Multiline = True
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(290, 81)
        Me.txtjudul.TabIndex = 9
        '
        'txtnegara
        '
        Me.txtnegara.Location = New System.Drawing.Point(170, 204)
        Me.txtnegara.Name = "txtnegara"
        Me.txtnegara.Size = New System.Drawing.Size(207, 26)
        Me.txtnegara.TabIndex = 10
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(170, 389)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(207, 26)
        Me.txtstock.TabIndex = 11
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(910, 68)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(207, 26)
        Me.txtcari.TabIndex = 12
        '
        'cmbtype
        '
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Location = New System.Drawing.Point(170, 260)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(207, 28)
        Me.cmbtype.TabIndex = 13
        '
        'cmbkategori
        '
        Me.cmbkategori.FormattingEnabled = True
        Me.cmbkategori.Location = New System.Drawing.Point(170, 324)
        Me.cmbkategori.Name = "cmbkategori"
        Me.cmbkategori.Size = New System.Drawing.Size(207, 28)
        Me.cmbkategori.TabIndex = 14
        '
        'bttambah
        '
        Me.bttambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttambah.Image = Global.PrjRental.My.Resources.Resources.add
        Me.bttambah.Location = New System.Drawing.Point(38, 502)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(119, 47)
        Me.bttambah.TabIndex = 15
        Me.bttambah.Text = "&Tambah"
        Me.bttambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.Image = Global.PrjRental.My.Resources.Resources.Save
        Me.btsimpan.Location = New System.Drawing.Point(151, 502)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(119, 47)
        Me.btsimpan.TabIndex = 16
        Me.btsimpan.Text = "&Simpan"
        Me.btsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btedit.Image = Global.PrjRental.My.Resources.Resources.edit_validated_icon
        Me.btedit.Location = New System.Drawing.Point(267, 502)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(93, 47)
        Me.btedit.TabIndex = 17
        Me.btedit.Text = "&Edit"
        Me.btedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btedit.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.Image = Global.PrjRental.My.Resources.Resources.delete_16
        Me.bthapus.Location = New System.Drawing.Point(359, 502)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(101, 47)
        Me.bthapus.TabIndex = 18
        Me.bthapus.Text = "&Hapus"
        Me.bthapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.Image = Global.PrjRental.My.Resources.Resources.refresh
        Me.btbatal.Location = New System.Drawing.Point(454, 502)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(108, 47)
        Me.btbatal.TabIndex = 19
        Me.btbatal.Text = "&Batal"
        Me.btbatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.Image = Global.PrjRental.My.Resources.Resources.delete1
        Me.btkeluar.Location = New System.Drawing.Point(548, 502)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(109, 47)
        Me.btkeluar.TabIndex = 20
        Me.btkeluar.Text = "&Keluar"
        Me.btkeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'bttype
        '
        Me.bttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttype.Image = Global.PrjRental.My.Resources.Resources.add
        Me.bttype.Location = New System.Drawing.Point(413, 260)
        Me.bttype.Name = "bttype"
        Me.bttype.Size = New System.Drawing.Size(89, 39)
        Me.bttype.TabIndex = 22
        Me.bttype.Text = "Add"
        Me.bttype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bttype.UseVisualStyleBackColor = True
        '
        'dgvcd
        '
        Me.dgvcd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcd.Location = New System.Drawing.Point(544, 121)
        Me.dgvcd.Name = "dgvcd"
        Me.dgvcd.RowTemplate.Height = 28
        Me.dgvcd.Size = New System.Drawing.Size(848, 363)
        Me.dgvcd.TabIndex = 23
        '
        'btkategori
        '
        Me.btkategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkategori.Image = Global.PrjRental.My.Resources.Resources.add
        Me.btkategori.Location = New System.Drawing.Point(413, 318)
        Me.btkategori.Name = "btkategori"
        Me.btkategori.Size = New System.Drawing.Size(89, 39)
        Me.btkategori.TabIndex = 24
        Me.btkategori.Text = "Add"
        Me.btkategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btkategori.UseVisualStyleBackColor = True
        '
        'frmvcd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1434, 589)
        Me.Controls.Add(Me.btkategori)
        Me.Controls.Add(Me.dgvcd)
        Me.Controls.Add(Me.bttype)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.cmbkategori)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtnegara)
        Me.Controls.Add(Me.txtjudul)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmvcd"
        Me.Text = "frmvcd"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvcd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents txtjudul As System.Windows.Forms.TextBox
    Friend WithEvents txtnegara As System.Windows.Forms.TextBox
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbkategori As System.Windows.Forms.ComboBox
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents bttype As System.Windows.Forms.Button
    Friend WithEvents dgvcd As System.Windows.Forms.DataGridView
    Friend WithEvents btkategori As System.Windows.Forms.Button
End Class
