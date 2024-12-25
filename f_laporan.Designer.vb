<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_laporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_laporan))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dt_akhir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_awal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_customer = New System.Windows.Forms.TextBox()
        Me.l_namacustomer = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.l_namabarang = New System.Windows.Forms.Label()
        Me.txt_barang = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.b_rincian = New System.Windows.Forms.Button()
        Me.b_cust = New System.Windows.Forms.Button()
        Me.b_tanggal = New System.Windows.Forms.Button()
        Me.bw_report = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.b_setting = New System.Windows.Forms.Button()
        Me.b_export = New System.Windows.Forms.Button()
        Me.b_print = New System.Windows.Forms.Button()
        Me.bw_customer = New System.ComponentModel.BackgroundWorker()
        Me.bw_barang = New System.ComponentModel.BackgroundWorker()
        Me.grid_customer = New System.Windows.Forms.DataGridView()
        Me.bs_report1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_customer = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_barang = New System.Windows.Forms.BindingSource(Me.components)
        Me.grid_barang = New System.Windows.Forms.DataGridView()
        Me.grid_report = New ADGV.AdvancedDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bs_report2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_report3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.bs_report4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.panel_header.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.grid_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.bs_report2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_report3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_report4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.Controls.Add(Me.TableLayoutPanel2)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(1015, 100)
        Me.panel_header.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dt_akhir, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dt_awal, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_customer, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.l_namacustomer, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.l_namabarang, 7, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_barang, 7, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(2, 10, 0, 2)
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1015, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'dt_akhir
        '
        Me.dt_akhir.CustomFormat = "dd MMM yyyy"
        Me.dt_akhir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dt_akhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_akhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_akhir.Location = New System.Drawing.Point(106, 57)
        Me.dt_akhir.Name = "dt_akhir"
        Me.dt_akhir.Size = New System.Drawing.Size(196, 30)
        Me.dt_akhir.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 44)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sampai"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_awal
        '
        Me.dt_awal.CustomFormat = "dd MMM yyyy"
        Me.dt_awal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dt_awal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_awal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_awal.Location = New System.Drawing.Point(106, 13)
        Me.dt_awal.Name = "dt_awal"
        Me.dt_awal.Size = New System.Drawing.Size(196, 30)
        Me.dt_awal.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 44)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_customer
        '
        Me.txt_customer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer.Location = New System.Drawing.Point(459, 13)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.Size = New System.Drawing.Size(196, 30)
        Me.txt_customer.TabIndex = 5
        '
        'l_namacustomer
        '
        Me.l_namacustomer.AutoSize = True
        Me.l_namacustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.l_namacustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_namacustomer.Location = New System.Drawing.Point(459, 54)
        Me.l_namacustomer.Name = "l_namacustomer"
        Me.l_namacustomer.Size = New System.Drawing.Size(196, 44)
        Me.l_namacustomer.TabIndex = 6
        Me.l_namacustomer.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(711, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 44)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Barang"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_namabarang
        '
        Me.l_namabarang.AutoSize = True
        Me.l_namabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_namabarang.Location = New System.Drawing.Point(812, 54)
        Me.l_namabarang.Name = "l_namabarang"
        Me.l_namabarang.Size = New System.Drawing.Size(51, 20)
        Me.l_namabarang.TabIndex = 8
        Me.l_namabarang.Text = "Nama"
        '
        'txt_barang
        '
        Me.txt_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_barang.Location = New System.Drawing.Point(812, 13)
        Me.txt_barang.Name = "txt_barang"
        Me.txt_barang.Size = New System.Drawing.Size(196, 30)
        Me.txt_barang.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.b_rincian, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.b_cust, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.b_tanggal, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 100)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1015, 66)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'b_rincian
        '
        Me.b_rincian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b_rincian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_rincian.Location = New System.Drawing.Point(678, 8)
        Me.b_rincian.Name = "b_rincian"
        Me.b_rincian.Size = New System.Drawing.Size(329, 50)
        Me.b_rincian.TabIndex = 2
        Me.b_rincian.Text = "Rincian Penjualan"
        Me.b_rincian.UseVisualStyleBackColor = True
        '
        'b_cust
        '
        Me.b_cust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b_cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_cust.Location = New System.Drawing.Point(343, 8)
        Me.b_cust.Name = "b_cust"
        Me.b_cust.Size = New System.Drawing.Size(329, 50)
        Me.b_cust.TabIndex = 1
        Me.b_cust.Text = "Rekap Penjualan per Hari"
        Me.b_cust.UseVisualStyleBackColor = True
        '
        'b_tanggal
        '
        Me.b_tanggal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tanggal.Location = New System.Drawing.Point(8, 8)
        Me.b_tanggal.Name = "b_tanggal"
        Me.b_tanggal.Size = New System.Drawing.Size(329, 50)
        Me.b_tanggal.TabIndex = 0
        Me.b_tanggal.Text = "Rekap Penjualan per Bulan"
        Me.b_tanggal.UseVisualStyleBackColor = True
        '
        'bw_report
        '
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.b_setting, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.b_export, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.b_print, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 595)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1015, 66)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'b_setting
        '
        Me.b_setting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b_setting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_setting.Location = New System.Drawing.Point(8, 8)
        Me.b_setting.Name = "b_setting"
        Me.b_setting.Size = New System.Drawing.Size(329, 50)
        Me.b_setting.TabIndex = 3
        Me.b_setting.TabStop = False
        Me.b_setting.UseVisualStyleBackColor = True
        '
        'b_export
        '
        Me.b_export.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b_export.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_export.Location = New System.Drawing.Point(678, 8)
        Me.b_export.Name = "b_export"
        Me.b_export.Size = New System.Drawing.Size(329, 50)
        Me.b_export.TabIndex = 2
        Me.b_export.Text = "Export"
        Me.b_export.UseVisualStyleBackColor = True
        '
        'b_print
        '
        Me.b_print.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_print.Location = New System.Drawing.Point(343, 8)
        Me.b_print.Name = "b_print"
        Me.b_print.Size = New System.Drawing.Size(329, 50)
        Me.b_print.TabIndex = 1
        Me.b_print.Text = "Laporan Stock"
        Me.b_print.UseVisualStyleBackColor = True
        '
        'bw_customer
        '
        '
        'bw_barang
        '
        '
        'grid_customer
        '
        Me.grid_customer.AllowUserToAddRows = False
        Me.grid_customer.AllowUserToDeleteRows = False
        Me.grid_customer.AllowUserToResizeRows = False
        Me.grid_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_customer.ColumnHeadersVisible = False
        Me.grid_customer.Location = New System.Drawing.Point(555, 261)
        Me.grid_customer.MultiSelect = False
        Me.grid_customer.Name = "grid_customer"
        Me.grid_customer.ReadOnly = True
        Me.grid_customer.RowHeadersVisible = False
        Me.grid_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_customer.ShowCellErrors = False
        Me.grid_customer.ShowCellToolTips = False
        Me.grid_customer.ShowEditingIcon = False
        Me.grid_customer.ShowRowErrors = False
        Me.grid_customer.Size = New System.Drawing.Size(361, 215)
        Me.grid_customer.TabIndex = 4
        '
        'grid_barang
        '
        Me.grid_barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_barang.ColumnHeadersVisible = False
        Me.grid_barang.Location = New System.Drawing.Point(646, 172)
        Me.grid_barang.MultiSelect = False
        Me.grid_barang.Name = "grid_barang"
        Me.grid_barang.ReadOnly = True
        Me.grid_barang.RowHeadersVisible = False
        Me.grid_barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_barang.Size = New System.Drawing.Size(361, 215)
        Me.grid_barang.TabIndex = 5
        '
        'grid_report
        '
        Me.grid_report.AutoGenerateContextFilters = True
        Me.grid_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_report.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_report.ColumnHeadersHeight = 40
        Me.grid_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_report.DateWithTime = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_report.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_report.Location = New System.Drawing.Point(5, 5)
        Me.grid_report.Name = "grid_report"
        Me.grid_report.RowHeadersVisible = False
        Me.grid_report.Size = New System.Drawing.Size(1005, 414)
        Me.grid_report.TabIndex = 6
        Me.grid_report.TimeFilter = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_report)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(1015, 424)
        Me.Panel1.TabIndex = 7
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 166)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1015, 5)
        Me.ProgressBar1.TabIndex = 7
        '
        'f_laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 661)
        Me.Controls.Add(Me.grid_customer)
        Me.Controls.Add(Me.grid_barang)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.panel_header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "f_laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_header.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.grid_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.bs_report2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_report3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_report4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dt_awal As DateTimePicker
    Friend WithEvents dt_akhir As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents b_tanggal As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_customer As TextBox
    Friend WithEvents b_rincian As Button
    Friend WithEvents b_cust As Button
    Friend WithEvents l_namacustomer As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents l_namabarang As Label
    Friend WithEvents txt_barang As TextBox
    Friend WithEvents bw_report As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents b_export As Button
    Friend WithEvents b_print As Button
    Friend WithEvents bw_customer As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_barang As System.ComponentModel.BackgroundWorker
    Friend WithEvents b_setting As Button
    Friend WithEvents grid_customer As DataGridView
    Friend WithEvents bs_report1 As BindingSource
    Friend WithEvents bs_customer As BindingSource
    Friend WithEvents bs_barang As BindingSource
    Friend WithEvents grid_barang As DataGridView
    Friend WithEvents grid_report As ADGV.AdvancedDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bs_report2 As BindingSource
    Friend WithEvents bs_report3 As BindingSource
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents bs_report4 As BindingSource
End Class
