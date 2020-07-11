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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDescricao = New GFT.Util.SuperTextBox()
        Me.cbCategoria = New GFT.Util.SuperComboBox()
        Me.lblMesReferente = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtMesReferente = New GFT.Util.SuperTextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.cbStatus = New GFT.Util.SuperComboBox()
        Me.dtDespesa = New GFT.Util.SuperDatePicker()
        Me.lblData = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbDespesaFixa = New GFT.Util.SuperComboBox()
        Me.chkDespesaFixa = New System.Windows.Forms.CheckBox()
        Me.cbPagamento = New GFT.Util.SuperComboBox()
        Me.cbConta = New GFT.Util.SuperComboBox()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.txtParcela = New GFT.Util.SuperTextBox()
        Me.lblValorParcela = New System.Windows.Forms.Label()
        Me.txtValorParcela = New GFT.Util.SuperTextBox()
        Me.chkParcela = New System.Windows.Forms.CheckBox()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.cbParcelamento = New GFT.Util.SuperComboBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValorTotal = New GFT.Util.SuperTextBox()
        Me.lblParcela = New System.Windows.Forms.Label()
        Me.ImgAddDespesa = New System.Windows.Forms.ImageList(Me.components)
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnDetalhe = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.tabDespesa.SuspendLayout()
        Me.tpAddDespesa.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabDespesa
        '
        Me.tabDespesa.Controls.Add(Me.tpAddDespesa)
        Me.tabDespesa.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabDespesa.HotTrack = True
        Me.tabDespesa.ImageList = Me.ImgAddDespesa
        Me.tabDespesa.Location = New System.Drawing.Point(40, 42)
        Me.tabDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.tabDespesa.Name = "tabDespesa"
        Me.tabDespesa.Padding = New System.Drawing.Point(50, 10)
        Me.tabDespesa.SelectedIndex = 0
        Me.tabDespesa.Size = New System.Drawing.Size(851, 486)
        Me.tabDespesa.TabIndex = 4
        '
        'tpAddDespesa
        '
        Me.tpAddDespesa.Controls.Add(Me.GroupBox2)
        Me.tpAddDespesa.Controls.Add(Me.GroupBox1)
        Me.tpAddDespesa.ImageIndex = 0
        Me.tpAddDespesa.Location = New System.Drawing.Point(4, 71)
        Me.tpAddDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.tpAddDespesa.Name = "tpAddDespesa"
        Me.tpAddDespesa.Padding = New System.Windows.Forms.Padding(4)
        Me.tpAddDespesa.Size = New System.Drawing.Size(843, 411)
        Me.tpAddDespesa.TabIndex = 0
        Me.tpAddDespesa.Text = "Adicionar Despesa"
        Me.tpAddDespesa.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Location = New System.Drawing.Point(36, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(769, 160)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'txtDescricao
        '
        Me.txtDescricao.Alterado = False
        Me.txtDescricao.BackColor = System.Drawing.Color.White
        Me.txtDescricao.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtDescricao.Location = New System.Drawing.Point(12, 117)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(403, 32)
        Me.txtDescricao.SuperMascara = "0.00"
        Me.txtDescricao.SuperObrigatorio = False
        Me.txtDescricao.SuperTravaErrors = False
        Me.txtDescricao.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtDescricao.SuperTxtObrigatorio = ""
        Me.txtDescricao.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtDescricao.TabIndex = 10
        '
        'cbCategoria
        '
        Me.cbCategoria.Alterado = False
        Me.cbCategoria.BackColor = System.Drawing.Color.LightGray
        Me.cbCategoria.CorFundo = System.Drawing.Color.White
        Me.cbCategoria.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbCategoria.CorTexto = System.Drawing.Color.Black
        Me.cbCategoria.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbCategoria.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(425, 119)
        Me.cbCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(289, 30)
        Me.cbCategoria.SuperObrigatorio = False
        Me.cbCategoria.SuperTxtObrigatorio = ""
        Me.cbCategoria.TabIndex = 6
        '
        'lblMesReferente
        '
        Me.lblMesReferente.AutoSize = True
        Me.lblMesReferente.Location = New System.Drawing.Point(195, 23)
        Me.lblMesReferente.Name = "lblMesReferente"
        Me.lblMesReferente.Size = New System.Drawing.Size(182, 25)
        Me.lblMesReferente.TabIndex = 23
        Me.lblMesReferente.Text = "Mês / Referente:"
        Me.lblMesReferente.Visible = False
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(421, 92)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(118, 25)
        Me.lblCategoria.TabIndex = 7
        Me.lblCategoria.Text = "Categoria:"
        '
        'txtMesReferente
        '
        Me.txtMesReferente.Alterado = False
        Me.txtMesReferente.BackColor = System.Drawing.Color.White
        Me.txtMesReferente.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtMesReferente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMesReferente.ForeColor = System.Drawing.Color.Black
        Me.txtMesReferente.Location = New System.Drawing.Point(199, 50)
        Me.txtMesReferente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMesReferente.Name = "txtMesReferente"
        Me.txtMesReferente.ReadOnly = True
        Me.txtMesReferente.Size = New System.Drawing.Size(207, 32)
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
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(420, 23)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(86, 25)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Status:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(8, 94)
        Me.lblDescricao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(117, 25)
        Me.lblDescricao.TabIndex = 11
        Me.lblDescricao.Text = "Descrição:"
        '
        'cbStatus
        '
        Me.cbStatus.Alterado = False
        Me.cbStatus.BackColor = System.Drawing.Color.LightGray
        Me.cbStatus.CorFundo = System.Drawing.Color.White
        Me.cbStatus.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbStatus.CorTexto = System.Drawing.Color.Black
        Me.cbStatus.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbStatus.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(425, 50)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(289, 30)
        Me.cbStatus.SuperObrigatorio = True
        Me.cbStatus.SuperTxtObrigatorio = "Selecione um Status "
        Me.cbStatus.TabIndex = 14
        '
        'dtDespesa
        '
        Me.dtDespesa.Alterado = False
        Me.dtDespesa.BackColor = System.Drawing.Color.White
        Me.dtDespesa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDespesa.Location = New System.Drawing.Point(12, 50)
        Me.dtDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDespesa.Name = "dtDespesa"
        Me.dtDespesa.Size = New System.Drawing.Size(179, 32)
        Me.dtDespesa.TabIndex = 2
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(8, 23)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(68, 25)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbDespesaFixa)
        Me.GroupBox1.Controls.Add(Me.chkDespesaFixa)
        Me.GroupBox1.Controls.Add(Me.cbPagamento)
        Me.GroupBox1.Controls.Add(Me.cbConta)
        Me.GroupBox1.Controls.Add(Me.lblConta)
        Me.GroupBox1.Controls.Add(Me.txtParcela)
        Me.GroupBox1.Controls.Add(Me.lblValorParcela)
        Me.GroupBox1.Controls.Add(Me.txtValorParcela)
        Me.GroupBox1.Controls.Add(Me.chkParcela)
        Me.GroupBox1.Controls.Add(Me.lblFormaPagamento)
        Me.GroupBox1.Controls.Add(Me.cbParcelamento)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.txtValorTotal)
        Me.GroupBox1.Controls.Add(Me.lblParcela)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 175)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(768, 249)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'cbDespesaFixa
        '
        Me.cbDespesaFixa.Alterado = False
        Me.cbDespesaFixa.BackColor = System.Drawing.Color.LightGray
        Me.cbDespesaFixa.CorFundo = System.Drawing.Color.White
        Me.cbDespesaFixa.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbDespesaFixa.CorTexto = System.Drawing.Color.Black
        Me.cbDespesaFixa.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbDespesaFixa.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDespesaFixa.FormattingEnabled = True
        Me.cbDespesaFixa.Location = New System.Drawing.Point(217, 122)
        Me.cbDespesaFixa.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDespesaFixa.Name = "cbDespesaFixa"
        Me.cbDespesaFixa.Size = New System.Drawing.Size(200, 30)
        Me.cbDespesaFixa.SuperObrigatorio = False
        Me.cbDespesaFixa.SuperTxtObrigatorio = ""
        Me.cbDespesaFixa.TabIndex = 23
        '
        'chkDespesaFixa
        '
        Me.chkDespesaFixa.AutoSize = True
        Me.chkDespesaFixa.Location = New System.Drawing.Point(217, 92)
        Me.chkDespesaFixa.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDespesaFixa.Name = "chkDespesaFixa"
        Me.chkDespesaFixa.Size = New System.Drawing.Size(166, 29)
        Me.chkDespesaFixa.TabIndex = 22
        Me.chkDespesaFixa.Text = "Despesa Fixa"
        Me.chkDespesaFixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDespesaFixa.UseVisualStyleBackColor = True
        '
        'cbPagamento
        '
        Me.cbPagamento.Alterado = False
        Me.cbPagamento.BackColor = System.Drawing.Color.LightGray
        Me.cbPagamento.CorFundo = System.Drawing.Color.White
        Me.cbPagamento.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbPagamento.CorTexto = System.Drawing.Color.Black
        Me.cbPagamento.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbPagamento.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagamento.FormattingEnabled = True
        Me.cbPagamento.Location = New System.Drawing.Point(11, 186)
        Me.cbPagamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPagamento.Name = "cbPagamento"
        Me.cbPagamento.Size = New System.Drawing.Size(289, 30)
        Me.cbPagamento.SuperObrigatorio = True
        Me.cbPagamento.SuperTxtObrigatorio = "Selecione a Forma de Pagamento"
        Me.cbPagamento.TabIndex = 12
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.BackColor = System.Drawing.Color.LightGray
        Me.cbConta.CorFundo = System.Drawing.Color.White
        Me.cbConta.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbConta.CorTexto = System.Drawing.Color.Black
        Me.cbConta.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbConta.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.Location = New System.Drawing.Point(424, 186)
        Me.cbConta.Margin = New System.Windows.Forms.Padding(4)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(289, 30)
        Me.cbConta.SuperObrigatorio = True
        Me.cbConta.SuperTxtObrigatorio = "Conta Báncaria"
        Me.cbConta.TabIndex = 4
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(424, 156)
        Me.lblConta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(175, 25)
        Me.lblConta.TabIndex = 5
        Me.lblConta.Text = "Conta Báncaria:"
        '
        'txtParcela
        '
        Me.txtParcela.Alterado = False
        Me.txtParcela.BackColor = System.Drawing.Color.White
        Me.txtParcela.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtParcela.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParcela.Location = New System.Drawing.Point(424, 46)
        Me.txtParcela.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(100, 32)
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
        Me.lblValorParcela.Location = New System.Drawing.Point(213, 21)
        Me.lblValorParcela.Name = "lblValorParcela"
        Me.lblValorParcela.Size = New System.Drawing.Size(184, 25)
        Me.lblValorParcela.TabIndex = 21
        Me.lblValorParcela.Text = "Valor da parcela:"
        Me.lblValorParcela.Visible = False
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Alterado = False
        Me.txtValorParcela.BackColor = System.Drawing.Color.White
        Me.txtValorParcela.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValorParcela.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorParcela.Location = New System.Drawing.Point(217, 46)
        Me.txtValorParcela.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(200, 32)
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
        Me.chkParcela.Location = New System.Drawing.Point(12, 92)
        Me.chkParcela.Margin = New System.Windows.Forms.Padding(4)
        Me.chkParcela.Name = "chkParcela"
        Me.chkParcela.Size = New System.Drawing.Size(171, 29)
        Me.chkParcela.TabIndex = 16
        Me.chkParcela.Text = "Parcelamento"
        Me.chkParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkParcela.UseVisualStyleBackColor = True
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(7, 161)
        Me.lblFormaPagamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(235, 25)
        Me.lblFormaPagamento.TabIndex = 13
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cbParcelamento
        '
        Me.cbParcelamento.Alterado = False
        Me.cbParcelamento.BackColor = System.Drawing.Color.LightGray
        Me.cbParcelamento.CorFundo = System.Drawing.Color.White
        Me.cbParcelamento.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbParcelamento.CorTexto = System.Drawing.Color.Black
        Me.cbParcelamento.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbParcelamento.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbParcelamento.FormattingEnabled = True
        Me.cbParcelamento.Location = New System.Drawing.Point(12, 122)
        Me.cbParcelamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cbParcelamento.Name = "cbParcelamento"
        Me.cbParcelamento.Size = New System.Drawing.Size(153, 30)
        Me.cbParcelamento.SuperObrigatorio = False
        Me.cbParcelamento.SuperTxtObrigatorio = ""
        Me.cbParcelamento.TabIndex = 17
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(8, 21)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(128, 25)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor Total:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Alterado = False
        Me.txtValorTotal.BackColor = System.Drawing.Color.White
        Me.txtValorTotal.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValorTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(11, 47)
        Me.txtValorTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(200, 32)
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
        Me.lblParcela.Location = New System.Drawing.Point(420, 21)
        Me.lblParcela.Name = "lblParcela"
        Me.lblParcela.Size = New System.Drawing.Size(94, 25)
        Me.lblParcela.TabIndex = 19
        Me.lblParcela.Text = "Parcela:"
        Me.lblParcela.Visible = False
        '
        'ImgAddDespesa
        '
        Me.ImgAddDespesa.ImageStream = CType(resources.GetObject("ImgAddDespesa.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgAddDespesa.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgAddDespesa.Images.SetKeyName(0, "iconDespesa.png")
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(832, -2)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(95, 64)
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
        Me.btnSalvar.Location = New System.Drawing.Point(331, 553)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(271, 52)
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
        Me.btnDetalhe.Location = New System.Drawing.Point(40, 553)
        Me.btnDetalhe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDetalhe.Name = "btnDetalhe"
        Me.btnDetalhe.Size = New System.Drawing.Size(271, 52)
        Me.btnDetalhe.TabIndex = 13
        Me.btnDetalhe.Text = " &Detalhar"
        Me.btnDetalhe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDetalhe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDetalhe.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(620, 553)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(271, 52)
        Me.btnExcluir.TabIndex = 14
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'frmNovaDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(927, 644)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnDetalhe)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.tabDespesa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNovaDespesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNovaDespesa"
        Me.tabDespesa.ResumeLayout(False)
        Me.tpAddDespesa.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents btnExcluir As Button
    Friend WithEvents ImgAddDespesa As ImageList
End Class
