<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tabCtrlNovaConta = New GFT.Util.SuperTabControl()
        Me.tabContaNova = New System.Windows.Forms.TabPage()
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
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.tabCtrlNovaConta.SuspendLayout()
        Me.tabContaNova.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlNovaConta
        '
        Me.tabCtrlNovaConta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabCtrlNovaConta.Controls.Add(Me.tabContaNova)
        Me.tabCtrlNovaConta.Location = New System.Drawing.Point(39, 22)
        Me.tabCtrlNovaConta.Name = "tabCtrlNovaConta"
        Me.tabCtrlNovaConta.Padding = New System.Drawing.Point(50, 10)
        Me.tabCtrlNovaConta.SelectedIndex = 0
        Me.tabCtrlNovaConta.Size = New System.Drawing.Size(652, 262)
        Me.tabCtrlNovaConta.TabIndex = 39
        '
        'tabContaNova
        '
        Me.tabContaNova.Controls.Add(Me.cbTipoConta)
        Me.tabContaNova.Controls.Add(Me.txtBanco)
        Me.tabContaNova.Controls.Add(Me.lblTipoConta)
        Me.tabContaNova.Controls.Add(Me.lblBanco)
        Me.tabContaNova.Controls.Add(Me.lblAgencia)
        Me.tabContaNova.Controls.Add(Me.txtSaldo)
        Me.tabContaNova.Controls.Add(Me.lblConta)
        Me.tabContaNova.Controls.Add(Me.txtConta)
        Me.tabContaNova.Controls.Add(Me.lblSaldo)
        Me.tabContaNova.Controls.Add(Me.txtAgencia)
        Me.tabContaNova.Location = New System.Drawing.Point(4, 39)
        Me.tabContaNova.Name = "tabContaNova"
        Me.tabContaNova.Padding = New System.Windows.Forms.Padding(3)
        Me.tabContaNova.Size = New System.Drawing.Size(644, 219)
        Me.tabContaNova.TabIndex = 0
        Me.tabContaNova.Text = "Conta Báncaria"
        Me.tabContaNova.UseVisualStyleBackColor = True
        '
        'cbTipoConta
        '
        Me.cbTipoConta.Alterado = False
        Me.cbTipoConta.CorFundo = System.Drawing.Color.White
        Me.cbTipoConta.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTipoConta.CorTexto = System.Drawing.Color.Black
        Me.cbTipoConta.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbTipoConta.FormattingEnabled = True
        Me.cbTipoConta.Location = New System.Drawing.Point(338, 58)
        Me.cbTipoConta.Name = "cbTipoConta"
        Me.cbTipoConta.Size = New System.Drawing.Size(275, 24)
        Me.cbTipoConta.SuperObrigatorio = True
        Me.cbTipoConta.SuperTxtObrigatorio = "Tipo de Conta"
        Me.cbTipoConta.TabIndex = 45
        '
        'txtBanco
        '
        Me.txtBanco.Alterado = False
        Me.txtBanco.BackColor = System.Drawing.Color.White
        Me.txtBanco.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtBanco.Location = New System.Drawing.Point(44, 109)
        Me.txtBanco.Margin = New System.Windows.Forms.Padding(6)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(354, 22)
        Me.txtBanco.SuperMascara = ""
        Me.txtBanco.SuperObrigatorio = True
        Me.txtBanco.SuperTravaErrors = False
        Me.txtBanco.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtBanco.SuperTxtObrigatorio = "BANCO"
        Me.txtBanco.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtBanco.TabIndex = 37
        '
        'lblTipoConta
        '
        Me.lblTipoConta.AutoSize = True
        Me.lblTipoConta.Location = New System.Drawing.Point(335, 38)
        Me.lblTipoConta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTipoConta.Name = "lblTipoConta"
        Me.lblTipoConta.Size = New System.Drawing.Size(101, 17)
        Me.lblTipoConta.TabIndex = 44
        Me.lblTipoConta.Text = "Tipo de Conta:"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(40, 86)
        Me.lblBanco.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(52, 17)
        Me.lblBanco.TabIndex = 36
        Me.lblBanco.Text = "Banco:"
        '
        'lblAgencia
        '
        Me.lblAgencia.AutoSize = True
        Me.lblAgencia.Location = New System.Drawing.Point(40, 144)
        Me.lblAgencia.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAgencia.Name = "lblAgencia"
        Me.lblAgencia.Size = New System.Drawing.Size(63, 17)
        Me.lblAgencia.TabIndex = 38
        Me.lblAgencia.Text = "Agência:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Alterado = False
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtSaldo.Location = New System.Drawing.Point(43, 58)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(275, 22)
        Me.txtSaldo.SuperMascara = ""
        Me.txtSaldo.SuperObrigatorio = True
        Me.txtSaldo.SuperTravaErrors = False
        Me.txtSaldo.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSaldo.SuperTxtObrigatorio = "SALDO"
        Me.txtSaldo.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtSaldo.TabIndex = 43
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(166, 144)
        Me.lblConta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(49, 17)
        Me.lblConta.TabIndex = 41
        Me.lblConta.Text = "Conta:"
        '
        'txtConta
        '
        Me.txtConta.Alterado = False
        Me.txtConta.BackColor = System.Drawing.Color.White
        Me.txtConta.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtConta.Location = New System.Drawing.Point(169, 167)
        Me.txtConta.Margin = New System.Windows.Forms.Padding(6)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(184, 22)
        Me.txtConta.SuperMascara = ""
        Me.txtConta.SuperObrigatorio = False
        Me.txtConta.SuperTravaErrors = False
        Me.txtConta.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtConta.SuperTxtObrigatorio = ""
        Me.txtConta.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtConta.TabIndex = 40
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(39, 38)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(48, 17)
        Me.lblSaldo.TabIndex = 42
        Me.lblSaldo.Text = "Saldo:"
        '
        'txtAgencia
        '
        Me.txtAgencia.Alterado = False
        Me.txtAgencia.BackColor = System.Drawing.Color.White
        Me.txtAgencia.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtAgencia.Location = New System.Drawing.Point(43, 167)
        Me.txtAgencia.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(114, 22)
        Me.txtAgencia.SuperMascara = ""
        Me.txtAgencia.SuperObrigatorio = False
        Me.txtAgencia.SuperTravaErrors = False
        Me.txtAgencia.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtAgencia.SuperTxtObrigatorio = ""
        Me.txtAgencia.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtAgencia.TabIndex = 39
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
        Me.btnFechar.Location = New System.Drawing.Point(398, 301)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(202, 54)
        Me.btnFechar.TabIndex = 38
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
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
        Me.btnSalvar.Location = New System.Drawing.Point(107, 301)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 54)
        Me.btnSalvar.TabIndex = 37
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 392)
        Me.Controls.Add(Me.tabCtrlNovaConta)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.tabCtrlNovaConta.ResumeLayout(False)
        Me.tabContaNova.ResumeLayout(False)
        Me.tabContaNova.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlNovaConta As GFT.Util.SuperTabControl
    Friend WithEvents tabContaNova As TabPage
    Friend WithEvents cbTipoConta As GFT.Util.SuperComboBox
    Friend WithEvents txtBanco As GFT.Util.SuperTextBox
    Friend WithEvents lblTipoConta As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents lblAgencia As Label
    Friend WithEvents txtSaldo As GFT.Util.SuperTextBox
    Friend WithEvents lblConta As Label
    Friend WithEvents txtConta As GFT.Util.SuperTextBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents txtAgencia As GFT.Util.SuperTextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnSalvar As Button
End Class
