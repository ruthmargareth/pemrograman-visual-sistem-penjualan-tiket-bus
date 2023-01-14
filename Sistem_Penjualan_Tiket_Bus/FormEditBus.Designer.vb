<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditBus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.CBJenis_bus = New System.Windows.Forms.ComboBox()
        Me.TxtTahun_pembuatan = New System.Windows.Forms.TextBox()
        Me.TxtKapasitas_bus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNamaBus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(277, 330)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(93, 31)
        Me.BtnEdit.TabIndex = 19
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'CBJenis_bus
        '
        Me.CBJenis_bus.FormattingEnabled = True
        Me.CBJenis_bus.Location = New System.Drawing.Point(335, 202)
        Me.CBJenis_bus.Name = "CBJenis_bus"
        Me.CBJenis_bus.Size = New System.Drawing.Size(225, 28)
        Me.CBJenis_bus.TabIndex = 18
        '
        'TxtTahun_pembuatan
        '
        Me.TxtTahun_pembuatan.Location = New System.Drawing.Point(335, 257)
        Me.TxtTahun_pembuatan.Name = "TxtTahun_pembuatan"
        Me.TxtTahun_pembuatan.Size = New System.Drawing.Size(225, 26)
        Me.TxtTahun_pembuatan.TabIndex = 17
        '
        'TxtKapasitas_bus
        '
        Me.TxtKapasitas_bus.Location = New System.Drawing.Point(335, 160)
        Me.TxtKapasitas_bus.Name = "TxtKapasitas_bus"
        Me.TxtKapasitas_bus.Size = New System.Drawing.Size(225, 26)
        Me.TxtKapasitas_bus.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(137, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tahun Pembuatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(137, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Jenis Bus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(137, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Kapasitas Bus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Form Edit Bus"
        '
        'TxtNamaBus
        '
        Me.TxtNamaBus.Location = New System.Drawing.Point(335, 111)
        Me.TxtNamaBus.Name = "TxtNamaBus"
        Me.TxtNamaBus.Size = New System.Drawing.Size(225, 26)
        Me.TxtNamaBus.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(137, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nama Bus"
        '
        'FormEditBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(738, 428)
        Me.Controls.Add(Me.TxtNamaBus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.CBJenis_bus)
        Me.Controls.Add(Me.TxtTahun_pembuatan)
        Me.Controls.Add(Me.TxtKapasitas_bus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditBus"
        Me.Text = "InfoTambahBus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEdit As Button
    Friend WithEvents CBJenis_bus As ComboBox
    Friend WithEvents TxtTahun_pembuatan As TextBox
    Friend WithEvents TxtKapasitas_bus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNamaBus As TextBox
    Friend WithEvents Label2 As Label
End Class
