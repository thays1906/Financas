<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCtrlConsulta = New GFT.Util.SuperTabControl()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.txtLetreiro = New GFT.Util.SuperLetreiro()
        Me.dgExtrato = New GFT.Util.SuperDataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.cbConta = New GFT.Util.SuperComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cbTipoFiltro = New GFT.Util.SuperComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFinalFiltro = New GFT.Util.SuperDatePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtInicialFiltro = New GFT.Util.SuperDatePicker()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.tabCtrlConsulta.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        CType(Me.dgExtrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltro.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.BackColor = System.Drawing.Color.White
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(238, 19)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(203, 42)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "iconFileExplorer.png")
        Me.ImageList1.Images.SetKeyName(1, "iconExtrato48x.png")
        '
        'tabCtrlConsulta
        '
        Me.tabCtrlConsulta.Controls.Add(Me.tpPesquisa)
        Me.tabCtrlConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlConsulta.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlConsulta.ImageList = Me.ImageList1
        Me.tabCtrlConsulta.ItemSize = New System.Drawing.Size(1284, 30)
        Me.tabCtrlConsulta.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlConsulta.Name = "tabCtrlConsulta"
        Me.tabCtrlConsulta.Padding = New System.Drawing.Point(5, 6)
        Me.tabCtrlConsulta.SelectedIndex = 0
        Me.tabCtrlConsulta.Size = New System.Drawing.Size(1284, 591)
        Me.tabCtrlConsulta.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabCtrlConsulta.TabIndex = 3
        '
        'tpPesquisa
        '
        Me.tpPesquisa.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tpPesquisa.Controls.Add(Me.txtLetreiro)
        Me.tpPesquisa.Controls.Add(Me.dgExtrato)
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.ImageIndex = 1
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 34)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(5)
        Me.tpPesquisa.Size = New System.Drawing.Size(1276, 553)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Extrato Báncario"
        '
        'txtLetreiro
        '
        Me.txtLetreiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiro.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiro.Location = New System.Drawing.Point(42, 510)
        Me.txtLetreiro.Name = "txtLetreiro"
        Me.txtLetreiro.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
        Me.txtLetreiro.Size = New System.Drawing.Size(306, 30)
        Me.txtLetreiro.TabIndex = 9
        Me.txtLetreiro.TextoLetreiro = ""
        Me.txtLetreiro.VelocidadeRolagem = 1
        '
        'dgExtrato
        '
        Me.dgExtrato.AdicionarCheckBox = True
        Me.dgExtrato.AllowUserToAddRows = False
        Me.dgExtrato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgExtrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgExtrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgExtrato.BackgroundColor = System.Drawing.Color.White
        Me.dgExtrato.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgExtrato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgExtrato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgExtrato.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgExtrato.ColumnHeadersHeight = 50
        Me.dgExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgExtrato.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.dgExtrato.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgExtrato.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgExtrato.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgExtrato.EnableHeadersVisualStyles = False
        Me.dgExtrato.Location = New System.Drawing.Point(44, 128)
        Me.dgExtrato.Name = "dgExtrato"
        Me.dgExtrato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgExtrato.RowHeadersVisible = False
        Me.dgExtrato.RowHeadersWidth = 51
        Me.dgExtrato.RowTemplate.Height = 24
        Me.dgExtrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgExtrato.Size = New System.Drawing.Size(1186, 362)
        Me.dgExtrato.TabIndex = 8
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Selecionar"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Selecionar"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 50
        '
        'gbFiltro
        '
        Me.gbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltro.BackColor = System.Drawing.SystemColors.Control
        Me.gbFiltro.Controls.Add(Me.lblConta)
        Me.gbFiltro.Controls.Add(Me.cbConta)
        Me.gbFiltro.Controls.Add(Me.lblTipo)
        Me.gbFiltro.Controls.Add(Me.cbTipoFiltro)
        Me.gbFiltro.Controls.Add(Me.Label1)
        Me.gbFiltro.Controls.Add(Me.dtFinalFiltro)
        Me.gbFiltro.Controls.Add(Me.Label2)
        Me.gbFiltro.Controls.Add(Me.dtInicialFiltro)
        Me.gbFiltro.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFiltro.Location = New System.Drawing.Point(44, 22)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(1187, 95)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(663, 32)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(175, 25)
        Me.lblConta.TabIndex = 12
        Me.lblConta.Text = "Conta Báncaria:"
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.CorFundo = System.Drawing.Color.White
        Me.cbConta.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbConta.CorTexto = System.Drawing.Color.Black
        Me.cbConta.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.Location = New System.Drawing.Point(668, 59)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(290, 33)
        Me.cbConta.SuperObrigatorio = False
        Me.cbConta.SuperTxtObrigatorio = ""
        Me.cbConta.TabIndex = 11
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(358, 32)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(194, 25)
        Me.lblTipo.TabIndex = 10
        Me.lblTipo.Text = "Receita/ Despesa:"
        '
        'cbTipoFiltro
        '
        Me.cbTipoFiltro.Alterado = False
        Me.cbTipoFiltro.CorFundo = System.Drawing.Color.White
        Me.cbTipoFiltro.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTipoFiltro.CorTexto = System.Drawing.Color.Black
        Me.cbTipoFiltro.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbTipoFiltro.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoFiltro.FormattingEnabled = True
        Me.cbTipoFiltro.Location = New System.Drawing.Point(362, 59)
        Me.cbTipoFiltro.Name = "cbTipoFiltro"
        Me.cbTipoFiltro.Size = New System.Drawing.Size(253, 33)
        Me.cbTipoFiltro.SuperObrigatorio = False
        Me.cbTipoFiltro.SuperTxtObrigatorio = ""
        Me.cbTipoFiltro.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "De:"
        '
        'dtFinalFiltro
        '
        Me.dtFinalFiltro.Alterado = False
        Me.dtFinalFiltro.BackColor = System.Drawing.Color.White
        Me.dtFinalFiltro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinalFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinalFiltro.Location = New System.Drawing.Point(173, 63)
        Me.dtFinalFiltro.Name = "dtFinalFiltro"
        Me.dtFinalFiltro.Size = New System.Drawing.Size(152, 29)
        Me.dtFinalFiltro.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Até:"
        '
        'dtInicialFiltro
        '
        Me.dtInicialFiltro.Alterado = False
        Me.dtInicialFiltro.BackColor = System.Drawing.Color.White
        Me.dtInicialFiltro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicialFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicialFiltro.Location = New System.Drawing.Point(19, 63)
        Me.dtInicialFiltro.Name = "dtInicialFiltro"
        Me.dtInicialFiltro.Size = New System.Drawing.Size(134, 29)
        Me.dtInicialFiltro.TabIndex = 3
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBotoes.Location = New System.Drawing.Point(0, 591)
        Me.gbBotoes.Margin = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Padding = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Size = New System.Drawing.Size(1284, 68)
        Me.gbBotoes.TabIndex = 27
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(737, 19)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(203, 42)
        Me.btnFechar.TabIndex = 7
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnExportar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(489, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(203, 42)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = " &Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'frmConsulta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1284, 659)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabCtrlConsulta)
        Me.Controls.Add(Me.gbBotoes)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsulta"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Extrato Báncario"
        Me.tabCtrlConsulta.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        CType(Me.dgExtrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabCtrlConsulta As GFT.Util.SuperTabControl
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents gbFiltro As GroupBox
    Friend WithEvents dtFinalFiltro As GFT.Util.SuperDatePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtInicialFiltro As GFT.Util.SuperDatePicker
    Friend WithEvents lblTipo As Label
    Friend WithEvents cbTipoFiltro As GFT.Util.SuperComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblConta As Label
    Friend WithEvents cbConta As GFT.Util.SuperComboBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents txtLetreiro As GFT.Util.SuperLetreiro
    Friend WithEvents dgExtrato As GFT.Util.SuperDataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
End Class
