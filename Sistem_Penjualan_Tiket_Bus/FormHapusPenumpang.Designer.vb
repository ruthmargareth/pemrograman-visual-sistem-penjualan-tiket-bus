<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusPenumpang
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblHapusNama = New System.Windows.Forms.Label()
        Me.BtnHapusPenumpang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(258, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(300, 37)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nama Penumpang"
        '
        'LblHapusNama
        '
        Me.LblHapusNama.AutoSize = True
        Me.LblHapusNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapusNama.ForeColor = System.Drawing.Color.Red
        Me.LblHapusNama.Location = New System.Drawing.Point(292, 175)
        Me.LblHapusNama.Name = "LblHapusNama"
        Me.LblHapusNama.Size = New System.Drawing.Size(233, 32)
        Me.LblHapusNama.TabIndex = 17
        Me.LblHapusNama.Text = "Hapus destinasi"
        Me.LblHapusNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHapusPenumpang
        '
        Me.BtnHapusPenumpang.Location = New System.Drawing.Point(348, 236)
        Me.BtnHapusPenumpang.Name = "BtnHapusPenumpang"
        Me.BtnHapusPenumpang.Size = New System.Drawing.Size(115, 40)
        Me.BtnHapusPenumpang.TabIndex = 15
        Me.BtnHapusPenumpang.Text = "Hapus"
        Me.BtnHapusPenumpang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(613, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Apakah Ingin Menghapus Penumpang?"
        '
        'FormHapusPenumpang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 360)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblHapusNama)
        Me.Controls.Add(Me.BtnHapusPenumpang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHapusPenumpang"
        Me.Text = "FormHapusPenumpang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents LblHapusNama As Label
    Friend WithEvents BtnHapusPenumpang As Button
    Friend WithEvents Label1 As Label
End Class
