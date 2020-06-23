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
        Me.tabDespesa = New GFT.Util.SuperTabControl()
        Me.tpAddDespesa = New System.Windows.Forms.TabPage()
        Me.lblMesReferente = New System.Windows.Forms.Label()
        Me.txtMesReferente = New GFT.Util.SuperTextBox()
        Me.lblValorParcela = New System.Windows.Forms.Label()
        Me.txtValorParcela = New GFT.Util.SuperTextBox()
        Me.lblParcela = New System.Windows.Forms.Label()
        Me.txtParcela = New GFT.Util.SuperTextBox()
        Me.chkParcela = New System.Windows.Forms.CheckBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cbStatus = New GFT.Util.SuperComboBox()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.cbPagamento = New GFT.Util.SuperComboBox()
        Me.txtDescricao = New GFT.Util.SuperTextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.cbCategoria = New GFT.Util.SuperComboBox()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.cbConta = New GFT.Util.SuperComboBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtDespesa = New GFT.Util.SuperDatePicker()
        Me.txtValorTotal = New GFT.Util.SuperTextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnDetalhe = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDespesaFixa = New System.Windows.Forms.CheckBox()
        Me.cbParcelamento = New GFT.Util.SuperComboBox()
        Me.cbDespesaFixa = New GFT.Util.SuperComboBox()
        Me.tabDespesa.SuspendLayout()
        Me.tpAddDespesa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabDespesa
        '
        Me.tabDespesa.Controls.Add(Me.tpAddDespesa)
        Me.tabDespesa.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabDespesa.HotTrack = True
        Me.tabDespesa.Location = New System.Drawing.Point(32, 34)
        Me.tabDespesa.Name = "tabDespesa"
        Me.tabDespesa.Padding = New System.Drawing.Point(50, 10)
        Me.tabDespesa.SelectedIndex = 0
        Me.tabDespesa.Size = New System.Drawing.Size(603, 395)
        Me.tabDespesa.TabIndex = 4
        '
        'tpAddDespesa
        '
        Me.tpAddDespesa.Controls.Add(Me.GroupBox2)
        Me.tpAddDespesa.Controls.Add(Me.GroupBox1)
        Me.tpAddDespesa.Location = New System.Drawing.Point(4, 41)
        Me.tpAddDespesa.Name = "tpAddDespesa"
        Me.tpAddDespesa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAddDespesa.Size = New System.Drawing.Size(595, 350)
        Me.tpAddDespesa.TabIndex = 0
        Me.tpAddDespesa.Text = "Adicionar Despesa"
        Me.tpAddDespesa.UseVisualStyleBackColor = True
        '
        'lblMesReferente
        '
        Me.lblMesReferente.AutoSize = True
        Me.lblMesReferente.Location = New System.Drawing.Point(146, 19)
        Me.lblMesReferente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMesReferente.Name = "lblMesReferente"
        Me.lblMesReferente.Size = New System.Drawing.Size(146, 18)
        Me.lblMesReferente.TabIndex = 23
        Me.lblMesReferente.Text = "Mês / Referente:"
        Me.lblMesReferente.Visible = False
        '
        'txtMesReferente
        '
        Me.txtMesReferente.Alterado = False
        Me.txtMesReferente.BackColor = System.Drawing.Color.White
        Me.txtMesReferente.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtMesReferente.Location = New System.Drawing.Point(149, 41)
        Me.txtMesReferente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMesReferente.Name = "txtMesReferente"
        Me.txtMesReferente.ReadOnly = True
        Me.txtMesReferente.Size = New System.Drawing.Size(156, 27)
        Me.txtMesReferente.SuperMascara = ""
        Me.txtMesReferente.SuperObrigatorio = False
        Me.txtMesReferente.SuperTravaErrors = False
        Me.txtMesReferente.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtMesReferente.SuperTxtObrigatorio = ""
        Me.txtMesReferente.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtMesReferente.TabIndex = 22
        Me.txtMesReferente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMesReferente.Visible = False
        '
        'lblValorParcela
        '
        Me.lblValorParcela.AutoSize = True
        Me.lblValorParcela.Location = New System.Drawing.Point(382, 89)
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
        Me.txtValorParcela.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtValorParcela.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorParcela.Location = New System.Drawing.Point(385, 110)
        Me.txtValorParcela.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(151, 27)
        Me.txtValorParcela.SuperMascara = ""
        Me.txtValorParcela.SuperObrigatorio = False
        Me.txtValorParcela.SuperTravaErrors = False
        Me.txtValorParcela.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValorParcela.SuperTxtObrigatorio = ""
        Me.txtValorParcela.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValorParcela.TabIndex = 20
        Me.txtValorParcela.Visible = False
        '
        'lblParcela
        '
        Me.lblParcela.AutoSize = True
        Me.lblParcela.Location = New System.Drawing.Point(382, 136)
        Me.lblParcela.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblParcela.Name = "lblParcela"
        Me.lblParcela.Size = New System.Drawing.Size(74, 18)
        Me.lblParcela.TabIndex = 19
        Me.lblParcela.Text = "Parcela:"
        Me.lblParcela.Visible = False
        '
        'txtParcela
        '
        Me.txtParcela.Alterado = False
        Me.txtParcela.BackColor = System.Drawing.Color.White
        Me.txtParcela.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtParcela.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParcela.Location = New System.Drawing.Point(385, 159)
        Me.txtParcela.Margin = New System.Windows.Forms.Padding(2)
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(76, 27)
        Me.txtParcela.SuperMascara = ""
        Me.txtParcela.SuperObrigatorio = False
        Me.txtParcela.SuperTravaErrors = False
        Me.txtParcela.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtParcela.SuperTxtObrigatorio = ""
        Me.txtParcela.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtParcela.TabIndex = 18
        Me.txtParcela.Visible = False
        '
        'chkParcela
        '
        Me.chkParcela.AutoSize = True
        Me.chkParcela.Location = New System.Drawing.Point(6, 19)
        Me.chkParcela.Name = "chkParcela"
        Me.chkParcela.Size = New System.Drawing.Size(138, 22)
        Me.chkParcela.TabIndex = 16
        Me.chkParcela.Text = "Parcelamento"
        Me.chkParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkParcela.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(383, 20)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 18)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Status:"
        '
        'cbStatus
        '
        Me.cbStatus.Alterado = False
        Me.cbStatus.CorFundo = System.Drawing.Color.White
        Me.cbStatus.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbStatus.CorTexto = System.Drawing.Color.Black
        Me.cbStatus.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbStatus.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(386, 41)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(151, 25)
        Me.cbStatus.SuperObrigatorio = True
        Me.cbStatus.SuperTxtObrigatorio = "Selecione um Status "
        Me.cbStatus.TabIndex = 14
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(3, 84)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(189, 18)
        Me.lblFormaPagamento.TabIndex = 13
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cbPagamento
        '
        Me.cbPagamento.Alterado = False
        Me.cbPagamento.CorFundo = System.Drawing.Color.White
        Me.cbPagamento.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbPagamento.CorTexto = System.Drawing.Color.Black
        Me.cbPagamento.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbPagamento.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagamento.FormattingEnabled = True
        Me.cbPagamento.Location = New System.Drawing.Point(6, 108)
        Me.cbPagamento.Name = "cbPagamento"
        Me.cbPagamento.Size = New System.Drawing.Size(218, 25)
        Me.cbPagamento.SuperObrigatorio = True
        Me.cbPagamento.SuperTxtObrigatorio = "Selecione a Forma de Pagamento"
        Me.cbPagamento.TabIndex = 12
        '
        'txtDescricao
        '
        Me.txtDescricao.Alterado = False
        Me.txtDescricao.BackColor = System.Drawing.Color.White
        Me.txtDescricao.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtDescricao.Location = New System.Drawing.Point(6, 97)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(303, 27)
        Me.txtDescricao.SuperMascara = "0.00"
        Me.txtDescricao.SuperObrigatorio = False
        Me.txtDescricao.SuperTravaErrors = False
        Me.txtDescricao.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtDescricao.SuperTxtObrigatorio = ""
        Me.txtDescricao.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtDescricao.TabIndex = 10
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(3, 75)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(93, 18)
        Me.lblDescricao.TabIndex = 11
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(316, 75)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(94, 18)
        Me.lblCategoria.TabIndex = 7
        Me.lblCategoria.Text = "Categoria:"
        '
        'cbCategoria
        '
        Me.cbCategoria.Alterado = False
        Me.cbCategoria.CorFundo = System.Drawing.Color.White
        Me.cbCategoria.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbCategoria.CorTexto = System.Drawing.Color.Black
        Me.cbCategoria.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbCategoria.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(319, 97)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(218, 25)
        Me.cbCategoria.SuperObrigatorio = False
        Me.cbCategoria.SuperTxtObrigatorio = ""
        Me.cbCategoria.TabIndex = 6
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(3, 136)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(139, 18)
        Me.lblConta.TabIndex = 5
        Me.lblConta.Text = "Conta Báncaria:"
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.CorFundo = System.Drawing.Color.White
        Me.cbConta.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbConta.CorTexto = System.Drawing.Color.Black
        Me.cbConta.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbConta.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.Location = New System.Drawing.Point(6, 157)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(218, 25)
        Me.cbConta.SuperObrigatorio = True
        Me.cbConta.SuperTxtObrigatorio = "Conta Báncaria"
        Me.cbConta.TabIndex = 4
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(6, 19)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(54, 18)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data:"
        '
        'dtDespesa
        '
        Me.dtDespesa.Alterado = False
        Me.dtDespesa.BackColor = System.Drawing.Color.White
        Me.dtDespesa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDespesa.Location = New System.Drawing.Point(9, 41)
        Me.dtDespesa.Name = "dtDespesa"
        Me.dtDespesa.Size = New System.Drawing.Size(135, 27)
        Me.dtDespesa.TabIndex = 2
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Alterado = False
        Me.txtValorTotal.BackColor = System.Drawing.Color.White
        Me.txtValorTotal.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtValorTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(385, 47)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(151, 27)
        Me.txtValorTotal.SuperMascara = "R$0.00"
        Me.txtValorTotal.SuperObrigatorio = True
        Me.txtValorTotal.SuperTravaErrors = False
        Me.txtValorTotal.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValorTotal.SuperTxtObrigatorio = "VALOR"
        Me.txtValorTotal.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValorTotal.TabIndex = 0
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(382, 25)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(102, 18)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor Total:"
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(632, -1)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(53, 41)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.icon_Salvar_png
        Me.btnSalvar.Location = New System.Drawing.Point(220, 448)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 42)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnDetalhe
        '
        Me.btnDetalhe.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalhe.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconDetalheFiles
        Me.btnDetalhe.Location = New System.Drawing.Point(432, 448)
        Me.btnDetalhe.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDetalhe.Name = "btnDetalhe"
        Me.btnDetalhe.Size = New System.Drawing.Size(203, 42)
        Me.btnDetalhe.TabIndex = 13
        Me.btnDetalhe.Text = " &Detalhar"
        Me.btnDetalhe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDetalhe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDetalhe.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbDespesaFixa)
        Me.GroupBox1.Controls.Add(Me.chkDespesaFixa)
        Me.GroupBox1.Controls.Add(Me.cbPagamento)
        Me.GroupBox1.Controls.Add(Me.cbConta)
        Me.GroupBox1.Controls.Add(Me.lblConta)
        Me.GroupBox1.Controls.Add(Me.lblValorParcela)
        Me.GroupBox1.Controls.Add(Me.lblFormaPagamento)
        Me.GroupBox1.Controls.Add(Me.txtValorParcela)
        Me.GroupBox1.Controls.Add(Me.lblParcela)
        Me.GroupBox1.Controls.Add(Me.chkParcela)
        Me.GroupBox1.Controls.Add(Me.txtParcela)
        Me.GroupBox1.Controls.Add(Me.cbParcelamento)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.txtValorTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 192)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescricao)
        Me.GroupBox2.Controls.Add(Me.cbCategoria)
        Me.GroupBox2.Controls.Add(Me.lblMesReferente)
        Me.GroupBox2.Controls.Add(Me.lblCategoria)
        Me.GroupBox2.Controls.Add(Me.txtMesReferente)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.lblDescricao)
        Me.GroupBox2.Controls.Add(Me.cbStatus)
        Me.GroupBox2.Controls.Add(Me.dtDespesa)
        Me.GroupBox2.Controls.Add(Me.lblData)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(543, 130)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'chkDespesaFixa
        '
        Me.chkDespesaFixa.AutoSize = True
        Me.chkDespesaFixa.Location = New System.Drawing.Point(153, 19)
        Me.chkDespesaFixa.Name = "chkDespesaFixa"
        Me.chkDespesaFixa.Size = New System.Drawing.Size(136, 22)
        Me.chkDespesaFixa.TabIndex = 22
        Me.chkDespesaFixa.Text = "Despesa Fixa"
        Me.chkDespesaFixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDespesaFixa.UseVisualStyleBackColor = True
        '
        'cbParcelamento
        '
        Me.cbParcelamento.Alterado = False
        Me.cbParcelamento.CorFundo = System.Drawing.Color.White
        Me.cbParcelamento.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbParcelamento.CorTexto = System.Drawing.Color.Black
        Me.cbParcelamento.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbParcelamento.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbParcelamento.FormattingEnabled = True
        Me.cbParcelamento.Location = New System.Drawing.Point(6, 47)
        Me.cbParcelamento.Name = "cbParcelamento"
        Me.cbParcelamento.Size = New System.Drawing.Size(116, 25)
        Me.cbParcelamento.SuperObrigatorio = False
        Me.cbParcelamento.SuperTxtObrigatorio = ""
        Me.cbParcelamento.TabIndex = 17
        '
        'cbDespesaFixa
        '
        Me.cbDespesaFixa.Alterado = False
        Me.cbDespesaFixa.CorFundo = System.Drawing.Color.White
        Me.cbDespesaFixa.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbDespesaFixa.CorTexto = System.Drawing.Color.Black
        Me.cbDespesaFixa.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbDespesaFixa.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDespesaFixa.FormattingEnabled = True
        Me.cbDespesaFixa.Location = New System.Drawing.Point(153, 47)
        Me.cbDespesaFixa.Name = "cbDespesaFixa"
        Me.cbDespesaFixa.Size = New System.Drawing.Size(138, 25)
        Me.cbDespesaFixa.SuperObrigatorio = False
        Me.cbDespesaFixa.SuperTxtObrigatorio = ""
        Me.cbDespesaFixa.TabIndex = 23
        '
        'frmNovaDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(684, 523)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabDespesa As GFT.Util.SuperTabControl
    Friend WithEvents tpAddDespesa As TabPage
    Friend WithEvents lblCategoria As Label
    Friend WithEvents cbCategoria As GFT.Util.SuperComboBox
    Friend WithEvents lblConta As Label
    Friend WithEvents cbConta As GFT.Util.SuperComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents dtDespesa As GFT.Util.SuperDatePicker
    Friend WithEvents txtValorTotal As GFT.Util.SuperTextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents txtDescricao As GFT.Util.SuperTextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents chkParcela As CheckBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbStatus As GFT.Util.SuperComboBox
    Friend WithEvents lblFormaPagamento As Label
    Friend WithEvents cbPagamento As GFT.Util.SuperComboBox
    Friend WithEvents lblParcela As Label
    Friend WithEvents txtParcela As GFT.Util.SuperTextBox
    Friend WithEvents lblValorParcela As Label
    Friend WithEvents txtValorParcela As GFT.Util.SuperTextBox
    Friend WithEvents lblMesReferente As Label
    Friend WithEvents txtMesReferente As GFT.Util.SuperTextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnDetalhe As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbDespesaFixa As GFT.Util.SuperComboBox
    Friend WithEvents chkDespesaFixa As CheckBox
    Friend WithEvents cbParcelamento As GFT.Util.SuperComboBox
End Class
