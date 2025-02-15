<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNamaAlat = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtNamaPetugasRuangan = New System.Windows.Forms.TextBox()
        Me.txtNamaPetugasMenyerahkan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNamaRuangan = New System.Windows.Forms.TextBox()
        Me.dtpTanggalJam = New System.Windows.Forms.DateTimePicker()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNamaAlat
        '
        Me.txtNamaAlat.Location = New System.Drawing.Point(192, 42)
        Me.txtNamaAlat.Name = "txtNamaAlat"
        Me.txtNamaAlat.Size = New System.Drawing.Size(100, 22)
        Me.txtNamaAlat.TabIndex = 0
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(192, 78)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 22)
        Me.txtJumlah.TabIndex = 1
        '
        'txtNamaPetugasRuangan
        '
        Me.txtNamaPetugasRuangan.Location = New System.Drawing.Point(192, 112)
        Me.txtNamaPetugasRuangan.Name = "txtNamaPetugasRuangan"
        Me.txtNamaPetugasRuangan.Size = New System.Drawing.Size(100, 22)
        Me.txtNamaPetugasRuangan.TabIndex = 2
        '
        'txtNamaPetugasMenyerahkan
        '
        Me.txtNamaPetugasMenyerahkan.Location = New System.Drawing.Point(192, 147)
        Me.txtNamaPetugasMenyerahkan.Name = "txtNamaPetugasMenyerahkan"
        Me.txtNamaPetugasMenyerahkan.Size = New System.Drawing.Size(100, 22)
        Me.txtNamaPetugasMenyerahkan.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Alat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jumlah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Petugas Terima"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Petugas Serah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ruangan"
        '
        'txtNamaRuangan
        '
        Me.txtNamaRuangan.Location = New System.Drawing.Point(192, 187)
        Me.txtNamaRuangan.Name = "txtNamaRuangan"
        Me.txtNamaRuangan.Size = New System.Drawing.Size(100, 22)
        Me.txtNamaRuangan.TabIndex = 9
        '
        'dtpTanggalJam
        '
        Me.dtpTanggalJam.Location = New System.Drawing.Point(563, 12)
        Me.dtpTanggalJam.Name = "dtpTanggalJam"
        Me.dtpTanggalJam.Size = New System.Drawing.Size(200, 22)
        Me.dtpTanggalJam.TabIndex = 10
        Me.dtpTanggalJam.Visible = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(192, 224)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 23)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(308, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(455, 205)
        Me.DataGridView1.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(789, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem1})
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.LoadToolStripMenuItem.Text = "File"
        '
        'LoadToolStripMenuItem1
        '
        Me.LoadToolStripMenuItem1.Name = "LoadToolStripMenuItem1"
        Me.LoadToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.LoadToolStripMenuItem1.Text = "Load"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 264)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dtpTanggalJam)
        Me.Controls.Add(Me.txtNamaRuangan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNamaPetugasMenyerahkan)
        Me.Controls.Add(Me.txtNamaPetugasRuangan)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtNamaAlat)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Peminjaman Alat Steril"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNamaAlat As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtNamaPetugasRuangan As TextBox
    Friend WithEvents txtNamaPetugasMenyerahkan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNamaRuangan As TextBox
    Friend WithEvents dtpTanggalJam As DateTimePicker
    Friend WithEvents btnSimpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
