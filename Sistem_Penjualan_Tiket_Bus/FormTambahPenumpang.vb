Imports System.IO
Public Class FormTambahPenumpang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FormMain.classpenumpang.NIKProperty = TxtNIKPenumpang.Text.ToString()
        FormMain.classpenumpang.nama_penumpangProperty = TxtNamaPenumpang.Text.ToString()
        FormMain.classpenumpang.alamat_penumpangProperty = RTBAlamat.Text.ToString()

        If RBLakiLaki.Checked() Then
            FormMain.classpenumpang.jenis_kelaminProperty = "Laki laki"
        ElseIf RBPerempuan.Checked() Then
            FormMain.classpenumpang.jenis_kelaminProperty = "Perempuan"
        End If

        FormMain.classpenumpang.AddDataPenumpangDatabase(FormMain.classpenumpang.NIKProperty,
                                                         FormMain.classpenumpang.nama_penumpangProperty,
                                                         FormMain.classpenumpang.alamat_penumpangProperty,
                                                         FormMain.classpenumpang.jenis_kelaminProperty)
        Me.Close()
    End Sub
End Class