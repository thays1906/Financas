<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNovaDespesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovaDespesa))
        Me.tabDespesa = New GFT.Util.SuperTabControl()
        Me.tpAddDespesa = New System.Windows.Forms.TabPage()
        Me.pnlNovaDespesa = New System.Windows.Forms.Panel()
        Me.txtMesReferente = New GFT.Util.SuperTextBox()
        Me.gbDespesa2 = New System.Windows.Forms.GroupBox()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.cbDespesaFixa = New GFT.Util.SuperComboBox()
        Me.cbPagamento = New GFT.Util.SuperComboBox()
        Me.chkDespesaFixa = New System.Windows.Forms.CheckBox()
        Me.txtParcela = New GFT.Util.SuperTextBox()
        Me.lblValorParcela = New System.Windows.Forms.Label()
        Me.txtValorParcela = New GFT.Util.SuperTextBox()
        Me.chkParcela = New System.Windows.Forms.CheckBox()
        Me.cbParcelamento = New GFT.Util.SuperComboBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValorTotal = New GFT.Util.SuperTextBox()
        Me.lblParcela = New System.Windows.Forms.Label()
        Me.gbDespesa1 = New System.Windows.Forms.GroupBox()
        Me.picStatus = New System.Windows.Forms.PictureBox()
        Me.picNewDespesa = New System.Windows.Forms.PictureBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtDescricao = New GFT.Util.SuperTextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cbCategoria = New GFT.Util.SuperComboBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.cbStatus = New GFT.Util.SuperComboBox()
        Me.dtDespesa = New GFT.Util.SuperDatePicker()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cbConta = New GFT.Util.SuperComboBox()
        Me.lblMesReferente = New System.Windows.Forms.Label()
        Me.ImgAddDespesa = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnDetalhe = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.ToolTipNovaDespesa = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabDespesa.SuspendLayout()
        Me.tpAddDespesa.SuspendLayout()
        Me.pnlNovaDespesa.SuspendLayout()
        Me.gbDespesa2.SuspendLayout()
        Me.gbDespesa1.SuspendLayout()
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNewDespesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabDespesa
        '
        Me.tabDespesa.Controls.Add(Me.tpAddDespesa)
        Me.tabDespesa.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabDespesa.HotTrack = True
        Me.tabDespesa.ImageList = Me.ImgAddDespesa
        Me.tabDespesa.Location = New System.Drawing.Point(48, 38)
        Me.tabDespesa.Name = "tabDespesa"
        Me.tabDespesa.Padding = New System.Drawing.Point(50, 10)
        Me.tabDespesa.SelectedIndex = 0
        Me.tabDespesa.Size = New System.Drawing.Size(748, 521)
        Me.tabDespesa.TabIndex = 4
        '
        'tpAddDespesa
        '
        Me.tpAddDespesa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpAddDespesa.Controls.Add(Me.pnlNovaDespesa)
        Me.tpAddDespesa.ImageIndex = 2
        Me.tpAddDespesa.Location = New System.Drawing.Point(4, 53)
        Me.tpAddDespesa.Name = "tpAddDespesa"
        Me.tpAddDespesa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAddDespesa.Size = New System.Drawing.Size(740, 464)
        Me.tpAddDespesa.TabIndex = 0
        Me.tpAddDespesa.Text = "Adicionar Despesa"
        '
        'pnlNovaDespesa
        '
        Me.pnlNovaDespesa.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNovaDespesa.Controls.Add(Me.txtMesReferente)
        Me.pnlNovaDespesa.Controls.Add(Me.gbDespesa2)
        Me.pnlNovaDespesa.Controls.Add(Me.gbDespesa1)
        Me.pnlNovaDespesa.Controls.Add(Me.lblMesReferente)
        Me.pnlNovaDespesa.Location = New System.Drawing.Point(29, 14)
        Me.pnlNovaDespesa.Name = "pnlNovaDespesa"
        Me.pnlNovaDespesa.Size = New System.Drawing.Size(691, 426)
        Me.pnlNovaDespesa.TabIndex = 0
        '
        'txtMesReferente
        '
        Me.txtMesReferente.Alterado = False
        Me.txtMesReferente.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtMesReferente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMesReferente.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtMesReferente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMesReferente.ForeColor = System.Drawing.Color.Black
        Me.txtMesReferente.Location = New System.Drawing.Point(0, 30)
        Me.txtMesReferente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMesReferente.Multiline = True
        Me.txtMesReferente.Name = "txtMesReferente"
        Me.txtMesReferente.ReadOnly = True
        Me.txtMesReferente.Size = New System.Drawing.Size(166, 25)
        Me.txtMesReferente.SuperMascara = ""
        Me.txtMesReferente.SuperObrigatorio = False
        Me.txtMesReferente.SuperTravaErrors = False
        Me.txtMesReferente.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtMesReferente.SuperTxtObrigatorio = ""
        Me.txtMesReferente.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtMesReferente.TabIndex = 26
        Me.txtMesReferente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMesReferente.Visible = False
        '
        'gbDespesa2
        '
        Me.gbDespesa2.BackColor = System.Drawing.Color.Transparent
        Me.gbDespesa2.Controls.Add(Me.lblFormaPagamento)
        Me.gbDespesa2.Controls.Add(Me.cbDespesaFixa)
        Me.gbDespesa2.Controls.Add(Me.cbPagamento)
        Me.gbDespesa2.Controls.Add(Me.chkDespesaFixa)
        Me.gbDespesa2.Controls.Add(Me.txtParcela)
        Me.gbDespesa2.Controls.Add(Me.lblValorParcela)
        Me.gbDespesa2.Controls.Add(Me.txtValorParcela)
        Me.gbDespesa2.Controls.Add(Me.chkParcela)
        Me.gbDespesa2.Controls.Add(Me.cbParcelamento)
        Me.gbDespesa2.Controls.Add(Me.lblValor)
        Me.gbDespesa2.Controls.Add(Me.txtValorTotal)
        Me.gbDespesa2.Controls.Add(Me.lblParcela)
        Me.gbDespesa2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbDespesa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbDespesa2.Location = New System.Drawing.Point(0, 260)
        Me.gbDespesa2.Name = "gbDespesa2"
        Me.gbDespesa2.Size = New System.Drawing.Size(691, 166)
        Me.gbDespesa2.TabIndex = 28
        Me.gbDespesa2.TabStop = False
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(412, 27)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(189, 18)
        Me.lblFormaPagamento.TabIndex = 13
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cbDespesaFixa
        '
        Me.cbDespesaFixa.Alterado = False
        Me.cbDespesaFixa.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cbDespesaFixa.CorFundo = System.Drawing.Color.White
        Me.cbDespesaFixa.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbDespesaFixa.CorTexto = System.Drawing.Color.Black
        Me.cbDespesaFixa.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbDespesaFixa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDespesaFixa.FormattingEnabled = True
        Me.cbDespesaFixa.Location = New System.Drawing.Point(193, 54)
        Me.cbDespesaFixa.Name = "cbDespesaFixa"
        Me.cbDespesaFixa.Size = New System.Drawing.Size(161, 26)
        Me.cbDespesaFixa.SuperObrigatorio = False
        Me.cbDespesaFixa.SuperTxtObrigatorio = ""
        Me.cbDespesaFixa.TabIndex = 23
        '
        'cbPagamento
        '
        Me.cbPagamento.Alterado = False
        Me.cbPagamento.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cbPagamento.CorFundo = System.Drawing.Color.White
        Me.cbPagamento.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbPagamento.CorTexto = System.Drawing.Color.Black
        Me.cbPagamento.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbPagamento.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagamento.FormattingEnabled = True
        Me.cbPagamento.Location = New System.Drawing.Point(415, 52)
        Me.cbPagamento.Name = "cbPagamento"
        Me.cbPagamento.Size = New System.Drawing.Size(232, 26)
        Me.cbPagamento.SuperObrigatorio = True
        Me.cbPagamento.SuperTxtObrigatorio = "Selecione a Forma de Pagamento"
        Me.cbPagamento.TabIndex = 12
        '
        'chkDespesaFixa
        '
        Me.chkDespesaFixa.AutoSize = True
        Me.chkDespesaFixa.Location = New System.Drawing.Point(193, 26)
        Me.chkDespesaFixa.Name = "chkDespesaFixa"
        Me.chkDespesaFixa.Size = New System.Drawing.Size(136, 22)
        Me.chkDespesaFixa.TabIndex = 22
        Me.chkDespesaFixa.Text = "Despesa Fixa"
        Me.chkDespesaFixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDespesaFixa.UseVisualStyleBackColor = True
        '
        'txtParcela
        '
        Me.txtParcela.Alterado = False
        Me.txtParcela.BackColor = System.Drawing.Color.White
        Me.txtParcela.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtParcela.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParcela.Location = New System.Drawing.Point(415, 129)
        Me.txtParcela.Margin = New System.Windows.Forms.Padding(2)
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(81, 27)
        Me.txtParcela.SuperMascara = ""
        Me.txtParcela.SuperObrigatorio = False
        Me.txtParcela.SuperTravaErrors = False
        Me.txtParcela.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtParcela.SuperTxtObrigatorio = ""
        Me.txtParcela.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtParcela.TabIndex = 18
        Me.txtParcela.Visible = False
        '
        'lblValorParcela
        '
        Me.lblValorParcela.AutoSize = True
        Me.lblValorParcela.Location = New System.Drawing.Point(190, 104)
        Me.lblValorParcela.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblValorParcela.Name = "lblValorParcela"
        Me.lblValorParcela.Size = New System.Drawing.Size(147, 18)
        Me.lblValorParcela.TabIndex = 21
        Me.lblValorParcela.Text = "Valor da parcela:"
        Me.lblValorParcela.Visible = False
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Alterado = False
        Me.txtValorParcela.BackColor = System.Drawing.Color.White
        Me.txtValorParcela.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtValorParcela.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorParcela.Location = New System.Drawing.Point(193, 129)
        Me.txtValorParcela.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(161, 27)
        Me.txtValorParcela.SuperMascara = ""
        Me.txtValorParcela.SuperObrigatorio = False
        Me.txtValorParcela.SuperTravaErrors = False
        Me.txtValorParcela.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValorParcela.SuperTxtObrigatorio = ""
        Me.txtValorParcela.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValorParcela.TabIndex = 20
        Me.txtValorParcela.Visible = False
        '
        'chkParcela
        '
        Me.chkParcela.AutoSize = True
        Me.chkParcela.Location = New System.Drawing.Point(10, 26)
        Me.chkParcela.Name = "chkParcela"
        Me.chkParcela.Size = New System.Drawing.Size(138, 22)
        Me.chkParcela.TabIndex = 16
        Me.chkParcela.Text = "Parcelamento"
        Me.chkParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkParcela.UseVisualStyleBackColor = True
        '
        'cbParcelamento
        '
        Me.cbParcelamento.Alterado = False
        Me.cbParcelamento.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cbParcelamento.CorFundo = System.Drawing.Color.White
        Me.cbParcelamento.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbParcelamento.CorTexto = System.Drawing.Color.Black
        Me.cbParcelamento.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbParcelamento.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbParcelamento.FormattingEnabled = True
        Me.cbParcelamento.IntegralHeight = False
        Me.cbParcelamento.ItemHeight = 18
        Me.cbParcelamento.Location = New System.Drawing.Point(10, 54)
        Me.cbParcelamento.Name = "cbParcelamento"
        Me.cbParcelamento.Size = New System.Drawing.Size(144, 26)
        Me.cbParcelamento.SuperObrigatorio = False
        Me.cbParcelamento.SuperTxtObrigatorio = ""
        Me.cbParcelamento.TabIndex = 17
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(7, 104)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(102, 18)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor Total:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Alterado = False
        Me.txtValorTotal.BackColor = System.Drawing.Color.White
        Me.txtValorTotal.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtValorTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(10, 129)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(161, 27)
        Me.txtValorTotal.SuperMascara = "R$0.00"
        Me.txtValorTotal.SuperObrigatorio = True
        Me.txtValorTotal.SuperTravaErrors = False
        Me.txtValorTotal.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValorTotal.SuperTxtObrigatorio = "VALOR"
        Me.txtValorTotal.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValorTotal.TabIndex = 0
        '
        'lblParcela
        '
        Me.lblParcela.AutoSize = True
        Me.lblParcela.Location = New System.Drawing.Point(412, 104)
        Me.lblParcela.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblParcela.Name = "lblParcela"
        Me.lblParcela.Size = New System.Drawing.Size(74, 18)
        Me.lblParcela.TabIndex = 19
        Me.lblParcela.Text = "Parcela:"
        Me.lblParcela.Visible = False
        '
        'gbDespesa1
        '
        Me.gbDespesa1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbDespesa1.BackColor = System.Drawing.Color.Transparent
        Me.gbDespesa1.Controls.Add(Me.picStatus)
        Me.gbDespesa1.Controls.Add(Me.picNewDespesa)
        Me.gbDespesa1.Controls.Add(Me.lblCategoria)
        Me.gbDespesa1.Controls.Add(Me.txtDescricao)
        Me.gbDespesa1.Controls.Add(Me.lblStatus)
        Me.gbDespesa1.Controls.Add(Me.cbCategoria)
        Me.gbDespesa1.Controls.Add(Me.lblDescricao)
        Me.gbDespesa1.Controls.Add(Me.lblConta)
        Me.gbDespesa1.Controls.Add(Me.cbStatus)
        Me.gbDespesa1.Controls.Add(Me.dtDespesa)
        Me.gbDespesa1.Controls.Add(Me.lblData)
        Me.gbDespesa1.Controls.Add(Me.cbConta)
        Me.gbDespesa1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbDespesa1.Location = New System.Drawing.Point(1, 50)
        Me.gbDespesa1.Name = "gbDespesa1"
        Me.gbDespesa1.Size = New System.Drawing.Size(690, 205)
        Me.gbDespesa1.TabIndex = 29
        Me.gbDespesa1.TabStop = False
        '
        'picStatus
        '
        Me.picStatus.BackColor = System.Drawing.SystemColors.Control
        Me.picStatus.Location = New System.Drawing.Point(639, 38)
        Me.picStatus.Name = "picStatus"
        Me.picStatus.Size = New System.Drawing.Size(32, 32)
        Me.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picStatus.TabIndex = 17
        Me.picStatus.TabStop = False
        Me.ToolTipNovaDespesa.SetToolTip(Me.picStatus, "Status da Despesa")
        '
        'picNewDespesa
        '
        Me.picNewDespesa.BackColor = System.Drawing.Color.Transparent
        Me.picNewDespesa.Location = New System.Drawing.Point(639, 151)
        Me.picNewDespesa.Name = "picNewDespesa"
        Me.picNewDespesa.Size = New System.Drawing.Size(48, 48)
        Me.picNewDespesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picNewDespesa.TabIndex = 16
        Me.picNewDespesa.TabStop = False
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(7, 145)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(94, 18)
        Me.lblCategoria.TabIndex = 7
        Me.lblCategoria.Text = "Categoria:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Alterado = False
        Me.txtDescricao.BackColor = System.Drawing.Color.White
        Me.txtDescricao.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtDescricao.Location = New System.Drawing.Point(9, 104)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(638, 38)
        Me.txtDescricao.SuperMascara = "0.00"
        Me.txtDescricao.SuperObrigatorio = False
        Me.txtDescricao.SuperTravaErrors = False
        Me.txtDescricao.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtDescricao.SuperTxtObrigatorio = ""
        Me.txtDescricao.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtDescricao.TabIndex = 10
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(402, 17)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 18)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Status:"
        '
        'cbCategoria
        '
        Me.cbCategoria.Alterado = False
        Me.cbCategoria.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cbCategoria.CorFundo = System.Drawing.Color.White
        Me.cbCategoria.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbCategoria.CorTexto = System.Drawing.Color.Black
        Me.cbCategoria.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(10, 166)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(232, 26)
        Me.cbCategoria.SuperObrigatorio = False
        Me.cbCategoria.SuperTxtObrigatorio = ""
        Me.cbCategoria.TabIndex = 6
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(8, 83)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(93, 18)
        Me.lblDescricao.TabIndex = 11
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(402, 145)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(139, 18)
        Me.lblConta.TabIndex = 5
        Me.lblConta.Text = "Conta Báncaria:"
        '
        'cbStatus
        '
        Me.cbStatus.Alterado = False
        Me.cbStatus.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cbStatus.CorFundo = System.Drawing.Color.White
        Me.cbStatus.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbStatus.CorTexto = System.Drawing.Color.Black
        Me.cbStatus.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbStatus.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(405, 41)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(232, 26)
        Me.cbStatus.SuperObrigatorio = True
        Me.cbStatus.SuperTxtObrigatorio = "Selecione um Status "
        Me.cbStatus.TabIndex = 14
        '
        'dtDespesa
        '
        Me.dtDespesa.Alterado = False
        Me.dtDespesa.BackColor = System.Drawing.Color.White
        Me.dtDespesa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDespesa.Location = New System.Drawing.Point(10, 38)
        Me.dtDespesa.Name = "dtDespesa"
        Me.dtDespesa.Size = New System.Drawing.Size(144, 27)
        Me.dtDespesa.TabIndex = 2
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(6, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(54, 18)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data:"
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cbConta.CorFundo = System.Drawing.Color.White
        Me.cbConta.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbConta.CorTexto = System.Drawing.Color.Black
        Me.cbConta.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbConta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.Location = New System.Drawing.Point(405, 166)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(232, 26)
        Me.cbConta.SuperObrigatorio = True
        Me.cbConta.SuperTxtObrigatorio = "Conta Báncaria"
        Me.cbConta.TabIndex = 4
        '
        'lblMesReferente
        '
        Me.lblMesReferente.AutoSize = True
        Me.lblMesReferente.Location = New System.Drawing.Point(-3, 10)
        Me.lblMesReferente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMesReferente.Name = "lblMesReferente"
        Me.lblMesReferente.Size = New System.Drawing.Size(161, 18)
        Me.lblMesReferente.TabIndex = 27
        Me.lblMesReferente.Text = "Referente ao mês:"
        Me.lblMesReferente.Visible = False
        '
        'ImgAddDespesa
        '
        Me.ImgAddDespesa.ImageStream = CType(resources.GetObject("ImgAddDespesa.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgAddDespesa.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgAddDespesa.Images.SetKeyName(0, "iconDespesa.png")
        Me.ImgAddDespesa.Images.SetKeyName(1, "icon_Despesa32x.png")
        Me.ImgAddDespesa.Images.SetKeyName(2, "testeIconDespesa32.png")
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(579, 565)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(217, 42)
        Me.btnExcluir.TabIndex = 14
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnDetalhe
        '
        Me.btnDetalhe.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalhe.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconDetalheFiles
        Me.btnDetalhe.Location = New System.Drawing.Point(48, 565)
        Me.btnDetalhe.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDetalhe.Name = "btnDetalhe"
        Me.btnDetalhe.Size = New System.Drawing.Size(217, 42)
        Me.btnDetalhe.TabIndex = 13
        Me.btnDetalhe.Text = " &Detalhar"
        Me.btnDetalhe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDetalhe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDetalhe.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(772, 0)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(76, 51)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(312, 565)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(217, 42)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'ToolTipNovaDespesa
        '
        Me.ToolTipNovaDespesa.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmNovaDespesa
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(848, 612)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnDetalhe)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.tabDespesa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNovaDespesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNovaDespesa"
        Me.tabDespesa.ResumeLayout(False)
        Me.tpAddDespesa.ResumeLayout(False)
        Me.pnlNovaDespesa.ResumeLayout(False)
        Me.pnlNovaDespesa.PerformLayout()
        Me.gbDespesa2.ResumeLayout(False)
        Me.gbDespesa2.PerformLayout()
        Me.gbDespesa1.ResumeLayout(False)
        Me.gbDespesa1.PerformLayout()
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNewDespesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabDespesa As GFT.Util.SuperTabControl
    Friend WithEvents tpAddDespesa As TabPage
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnDetalhe As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents ImgAddDespesa As ImageList
    Friend WithEvents pnlNovaDespesa As Panel
    Friend WithEvents txtMesReferente As GFT.Util.SuperTextBox
    Friend WithEvents gbDespesa2 As GroupBox
    Friend WithEvents lblFormaPagamento As Label
    Friend WithEvents cbDespesaFixa As GFT.Util.SuperComboBox
    Friend WithEvents cbPagamento As GFT.Util.SuperComboBox
    Friend WithEvents chkDespesaFixa As CheckBox
    Friend WithEvents txtParcela As GFT.Util.SuperTextBox
    Friend WithEvents lblValorParcela As Label
    Friend WithEvents txtValorParcela As GFT.Util.SuperTextBox
    Friend WithEvents chkParcela As CheckBox
    Friend WithEvents cbParcelamento As GFT.Util.SuperComboBox
    Friend WithEvents lblValor As Label
    Friend WithEvents txtValorTotal As GFT.Util.SuperTextBox
    Friend WithEvents lblParcela As Label
    Friend WithEvents gbDespesa1 As GroupBox
    Friend WithEvents picNewDespesa As PictureBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtDescricao As GFT.Util.SuperTextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbCategoria As GFT.Util.SuperComboBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblConta As Label
    Friend WithEvents cbStatus As GFT.Util.SuperComboBox
    Friend WithEvents dtDespesa As GFT.Util.SuperDatePicker
    Friend WithEvents lblData As Label
    Friend WithEvents cbConta As GFT.Util.SuperComboBox
    Friend WithEvents lblMesReferente As Label
    Friend WithEvents picStatus As PictureBox
    Friend WithEvents ToolTipNovaDespesa As ToolTip
End Class
