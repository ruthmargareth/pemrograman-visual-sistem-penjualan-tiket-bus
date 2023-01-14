Public Class FormHapusPenumpang

    Private nama_penumpang As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nama_penumpang = FormMain.selectedTableNamaPenumpang.ToString()
        LblHapusNama.Text = nama_penumpang
    End Sub

    Private Sub BtnHapusPenumpang_Click(sender As Object, e As EventArgs) Handles BtnHapusPenumpang.Click
        FormMain.classpenumpang.DeleteDataPenumpangByNIKDatabase(FormMain.selectedTablePenumpang)
        Me.Close()
    End Sub
End Class