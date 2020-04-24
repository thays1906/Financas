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
        Me.tabDespesa.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDespesa.HotTrack = True
        Me.tabDespesa.Location = New System.Drawing.Point(30, 2)
        Me.tabDespesa.Name = "tabDespesa"
        Me.tabDespesa.Padding = New System.Drawing.Point(50, 10)
        Me.tabDespesa.SelectedIndex = 0
        Me.tabDespesa.Size = New System.Drawing.Size(507, 313)
        Me.tabDespesa.TabIndex = 4
        '
        'tpAddDespesa
        '
        Me.tpAddDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.tpAddDespesa.Location = New System.Drawing.Point(4, 40)
        Me.tpAddDespesa.Name = "tpAddDespesa"
        Me.tpAddDespesa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAddDespesa.Size = New System.Drawing.Size(499, 269)
        Me.tpAddDespesa.TabIndex = 0
        Me.tpAddDespesa.Text = "Adicionar Despesa"
        Me.tpAddDespesa.UseVisualStyleBackColor = True
        '
        'cbParcelamento
        '
        Me.cbParcelamento.Alterado = False
        Me.cbParcelamento.FormattingEnabled = True
        Me.cbParcelamento.Location = New System.Drawing.Point(18, 236)
        Me.cbParcelamento.Name = "cbParcelamento"
        Me.cbParcelamento.Size = New System.Drawing.Size(75, 25)
        Me.cbParcelamento.SuperObrigatorio = False
        Me.cbParcelamento.SuperTxtObrigatorio = ""
        Me.cbParcelamento.TabIndex = 17
        '
        'chkParcela
        '
        Me.chkParcela.AutoSize = True
        Me.chkParcela.Location = New System.Drawing.Point(18, 209)
        Me.chkParcela.Name = "chkParcela"
        Me.chkParcela.Size = New System.Drawing.Size(118, 21)
        Me.chkParcela.TabIndex = 16
        Me.chkParcela.Text = "Parcelamento"
        Me.chkParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkParcela.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(289, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(54, 17)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Status:"
        '
        'cbStatus
        '
        Me.cbStatus.Alterado = False
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(292, 32)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(199, 25)
        Me.cbStatus.SuperObrigatorio = True
        Me.cbStatus.SuperTxtObrigatorio = "Selecione um Status "
        Me.cbStatus.TabIndex = 14
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(289, 122)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(154, 17)
        Me.lblFormaPagamento.TabIndex = 13
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cbPagamento
        '
        Me.cbPagamento.Alterado = False
        Me.cbPagamento.FormattingEnabled = True
        Me.cbPagamento.Location = New System.Drawing.Point(292, 142)
        Me.cbPagamento.Name = "cbPagamento"
        Me.cbPagamento.Size = New System.Drawing.Size(199, 25)
        Me.cbPagamento.SuperObrigatorio = True
        Me.cbPagamento.SuperTxtObrigatorio = "Selecione a Forma de Pagamento"
        Me.cbPagamento.TabIndex = 12
        '
        'txtDescricao
        '
        Me.txtDescricao.Alterado = False
        Me.txtDescricao.BackColor = System.Drawing.Color.White
        Me.txtDescricao.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtDescricao.Location = New System.Drawing.Point(18, 87)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(237, 25)
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
        Me.lblDescricao.Location = New System.Drawing.Point(15, 67)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(79, 17)
        Me.lblDescricao.TabIndex = 11
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(15, 119)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(75, 17)
        Me.lblCategoria.TabIndex = 7
        Me.lblCategoria.Text = "Categoria:"
        '
        'cbCategoria
        '
        Me.cbCategoria.Alterado = False
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(18, 139)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(199, 25)
        Me.cbCategoria.SuperObrigatorio = False
        Me.cbCategoria.SuperTxtObrigatorio = ""
        Me.cbCategoria.TabIndex = 6
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(289, 67)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(51, 17)
        Me.lblConta.TabIndex = 5
        Me.lblConta.Text = "Conta:"
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.Location = New System.Drawing.Point(292, 87)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(199, 25)
        Me.cbConta.SuperObrigatorio = True
        Me.cbConta.SuperTxtObrigatorio = "Selecione uma Conta"
        Me.cbConta.TabIndex = 4
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(15, 12)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(43, 17)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data:"
        '
        'dtDespesa
        '
        Me.dtDespesa.Alterado = False
        Me.dtDespesa.BackColor = System.Drawing.Color.White
        Me.dtDespesa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDespesa.Location = New System.Drawing.Point(18, 32)
        Me.dtDespesa.Name = "dtDespesa"
        Me.dtDespesa.Size = New System.Drawing.Size(109, 25)
        Me.dtDespesa.TabIndex = 2
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValor.Location = New System.Drawing.Point(335, 236)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(151, 25)
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
        Me.lblValor.Location = New System.Drawing.Point(332, 216)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(123, 17)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor da Despesa"
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
        Me.btnFechar.Location = New System.Drawing.Point(284, 331)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(137, 40)
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
        Me.btnSalvar.Location = New System.Drawing.Point(129, 331)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(137, 40)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "  &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'frmNovaDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(568, 392)
        Me.Controls.Add(Me.tabDespesa)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnFechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
End Class
