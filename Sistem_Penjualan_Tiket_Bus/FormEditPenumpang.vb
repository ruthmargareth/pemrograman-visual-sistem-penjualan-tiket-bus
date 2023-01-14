Public Class FormEditPenumpang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtNIKPenumpang.Text = FormMain.classpenumpang.NIKProperty
        TxtNamaPenumpang.Text = FormMain.classpenumpang.nama_penumpangProperty
        RTBAlamat.Text = FormMain.classpenumpang.alamat_penumpangProperty

        If String.Compare(FormMain.classpenumpang.jenis_kelaminProperty, "Laki laki") = 0 Then
            RBLakiLaki.Checked = True
        ElseIf String.Compare(FormMain.classpenumpang.jenis_kelaminProperty, "Perempuan") = 0 Then
            RBPerempuan.Checked = True
        End If
    End Sub
    Private Sub BtnEditPenumpang_Click(sender As Object, e As EventArgs) Handles BtnEditPenumpang.Click
        FormMain.classpenumpang.NIKProperty = TxtNIKPenumpang.Text.ToString()
        FormMain.classpenumpang.nama_penumpangProperty = TxtNamaPenumpang.Text.ToString()
        FormMain.classpenumpang.alamat_penumpangProperty = RTBAlamat.Text.ToString()

        If RBLakiLaki.Checked Then
            FormMain.classpenumpang.jenis_kelaminProperty = "Laki laki"
        ElseIf RBPerempuan.Checked Then
            FormMain.classpenumpang.jenis_kelaminProperty = "Perempuan"
        End If

        FormMain.classpenumpang.UpdateDataPenumpangByNIKDatabase(FormMain.selectedTablePenumpang,
                                                                 FormMain.classpenumpang.nama_penumpangProperty,
                                                                 FormMain.classpenumpang.alamat_penumpangProperty,
                                                                 FormMain.classpenumpang.jenis_kelaminProperty)

        Me.Close()
    End Sub
End Class