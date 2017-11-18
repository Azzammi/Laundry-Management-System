Imports System.Data
Imports Microsoft.Win32
Imports System.Threading
Imports System.Windows.Threading

Class MainWindow

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Load(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim dptimer As New DispatcherTimer
        dptimer.Start()

        AddHandler dptimer.Tick, AddressOf dptimer_tick
        'TIMELbl.Content = Format(Now, "hh:mm:ss")

        Dim Start_Page As New StartPage
        Frame1.Content = Start_Page

        'Dim Log_In As New Login

        'Log_In.Left = Me.Left
        'Log_In.Top = Me.Top
        'Log_In.Width = Me.Width
        'Log_In.Height = Me.Height

        'If Me.WindowState = Windows.WindowState.Normal Then
        '    Log_In.WindowState = Windows.WindowState.Normal
        'ElseIf Me.WindowState = Windows.WindowState.Maximized Then
        '    Log_In.WindowState = Windows.WindowState.Maximized
        'End If

        'Log_In.Owner = Me
        'Log_In.Show()

    End Sub

    Private Sub dptimer_tick(sender As Object, e As EventArgs)
        TIMELbl.Content = Format(Now, "hh:mm:ss")
    End Sub
    Private Sub TPenggunaBtn_Click(sender As Object, e As RoutedEventArgs) Handles TPenggunaBtn.Click
        StatusS = True
        Dim Pengguna As New Pengguna
        Pengguna.ShowDialog()
    End Sub

    Private Sub lPenggunaBtn_Click(sender As Object, e As RoutedEventArgs) Handles lPenggunaBtn.Click
        Dim ViewPengguna As New ViewPengguna
        ViewPengguna.ShowDialog()
    End Sub

    Private Sub TBarang_Click(sender As Object, e As RoutedEventArgs) Handles TBarang.Click
        StatusS = True
        Dim TBarang As New Barang
        TBarang.ShowDialog()
    End Sub

    Private Sub LBarang_Click(sender As Object, e As RoutedEventArgs) Handles LBarang.Click
        Dim LBarang As New ViewBarang
        LBarang.ShowDialog()
    End Sub

    Private Sub TKaryawan_Click(sender As Object, e As RoutedEventArgs) Handles TKaryawan.Click
        StatusS = True
        Dim TKaryawan As New Karyawan
        TKaryawan.ShowDialog()
    End Sub

    Private Sub LKaryawan_Click(sender As Object, e As RoutedEventArgs) Handles LKaryawan.Click
        Dim LKaryawan As New ViewKaryawan
        LKaryawan.ShowDialog()
    End Sub

    Private Sub TKonsumen_Click(sender As Object, e As RoutedEventArgs) Handles TKonsumen.Click
        StatusS = True
        Dim TBarang As New konsumen
        TBarang.ShowDialog()
    End Sub

    Private Sub LKonsumen_Click(sender As Object, e As RoutedEventArgs) Handles LKonsumen.Click
        Dim LBarang As New ViewKonsumen
        LBarang.ShowDialog()
    End Sub

    Private Sub RTransaksiBtn_Click(sender As Object, e As RoutedEventArgs) Handles RTransaksiBtn.Click
        Dim RTransaksi As New RincianTransaksi
        RTransaksi.ShowDialog()
    End Sub

    Private Sub RPembelianBtn_Click(sender As Object, e As RoutedEventArgs) Handles RPembelianBtn.Click
        Dim RPembelian As New RincianPembelian
        RPembelian.ShowDialog()
    End Sub

    Private Sub TSupplier_Click(sender As Object, e As RoutedEventArgs) Handles TSupplier.Click
        Dim TSupplier As New Supplier
        TSupplier.ShowDialog()
    End Sub

    Private Sub LSupplier_Click(sender As Object, e As RoutedEventArgs) Handles LSupplier.Click
        Dim LSupplier As New ViewSupplier
        LSupplier.ShowDialog()
    End Sub

    Private Sub JenisLaundryBtn_Click(sender As Object, e As RoutedEventArgs) Handles JenisLaundryBtn.Click
        Dim JenisLaundry As New ViewJenisLaundry
        JenisLaundry.ShowDialog()
    End Sub

    Private Sub TarifBtn_Click(sender As Object, e As RoutedEventArgs) Handles TarifBtn.Click
        Dim Tarif As New ViewTarif
        Tarif.ShowDialog()
    End Sub

    Private Sub Transaksi_click(sender As Object, e As RoutedEventArgs) Handles TransaksiBtn.Click
        Dim Transaksi As New Transaksi
        Transaksi.ShowDialog()
    End Sub

    Private Sub Pembelian_click(sender As Object, e As RoutedEventArgs) Handles PembelianBtn.Click
        Dim Pembelian As New Pembelian
        Pembelian.ShowDialog()
    End Sub
    Private Sub InfoBtn_Click(sender As Object, e As RoutedEventArgs) Handles InfoBtn.Click
        Dim About As New AboutBox1
        About.ShowDialog()
    End Sub

    Private Sub PemakaianBrgBtn_Click(sender As Object, e As RoutedEventArgs) Handles PemakaianBrgBtn.Click
        Dim Pemakai As New ViewPemakaianBarang2
        Pemakai.ShowDialog()
    End Sub

    Private Sub LaporanbarangBtn_Click(sender As Object, e As RoutedEventArgs) Handles LaporanbarangBtn.Click
        Dim Lpr As New Laporan
        Lpr.ShowDialog()
    End Sub

    Private Sub LaporankaryawanBtn_Click(sender As Object, e As RoutedEventArgs) Handles LaporankaryawanBtn.Click
        Dim Lprkaryawan As New LaporanKaryawan
        Lprkaryawan.ShowDialog()
    End Sub

    Private Sub LaporankonsumenBtn_Click(sender As Object, e As RoutedEventArgs) Handles LaporankonsumenBtn.Click
        Dim LprKonsumen As New laporanKonsumen
        LprKonsumen.ShowDialog()
    End Sub

    Private Sub LaporanpembelianBtn_Click(sender As Object, e As RoutedEventArgs) Handles LaporanpembelianBtn.Click
        Dim LprPembelian As New laporanpe
        LprPembelian.ShowDialog()
    End Sub

    Private Sub LaporansupplierBtn_Click(sender As Object, e As RoutedEventArgs) Handles LaporansupplierBtn.Click
        Dim LprSupplier As New LaporanSupplier
        LprSupplier.ShowDialog()
    End Sub

    Private Sub LaporantransaksiBtn_Click(sender As Object, e As RoutedEventArgs) Handles LaporantransaksiBtn.Click
        Dim LprTransaksi As New LaporanTransaksi
        LprTransaksi.ShowDialog()
    End Sub

    Private Sub AboutMenuBtn_Checked(sender As Object, e As RoutedEventArgs) Handles AboutMenuBtn.Checked
        Dim About As New AboutBox1
        About.ShowDialog()
    End Sub

    Private Sub ProfilBtn_Click(sender As Object, e As RoutedEventArgs) Handles ProfilBtn.Click
        Dim Profil As New AboutBox2
        Profil.ShowDialog()
    End Sub
End Class
