<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNovaConta
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
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.cbTipoConta = New GFT.Util.SuperComboBox()
        Me.lblAgencia = New System.Windows.Forms.Label()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.txtConta = New GFT.Util.SuperTextBox()
        Me.txtAgencia = New GFT.Util.SuperTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabCtrlConta = New GFT.Util.SuperTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaldo = New GFT.Util.SuperTextBox()
        Me.txtBanco = New GFT.Util.SuperTextBox()
        Me.tabCtrlConta.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.ForeColor = System.Drawing.Color.White
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(367, 297)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(202, 54)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.icon_Salvar_png
        Me.btnSalvar.Location = New System.Drawing.Point(103, 297)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 54)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'cbTipoConta
        '
        Me.cbTipoConta.Alterado = False
        Me.cbTipoConta.CorFundo = System.Drawing.Color.White
        Me.cbTipoConta.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTipoConta.CorTexto = System.Drawing.Color.Black
        Me.cbTipoConta.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbTipoConta.FormattingEnabled = True
        Me.cbTipoConta.Location = New System.Drawing.Point(302, 46)
        Me.cbTipoConta.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTipoConta.Name = "cbTipoConta"
        Me.cbTipoConta.Size = New System.Drawing.Size(275, 32)
        Me.cbTipoConta.SuperObrigatorio = True
        Me.cbTipoConta.SuperTxtObrigatorio = "Tipo de Conta"
        Me.cbTipoConta.TabIndex = 55
        '
        'lblAgencia
        '
        Me.lblAgencia.AutoSize = True
        Me.lblAgencia.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgencia.Location = New System.Drawing.Point(9, 152)
        Me.lblAgencia.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAgencia.Name = "lblAgencia"
        Me.lblAgencia.Size = New System.Drawing.Size(87, 24)
        Me.lblAgencia.TabIndex = 48
        Me.lblAgencia.Text = "Agência:"
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConta.Location = New System.Drawing.Point(146, 152)
        Me.lblConta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(69, 24)
        Me.lblConta.TabIndex = 51
        Me.lblConta.Text = "Conta:"
        '
        'txtConta
        '
        Me.txtConta.Alterado = False
        Me.txtConta.BackColor = System.Drawing.Color.White
        Me.txtConta.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtConta.Location = New System.Drawing.Point(150, 176)
        Me.txtConta.Margin = New System.Windows.Forms.Padding(0)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(184, 32)
        Me.txtConta.SuperMascara = ""
        Me.txtConta.SuperObrigatorio = False
        Me.txtConta.SuperTravaErrors = False
        Me.txtConta.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtConta.SuperTxtObrigatorio = ""
        Me.txtConta.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtConta.TabIndex = 50
        '
        'txtAgencia
        '
        Me.txtAgencia.Alterado = False
        Me.txtAgencia.BackColor = System.Drawing.Color.White
        Me.txtAgencia.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtAgencia.Location = New System.Drawing.Point(13, 176)
        Me.txtAgencia.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(114, 32)
        Me.txtAgencia.SuperMascara = ""
        Me.txtAgencia.SuperObrigatorio = False
        Me.txtAgencia.SuperTravaErrors = False
        Me.txtAgencia.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtAgencia.SuperTxtObrigatorio = ""
        Me.txtAgencia.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtAgencia.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Banco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 24)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Conta"
        '
        'tabCtrlConta
        '
        Me.tabCtrlConta.Controls.Add(Me.TabPage1)
        Me.tabCtrlConta.Location = New System.Drawing.Point(42, 12)
        Me.tabCtrlConta.Name = "tabCtrlConta"
        Me.tabCtrlConta.SelectedIndex = 0
        Me.tabCtrlConta.Size = New System.Drawing.Size(604, 275)
        Me.tabCtrlConta.TabIndex = 58
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtSaldo)
        Me.TabPage1.Controls.Add(Me.txtBanco)
        Me.TabPage1.Controls.Add(Me.txtConta)
        Me.TabPage1.Controls.Add(Me.cbTipoConta)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtAgencia)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblConta)
        Me.TabPage1.Controls.Add(Me.lblAgencia)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(596, 238)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conta Báncaria"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 24)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Saldo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Alterado = False
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtSaldo.Location = New System.Drawing.Point(17, 46)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(275, 32)
        Me.txtSaldo.SuperMascara = ""
        Me.txtSaldo.SuperObrigatorio = True
        Me.txtSaldo.SuperTravaErrors = False
        Me.txtSaldo.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSaldo.SuperTxtObrigatorio = ""
        Me.txtSaldo.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtSaldo.TabIndex = 59
        '
        'txtBanco
        '
        Me.txtBanco.Alterado = False
        Me.txtBanco.BackColor = System.Drawing.Color.White
        Me.txtBanco.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtBanco.Location = New System.Drawing.Point(15, 108)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(277, 32)
        Me.txtBanco.SuperMascara = ""
        Me.txtBanco.SuperObrigatorio = False
        Me.txtBanco.SuperTravaErrors = False
        Me.txtBanco.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtBanco.SuperTxtObrigatorio = ""
        Me.txtBanco.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtBanco.TabIndex = 58
        '
        'frmNovaConta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(686, 364)
        Me.Controls.Add(Me.tabCtrlConta)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNovaConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNovaConta"
        Me.tabCtrlConta.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents cbTipoConta As GFT.Util.SuperComboBox
    Friend WithEvents lblAgencia As Label
    Friend WithEvents lblConta As Label
    Friend WithEvents txtConta As GFT.Util.SuperTextBox
    Friend WithEvents txtAgencia As GFT.Util.SuperTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tabCtrlConta As GFT.Util.SuperTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSaldo As GFT.Util.SuperTextBox
    Friend WithEvents txtBanco As GFT.Util.SuperTextBox
End Class
