Imports System.ComponentModel
Imports System.Data.SqlClient
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Excel

Public Class f_laporan
    Dim conn_report As MySqlConnection
    Dim conn_customer As MySqlConnection
    Dim conn_barang As MySqlConnection
    Dim cmd_customer As MySqlCommand
    Dim cmd_barang As MySqlCommand
    Dim cmd_report As MySqlCommand
    Dim secretpass As String = ""
    Dim connectionString As String = "Server=" & My.Settings.server & ";Database=" & My.Settings.database & ";User Id=" & My.Settings.user & ";Password=" & My.Settings.pass & ";"
    Dim report_idx As Integer

    Dim da_report As MySqlDataAdapter
    Dim ds_report As DataSet
    Dim ds_barang As DataSet
    Dim ds_customer As DataSet

    Public Class param
        Public sql As String
        Public awal As Date
        Public akhir As Date
        Public cust As String
        Public barang As String
    End Class

    Dim var_param As param = New param()

    Private Sub busy(yes As Boolean)
        If yes = True Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Private Sub kosong()
        dt_awal.Value = Now
        dt_akhir.Value = Now
        dt_akhir.Checked = False
        txt_customer.Clear()
        l_namacustomer.Text = ""
        txt_barang.Clear()
        l_namabarang.Text = ""
        grid_customer.Hide()
        grid_barang.Hide()
    End Sub



    Private Sub b_setting_KeyDown(sender As Object, e As KeyEventArgs) Handles b_setting.KeyDown
        If e.KeyCode = Keys.F1 Then
            secretpass = ""
        ElseIf e.KeyCode = Keys.F3 Then
            MsgBox(secretpass)
        Else
            secretpass = secretpass + Chr(e.KeyValue)
            ' MsgBox(Chr(e.KeyValue) & vbCrLf & secretpass)
        End If


        If secretpass = My.Settings.secretpass Then
            'MsgBox("sukses")
            f_setting.ShowDialog()
        End If
    End Sub

    Private Sub txt_customer_TextChanged(sender As Object, e As EventArgs) Handles txt_customer.TextChanged
        If txt_customer.Text.Length > 0 Then
            If grid_customer.Visible = False Then
                grid_customer.Show()
                grid_barang.Hide()
                grid_customer.Location = txt_customer.Location
                grid_customer.Top = grid_customer.Top + txt_customer.Height + 2
            Else
                'If (grid_customer.CurrentRow.Cells(1).Value.ToString = txt_customer.Text Or grid_customer.CurrentRow.Cells(0).Value.ToString = txt_customer.Text) And grid_customer.Rows.Count = 1 Then
                '    l_namacustomer.Text = grid_customer.CurrentRow.Cells(1).Value.ToString
                '    grid_customer.Hide()
                'End If
                bs_customer.Filter = "kode like '%" & txt_customer.Text & "%' or nama like '%" & txt_customer.Text & "%'"
            End If
        Else
            grid_customer.Hide()
            bs_customer.RemoveFilter()
            l_namacustomer.Text = ""

        End If
        grid_customer.Refresh()
    End Sub
    Private Sub txt_barang_TextChanged(sender As Object, e As EventArgs) Handles txt_barang.TextChanged
        If txt_barang.Text.Length > 0 Then
            If grid_barang.Visible = False Then
                grid_barang.Show()
                grid_customer.Hide()
                grid_barang.Location = txt_barang.Location
                grid_barang.Top = grid_barang.Top + txt_barang.Height + 2
                grid_barang.Left = grid_barang.Left - grid_barang.Width + txt_barang.Width
            Else
                'If (grid_customer.CurrentRow.Cells(1).Value.ToString = txt_customer.Text Or grid_customer.CurrentRow.Cells(0).Value.ToString = txt_customer.Text) And grid_customer.Rows.Count = 1 Then
                '    l_namacustomer.Text = grid_customer.CurrentRow.Cells(1).Value.ToString
                '    grid_customer.Hide()
                'End If
                bs_barang.Filter = "kode like '%" & txt_barang.Text & "%' or nama like '%" & txt_customer.Text & "%'"
            End If
        Else
            grid_barang.Hide()
            bs_barang.RemoveFilter()
            l_namabarang.Text = ""

        End If
        grid_barang.Refresh()
    End Sub

    Private Sub f_laporan_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        kosong()
        load_customer()
        load_barang()
    End Sub

    Private Sub load_customer()

        bw_customer.WorkerReportsProgress = True
        bw_customer.WorkerSupportsCancellation = True
        If bw_customer.IsBusy = False Then
            busy(True)
            bw_customer.RunWorkerAsync()
        End If
    End Sub

    Private Sub load_barang()

        bw_barang.WorkerReportsProgress = True
        bw_barang.WorkerSupportsCancellation = True
        If bw_barang.IsBusy = False Then
            busy(True)
            bw_barang.RunWorkerAsync()
        End If
    End Sub

    Private Sub sp_customer()
        connectionString = "Server=" & My.Settings.server & ";Database=" & My.Settings.database & ";User Id=" & My.Settings.user & ";Password=" & My.Settings.pass & ";"
        conn_customer = New MySqlConnection(connectionString)
        cmd_customer = New MySqlCommand(My.Settings.sql_customer, conn_customer)
        'cmd_customer.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.AddWithValue("@param", param)
    End Sub
    Private Sub sp_barang()
        connectionString = "Server=" & My.Settings.server & ";Database=" & My.Settings.database & ";User Id=" & My.Settings.user & ";Password=" & My.Settings.pass & ";"
        conn_barang = New MySqlConnection(connectionString)
        cmd_barang = New MySqlCommand(My.Settings.sql_barang, conn_barang)
        'cmd_customer.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.AddWithValue("@param", param)
    End Sub

    Private Sub sp_report(sql As String, awal As String, akhir As String, cust As String, barang As String)
        connectionString = "Server=" & My.Settings.server & ";Database=" & My.Settings.database & ";User Id=" & My.Settings.user & ";Password=" & My.Settings.pass & ";"
        conn_report = New MySqlConnection(connectionString)

        'sql = Replace(sql, "$awal", awal)
        'sql = Replace(sql, "$akhir", akhir)
        'sql = Replace(sql, "$cust", cust)
        'sql = Replace(sql, "$barang", barang)

        ' MsgBox(sql)
        cmd_report = New MySqlCommand(sql, conn_report)
        cmd_report.Parameters.AddWithValue("@awal", awal)
        cmd_report.Parameters.AddWithValue("@akhir", akhir)
        cmd_report.Parameters.AddWithValue("@customer", cust)
        cmd_report.Parameters.AddWithValue("@barang", barang)
        ' cmd_report.CommandType = CommandType.Text
        'cmd_customer.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.AddWithValue("@param", param)
    End Sub

    Private Sub b_rincian_Click(sender As Object, e As EventArgs) Handles b_rincian.Click
        report_idx = 3
        var_param.sql = My.Settings.sql_report3
        var_param.awal = dt_awal.Value
        var_param.akhir = dt_akhir.Value
        var_param.cust = txt_customer.Text
        var_param.barang = txt_barang.Text

        Try
            grid_report.Columns(2).Frozen = False
            grid_report.Columns(3).Frozen = False
            grid_report.Columns(4).Frozen = False
            grid_report.Columns(5).Frozen = False
        Catch ex As Exception

        End Try


        bw_report.WorkerReportsProgress = True
        bw_report.WorkerSupportsCancellation = True
        If bw_report.IsBusy = False Then
            busy(True)
            bw_report.RunWorkerAsync(var_param)
        End If
    End Sub

    Private Sub bw_customer_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_customer.DoWork
        Try
            sp_customer()
            Dim adapter As New MySqlDataAdapter(cmd_customer)
            adapter.SelectCommand.Connection = conn_customer ' Inisialisasi properti Connection

            ds_customer = New DataSet
            'ds_absen = New DataSet
            ds_customer.Clear()
            adapter.Fill(ds_customer, "customer")
        Catch ex As Exception

        End Try




    End Sub

    Private Sub bw_barang_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_barang.DoWork
        Try
            sp_barang()
            Dim adapter As New MySqlDataAdapter(cmd_barang)
            adapter.SelectCommand.Connection = conn_barang ' Inisialisasi properti Connection

            ds_barang = New DataSet
            'ds_absen = New DataSet
            ds_barang.Clear()
            adapter.Fill(ds_barang, "barang")
        Catch ex As Exception

        End Try




    End Sub
    Private Sub bw_report_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_report.DoWork
        Try
            Dim var_sql As String = CStr(e.Argument.sql)
            Dim var_awal As Date = CStr(e.Argument.awal)
            Dim var_akhir As Date = CStr(e.Argument.akhir)
            Dim var_cust As String = CStr(e.Argument.cust)
            Dim var_barang As String = CStr(e.Argument.barang)

            connectionString = "Server=" & My.Settings.server & ";Database=" & My.Settings.database & ";User Id=" & My.Settings.user & ";Password=" & My.Settings.pass & ";"
            conn_report = New MySqlConnection(connectionString)

            'sql = Replace(sql, "$awal", awal)
            'sql = Replace(sql, "$akhir", akhir)
            'sql = Replace(sql, "$cust", cust)
            'sql = Replace(sql, "$barang", barang)

            ' MsgBox(sql)
            cmd_report = New MySqlCommand(var_sql, conn_report)
            If report_idx <> 4 Then
                cmd_report.Parameters.AddWithValue("@awal", var_awal)
                cmd_report.Parameters.AddWithValue("@akhir", var_akhir)
                cmd_report.Parameters.AddWithValue("@customer", var_cust)
                cmd_report.Parameters.AddWithValue("@barang", var_barang)
            End If

            da_report = New MySqlDataAdapter(cmd_report)
            ds_report = New DataSet
            'ds_absen = New DataSet
            ds_report.Clear()
            da_report.Fill(ds_report, "report" & report_idx)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub bw_customer_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_customer.RunWorkerCompleted
        bs_customer.DataSource = (ds_customer.Tables("customer"))
        grid_customer.DataSource = bs_customer
        If grid_customer.Rows.Count > 0 Then
            Try
                'atur_grid(grid_absen, param)
                grid_customer.Columns(0).Frozen = True
                ' grid_customer.Columns(1).Frozen = True
            Catch ex As Exception

            End Try

        End If

        conn_customer.Close()

        If bw_customer.IsBusy = False And bw_barang.IsBusy = False And bw_report.IsBusy = False Then
            busy(False)
        Else
            busy(True)
        End If

    End Sub

    Private Sub bw_barang_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_barang.RunWorkerCompleted
        bs_barang.DataSource = (ds_barang.Tables("barang"))
        grid_barang.DataSource = bs_barang
        If grid_barang.Rows.Count > 0 Then
            Try
                'atur_grid(grid_absen, param)
                grid_barang.Columns(0).Frozen = True
                ' grid_customer.Columns(1).Frozen = True
            Catch ex As Exception

            End Try

        End If

        conn_barang.Close()

        If bw_customer.IsBusy = False And bw_barang.IsBusy = False And bw_report.IsBusy = False Then
            busy(False)
        Else
            busy(True)
        End If

    End Sub
    Private Sub bw_report_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_report.RunWorkerCompleted
        grid_report.Columns.Clear()

        If report_idx = 1 Then
            bs_report1.DataSource = (ds_report.Tables("report" & report_idx))
            grid_report.DataSource = bs_report1
        ElseIf report_idx = 2 Then
            bs_report2.DataSource = (ds_report.Tables("report" & report_idx))
            grid_report.DataSource = bs_report2
        ElseIf report_idx = 3 Then
            bs_report3.DataSource = (ds_report.Tables("report" & report_idx))
            grid_report.DataSource = bs_report3
        ElseIf report_idx = 4 Then
            bs_report4.DataSource = (ds_report.Tables("report" & report_idx))
            grid_report.DataSource = bs_report4
        End If


        If grid_report.Rows.Count > 0 Then
            Try
                'atur_grid(grid_absen, param)
                grid_report.Columns(0).Visible = False
                grid_report.Columns(1).Visible = False
                'grid_report.Columns(2).Frozen = True
                'grid_report.Columns(3).Frozen = True
                'grid_report.Columns(4).Frozen = True
                'grid_report.Columns(5).Frozen = True
                ' grid_customer.Columns(1).Frozen = True

                If report_idx = 1 Then
                    grid_report.Columns(2).Width = 200
                    grid_report.Columns(3).Width = 200
                    grid_report.Columns(4).Width = 100

                    grid_report.Columns(4).DefaultCellStyle.Format = "N0"
                    grid_report.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf report_idx = 2 Then
                    grid_report.Columns(2).Width = 200
                    grid_report.Columns(3).Width = 100
                    grid_report.Columns(4).Width = 200
                    grid_report.Columns(5).Width = 200
                    grid_report.Columns(6).Width = 100

                    grid_report.Columns(6).DefaultCellStyle.Format = "N0"
                    grid_report.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                ElseIf report_idx = 3 Then

                    grid_report.Columns(7).DefaultCellStyle.Format = "N2"
                    grid_report.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grid_report.Columns(9).DefaultCellStyle.Format = "N0"
                    grid_report.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grid_report.Columns(10).DefaultCellStyle.Format = "N2"
                    grid_report.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grid_report.Columns(11).DefaultCellStyle.Format = "N0"
                    grid_report.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grid_report.Columns(12).DefaultCellStyle.Format = "N0"
                    grid_report.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf report_idx = 4 Then
                    grid_report.Columns(0).Visible = True
                    grid_report.Columns(1).Visible = True
                    grid_report.Columns(2).DefaultCellStyle.Format = "N2"
                    grid_report.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grid_report.Columns(3).DefaultCellStyle.Format = "N0"
                    grid_report.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grid_report.Columns(4).DefaultCellStyle.Format = "N2"
                    grid_report.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            Catch ex As Exception

            End Try

        End If

        conn_report.Close()

        If bw_customer.IsBusy = False And bw_barang.IsBusy = False And bw_report.IsBusy = False Then
            busy(False)
        Else
            busy(True)
        End If

    End Sub

    'Private Sub b_print_Click(sender As Object, e As EventArgs) Handles b_print.Click
    '    Dim connectionString As String = "Server=127.0.0.1;Database=kiosku;User Id=root;Password=;"
    '    Dim connection As New MySqlConnection(connectionString)

    '    Try
    '        connection.Open()
    '        Dim cmd As New MySqlCommand("sp_customer", connection)
    '        cmd.CommandType = CommandType.StoredProcedure

    '        Dim adapter As New MySqlDataAdapter(cmd)
    '        adapter.SelectCommand.Connection = connection ' Inisialisasi properti Connection

    '        Dim dataTable As New DataTable()
    '        adapter.Fill(dataTable)

    '        bs_customer.DataSource = dataTable
    '        grid_customer.DataSource = bs_customer
    '    Catch ex As Exception
    '        MessageBox.Show("Kesalahan: " & ex.Message)
    '    Finally
    '        connection.Close()
    '    End Try
    'End Sub

    Private Sub grid_customer_DoubleClick(sender As Object, e As EventArgs) Handles grid_customer.DoubleClick
        txt_customer.Text = grid_customer.CurrentRow.Cells(0).Value.ToString
        l_namacustomer.Text = grid_customer.CurrentRow.Cells(1).Value.ToString
        grid_customer.Hide()
    End Sub
    Private Sub grid_barang_DoubleClick(sender As Object, e As EventArgs) Handles grid_barang.DoubleClick
        txt_barang.Text = grid_barang.CurrentRow.Cells(0).Value.ToString
        l_namabarang.Text = grid_barang.CurrentRow.Cells(1).Value.ToString
        grid_barang.Hide()
    End Sub

    Private Sub dt_akhir_ValueChanged(sender As Object, e As EventArgs) Handles dt_akhir.ValueChanged
        If dt_akhir.Value < dt_awal.Value Then
            dt_akhir.Value = dt_awal.Value
        End If
    End Sub

    Private Sub dt_awal_ValueChanged(sender As Object, e As EventArgs) Handles dt_awal.ValueChanged
        If dt_akhir.Value < dt_awal.Value Then
            dt_akhir.Value = dt_awal.Value

        End If
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub b_setting_Click(sender As Object, e As EventArgs) Handles b_setting.Click
        secretpass = ""
    End Sub

    Private Sub b_cust_Click(sender As Object, e As EventArgs) Handles b_cust.Click
        report_idx = 2
        var_param.sql = My.Settings.sql_report2
        var_param.awal = dt_awal.Value.ToString("yyyy-MM-dd")
        var_param.akhir = dt_akhir.Value.ToString("yyyy-MM-dd")
        var_param.cust = txt_customer.Text
        var_param.barang = txt_barang.Text

        Try
            grid_report.Columns(2).Frozen = False
            grid_report.Columns(3).Frozen = False
            grid_report.Columns(4).Frozen = False
            grid_report.Columns(5).Frozen = False
        Catch ex As Exception

        End Try


        bw_report.WorkerReportsProgress = True
        bw_report.WorkerSupportsCancellation = True
        If bw_report.IsBusy = False Then
            busy(True)
            bw_report.RunWorkerAsync(var_param)
        End If
    End Sub

    Private Sub b_tanggal_Click(sender As Object, e As EventArgs) Handles b_tanggal.Click
        report_idx = 1
        var_param.sql = My.Settings.sql_report1
        var_param.awal = dt_awal.Value.ToString("yyyy-MM-dd")
        var_param.akhir = dt_akhir.Value.ToString("yyyy-MM-dd")
        var_param.cust = txt_customer.Text
        var_param.barang = txt_barang.Text

        Try
            grid_report.Columns(2).Frozen = False
            grid_report.Columns(3).Frozen = False
            grid_report.Columns(4).Frozen = False
            grid_report.Columns(5).Frozen = False
        Catch ex As Exception

        End Try


        bw_report.WorkerReportsProgress = True
        bw_report.WorkerSupportsCancellation = True
        If bw_report.IsBusy = False Then
            busy(True)
            bw_report.RunWorkerAsync(var_param)
        End If
    End Sub

    Private Sub export()
        If grid_report.Rows.Count = 0 Then
            MsgBox("Data kosong, silahkan pilih data terlebih dahulu!", vbExclamation, "System")
        Else
            b_export.Enabled = False
            b_export.Text = "Prepare"
            Try
                SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
                If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Dim xlApp As Excel.Application
                    Dim xlWorkBook As Excel.Workbook
                    Dim xlWorkSheet As Excel.Worksheet
                    Dim misValue As Object = Reflection.Missing.Value
                    xlApp = New Excel.Application
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    xlWorkSheet = xlWorkBook.Sheets("Sheet1")

                    xlWorkSheet.Cells.NumberFormat = "@"
                    Dim r As Integer
                    'baris column header

                    If report_idx = 1 Then
                        xlWorkSheet.Cells(1, 1) = "Laporan Bulanan"
                        xlWorkSheet.Rows(1).Font.Bold = True
                        xlWorkSheet.Cells(2, 1) = "Periode " & grid_report.Rows(0).Cells(3).Value.ToString
                        xlWorkSheet.Rows(2).Font.Bold = True
                        xlWorkSheet.Cells(3, 1) = Now

                        xlWorkSheet.Cells(1, 1).columnwidth = 23
                        xlWorkSheet.Cells(1, 2).columnwidth = 32
                        xlWorkSheet.Cells(1, 3).columnwidth = 13
                        r = 5
                    ElseIf report_idx = 2 Then
                        xlWorkSheet.Cells(1, 1) = "Laporan Harian"
                        xlWorkSheet.Rows(1).Font.Bold = True
                        xlWorkSheet.Cells(2, 1) = "Periode " & grid_report.Rows(0).Cells(4).Value.ToString & " s/d " & grid_report.Rows(0).Cells(5).Value.ToString
                        xlWorkSheet.Rows(2).Font.Bold = True
                        xlWorkSheet.Cells(3, 1) = Now
                        xlWorkSheet.Cells(1, 1).columnwidth = 23
                        xlWorkSheet.Cells(1, 2).columnwidth = 10
                        xlWorkSheet.Cells(1, 3).columnwidth = 15
                        xlWorkSheet.Cells(1, 4).columnwidth = 15
                        xlWorkSheet.Cells(1, 5).columnwidth = 20
                        xlWorkSheet.Cells(1, 5).EntireColumn.NumberFormat = "@"
                        r = 5
                    ElseIf report_idx = 3 Then
                        xlWorkSheet.Cells(1, 1) = "Rincian Penjualan"
                        xlWorkSheet.Rows(1).Font.Bold = True
                        xlWorkSheet.Cells(2, 1) = "Customer : "
                        xlWorkSheet.Rows(2).Font.Bold = True
                        xlWorkSheet.Cells(3, 1) = "Customer : "
                        xlWorkSheet.Cells(4, 1) = "Barang : "
                        xlWorkSheet.Cells(5, 1) = Now
                        xlWorkSheet.Cells(1, 1).columnwidth = 23
                        r = 7

                    ElseIf report_idx = 4 Then
                        xlWorkSheet.Cells(1, 1) = "laporan Nilai Stock"
                        xlWorkSheet.Rows(1).Font.Bold = True
                        xlWorkSheet.Cells(2, 1) = "Tanggal Cetak : "
                        xlWorkSheet.Rows(2).Font.Bold = True
                        xlWorkSheet.Cells(2, 2) = Now
                        xlWorkSheet.Cells(1, 1).columnwidth = 23
                        r = 4
                    End If



                    For k As Integer = 2 To grid_report.Columns.Count - 1 'tanpa kolom 0
                        xlWorkSheet.Cells(r, k - 1) = grid_report.Columns(k).HeaderText
                        xlWorkSheet.Rows(r).Font.Bold = True
                    Next


                    'baris mulai data
                    ProgressBar1.Maximum = grid_report.RowCount
                    ProgressBar1.Value = 0
                    r = r + 1
                    For a As Integer = 1 To grid_report.Rows.Count
                        ProgressBar1.Value = a
                        For k As Integer = 2 To grid_report.Columns.Count - 1 'tanpa kolom 0
                            xlWorkSheet.Cells(r, k - 1) = grid_report.Rows(a - 1).Cells(k).Value
                        Next
                        r = r + 1
                    Next
                    xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                    xlWorkBook.Close()
                    xlApp.Quit()
                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)
                    b_export.Enabled = True
                    b_export.Text = "Export"
                    MsgBox("Berhasil disimpan" & vbCrLf & "di : " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "System")
                    ProgressBar1.Value = 0
                Else
                    b_export.Enabled = True
                    b_export.Text = "Export"
                    ProgressBar1.Value = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan data !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                b_export.Enabled = True
                b_export.Text = "Export"
                ProgressBar1.Value = 0
                Return
            End Try
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub b_export_Click(sender As Object, e As EventArgs) Handles b_export.Click
        export()
    End Sub

    Private Sub b_print_Click(sender As Object, e As EventArgs) Handles b_print.Click
        report_idx = 4
        var_param.sql = My.Settings.sql_report4
        var_param.awal = dt_awal.Value
        var_param.akhir = dt_akhir.Value
        var_param.cust = txt_customer.Text
        var_param.barang = txt_barang.Text
        Try
            grid_report.Columns(2).Frozen = False
            grid_report.Columns(3).Frozen = False
            grid_report.Columns(4).Frozen = False
            grid_report.Columns(5).Frozen = False
        Catch ex As Exception

        End Try


        bw_report.WorkerReportsProgress = True
        bw_report.WorkerSupportsCancellation = True
        If bw_report.IsBusy = False Then
            busy(True)
            bw_report.RunWorkerAsync(var_param)
        End If
    End Sub
End Class
