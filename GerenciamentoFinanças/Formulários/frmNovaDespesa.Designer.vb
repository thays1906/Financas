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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovaDespesa))
        Me.tabDespesa = New GFT.Util.SuperTabControl()
        Me.tpAddDespesa = New System.Windows.Forms.TabPage()
        Me.lblValorParcela = New System.Windows.Forms.Label()
        Me.txtValorParcela = New GFT.Util.SuperTextBox()
        Me.lblParcela = New System.Windows.Forms.Label()
        Me.txtParcela = New GFT.Util.SuperTextBox()
        Me.cbParcelamento = New GFT.Util.SuperComboBox()
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
        Me.txtValor = New GFT.Util.SuperTextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.btnFechar = New GFT.Util.SuperButton()
        Me.btnSalvar = New GFT.Util.SuperButton()
        Me.tabDespesa.SuspendLayout()
        Me.tpAddDespesa.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabDespesa
        '
        Me.tabDespesa.Controls.Add(Me.tpAddDespesa)
        Me.tabDespesa.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDespesa.HotTrack = True
        Me.tabDespesa.Location = New System.Drawing.Point(34, 13)
        Me.tabDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.tabDespesa.Name = "tabDespesa"
        Me.tabDespesa.Padding = New System.Drawing.Point(50, 10)
        Me.tabDespesa.SelectedIndex = 0
        Me.tabDespesa.Size = New System.Drawing.Size(706, 463)
        Me.tabDespesa.TabIndex = 4
        '
        'tpAddDespesa
        '
        Me.tpAddDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpAddDespesa.Controls.Add(Me.lblValorParcela)
        Me.tpAddDespesa.Controls.Add(Me.txtValorParcela)
        Me.tpAddDespesa.Controls.Add(Me.lblParcela)
        Me.tpAddDespesa.Controls.Add(Me.txtParcela)
        Me.tpAddDespesa.Controls.Add(Me.cbParcelamento)
        Me.tpAddDespesa.Controls.Add(Me.chkParcela)
        Me.tpAddDespesa.Controls.Add(Me.lblStatus)
        Me.tpAddDespesa.Controls.Add(Me.cbStatus)
        Me.tpAddDespesa.Controls.Add(Me.lblFormaPagamento)
        Me.tpAddDespesa.Controls.Add(Me.cbPagamento)
        Me.tpAddDespesa.Controls.Add(Me.txtDescricao)
        Me.tpAddDespesa.Controls.Add(Me.lblDescricao)
        Me.tpAddDespesa.Controls.Add(Me.lblCategoria)
        Me.tpAddDespesa.Controls.Add(Me.cbCategoria)
        Me.tpAddDespesa.Controls.Add(Me.lblConta)
        Me.tpAddDespesa.Controls.Add(Me.cbConta)
        Me.tpAddDespesa.Controls.Add(Me.lblData)
        Me.tpAddDespesa.Controls.Add(Me.dtDespesa)
        Me.tpAddDespesa.Controls.Add(Me.txtValor)
        Me.tpAddDespesa.Controls.Add(Me.lblValor)
        Me.tpAddDespesa.Location = New System.Drawing.Point(4, 45)
        Me.tpAddDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.tpAddDespesa.Name = "tpAddDespesa"
        Me.tpAddDespesa.Padding = New System.Windows.Forms.Padding(4)
        Me.tpAddDespesa.Size = New System.Drawing.Size(698, 414)
        Me.tpAddDespesa.TabIndex = 0
        Me.tpAddDespesa.Text = "Adicionar Despesa"
        Me.tpAddDespesa.UseVisualStyleBackColor = True
        '
        'lblValorParcela
        '
        Me.lblValorParcela.AutoSize = True
        Me.lblValorParcela.Location = New System.Drawing.Point(242, 212)
        Me.lblValorParcela.Name = "lblValorParcela"
        Me.lblValorParcela.Size = New System.Drawing.Size(153, 23)
        Me.lblValorParcela.TabIndex = 21
        Me.lblValorParcela.Text = "Valor da parcela:"
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Alterado = False
        Me.txtValorParcela.BackColor = System.Drawing.Color.White
        Me.txtValorParcela.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValorParcela.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorParcela.Location = New System.Drawing.Point(246, 239)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(149, 32)
        Me.txtValorParcela.SuperMascara = ""
        Me.txtValorParcela.SuperObrigatorio = False
        Me.txtValorParcela.SuperTravaErrors = False
        Me.txtValorParcela.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValorParcela.SuperTxtObrigatorio = ""
        Me.txtValorParcela.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValorParcela.TabIndex = 20
        '
        'lblParcela
        '
        Me.lblParcela.AutoSize = True
        Me.lblParcela.Location = New System.Drawing.Point(425, 212)
        Me.lblParcela.Name = "lblParcela"
        Me.lblParcela.Size = New System.Drawing.Size(77, 23)
        Me.lblParcela.TabIndex = 19
        Me.lblParcela.Text = "Parcela:"
        '
        'txtParcela
        '
        Me.txtParcela.Alterado = False
        Me.txtParcela.BackColor = System.Drawing.Color.White
        Me.txtParcela.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtParcela.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParcela.Location = New System.Drawing.Point(429, 239)
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(100, 32)
        Me.txtParcela.SuperMascara = ""
        Me.txtParcela.SuperObrigatorio = False
        Me.txtParcela.SuperTravaErrors = False
        Me.txtParcela.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtParcela.SuperTxtObrigatorio = ""
        Me.txtParcela.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtParcela.TabIndex = 18
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
        Me.cbParcelamento.Location = New System.Drawing.Point(20, 178)
        Me.cbParcelamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cbParcelamento.Name = "cbParcelamento"
        Me.cbParcelamento.Size = New System.Drawing.Size(153, 30)
        Me.cbParcelamento.SuperObrigatorio = False
        Me.cbParcelamento.SuperTxtObrigatorio = ""
        Me.cbParcelamento.TabIndex = 17
        '
        'chkParcela
        '
        Me.chkParcela.AutoSize = True
        Me.chkParcela.Location = New System.Drawing.Point(20, 147)
        Me.chkParcela.Margin = New System.Windows.Forms.Padding(4)
        Me.chkParcela.Name = "chkParcela"
        Me.chkParcela.Size = New System.Drawing.Size(145, 27)
        Me.chkParcela.TabIndex = 16
        Me.chkParcela.Text = "Parcelamento"
        Me.chkParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkParcela.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(378, 15)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(69, 23)
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
        Me.cbStatus.Location = New System.Drawing.Point(382, 39)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(200, 30)
        Me.cbStatus.SuperObrigatorio = True
        Me.cbStatus.SuperTxtObrigatorio = "Selecione um Status "
        Me.cbStatus.TabIndex = 14
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(425, 275)
        Me.lblFormaPagamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(197, 23)
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
        Me.cbPagamento.Location = New System.Drawing.Point(429, 302)
        Me.cbPagamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPagamento.Name = "cbPagamento"
        Me.cbPagamento.Size = New System.Drawing.Size(264, 30)
        Me.cbPagamento.SuperObrigatorio = True
        Me.cbPagamento.SuperTxtObrigatorio = "Selecione a Forma de Pagamento"
        Me.cbPagamento.TabIndex = 12
        '
        'txtDescricao
        '
        Me.txtDescricao.Alterado = False
        Me.txtDescricao.BackColor = System.Drawing.Color.White
        Me.txtDescricao.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtDescricao.Location = New System.Drawing.Point(20, 110)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(562, 29)
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
        Me.lblDescricao.Location = New System.Drawing.Point(20, 82)
        Me.lblDescricao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(97, 23)
        Me.lblDescricao.TabIndex = 11
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(20, 275)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(96, 23)
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
        Me.cbCategoria.Location = New System.Drawing.Point(20, 302)
        Me.cbCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(290, 30)
        Me.cbCategoria.SuperObrigatorio = False
        Me.cbCategoria.SuperTxtObrigatorio = ""
        Me.cbCategoria.TabIndex = 6
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(20, 337)
        Me.lblConta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(65, 23)
        Me.lblConta.TabIndex = 5
        Me.lblConta.Text = "Conta:"
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
        Me.cbConta.Location = New System.Drawing.Point(20, 364)
        Me.cbConta.Margin = New System.Windows.Forms.Padding(4)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(290, 30)
        Me.cbConta.SuperObrigatorio = True
        Me.cbConta.SuperTxtObrigatorio = "Selecione uma Conta"
        Me.cbConta.TabIndex = 4
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(20, 15)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(56, 23)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data:"
        '
        'dtDespesa
        '
        Me.dtDespesa.Alterado = False
        Me.dtDespesa.BackColor = System.Drawing.Color.White
        Me.dtDespesa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDespesa.Location = New System.Drawing.Point(20, 39)
        Me.dtDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDespesa.Name = "dtDespesa"
        Me.dtDespesa.Size = New System.Drawing.Size(179, 29)
        Me.dtDespesa.TabIndex = 2
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(20, 239)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(200, 32)
        Me.txtValor.SuperMascara = "0.00"
        Me.txtValor.SuperObrigatorio = False
        Me.txtValor.SuperTravaErrors = False
        Me.txtValor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor.SuperTxtObrigatorio = "Preencha o valor da Despesa"
        Me.txtValor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor.TabIndex = 0
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(20, 212)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(106, 23)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor Total:"
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.BackgroundImage = CType(resources.GetObject("btnFechar.BackgroundImage"), System.Drawing.Image)
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(373, 484)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(183, 49)
        Me.btnFechar.TabIndex = 9
        Me.btnFechar.Text = "  &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.icon_Salvar_png
        Me.btnSalvar.Location = New System.Drawing.Point(140, 484)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(183, 49)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "  &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'frmNovaDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(781, 556)
        Me.Controls.Add(Me.tabDespesa)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnFechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNovaDespesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNovaDespesa"
        Me.tabDespesa.ResumeLayout(False)
        Me.tpAddDespesa.ResumeLayout(False)
        Me.tpAddDespesa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabDespesa As GFT.Util.SuperTabControl
    Friend WithEvents tpAddDespesa As TabPage
    Friend WithEvents btnFechar As GFT.Util.SuperButton
    Friend WithEvents btnSalvar As GFT.Util.SuperButton
    Friend WithEvents lblCategoria As Label
    Friend WithEvents cbCategoria As GFT.Util.SuperComboBox
    Friend WithEvents lblConta As Label
    Friend WithEvents cbConta As GFT.Util.SuperComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents dtDespesa As GFT.Util.SuperDatePicker
    Friend WithEvents txtValor As GFT.Util.SuperTextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents txtDescricao As GFT.Util.SuperTextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents cbParcelamento As GFT.Util.SuperComboBox
    Friend WithEvents chkParcela As CheckBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbStatus As GFT.Util.SuperComboBox
    Friend WithEvents lblFormaPagamento As Label
    Friend WithEvents cbPagamento As GFT.Util.SuperComboBox
    Friend WithEvents lblParcela As Label
    Friend WithEvents txtParcela As GFT.Util.SuperTextBox
    Friend WithEvents lblValorParcela As Label
    Friend WithEvents txtValorParcela As GFT.Util.SuperTextBox
End Class
