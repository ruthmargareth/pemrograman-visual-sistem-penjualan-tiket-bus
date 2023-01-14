<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registration
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRATION"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(148, 151)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(121, 26)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Username"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(148, 197)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 26)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Email"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(148, 245)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(116, 26)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Password"
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(302, 151)
        Me.txtuname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(312, 26)
        Me.txtuname.TabIndex = 6
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(302, 199)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(312, 26)
        Me.txtemail.TabIndex = 7
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(302, 247)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(312, 26)
        Me.txtpass.TabIndex = 8
        '
        'btnregister
        '
        Me.btnregister.Location = New System.Drawing.Point(344, 311)
        Me.btnregister.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(189, 38)
        Me.btnregister.TabIndex = 9
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = True
        '
        'registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(861, 430)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "registration"
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents txtuname As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnregister As Button
End Class
