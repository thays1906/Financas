<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCobranca
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCobranca))
        Me.tabCtrlCobranca = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtLetreiroCobr = New GFT.Util.SuperLetreiro()
        Me.dgCobranca = New System.Windows.Forms.DataGridView()
        Me.chkDataGrid = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbCobrancaFiltro = New System.Windows.Forms.GroupBox()
        Me.chkPeriodo = New System.Windows.Forms.CheckBox()
        Me.cbAno = New GFT.Util.SuperComboBox()
        Me.lblDataFim = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.cbMes = New GFT.Util.SuperComboBox()
        Me.dtFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbStatus = New GFT.Util.SuperComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cbDevedor = New GFT.Util.SuperComboBox()
        Me.lblDevedor = New System.Windows.Forms.Label()
        Me.ImgListCobranca = New System.Windows.Forms.ImageList(Me.components)
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.tabCtrlCobranca.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgCobranca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCobrancaFiltro.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlCobranca
        '
        Me.tabCtrlCobranca.Controls.Add(Me.TabPage1)
        Me.tabCtrlCobranca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlCobranca.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlCobranca.ImageList = Me.ImgListCobranca
        Me.tabCtrlCobranca.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlCobranca.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCtrlCobranca.Name = "tabCtrlCobranca"
        Me.tabCtrlCobranca.Padding = New System.Drawing.Point(100, 6)
        Me.tabCtrlCobranca.SelectedIndex = 0
        Me.tabCtrlCobranca.Size = New System.Drawing.Size(1799, 753)
        Me.tabCtrlCobranca.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.txtLetreiroCobr)
        Me.TabPage1.Controls.Add(Me.dgCobranca)
        Me.TabPage1.Controls.Add(Me.gbCobrancaFiltro)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 61)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1791, 688)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Empréstimos"
        '
        'txtLetreiroCobr
        '
        Me.txtLetreiroCobr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiroCobr.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiroCobr.ForeColor = System.Drawing.Color.White
        Me.txtLetreiroCobr.Location = New System.Drawing.Point(64, 642)
        Me.txtLetreiroCobr.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLetreiroCobr.Name = "txtLetreiroCobr"
        Me.txtLetreiroCobr.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Direita
        Me.txtLetreiroCobr.Size = New System.Drawing.Size(416, 23)
        Me.txtLetreiroCobr.TabIndex = 2
        Me.txtLetreiroCobr.TextoLetreiro = "0,0 Registros"
        Me.txtLetreiroCobr.VelocidadeRolagem = 1
        '
        'dgCobranca
        '
        Me.dgCobranca.AllowUserToAddRows = False
        Me.dgCobranca.AllowUserToDeleteRows = False
        Me.dgCobranca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCobranca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCobranca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgCobranca.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgCobranca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCobranca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgCobranca.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgCobranca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCobranca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCobranca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCobranca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkDataGrid})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCobranca.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCobranca.EnableHeadersVisualStyles = False
        Me.dgCobranca.GridColor = System.Drawing.Color.Black
        Me.dgCobranca.Location = New System.Drawing.Point(64, 216)
        Me.dgCobranca.Margin = New System.Windows.Forms.Padding(4)
        Me.dgCobranca.Name = "dgCobranca"
        Me.dgCobranca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCobranca.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgCobranca.RowHeadersVisible = False
        Me.dgCobranca.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgCobranca.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgCobranca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCobranca.Size = New System.Drawing.Size(1661, 418)
        Me.dgCobranca.TabIndex = 1
        '
        'chkDataGrid
        '
        Me.chkDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chkDataGrid.HeaderText = "Selecionar"
        Me.chkDataGrid.MinimumWidth = 6
        Me.chkDataGrid.Name = "chkDataGrid"
        Me.chkDataGrid.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chkDataGrid.TrueValue = "true"
        Me.chkDataGrid.Width = 122
        '
        'gbCobrancaFiltro
        '
        Me.gbCobrancaFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCobrancaFiltro.BackColor = System.Drawing.Color.LightSlateGray
        Me.gbCobrancaFiltro.Controls.Add(Me.chkPeriodo)
        Me.gbCobrancaFiltro.Controls.Add(Me.cbAno)
        Me.gbCobrancaFiltro.Controls.Add(Me.lblDataFim)
        Me.gbCobrancaFiltro.Controls.Add(Me.Label1)
        Me.gbCobrancaFiltro.Controls.Add(Me.dtInicial)
        Me.gbCobrancaFiltro.Controls.Add(Me.lblDataInicio)
        Me.gbCobrancaFiltro.Controls.Add(Me.cbMes)
        Me.gbCobrancaFiltro.Controls.Add(Me.dtFinal)
        Me.gbCobrancaFiltro.Controls.Add(Me.Label2)
        Me.gbCobrancaFiltro.Controls.Add(Me.cbStatus)
        Me.gbCobrancaFiltro.Controls.Add(Me.lblStatus)
        Me.gbCobrancaFiltro.Controls.Add(Me.cbDevedor)
        Me.gbCobrancaFiltro.Controls.Add(Me.lblDevedor)
        Me.gbCobrancaFiltro.ForeColor = System.Drawing.Color.White
        Me.gbCobrancaFiltro.Location = New System.Drawing.Point(64, 25)
        Me.gbCobrancaFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCobrancaFiltro.Name = "gbCobrancaFiltro"
        Me.gbCobrancaFiltro.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCobrancaFiltro.Size = New System.Drawing.Size(1661, 142)
        Me.gbCobrancaFiltro.TabIndex = 0
        Me.gbCobrancaFiltro.TabStop = False
        Me.gbCobrancaFiltro.Text = "Filtro"
        '
        'chkPeriodo
        '
        Me.chkPeriodo.AutoSize = True
        Me.chkPeriodo.Location = New System.Drawing.Point(1184, 20)
        Me.chkPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPeriodo.Name = "chkPeriodo"
        Me.chkPeriodo.Size = New System.Drawing.Size(218, 29)
        Me.chkPeriodo.TabIndex = 12
        Me.chkPeriodo.Text = "Filtrar por Período"
        Me.chkPeriodo.UseVisualStyleBackColor = True
        '
        'cbAno
        '
        Me.cbAno.Alterado = False
        Me.cbAno.BackColor = System.Drawing.SystemColors.Window
        Me.cbAno.CorFundo = System.Drawing.SystemColors.Window
        Me.cbAno.CorFundoSelecionado = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbAno.CorTexto = System.Drawing.Color.Black
        Me.cbAno.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbAno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbAno.ForeColor = System.Drawing.Color.Black
        Me.cbAno.FormattingEnabled = True
        Me.cbAno.Location = New System.Drawing.Point(884, 81)
        Me.cbAno.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAno.Name = "cbAno"
        Me.cbAno.Size = New System.Drawing.Size(200, 33)
        Me.cbAno.SuperObrigatorio = False
        Me.cbAno.SuperTxtObrigatorio = ""
        Me.cbAno.TabIndex = 10
        '
        'lblDataFim
        '
        Me.lblDataFim.AutoSize = True
        Me.lblDataFim.Location = New System.Drawing.Point(1370, 53)
        Me.lblDataFim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataFim.Name = "lblDataFim"
        Me.lblDataFim.Size = New System.Drawing.Size(55, 25)
        Me.lblDataFim.TabIndex = 4
        Me.lblDataFim.Text = "Até:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(880, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ano:"
        '
        'dtInicial
        '
        Me.dtInicial.CalendarFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicial.CalendarForeColor = System.Drawing.Color.Black
        Me.dtInicial.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtInicial.Enabled = False
        Me.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicial.Location = New System.Drawing.Point(1184, 82)
        Me.dtInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Size = New System.Drawing.Size(183, 32)
        Me.dtInicial.TabIndex = 50
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.BackColor = System.Drawing.Color.Transparent
        Me.lblDataInicio.Location = New System.Drawing.Point(1179, 53)
        Me.lblDataInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(48, 25)
        Me.lblDataInicio.TabIndex = 5
        Me.lblDataInicio.Text = "De:"
        '
        'cbMes
        '
        Me.cbMes.Alterado = False
        Me.cbMes.BackColor = System.Drawing.SystemColors.Window
        Me.cbMes.CorFundo = System.Drawing.SystemColors.Window
        Me.cbMes.CorFundoSelecionado = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbMes.CorTexto = System.Drawing.Color.Black
        Me.cbMes.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbMes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbMes.ForeColor = System.Drawing.Color.Black
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(595, 81)
        Me.cbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(280, 33)
        Me.cbMes.SuperObrigatorio = False
        Me.cbMes.SuperTxtObrigatorio = ""
        Me.cbMes.TabIndex = 8
        '
        'dtFinal
        '
        Me.dtFinal.Enabled = False
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinal.Location = New System.Drawing.Point(1375, 82)
        Me.dtFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(184, 32)
        Me.dtFinal.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(591, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mês:"
        '
        'cbStatus
        '
        Me.cbStatus.Alterado = False
        Me.cbStatus.BackColor = System.Drawing.SystemColors.Window
        Me.cbStatus.CorFundo = System.Drawing.SystemColors.Window
        Me.cbStatus.CorFundoSelecionado = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbStatus.CorTexto = System.Drawing.Color.Black
        Me.cbStatus.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbStatus.ForeColor = System.Drawing.Color.Black
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(385, 81)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(200, 33)
        Me.cbStatus.SuperObrigatorio = False
        Me.cbStatus.SuperTxtObrigatorio = ""
        Me.cbStatus.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(381, 55)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(86, 25)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status:"
        '
        'cbDevedor
        '
        Me.cbDevedor.Alterado = False
        Me.cbDevedor.BackColor = System.Drawing.SystemColors.Window
        Me.cbDevedor.CorFundo = System.Drawing.SystemColors.Window
        Me.cbDevedor.CorFundoSelecionado = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbDevedor.CorTexto = System.Drawing.Color.Black
        Me.cbDevedor.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbDevedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbDevedor.ForeColor = System.Drawing.Color.Black
        Me.cbDevedor.FormattingEnabled = True
        Me.cbDevedor.Location = New System.Drawing.Point(35, 81)
        Me.cbDevedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDevedor.Name = "cbDevedor"
        Me.cbDevedor.Size = New System.Drawing.Size(341, 33)
        Me.cbDevedor.SuperObrigatorio = False
        Me.cbDevedor.SuperTxtObrigatorio = ""
        Me.cbDevedor.TabIndex = 3
        '
        'lblDevedor
        '
        Me.lblDevedor.AutoSize = True
        Me.lblDevedor.Location = New System.Drawing.Point(31, 55)
        Me.lblDevedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDevedor.Name = "lblDevedor"
        Me.lblDevedor.Size = New System.Drawing.Size(118, 25)
        Me.lblDevedor.TabIndex = 3
        Me.lblDevedor.Text = "Devedores"
        '
        'ImgListCobranca
        '
        Me.ImgListCobranca.ImageStream = CType(resources.GetObject("ImgListCobranca.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListCobranca.TransparentColor = System.Drawing.Color.Black
        Me.ImgListCobranca.Images.SetKeyName(0, "iconeCObr.png")
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnAdd)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbBotoes.Location = New System.Drawing.Point(0, 753)
        Me.gbBotoes.Margin = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Padding = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Size = New System.Drawing.Size(1799, 79)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnExportar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(1182, 16)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(271, 52)
        Me.btnExportar.TabIndex = 5
        Me.btnExportar.Text = " &Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1460, 16)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(271, 52)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(903, 16)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(271, 52)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.Enabled = False
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnEditar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditar
        Me.btnEditar.Location = New System.Drawing.Point(624, 16)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(271, 52)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = " &Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnAdd.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddBlue
        Me.btnAdd.Location = New System.Drawing.Point(346, 16)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(271, 52)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = " &Adicionar"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(62, 16)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(271, 52)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'frmCobranca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1799, 832)
        Me.Controls.Add(Me.tabCtrlCobranca)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCobranca"
        Me.tabCtrlCobranca.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgCobranca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCobrancaFiltro.ResumeLayout(False)
        Me.gbCobrancaFiltro.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlCobranca As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gbCobrancaFiltro As GroupBox
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents txtLetreiroCobr As GFT.Util.SuperLetreiro
    Friend WithEvents dgCobranca As DataGridView
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents ImgListCobranca As ImageList
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDataInicio As Label
    Friend WithEvents lblDataFim As Label
    Friend WithEvents lblDevedor As Label
    Friend WithEvents dtFinal As DateTimePicker
    Friend WithEvents dtInicial As DateTimePicker
    Friend WithEvents cbStatus As GFT.Util.SuperComboBox
    Friend WithEvents cbDevedor As GFT.Util.SuperComboBox
    Friend WithEvents chkPeriodo As CheckBox
    Friend WithEvents cbAno As GFT.Util.SuperComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMes As GFT.Util.SuperComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkDataGrid As DataGridViewCheckBoxColumn
End Class
