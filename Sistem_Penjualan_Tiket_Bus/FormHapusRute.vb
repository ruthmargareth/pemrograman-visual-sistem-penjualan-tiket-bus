Public Class FormHapusRute

    Private asal_rute As String
    Private destinasi_rute As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        asal_rute = FormMain.selectedTableRuteAsal.ToString()
        LblHapusAsal.Text = asal_rute
        destinasi_rute = FormMain.selectedTableRuteDestinasi.ToString()
        LblHapusDestinasi.Text = destinasi_rute

    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        FormMain.classrute.DeleteDataRuteByIDDatabase(FormMain.selectedTableRute)
        Me.Close()
    End Sub
End Class