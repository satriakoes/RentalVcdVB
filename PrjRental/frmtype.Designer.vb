<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtype
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.dgtype = New System.Windows.Forms.DataGridView()
        Me.btkeluar = New System.Windows.Forms.Button()
        CType(Me.dgtype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type Film"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(305, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Terisi Otomatis"
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.Image = Global.PrjRental.My.Resources.Resources.Save
        Me.btsimpan.Location = New System.Drawing.Point(57, 145)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(112, 40)
        Me.btsimpan.TabIndex = 3
        Me.btsimpan.Text = "&Simpan"
        Me.btsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.Image = Global.PrjRental.My.Resources.Resources.delete_16
        Me.bthapus.Location = New System.Drawing.Point(166, 145)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(113, 40)
        Me.bthapus.TabIndex = 4
        Me.bthapus.Text = "&Hapus"
        Me.bthapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.Image = Global.PrjRental.My.Resources.Resources.refresh
        Me.btbatal.Location = New System.Drawing.Point(276, 145)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(95, 40)
        Me.btbatal.TabIndex = 5
        Me.btbatal.Text = "&Batal"
        Me.btbatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(132, 37)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(100, 26)
        Me.txtno.TabIndex = 7
        '
        'txttype
        '
        Me.txttype.Location = New System.Drawing.Point(132, 96)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(301, 26)
        Me.txttype.TabIndex = 8
        '
        'dgtype
        '
        Me.dgtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtype.Location = New System.Drawing.Point(39, 207)
        Me.dgtype.Name = "dgtype"
        Me.dgtype.RowTemplate.Height = 28
        Me.dgtype.Size = New System.Drawing.Size(439, 215)
        Me.dgtype.TabIndex = 9
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.Image = Global.PrjRental.My.Resources.Resources.delete1
        Me.btkeluar.Location = New System.Drawing.Point(368, 145)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btkeluar.Size = New System.Drawing.Size(110, 40)
        Me.btkeluar.TabIndex = 6
        Me.btkeluar.Text = "&Keluar"
        Me.btkeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'frmtype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.PrjRental.My.Resources.Resources.login_bg
        Me.ClientSize = New System.Drawing.Size(517, 434)
        Me.Controls.Add(Me.dgtype)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmtype"
        Me.Text = "Tambah Tipe"
        CType(Me.dgtype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents dgtype As System.Windows.Forms.DataGridView
End Class
