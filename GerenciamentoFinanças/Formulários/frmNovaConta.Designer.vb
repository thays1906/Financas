<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNovaConta
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
        Me.gbAddConta = New System.Windows.Forms.GroupBox()
        Me.cbTipoConta = New GFT.Util.SuperComboBox()
        Me.txtBanco = New GFT.Util.SuperTextBox()
        Me.lblTipoConta = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.lblAgencia = New System.Windows.Forms.Label()
        Me.txtSaldo = New GFT.Util.SuperTextBox()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.txtConta = New GFT.Util.SuperTextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.txtAgencia = New GFT.Util.SuperTextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.tabCtrlNovaConta = New GFT.Util.SuperTabControl()
        Me.tabContaNova = New System.Windows.Forms.TabPage()
        Me.gbAddConta.SuspendLayout()
        Me.tabCtrlNovaConta.SuspendLayout()
        Me.tabContaNova.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAddConta
        '
        Me.gbAddConta.Controls.Add(Me.cbTipoConta)
        Me.gbAddConta.Controls.Add(Me.txtBanco)
        Me.gbAddConta.Controls.Add(Me.lblTipoConta)
        Me.gbAddConta.Controls.Add(Me.lblBanco)
        Me.gbAddConta.Controls.Add(Me.lblAgencia)
        Me.gbAddConta.Controls.Add(Me.txtSaldo)
        Me.gbAddConta.Controls.Add(Me.lblConta)
        Me.gbAddConta.Controls.Add(Me.txtConta)
        Me.gbAddConta.Controls.Add(Me.lblSaldo)
        Me.gbAddConta.Controls.Add(Me.txtAgencia)
        Me.gbAddConta.Location = New System.Drawing.Point(7, 7)
        Me.gbAddConta.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAddConta.Name = "gbAddConta"
        Me.gbAddConta.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAddConta.Size = New System.Drawing.Size(719, 297)
        Me.gbAddConta.TabIndex = 0
        Me.gbAddConta.TabStop = False
        Me.gbAddConta.Text = "Dados da Conta"
        '
        'cbTipoConta
        '
        Me.cbTipoConta.Alterado = False
        Me.cbTipoConta.CorFundo = System.Drawing.Color.White
        Me.cbTipoConta.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTipoConta.CorTexto = System.Drawing.Color.Black
        Me.cbTipoConta.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbTipoConta.FormattingEnabled = True
        Me.cbTipoConta.Location = New System.Drawing.Point(395, 95)
        Me.cbTipoConta.Name = "cbTipoConta"
        Me.cbTipoConta.Size = New System.Drawing.Size(275, 32)
        Me.cbTipoConta.SuperObrigatorio = True
        Me.cbTipoConta.SuperTxtObrigatorio = "Tipo de Conta"
        Me.cbTipoConta.TabIndex = 35
        '
        'txtBanco
        '
        Me.txtBanco.Alterado = False
        Me.txtBanco.BackColor = System.Drawing.Color.White
        Me.txtBanco.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtBanco.Location = New System.Drawing.Point(50, 163)
        Me.txtBanco.Margin = New System.Windows.Forms.Padding(6)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(620, 32)
        Me.txtBanco.SuperMascara = ""
        Me.txtBanco.SuperObrigatorio = True
        Me.txtBanco.SuperTravaErrors = False
        Me.txtBanco.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtBanco.SuperTxtObrigatorio = "BANCO"
        Me.txtBanco.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtBanco.TabIndex = 26
        '
        'lblTipoConta
        '
        Me.lblTipoConta.AutoSize = True
        Me.lblTipoConta.Location = New System.Drawing.Point(390, 65)
        Me.lblTipoConta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTipoConta.Name = "lblTipoConta"
        Me.lblTipoConta.Size = New System.Drawing.Size(142, 24)
        Me.lblTipoConta.TabIndex = 34
        Me.lblTipoConta.Text = "Tipo de Conta:"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(46, 133)
        Me.lblBanco.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(71, 24)
        Me.lblBanco.TabIndex = 25
        Me.lblBanco.Text = "Banco:"
        '
        'lblAgencia
        '
        Me.lblAgencia.AutoSize = True
        Me.lblAgencia.Location = New System.Drawing.Point(46, 201)
        Me.lblAgencia.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAgencia.Name = "lblAgencia"
        Me.lblAgencia.Size = New System.Drawing.Size(87, 24)
        Me.lblAgencia.TabIndex = 27
        Me.lblAgencia.Text = "Agência:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Alterado = False
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtSaldo.Location = New System.Drawing.Point(49, 95)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(275, 32)
        Me.txtSaldo.SuperMascara = ""
        Me.txtSaldo.SuperObrigatorio = True
        Me.txtSaldo.SuperTravaErrors = False
        Me.txtSaldo.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSaldo.SuperTxtObrigatorio = "SALDO"
        Me.txtSaldo.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtSaldo.TabIndex = 32
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(391, 201)
        Me.lblConta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(69, 24)
        Me.lblConta.TabIndex = 30
        Me.lblConta.Text = "Conta:"
        '
        'txtConta
        '
        Me.txtConta.Alterado = False
        Me.txtConta.BackColor = System.Drawing.Color.White
        Me.txtConta.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtConta.Location = New System.Drawing.Point(394, 231)
        Me.txtConta.Margin = New System.Windows.Forms.Padding(6)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(275, 32)
        Me.txtConta.SuperMascara = ""
        Me.txtConta.SuperObrigatorio = False
        Me.txtConta.SuperTravaErrors = False
        Me.txtConta.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtConta.SuperTxtObrigatorio = ""
        Me.txtConta.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtConta.TabIndex = 29
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(45, 65)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(66, 24)
        Me.lblSaldo.TabIndex = 31
        Me.lblSaldo.Text = "Saldo:"
        '
        'txtAgencia
        '
        Me.txtAgencia.Alterado = False
        Me.txtAgencia.BackColor = System.Drawing.Color.White
        Me.txtAgencia.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtAgencia.Location = New System.Drawing.Point(50, 231)
        Me.txtAgencia.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(275, 32)
        Me.txtAgencia.SuperMascara = ""
        Me.txtAgencia.SuperObrigatorio = False
        Me.txtAgencia.SuperTravaErrors = False
        Me.txtAgencia.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtAgencia.SuperTxtObrigatorio = ""
        Me.txtAgencia.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtAgencia.TabIndex = 28
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.icon_Salvar_png
        Me.btnSalvar.Location = New System.Drawing.Point(168, 374)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 54)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(455, 374)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(202, 54)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'tabCtrlNovaConta
        '
        Me.tabCtrlNovaConta.Controls.Add(Me.tabContaNova)
        Me.tabCtrlNovaConta.Location = New System.Drawing.Point(31, 12)
        Me.tabCtrlNovaConta.Name = "tabCtrlNovaConta"
        Me.tabCtrlNovaConta.Padding = New System.Drawing.Point(50, 10)
        Me.tabCtrlNovaConta.SelectedIndex = 0
        Me.tabCtrlNovaConta.Size = New System.Drawing.Size(744, 353)
        Me.tabCtrlNovaConta.TabIndex = 36
        '
        'tabContaNova
        '
        Me.tabContaNova.Controls.Add(Me.gbAddConta)
        Me.tabContaNova.Location = New System.Drawing.Point(4, 47)
        Me.tabContaNova.Name = "tabContaNova"
        Me.tabContaNova.Padding = New System.Windows.Forms.Padding(3)
        Me.tabContaNova.Size = New System.Drawing.Size(736, 302)
        Me.tabContaNova.TabIndex = 0
        Me.tabContaNova.Text = "Conta Báncaria"
        Me.tabContaNova.UseVisualStyleBackColor = True
        '
        'frmNovaConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 453)
        Me.Controls.Add(Me.tabCtrlNovaConta)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNovaConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNovaConta"
        Me.gbAddConta.ResumeLayout(False)
        Me.gbAddConta.PerformLayout()
        Me.tabCtrlNovaConta.ResumeLayout(False)
        Me.tabContaNova.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbAddConta As GroupBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents txtBanco As GFT.Util.SuperTextBox
    Friend WithEvents lblTipoConta As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents lblAgencia As Label
    Friend WithEvents txtSaldo As GFT.Util.SuperTextBox
    Friend WithEvents lblConta As Label
    Friend WithEvents txtConta As GFT.Util.SuperTextBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents txtAgencia As GFT.Util.SuperTextBox
    Friend WithEvents cbTipoConta As GFT.Util.SuperComboBox
    Friend WithEvents tabCtrlNovaConta As GFT.Util.SuperTabControl
    Friend WithEvents tabContaNova As TabPage
End Class
