<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.label1 = New System.Windows.Forms.Label()
        Me.BtnHapusBus = New System.Windows.Forms.Button()
        Me.BtnEditBus = New System.Windows.Forms.Button()
        Me.BtnTambahBus = New System.Windows.Forms.Button()
        Me.DataGridBus = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnHapusRute = New System.Windows.Forms.Button()
        Me.BtnEditRute = New System.Windows.Forms.Button()
        Me.BtnTambahRute = New System.Windows.Forms.Button()
        Me.DataGridRute = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnHapusPenumpang = New System.Windows.Forms.Button()
        Me.BtnEditPenumpang = New System.Windows.Forms.Button()
        Me.BtnTambahPenumpang = New System.Windows.Forms.Button()
        Me.DataGridPenumpang = New System.Windows.Forms.DataGridView()
        Me.BtnFormTiket = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridBus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridRute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridPenumpang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(85, 25)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1095, 440)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.label1)
        Me.TabPage1.Controls.Add(Me.BtnHapusBus)
        Me.TabPage1.Controls.Add(Me.BtnEditBus)
        Me.TabPage1.Controls.Add(Me.BtnTambahBus)
        Me.TabPage1.Controls.Add(Me.DataGridBus)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1087, 407)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form Bus"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(6, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(165, 37)
        Me.label1.TabIndex = 36
        Me.label1.Text = "Form Bus"
        '
        'BtnHapusBus
        '
        Me.BtnHapusBus.Location = New System.Drawing.Point(379, 326)
        Me.BtnHapusBus.Name = "BtnHapusBus"
        Me.BtnHapusBus.Size = New System.Drawing.Size(177, 34)
        Me.BtnHapusBus.TabIndex = 35
        Me.BtnHapusBus.Text = "Hapus Bus"
        Me.BtnHapusBus.UseVisualStyleBackColor = True
        '
        'BtnEditBus
        '
        Me.BtnEditBus.Location = New System.Drawing.Point(196, 326)
        Me.BtnEditBus.Name = "BtnEditBus"
        Me.BtnEditBus.Size = New System.Drawing.Size(177, 34)
        Me.BtnEditBus.TabIndex = 34
        Me.BtnEditBus.Text = "Edit Bus"
        Me.BtnEditBus.UseVisualStyleBackColor = True
        '
        'BtnTambahBus
        '
        Me.BtnTambahBus.Location = New System.Drawing.Point(13, 326)
        Me.BtnTambahBus.Name = "BtnTambahBus"
        Me.BtnTambahBus.Size = New System.Drawing.Size(177, 34)
        Me.BtnTambahBus.TabIndex = 33
        Me.BtnTambahBus.Text = "Tambah Bus"
        Me.BtnTambahBus.UseVisualStyleBackColor = True
        '
        'DataGridBus
        '
        Me.DataGridBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBus.Location = New System.Drawing.Point(13, 47)
        Me.DataGridBus.Name = "DataGridBus"
        Me.DataGridBus.RowHeadersWidth = 62
        Me.DataGridBus.RowTemplate.Height = 28
        Me.DataGridBus.Size = New System.Drawing.Size(1023, 273)
        Me.DataGridBus.TabIndex = 32
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.BtnHapusRute)
        Me.TabPage2.Controls.Add(Me.BtnEditRute)
        Me.TabPage2.Controls.Add(Me.BtnTambahRute)
        Me.TabPage2.Controls.Add(Me.DataGridRute)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1087, 407)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Form Rute"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 37)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Form Rute"
        '
        'BtnHapusRute
        '
        Me.BtnHapusRute.Location = New System.Drawing.Point(378, 333)
        Me.BtnHapusRute.Name = "BtnHapusRute"
        Me.BtnHapusRute.Size = New System.Drawing.Size(177, 34)
        Me.BtnHapusRute.TabIndex = 14
        Me.BtnHapusRute.Text = "Hapus Rute"
        Me.BtnHapusRute.UseVisualStyleBackColor = True
        '
        'BtnEditRute
        '
        Me.BtnEditRute.Location = New System.Drawing.Point(195, 333)
        Me.BtnEditRute.Name = "BtnEditRute"
        Me.BtnEditRute.Size = New System.Drawing.Size(177, 34)
        Me.BtnEditRute.TabIndex = 13
        Me.BtnEditRute.Text = "Edit Rute"
        Me.BtnEditRute.UseVisualStyleBackColor = True
        '
        'BtnTambahRute
        '
        Me.BtnTambahRute.Location = New System.Drawing.Point(12, 333)
        Me.BtnTambahRute.Name = "BtnTambahRute"
        Me.BtnTambahRute.Size = New System.Drawing.Size(177, 34)
        Me.BtnTambahRute.TabIndex = 12
        Me.BtnTambahRute.Text = "Tambah Rute"
        Me.BtnTambahRute.UseVisualStyleBackColor = True
        '
        'DataGridRute
        '
        Me.DataGridRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRute.Location = New System.Drawing.Point(12, 43)
        Me.DataGridRute.Name = "DataGridRute"
        Me.DataGridRute.RowHeadersWidth = 62
        Me.DataGridRute.RowTemplate.Height = 28
        Me.DataGridRute.Size = New System.Drawing.Size(1021, 284)
        Me.DataGridRute.TabIndex = 11
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.BtnFormTiket)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.BtnHapusPenumpang)
        Me.TabPage3.Controls.Add(Me.BtnEditPenumpang)
        Me.TabPage3.Controls.Add(Me.BtnTambahPenumpang)
        Me.TabPage3.Controls.Add(Me.DataGridPenumpang)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1087, 407)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Form Penumpang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(4, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(289, 37)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Form Penumpang"
        '
        'BtnHapusPenumpang
        '
        Me.BtnHapusPenumpang.Location = New System.Drawing.Point(465, 335)
        Me.BtnHapusPenumpang.Name = "BtnHapusPenumpang"
        Me.BtnHapusPenumpang.Size = New System.Drawing.Size(221, 34)
        Me.BtnHapusPenumpang.TabIndex = 15
        Me.BtnHapusPenumpang.Text = "Hapus Penumpang"
        Me.BtnHapusPenumpang.UseVisualStyleBackColor = True
        '
        'BtnEditPenumpang
        '
        Me.BtnEditPenumpang.Location = New System.Drawing.Point(238, 335)
        Me.BtnEditPenumpang.Name = "BtnEditPenumpang"
        Me.BtnEditPenumpang.Size = New System.Drawing.Size(221, 34)
        Me.BtnEditPenumpang.TabIndex = 14
        Me.BtnEditPenumpang.Text = "Edit Penumpang"
        Me.BtnEditPenumpang.UseVisualStyleBackColor = True
        '
        'BtnTambahPenumpang
        '
        Me.BtnTambahPenumpang.Location = New System.Drawing.Point(11, 335)
        Me.BtnTambahPenumpang.Name = "BtnTambahPenumpang"
        Me.BtnTambahPenumpang.Size = New System.Drawing.Size(221, 34)
        Me.BtnTambahPenumpang.TabIndex = 13
        Me.BtnTambahPenumpang.Text = "Tambah Penumpang"
        Me.BtnTambahPenumpang.UseVisualStyleBackColor = True
        '
        'DataGridPenumpang
        '
        Me.DataGridPenumpang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPenumpang.Location = New System.Drawing.Point(11, 47)
        Me.DataGridPenumpang.Name = "DataGridPenumpang"
        Me.DataGridPenumpang.RowHeadersWidth = 62
        Me.DataGridPenumpang.RowTemplate.Height = 28
        Me.DataGridPenumpang.Size = New System.Drawing.Size(1026, 282)
        Me.DataGridPenumpang.TabIndex = 12
        '
        'BtnFormTiket
        '
        Me.BtnFormTiket.Location = New System.Drawing.Point(816, 335)
        Me.BtnFormTiket.Name = "BtnFormTiket"
        Me.BtnFormTiket.Size = New System.Drawing.Size(221, 34)
        Me.BtnFormTiket.TabIndex = 17
        Me.BtnFormTiket.Text = "Form Tiket"
        Me.BtnFormTiket.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 480)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridBus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridRute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridPenumpang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents label1 As Label
    Friend WithEvents BtnHapusBus As Button
    Friend WithEvents BtnEditBus As Button
    Friend WithEvents BtnTambahBus As Button
    Friend WithEvents DataGridBus As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnHapusRute As Button
    Friend WithEvents BtnEditRute As Button
    Friend WithEvents BtnTambahRute As Button
    Friend WithEvents DataGridRute As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnHapusPenumpang As Button
    Friend WithEvents BtnEditPenumpang As Button
    Friend WithEvents BtnTambahPenumpang As Button
    Friend WithEvents DataGridPenumpang As DataGridView
    Friend WithEvents BtnFormTiket As Button
End Class
