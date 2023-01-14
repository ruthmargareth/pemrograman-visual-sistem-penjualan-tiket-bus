Public Class FormEditBus
    Dim jenis As New List(Of String) From {"Normal Deck", "Double Decker (DD)", "High Decker (HD)", "Ultra High Deck (UHD)"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        CBJenis_bus.DataSource = jenis
        ' Add any initialization after the InitializeComponent() call.
        TxtNamaBus.Text = FormMain.JenisBus.nama_busProperty
        TxtKapasitas_bus.Text = FormMain.JenisBus.kapasitas_busProperty
        CBJenis_bus.SelectedItem() = FormMain.JenisBus.jenis_busProperty
        TxtTahun_pembuatan.Text = FormMain.JenisBus.tahun_pembuatanProperty
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        FormMain.JenisBus.nama_busProperty = TxtNamaBus.Text.ToString()
        FormMain.JenisBus.kapasitas_busProperty = Integer.Parse(TxtKapasitas_bus.Text)
        FormMain.JenisBus.jenis_busProperty = CBJenis_bus.SelectedItem().ToString
        FormMain.JenisBus.tahun_pembuatanProperty = TxtTahun_pembuatan.Text.ToString()

        FormMain.JenisBus.UpdateDataBusByIDDatabase(FormMain.selectedTableBus,
                                                   FormMain.JenisBus.nama_busProperty,
                                                   FormMain.JenisBus.kapasitas_busProperty,
                                                   FormMain.JenisBus.jenis_busProperty,
                                                   FormMain.JenisBus.tahun_pembuatanProperty)
        Me.Close()
    End Sub
End Class