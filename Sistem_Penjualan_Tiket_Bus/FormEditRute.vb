Public Class FormEditRute

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtAsal_rute.Text = FormMain.classrute.asal_ruteProperty
        TxtDestinasi.Text = FormMain.classrute.destinasi_ruteProperty
        DTPJadwalKeberangkatan.Text = FormMain.classrute.jadwal_keberangkatanProperty
        DTPJadwalKedatangan.Text = FormMain.classrute.jadwal_kedatanganProperty

        If String.Compare(FormMain.classrute.tarif_ruteProperty, "Rp.50000") = 0 Then
            RBHarga1.Checked = True
        ElseIf String.Compare(FormMain.classrute.tarif_ruteProperty, "Rp.75000") = 0 Then
            RBHarga2.Checked = True
        ElseIf String.Compare(FormMain.classrute.tarif_ruteProperty, "Rp.100000") = 0 Then
            RBHarga3.Checked = True
        ElseIf String.Compare(FormMain.classrute.tarif_ruteProperty, "Rp.125000") = 0 Then
            RBHarga4.Checked = True
        End If
    End Sub

    Private Sub BtnEditRute_Click(sender As Object, e As EventArgs) Handles BtnEditRute.Click
        FormMain.classrute.asal_ruteProperty = TxtAsal_rute.Text.ToString()
        FormMain.classrute.destinasi_ruteProperty = TxtDestinasi.Text.ToString()
        FormMain.classrute.jadwal_keberangkatanProperty = DTPJadwalKeberangkatan.Value.ToString("HH:mm:ss")
        FormMain.classrute.jadwal_kedatanganProperty = DTPJadwalKeberangkatan.Value.ToString("HH:mm:ss")

        If RBHarga1.Checked Then
            FormMain.classrute.tarif_ruteProperty = "Rp.50000"
        ElseIf RBHarga2.Checked Then
            FormMain.classrute.tarif_ruteProperty = "Rp.75000"
        ElseIf RBHarga3.Checked Then
            FormMain.classrute.tarif_ruteProperty = "Rp.100000"
        ElseIf RBHarga4.Checked Then
            FormMain.classrute.tarif_ruteProperty = "Rp.125000"
        End If


        FormMain.classrute.UpdateDataRuteByIDDatabase(FormMain.selectedTableRute,
                                                      FormMain.classrute.asal_ruteProperty,
                                                      FormMain.classrute.destinasi_ruteProperty,
                                                      FormMain.classrute.tarif_ruteProperty,
                                                      FormMain.classrute.jadwal_keberangkatanProperty,
                                                      FormMain.classrute.jadwal_kedatanganProperty)
        Me.Close()
    End Sub
End Class