<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusRute
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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblHapusAsal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblHapusDestinasi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(308, 239)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(115, 40)
        Me.BtnHapus.TabIndex = 8
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LblHapusAsal
        '
        Me.LblHapusAsal.AutoSize = True
        Me.LblHapusAsal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapusAsal.ForeColor = System.Drawing.Color.Red
        Me.LblHapusAsal.Location = New System.Drawing.Point(157, 171)
        Me.LblHapusAsal.Name = "LblHapusAsal"
        Me.LblHapusAsal.Size = New System.Drawing.Size(167, 32)
        Me.LblHapusAsal.TabIndex = 7
        Me.LblHapusAsal.Text = "Hapus asal"
        Me.LblHapusAsal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(133, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Apakah Ingin Menghapus Rute?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(382, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 32)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "|"
        '
        'LblHapusDestinasi
        '
        Me.LblHapusDestinasi.AutoSize = True
        Me.LblHapusDestinasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapusDestinasi.ForeColor = System.Drawing.Color.Red
        Me.LblHapusDestinasi.Location = New System.Drawing.Point(444, 171)
        Me.LblHapusDestinasi.Name = "LblHapusDestinasi"
        Me.LblHapusDestinasi.Size = New System.Drawing.Size(233, 32)
        Me.LblHapusDestinasi.TabIndex = 10
        Me.LblHapusDestinasi.Text = "Hapus destinasi"
        Me.LblHapusDestinasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(220, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 37)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Asal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(464, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 37)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Destinasi"
        '
        'FormHapusRute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 322)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblHapusDestinasi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblHapusAsal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHapusRute"
        Me.Text = "FormHapusRute"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblHapusAsal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblHapusDestinasi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
