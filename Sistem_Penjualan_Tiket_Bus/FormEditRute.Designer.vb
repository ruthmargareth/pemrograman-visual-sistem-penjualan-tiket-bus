<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditRute
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
        Me.TxtDestinasi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEditRute = New System.Windows.Forms.Button()
        Me.TxtAsal_rute = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBTarif = New System.Windows.Forms.GroupBox()
        Me.RBHarga2 = New System.Windows.Forms.RadioButton()
        Me.RBHarga1 = New System.Windows.Forms.RadioButton()
        Me.RBHarga4 = New System.Windows.Forms.RadioButton()
        Me.RBHarga3 = New System.Windows.Forms.RadioButton()
        Me.DTPJadwalKedatangan = New System.Windows.Forms.DateTimePicker()
        Me.DTPJadwalKeberangkatan = New System.Windows.Forms.DateTimePicker()
        Me.GBTarif.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtDestinasi
        '
        Me.TxtDestinasi.Location = New System.Drawing.Point(355, 164)
        Me.TxtDestinasi.Name = "TxtDestinasi"
        Me.TxtDestinasi.Size = New System.Drawing.Size(225, 26)
        Me.TxtDestinasi.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(119, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Jadwal Kedatangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(119, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Asal"
        '
        'BtnEditRute
        '
        Me.BtnEditRute.Location = New System.Drawing.Point(287, 491)
        Me.BtnEditRute.Name = "BtnEditRute"
        Me.BtnEditRute.Size = New System.Drawing.Size(93, 31)
        Me.BtnEditRute.TabIndex = 45
        Me.BtnEditRute.Text = "Edit"
        Me.BtnEditRute.UseVisualStyleBackColor = True
        '
        'TxtAsal_rute
        '
        Me.TxtAsal_rute.Location = New System.Drawing.Point(355, 115)
        Me.TxtAsal_rute.Name = "TxtAsal_rute"
        Me.TxtAsal_rute.Size = New System.Drawing.Size(225, 26)
        Me.TxtAsal_rute.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(119, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Jadwal Keberangkatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(119, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Tarif"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(119, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Destinasi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(246, 37)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Form Edit Rute"
        '
        'GBTarif
        '
        Me.GBTarif.Controls.Add(Me.RBHarga2)
        Me.GBTarif.Controls.Add(Me.RBHarga1)
        Me.GBTarif.Controls.Add(Me.RBHarga4)
        Me.GBTarif.Controls.Add(Me.RBHarga3)
        Me.GBTarif.ForeColor = System.Drawing.Color.White
        Me.GBTarif.Location = New System.Drawing.Point(355, 208)
        Me.GBTarif.Name = "GBTarif"
        Me.GBTarif.Size = New System.Drawing.Size(225, 148)
        Me.GBTarif.TabIndex = 54
        Me.GBTarif.TabStop = False
        Me.GBTarif.Text = "Tarif"
        '
        'RBHarga2
        '
        Me.RBHarga2.AutoSize = True
        Me.RBHarga2.Location = New System.Drawing.Point(6, 55)
        Me.RBHarga2.Name = "RBHarga2"
        Me.RBHarga2.Size = New System.Drawing.Size(104, 24)
        Me.RBHarga2.TabIndex = 35
        Me.RBHarga2.TabStop = True
        Me.RBHarga2.Text = "Rp.75000"
        Me.RBHarga2.UseVisualStyleBackColor = True
        '
        'RBHarga1
        '
        Me.RBHarga1.AutoSize = True
        Me.RBHarga1.Location = New System.Drawing.Point(6, 25)
        Me.RBHarga1.Name = "RBHarga1"
        Me.RBHarga1.Size = New System.Drawing.Size(104, 24)
        Me.RBHarga1.TabIndex = 34
        Me.RBHarga1.TabStop = True
        Me.RBHarga1.Text = "Rp.50000"
        Me.RBHarga1.UseVisualStyleBackColor = True
        '
        'RBHarga4
        '
        Me.RBHarga4.AutoSize = True
        Me.RBHarga4.Location = New System.Drawing.Point(6, 115)
        Me.RBHarga4.Name = "RBHarga4"
        Me.RBHarga4.Size = New System.Drawing.Size(113, 24)
        Me.RBHarga4.TabIndex = 37
        Me.RBHarga4.TabStop = True
        Me.RBHarga4.Text = "Rp.125000"
        Me.RBHarga4.UseVisualStyleBackColor = True
        '
        'RBHarga3
        '
        Me.RBHarga3.AutoSize = True
        Me.RBHarga3.Location = New System.Drawing.Point(6, 85)
        Me.RBHarga3.Name = "RBHarga3"
        Me.RBHarga3.Size = New System.Drawing.Size(113, 24)
        Me.RBHarga3.TabIndex = 36
        Me.RBHarga3.TabStop = True
        Me.RBHarga3.Text = "Rp.100000"
        Me.RBHarga3.UseVisualStyleBackColor = True
        '
        'DTPJadwalKedatangan
        '
        Me.DTPJadwalKedatangan.CustomFormat = "HH:mm:ss"
        Me.DTPJadwalKedatangan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPJadwalKedatangan.Location = New System.Drawing.Point(355, 423)
        Me.DTPJadwalKedatangan.Name = "DTPJadwalKedatangan"
        Me.DTPJadwalKedatangan.ShowUpDown = True
        Me.DTPJadwalKedatangan.Size = New System.Drawing.Size(225, 26)
        Me.DTPJadwalKedatangan.TabIndex = 56
        '
        'DTPJadwalKeberangkatan
        '
        Me.DTPJadwalKeberangkatan.CustomFormat = "HH:mm:ss"
        Me.DTPJadwalKeberangkatan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPJadwalKeberangkatan.Location = New System.Drawing.Point(355, 376)
        Me.DTPJadwalKeberangkatan.Name = "DTPJadwalKeberangkatan"
        Me.DTPJadwalKeberangkatan.ShowUpDown = True
        Me.DTPJadwalKeberangkatan.Size = New System.Drawing.Size(225, 26)
        Me.DTPJadwalKeberangkatan.TabIndex = 55
        '
        'FormEditRute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 573)
        Me.Controls.Add(Me.DTPJadwalKedatangan)
        Me.Controls.Add(Me.DTPJadwalKeberangkatan)
        Me.Controls.Add(Me.GBTarif)
        Me.Controls.Add(Me.TxtDestinasi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEditRute)
        Me.Controls.Add(Me.TxtAsal_rute)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditRute"
        Me.Text = "FormEditRute"
        Me.GBTarif.ResumeLayout(False)
        Me.GBTarif.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDestinasi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEditRute As Button
    Friend WithEvents TxtAsal_rute As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GBTarif As GroupBox
    Friend WithEvents RBHarga2 As RadioButton
    Friend WithEvents RBHarga1 As RadioButton
    Friend WithEvents RBHarga4 As RadioButton
    Friend WithEvents RBHarga3 As RadioButton
    Friend WithEvents DTPJadwalKedatangan As DateTimePicker
    Friend WithEvents DTPJadwalKeberangkatan As DateTimePicker
End Class
