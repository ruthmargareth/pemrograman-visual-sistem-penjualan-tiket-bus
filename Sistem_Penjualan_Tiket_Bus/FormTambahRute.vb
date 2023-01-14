Imports System.IO

Public Class FormTambahRute


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnTambahRute_Click(sender As Object, e As EventArgs) Handles BtnTambahRute.Click
        FormMain.classrute.asal_ruteProperty = TxtAsal_rute.Text.ToString()
        FormMain.classrute.destinasi_ruteProperty = TxtDestinasi.Text.ToString()
        FormMain.classrute.jadwal_keberangkatanProperty = DTPJadwalKeberangkatan.Value.ToString("HH:mm:ss")
        FormMain.classrute.jadwal_kedatanganProperty = DTPJadwalKedatangan.Value.ToString("HH:mm:ss")

        If RBharga1.Checked() Then
            FormMain.classrute.tarif_ruteProperty = "Rp.50000"
        ElseIf RBHarga2.Checked() Then
            FormMain.classrute.tarif_ruteProperty = "Rp.75000"
        ElseIf RBharga3.Checked() Then
            FormMain.classrute.tarif_ruteProperty = "Rp.100000"
        ElseIf RBHarga4.Checked() Then
            FormMain.classrute.tarif_ruteProperty = "Rp.125000"
        End If

        FormMain.classrute.AddDataRuteDatabase(FormMain.classrute.asal_ruteProperty,
                                               FormMain.classrute.destinasi_ruteProperty,
                                               FormMain.classrute.tarif_ruteProperty,
                                               FormMain.classrute.jadwal_keberangkatanProperty,
                                               FormMain.classrute.jadwal_kedatanganProperty)
        Me.Close()
    End Sub


End Class