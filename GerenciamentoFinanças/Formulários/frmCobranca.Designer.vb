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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCobranca))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabCtrlCobranca = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkSelecionaTodos = New System.Windows.Forms.CheckBox()
        Me.gbCobrancaFiltro = New System.Windows.Forms.GroupBox()
        Me.chkPeriodo = New System.Windows.Forms.CheckBox()
        Me.lblDataFim = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.dtFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDevedor = New System.Windows.Forms.Label()
        Me.ImgListCobranca = New System.Windows.Forms.ImageList(Me.components)
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtLetreiroCobr = New GFT.Util.SuperLetreiro()
        Me.cbAno = New GFT.Util.SuperComboBox()
        Me.cbMes = New GFT.Util.SuperComboBox()
        Me.cbStatus = New GFT.Util.SuperComboBox()
        Me.cbDevedor = New GFT.Util.SuperComboBox()
        Me.datagridCobranca = New GFT.Util.SuperDataGridView()
        Me.tabCtrlCobranca.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbCobrancaFiltro.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        CType(Me.datagridCobranca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCtrlCobranca
        '
        Me.tabCtrlCobranca.Controls.Add(Me.TabPage1)
        Me.tabCtrlCobranca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlCobranca.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlCobranca.ImageList = Me.ImgListCobranca
        Me.tabCtrlCobranca.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlCobranca.Name = "tabCtrlCobranca"
        Me.tabCtrlCobranca.Padding = New System.Drawing.Point(100, 6)
        Me.tabCtrlCobranca.SelectedIndex = 0
        Me.tabCtrlCobranca.Size = New System.Drawing.Size(1349, 612)
        Me.tabCtrlCobranca.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.datagridCobranca)
        Me.TabPage1.Controls.Add(Me.chkSelecionaTodos)
        Me.TabPage1.Controls.Add(Me.txtLetreiroCobr)
        Me.TabPage1.Controls.Add(Me.gbCobrancaFiltro)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 61)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1341, 547)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Empréstimos"
        '
        'chkSelecionaTodos
        '
        Me.chkSelecionaTodos.AutoSize = True
        Me.chkSelecionaTodos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkSelecionaTodos.Location = New System.Drawing.Point(48, 168)
        Me.chkSelecionaTodos.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSelecionaTodos.Name = "chkSelecionaTodos"
        Me.chkSelecionaTodos.Size = New System.Drawing.Size(238, 22)
        Me.chkSelecionaTodos.TabIndex = 3
        Me.chkSelecionaTodos.Text = "Marcar / Desmarcar Todos"
        Me.chkSelecionaTodos.UseVisualStyleBackColor = True
        '
        'gbCobrancaFiltro
        '
        Me.gbCobrancaFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCobrancaFiltro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
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
        Me.gbCobrancaFiltro.ForeColor = System.Drawing.Color.Black
        Me.gbCobrancaFiltro.Location = New System.Drawing.Point(48, 20)
        Me.gbCobrancaFiltro.Name = "gbCobrancaFiltro"
        Me.gbCobrancaFiltro.Size = New System.Drawing.Size(1246, 115)
        Me.gbCobrancaFiltro.TabIndex = 0
        Me.gbCobrancaFiltro.TabStop = False
        Me.gbCobrancaFiltro.Text = "Filtro"
        '
        'chkPeriodo
        '
        Me.chkPeriodo.AutoSize = True
        Me.chkPeriodo.Location = New System.Drawing.Point(888, 16)
        Me.chkPeriodo.Name = "chkPeriodo"
        Me.chkPeriodo.Size = New System.Drawing.Size(174, 22)
        Me.chkPeriodo.TabIndex = 12
        Me.chkPeriodo.Text = "Filtrar por Período"
        Me.chkPeriodo.UseVisualStyleBackColor = True
        '
        'lblDataFim
        '
        Me.lblDataFim.AutoSize = True
        Me.lblDataFim.Location = New System.Drawing.Point(1028, 43)
        Me.lblDataFim.Name = "lblDataFim"
        Me.lblDataFim.Size = New System.Drawing.Size(43, 18)
        Me.lblDataFim.TabIndex = 4
        Me.lblDataFim.Text = "Até:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(660, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
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
        Me.dtInicial.Location = New System.Drawing.Point(888, 67)
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Size = New System.Drawing.Size(138, 27)
        Me.dtInicial.TabIndex = 50
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.BackColor = System.Drawing.Color.Transparent
        Me.lblDataInicio.Location = New System.Drawing.Point(884, 43)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(37, 18)
        Me.lblDataInicio.TabIndex = 5
        Me.lblDataInicio.Text = "De:"
        '
        'dtFinal
        '
        Me.dtFinal.Enabled = False
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinal.Location = New System.Drawing.Point(1031, 67)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(139, 27)
        Me.dtFinal.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mês:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(286, 45)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 18)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status:"
        '
        'lblDevedor
        '
        Me.lblDevedor.AutoSize = True
        Me.lblDevedor.Location = New System.Drawing.Point(23, 45)
        Me.lblDevedor.Name = "lblDevedor"
        Me.lblDevedor.Size = New System.Drawing.Size(94, 18)
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
        Me.gbBotoes.Location = New System.Drawing.Point(0, 612)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1349, 64)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnExportar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(886, 13)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(203, 42)
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
        Me.btnFechar.Location = New System.Drawing.Point(1095, 13)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(203, 42)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(677, 13)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(203, 42)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnEditar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditar
        Me.btnEditar.Location = New System.Drawing.Point(468, 13)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(203, 42)
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
        Me.btnAdd.Location = New System.Drawing.Point(260, 13)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(203, 42)
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
        Me.btnPesquisar.Location = New System.Drawing.Point(46, 13)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(203, 42)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtLetreiroCobr
        '
        Me.txtLetreiroCobr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiroCobr.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiroCobr.ForeColor = System.Drawing.Color.White
        Me.txtLetreiroCobr.Location = New System.Drawing.Point(48, 522)
        Me.txtLetreiroCobr.Name = "txtLetreiroCobr"
        Me.txtLetreiroCobr.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Direita
        Me.txtLetreiroCobr.Size = New System.Drawing.Size(312, 19)
        Me.txtLetreiroCobr.TabIndex = 2
        Me.txtLetreiroCobr.TextoLetreiro = "0,0 Registros"
        Me.txtLetreiroCobr.VelocidadeRolagem = 1
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
        Me.cbAno.Location = New System.Drawing.Point(663, 66)
        Me.cbAno.Name = "cbAno"
        Me.cbAno.Size = New System.Drawing.Size(151, 26)
        Me.cbAno.SuperObrigatorio = False
        Me.cbAno.SuperTxtObrigatorio = ""
        Me.cbAno.TabIndex = 10
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
        Me.cbMes.Location = New System.Drawing.Point(446, 66)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(211, 26)
        Me.cbMes.SuperObrigatorio = False
        Me.cbMes.SuperTxtObrigatorio = ""
        Me.cbMes.TabIndex = 8
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
        Me.cbStatus.Location = New System.Drawing.Point(289, 66)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(151, 26)
        Me.cbStatus.SuperObrigatorio = False
        Me.cbStatus.SuperTxtObrigatorio = ""
        Me.cbStatus.TabIndex = 4
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
        Me.cbDevedor.Location = New System.Drawing.Point(26, 66)
        Me.cbDevedor.Name = "cbDevedor"
        Me.cbDevedor.Size = New System.Drawing.Size(257, 26)
        Me.cbDevedor.SuperObrigatorio = False
        Me.cbDevedor.SuperTxtObrigatorio = ""
        Me.cbDevedor.TabIndex = 3
        '
        'datagridCobranca
        '
        Me.datagridCobranca.AdicionarCheckBox = True
        Me.datagridCobranca.AllowUserToAddRows = False
        Me.datagridCobranca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridCobranca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridCobranca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datagridCobranca.BackgroundColor = System.Drawing.Color.White
        Me.datagridCobranca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridCobranca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.datagridCobranca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridCobranca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridCobranca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridCobranca.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.datagridCobranca.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridCobranca.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridCobranca.EnableHeadersVisualStyles = False
        Me.datagridCobranca.Location = New System.Drawing.Point(48, 208)
        Me.datagridCobranca.Name = "datagridCobranca"
        Me.datagridCobranca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.datagridCobranca.RowHeadersVisible = False
        Me.datagridCobranca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridCobranca.Size = New System.Drawing.Size(1246, 305)
        Me.datagridCobranca.TabIndex = 4
        '
        'frmCobranca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 676)
        Me.Controls.Add(Me.tabCtrlCobranca)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCobranca"
        Me.tabCtrlCobranca.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gbCobrancaFiltro.ResumeLayout(False)
        Me.gbCobrancaFiltro.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        CType(Me.datagridCobranca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlCobranca As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gbCobrancaFiltro As GroupBox
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents txtLetreiroCobr As GFT.Util.SuperLetreiro
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
    Friend WithEvents chkSelecionaTodos As CheckBox
    Friend WithEvents datagridCobranca As GFT.Util.SuperDataGridView
End Class
