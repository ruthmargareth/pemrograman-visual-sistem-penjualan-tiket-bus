Imports System.IO
Public Class FormMain
    Public Shared JenisBus As JenisBus
    Public Shared selectedTableBus As String
    Public Shared selectedBus As String
    Public Shared selectedTableBusNama As String
    Public Shared classrute As ClassRute
    Public Shared selectedTableRute As String
    Public Shared selectedRute As String
    Public Shared selectedTableRuteAsal As String
    Public Shared selectedTableRuteDestinasi As String
    Public Shared selectedTableJadwalKeberangkatan As String
    Public Shared selectedTableJadwalKedatangan As String
    Public Shared selectedTableTarif As String
    Public Shared classpenumpang As ClassPenumpang
    Public Shared selectedTablePenumpang As String
    Public Shared selectedPenumpang As String
    Public Shared selectedTableNIKPenumpang As String
    Public Shared selectedTableNamaPenumpang As String
    Public Shared selectedTableIdBus As String
    Public Shared selectedTableIdRute As String


    Public Sub New()
        JenisBus = New JenisBus()
        classrute = New ClassRute()
        classpenumpang = New ClassPenumpang()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableBusDatabase()
        ReloadDataTableRuteDatabase()
        ReloadDataTablepenumpangDatabase()


    End Sub

    Private Sub FormMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableBusDatabase()
        ReloadDataTableRuteDatabase()
        ReloadDataTablepenumpangDatabase()

    End Sub

    'reload data
    Private Sub ReloadDataTableBusDatabase()
        DataGridBus.DataSource = JenisBus.GetDataBusDatabase()
    End Sub

    Private Sub ReloadDataTablepenumpangDatabase()
        DataGridPenumpang.DataSource = classpenumpang.GetDataPenumpangDatabase()
    End Sub


    Private Sub ReloadDataTableRuteDatabase()
        DataGridRute.DataSource = classrute.GetDataRuteDatabase()
    End Sub


    'BTN BUS (tambah edit delete grid)
    Private Sub DataGridBus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBus.CellClick
        Dim indexBus As Integer = e.RowIndex
        Dim selectedRowBus As DataGridViewRow
        selectedRowBus = DataGridBus.Rows(indexBus)

        selectedTableBus = selectedRowBus.Cells(0).Value
        selectedTableBusNama = selectedRowBus.Cells(1).Value
    End Sub

    Private Sub BtnTambahBus_Click(sender As Object, e As EventArgs) Handles BtnTambahBus.Click
        Dim tambah_bus = New FormTambahBus()
        tambah_bus.Show()
    End Sub

    Private Sub BtnEditBus_Click(sender As Object, e As EventArgs) Handles BtnEditBus.Click
        Dim selectedBus As List(Of String) = JenisBus.GetDataBusByIDDatabase(selectedTableBus)

        JenisBus.nama_busProperty = selectedBus(1)
        JenisBus.kapasitas_busProperty = selectedBus(2)
        JenisBus.jenis_busProperty = selectedBus(3)
        JenisBus.tahun_pembuatanProperty = selectedBus(4)

        Dim form_edit = New FormEditBus()
        form_edit.Show()
    End Sub

    Private Sub BtnHapusBus_Click(sender As Object, e As EventArgs) Handles BtnHapusBus.Click
        'Dim result As DialogResult = MessageBox.Show("Apakah ingin menghapus data bus?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'JenisBus.DeleteDataBusByIDDatabase(selectedTableBus)

        Dim hapus_bus = New FormHapusBus
        hapus_bus.Show()
    End Sub

    'BTN RUTE (tambah edit delete grid)
    Private Sub BtnTambahRute_Click(sender As Object, e As EventArgs) Handles BtnTambahRute.Click
        Dim tambah_rute = New FormTambahRute()
        tambah_rute.Show()
    End Sub

    Private Sub DataGridRute_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRute.CellClick
        Dim indexRute As Integer = e.RowIndex
        Dim selectedRowRute As DataGridViewRow
        selectedRowRute = DataGridRute.Rows(indexRute)

        selectedTableRute = selectedRowRute.Cells(0).Value
        selectedTableRuteAsal = selectedRowRute.Cells(1).Value
        selectedTableRuteDestinasi = selectedRowRute.Cells(2).Value
    End Sub

    Private Sub BtnEditRute_Click(sender As Object, e As EventArgs) Handles BtnEditRute.Click
        Dim selectedrute As List(Of String) = classrute.GetDataRuteByIDDatabase(selectedTableRute)

        classrute.asal_ruteProperty = selectedrute(1)
        classrute.destinasi_ruteProperty = selectedrute(2)
        classrute.tarif_ruteProperty = selectedrute(3)
        classrute.jadwal_keberangkatanProperty = selectedrute(4)
        classrute.jadwal_kedatanganProperty = selectedrute(5)

        Dim edit_rute = New FormEditRute()
        edit_rute.Show()
    End Sub

    Private Sub BtnHapusRute_Click(sender As Object, e As EventArgs) Handles BtnHapusRute.Click
        'Dim resultrute As DialogResult = MessageBox.Show("Apakah ingin menghapus data rute?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'classrute.DeleteDataRuteByIDDatabase(selectedTableRute)

        Dim hapus_rute = New FormHapusRute
        hapus_rute.Show()
    End Sub

    'BTN TAMBAH PENUMPANG (tambah edit delete grid)
    Private Sub BtnTambahPenumpang_Click(sender As Object, e As EventArgs) Handles BtnTambahPenumpang.Click
        Dim tambah_penumpang = New FormTambahPenumpang()
        tambah_penumpang.Show()
    End Sub

    Private Sub DataGridPenumpang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPenumpang.CellClick
        Dim indexPenumpang As Integer = e.RowIndex
        Dim selectedRowPenumpang As DataGridViewRow
        selectedRowPenumpang = DataGridPenumpang.Rows(indexPenumpang)

        selectedTablePenumpang = selectedRowPenumpang.Cells(0).Value
        selectedTableNamaPenumpang = selectedRowPenumpang.Cells(1).Value
    End Sub

    Private Sub BtnEditPenumpang_Click(sender As Object, e As EventArgs) Handles BtnEditPenumpang.Click
        Dim selectedPenumpang As List(Of String) = classpenumpang.GetDataPenumpangByNIKDatabase(selectedTablePenumpang)

        classpenumpang.NIKProperty = selectedPenumpang(0)
        classpenumpang.nama_penumpangProperty = selectedPenumpang(1)
        classpenumpang.alamat_penumpangProperty = selectedPenumpang(2)
        classpenumpang.jenis_kelaminProperty = selectedPenumpang(3)

        Dim edit_penumpang = New FormEditPenumpang()
        edit_penumpang.Show()
    End Sub

    Private Sub BtnHapusPenumpang_Click(sender As Object, e As EventArgs) Handles BtnHapusPenumpang.Click
        'Dim resultpenumpang As DialogResult = MessageBox.Show("Apakah ingin menghapus data penumpang?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'classpenumpang.DeleteDataPenumpangByNIKDatabase(selectedTablePenumpang)
        Dim hapus_penumpang = New FormHapusPenumpang
        hapus_penumpang.Show()

    End Sub


End Class