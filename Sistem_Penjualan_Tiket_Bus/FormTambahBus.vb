Imports System.IO

Public Class FormTambahBus
    Dim jenis As New List(Of String) From {"Normal Deck", "Double Decker (DD)", "High Decker (HD)", "Ultra High Deck (UHD)"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CBJenis_bus.DataSource = jenis
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FormMain.JenisBus.nama_busProperty = TxtNamaBus.Text.ToString()
        FormMain.JenisBus.kapasitas_busProperty = TxtKapasitas_bus.Text.ToString()
        FormMain.JenisBus.jenis_busProperty = CBJenis_bus.SelectedItem().ToString()
        FormMain.JenisBus.tahun_pembuatanProperty = Integer.Parse(TxtTahun_pembuatan.Text)

        FormMain.JenisBus.AddDataBusDatabase(FormMain.JenisBus.nama_busProperty,
                                            FormMain.JenisBus.kapasitas_busProperty,
                                            FormMain.JenisBus.jenis_busProperty,
                                            FormMain.JenisBus.tahun_pembuatanProperty)
        Me.Close()
    End Sub
End Class