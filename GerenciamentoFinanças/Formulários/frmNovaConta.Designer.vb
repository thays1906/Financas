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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovaConta))
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
        Me.chkPrincipalConta = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaldo = New GFT.Util.SuperTextBox()
        Me.txtBanco = New GFT.Util.SuperTextBox()
        Me.ImgAddConta = New System.Windows.Forms.ImageList(Me.components)
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.tabCtrlConta.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.ForeColor = System.Drawing.Color.White
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(802, -2)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(71, 52)
        Me.btnFechar.TabIndex = 7
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.BackColor = System.Drawing.Color.DimGray
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconSalvar
        Me.btnSalvar.Location = New System.Drawing.Point(315, 504)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 42)
        Me.btnSalvar.TabIndex = 6
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
        Me.cbTipoConta.Location = New System.Drawing.Point(169, 101)
        Me.cbTipoConta.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTipoConta.Name = "cbTipoConta"
        Me.cbTipoConta.Size = New System.Drawing.Size(275, 33)
        Me.cbTipoConta.SuperObrigatorio = True
        Me.cbTipoConta.SuperTxtObrigatorio = "Tipo de Conta"
        Me.cbTipoConta.TabIndex = 2
        '
        'lblAgencia
        '
        Me.lblAgencia.AutoSize = True
        Me.lblAgencia.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgencia.Location = New System.Drawing.Point(80, 209)
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
        Me.lblConta.Location = New System.Drawing.Point(80, 252)
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
        Me.txtConta.Location = New System.Drawing.Point(169, 248)
        Me.txtConta.Margin = New System.Windows.Forms.Padding(0)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(184, 32)
        Me.txtConta.SuperMascara = ""
        Me.txtConta.SuperObrigatorio = False
        Me.txtConta.SuperTravaErrors = False
        Me.txtConta.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtConta.SuperTxtObrigatorio = ""
        Me.txtConta.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtConta.TabIndex = 5
        '
        'txtAgencia
        '
        Me.txtAgencia.Alterado = False
        Me.txtAgencia.BackColor = System.Drawing.Color.White
        Me.txtAgencia.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtAgencia.Location = New System.Drawing.Point(169, 205)
        Me.txtAgencia.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(147, 32)
        Me.txtAgencia.SuperMascara = ""
        Me.txtAgencia.SuperObrigatorio = False
        Me.txtAgencia.SuperTravaErrors = False
        Me.txtAgencia.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtAgencia.SuperTxtObrigatorio = ""
        Me.txtAgencia.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtAgencia.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Banco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Conta"
        '
        'tabCtrlConta
        '
        Me.tabCtrlConta.Controls.Add(Me.TabPage1)
        Me.tabCtrlConta.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlConta.ImageList = Me.ImgAddConta
        Me.tabCtrlConta.Location = New System.Drawing.Point(57, 44)
        Me.tabCtrlConta.Name = "tabCtrlConta"
        Me.tabCtrlConta.Padding = New System.Drawing.Point(50, 8)
        Me.tabCtrlConta.SelectedIndex = 0
        Me.tabCtrlConta.Size = New System.Drawing.Size(765, 440)
        Me.tabCtrlConta.TabIndex = 58
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbDados)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 65)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(757, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conta Báncaria"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkPrincipalConta
        '
        Me.chkPrincipalConta.AutoSize = True
        Me.chkPrincipalConta.Location = New System.Drawing.Point(492, 16)
        Me.chkPrincipalConta.Name = "chkPrincipalConta"
        Me.chkPrincipalConta.Size = New System.Drawing.Size(192, 29)
        Me.chkPrincipalConta.TabIndex = 0
        Me.chkPrincipalConta.Text = "Tornar Principal"
        Me.chkPrincipalConta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Saldo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Alterado = False
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtSaldo.Location = New System.Drawing.Point(169, 50)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(275, 32)
        Me.txtSaldo.SuperMascara = ""
        Me.txtSaldo.SuperObrigatorio = True
        Me.txtSaldo.SuperTravaErrors = False
        Me.txtSaldo.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSaldo.SuperTxtObrigatorio = ""
        Me.txtSaldo.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtSaldo.TabIndex = 1
        '
        'txtBanco
        '
        Me.txtBanco.Alterado = False
        Me.txtBanco.BackColor = System.Drawing.Color.White
        Me.txtBanco.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtBanco.Location = New System.Drawing.Point(169, 154)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(319, 32)
        Me.txtBanco.SuperMascara = ""
        Me.txtBanco.SuperObrigatorio = False
        Me.txtBanco.SuperTravaErrors = False
        Me.txtBanco.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtBanco.SuperTxtObrigatorio = ""
        Me.txtBanco.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtBanco.TabIndex = 3
        '
        'ImgAddConta
        '
        Me.ImgAddConta.ImageStream = CType(resources.GetObject("ImgAddConta.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgAddConta.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgAddConta.Images.SetKeyName(0, "iconBank.png")
        '
        'gbDados
        '
        Me.gbDados.Controls.Add(Me.chkPrincipalConta)
        Me.gbDados.Controls.Add(Me.Label1)
        Me.gbDados.Controls.Add(Me.txtBanco)
        Me.gbDados.Controls.Add(Me.txtAgencia)
        Me.gbDados.Controls.Add(Me.txtSaldo)
        Me.gbDados.Controls.Add(Me.lblAgencia)
        Me.gbDados.Controls.Add(Me.Label2)
        Me.gbDados.Controls.Add(Me.Label3)
        Me.gbDados.Controls.Add(Me.lblConta)
        Me.gbDados.Controls.Add(Me.txtConta)
        Me.gbDados.Controls.Add(Me.cbTipoConta)
        Me.gbDados.Location = New System.Drawing.Point(37, 30)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(684, 313)
        Me.gbDados.TabIndex = 62
        Me.gbDados.TabStop = False
        Me.gbDados.Text = "Dados"
        '
        'frmNovaConta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(873, 569)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.tabCtrlConta)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNovaConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNovaConta"
        Me.tabCtrlConta.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
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
    Friend WithEvents chkPrincipalConta As CheckBox
    Friend WithEvents gbDados As GroupBox
    Friend WithEvents ImgAddConta As ImageList
End Class
