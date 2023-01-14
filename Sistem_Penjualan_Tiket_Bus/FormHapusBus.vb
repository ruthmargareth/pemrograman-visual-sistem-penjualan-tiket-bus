Public Class FormHapusBus

    Private nama_bus As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nama_bus = FormMain.selectedTableBusNama.ToString()
        LblHapusBus.Text = nama_bus
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        FormMain.JenisBus.DeleteDataBusByIDDatabase(FormMain.selectedTableBus)
        Me.Close()
    End Sub
End Class