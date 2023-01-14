<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahPenumpang
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
        Me.TxtNIKPenumpang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtNamaPenumpang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RTBAlamat = New System.Windows.Forms.RichTextBox()
        Me.GBJenisKelamin = New System.Windows.Forms.GroupBox()
        Me.RBPerempuan = New System.Windows.Forms.RadioButton()
        Me.RBLakiLaki = New System.Windows.Forms.RadioButton()
        Me.GBJenisKelamin.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNIKPenumpang
        '
        Me.TxtNIKPenumpang.Location = New System.Drawing.Point(387, 102)
        Me.TxtNIKPenumpang.Name = "TxtNIKPenumpang"
        Me.TxtNIKPenumpang.Size = New System.Drawing.Size(225, 26)
        Me.TxtNIKPenumpang.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(151, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "NIK"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(315, 455)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(93, 31)
        Me.BtnTambah.TabIndex = 19
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtNamaPenumpang
        '
        Me.TxtNamaPenumpang.Location = New System.Drawing.Point(387, 149)
        Me.TxtNamaPenumpang.Name = "TxtNamaPenumpang"
        Me.TxtNamaPenumpang.Size = New System.Drawing.Size(225, 26)
        Me.TxtNamaPenumpang.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(151, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(151, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(151, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nama Penumpang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Form Tambah Penumpang"
        '
        'RTBAlamat
        '
        Me.RTBAlamat.Location = New System.Drawing.Point(387, 197)
        Me.RTBAlamat.Name = "RTBAlamat"
        Me.RTBAlamat.Size = New System.Drawing.Size(225, 119)
        Me.RTBAlamat.TabIndex = 22
        Me.RTBAlamat.Text = ""
        '
        'GBJenisKelamin
        '
        Me.GBJenisKelamin.Controls.Add(Me.RBPerempuan)
        Me.GBJenisKelamin.Controls.Add(Me.RBLakiLaki)
        Me.GBJenisKelamin.ForeColor = System.Drawing.Color.White
        Me.GBJenisKelamin.Location = New System.Drawing.Point(387, 338)
        Me.GBJenisKelamin.Name = "GBJenisKelamin"
        Me.GBJenisKelamin.Size = New System.Drawing.Size(225, 88)
        Me.GBJenisKelamin.TabIndex = 55
        Me.GBJenisKelamin.TabStop = False
        Me.GBJenisKelamin.Text = "Jenis Kelamin"
        '
        'RBPerempuan
        '
        Me.RBPerempuan.AutoSize = True
        Me.RBPerempuan.Location = New System.Drawing.Point(6, 55)
        Me.RBPerempuan.Name = "RBPerempuan"
        Me.RBPerempuan.Size = New System.Drawing.Size(116, 24)
        Me.RBPerempuan.TabIndex = 35
        Me.RBPerempuan.TabStop = True
        Me.RBPerempuan.Text = "Perempuan"
        Me.RBPerempuan.UseVisualStyleBackColor = True
        '
        'RBLakiLaki
        '
        Me.RBLakiLaki.AutoSize = True
        Me.RBLakiLaki.Location = New System.Drawing.Point(6, 25)
        Me.RBLakiLaki.Name = "RBLakiLaki"
        Me.RBLakiLaki.Size = New System.Drawing.Size(96, 24)
        Me.RBLakiLaki.TabIndex = 34
        Me.RBLakiLaki.TabStop = True
        Me.RBLakiLaki.Text = "Laki Laki"
        Me.RBLakiLaki.UseVisualStyleBackColor = True
        '
        'FormTambahPenumpang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 566)
        Me.Controls.Add(Me.GBJenisKelamin)
        Me.Controls.Add(Me.RTBAlamat)
        Me.Controls.Add(Me.TxtNIKPenumpang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtNamaPenumpang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTambahPenumpang"
        Me.Text = "FormTambahPenumpang"
        Me.GBJenisKelamin.ResumeLayout(False)
        Me.GBJenisKelamin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNIKPenumpang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TxtNamaPenumpang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RTBAlamat As RichTextBox
    Friend WithEvents GBJenisKelamin As GroupBox
    Friend WithEvents RBPerempuan As RadioButton
    Friend WithEvents RBLakiLaki As RadioButton
End Class
