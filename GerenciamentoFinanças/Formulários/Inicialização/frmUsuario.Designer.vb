<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.tabCtrlUsuar = New System.Windows.Forms.TabControl()
        Me.tabCadastro = New System.Windows.Forms.TabPage()
        Me.chkLogin = New System.Windows.Forms.CheckBox()
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.chkAlteraSenha = New System.Windows.Forms.CheckBox()
        Me.gbAlterarSenha = New System.Windows.Forms.GroupBox()
        Me.txtConfirmSenha = New GFT.Util.SuperTextBox()
        Me.txtSenha = New GFT.Util.SuperTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New GFT.Util.SuperTextBox()
        Me.ImgUsuar = New System.Windows.Forms.ImageList(Me.components)
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.tabCtrlUsuar.SuspendLayout()
        Me.tabCadastro.SuspendLayout()
        Me.gbDados.SuspendLayout()
        Me.gbAlterarSenha.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlUsuar
        '
        Me.tabCtrlUsuar.Controls.Add(Me.tabCadastro)
        Me.tabCtrlUsuar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlUsuar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlUsuar.ImageList = Me.ImgUsuar
        Me.tabCtrlUsuar.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlUsuar.Name = "tabCtrlUsuar"
        Me.tabCtrlUsuar.Padding = New System.Drawing.Point(50, 10)
        Me.tabCtrlUsuar.SelectedIndex = 0
        Me.tabCtrlUsuar.Size = New System.Drawing.Size(1203, 568)
        Me.tabCtrlUsuar.TabIndex = 0
        '
        'tabCadastro
        '
        Me.tabCadastro.Controls.Add(Me.chkLogin)
        Me.tabCadastro.Controls.Add(Me.gbDados)
        Me.tabCadastro.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCadastro.ImageIndex = 0
        Me.tabCadastro.Location = New System.Drawing.Point(4, 69)
        Me.tabCadastro.Name = "tabCadastro"
        Me.tabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastro.Size = New System.Drawing.Size(1195, 495)
        Me.tabCadastro.TabIndex = 0
        Me.tabCadastro.Text = "Usuário"
        Me.tabCadastro.UseVisualStyleBackColor = True
        '
        'chkLogin
        '
        Me.chkLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkLogin.AutoSize = True
        Me.chkLogin.Location = New System.Drawing.Point(916, 27)
        Me.chkLogin.Name = "chkLogin"
        Me.chkLogin.Size = New System.Drawing.Size(203, 29)
        Me.chkLogin.TabIndex = 5
        Me.chkLogin.Text = "Desabilitar Login"
        Me.chkLogin.UseVisualStyleBackColor = True
        '
        'gbDados
        '
        Me.gbDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDados.Controls.Add(Me.chkAlteraSenha)
        Me.gbDados.Controls.Add(Me.gbAlterarSenha)
        Me.gbDados.Controls.Add(Me.Label1)
        Me.gbDados.Controls.Add(Me.txtUsuario)
        Me.gbDados.Location = New System.Drawing.Point(68, 50)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(1051, 397)
        Me.gbDados.TabIndex = 1
        Me.gbDados.TabStop = False
        Me.gbDados.Text = "Dados"
        '
        'chkAlteraSenha
        '
        Me.chkAlteraSenha.AutoSize = True
        Me.chkAlteraSenha.Location = New System.Drawing.Point(78, 153)
        Me.chkAlteraSenha.Name = "chkAlteraSenha"
        Me.chkAlteraSenha.Size = New System.Drawing.Size(182, 29)
        Me.chkAlteraSenha.TabIndex = 1
        Me.chkAlteraSenha.Text = "Trocar a senha"
        Me.chkAlteraSenha.UseVisualStyleBackColor = True
        '
        'gbAlterarSenha
        '
        Me.gbAlterarSenha.Controls.Add(Me.txtConfirmSenha)
        Me.gbAlterarSenha.Controls.Add(Me.txtSenha)
        Me.gbAlterarSenha.Controls.Add(Me.Label3)
        Me.gbAlterarSenha.Controls.Add(Me.Label2)
        Me.gbAlterarSenha.Enabled = False
        Me.gbAlterarSenha.Location = New System.Drawing.Point(78, 188)
        Me.gbAlterarSenha.Name = "gbAlterarSenha"
        Me.gbAlterarSenha.Size = New System.Drawing.Size(599, 184)
        Me.gbAlterarSenha.TabIndex = 2
        Me.gbAlterarSenha.TabStop = False
        Me.gbAlterarSenha.Text = "Alterar senha"
        '
        'txtConfirmSenha
        '
        Me.txtConfirmSenha.Alterado = False
        Me.txtConfirmSenha.BackColor = System.Drawing.Color.White
        Me.txtConfirmSenha.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtConfirmSenha.Location = New System.Drawing.Point(340, 102)
        Me.txtConfirmSenha.Name = "txtConfirmSenha"
        Me.txtConfirmSenha.Size = New System.Drawing.Size(221, 32)
        Me.txtConfirmSenha.SuperMascara = ""
        Me.txtConfirmSenha.SuperObrigatorio = True
        Me.txtConfirmSenha.SuperTravaErrors = False
        Me.txtConfirmSenha.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtConfirmSenha.SuperTxtObrigatorio = "Confirme a senha"
        Me.txtConfirmSenha.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtConfirmSenha.TabIndex = 3
        '
        'txtSenha
        '
        Me.txtSenha.Alterado = False
        Me.txtSenha.BackColor = System.Drawing.Color.White
        Me.txtSenha.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtSenha.Location = New System.Drawing.Point(28, 102)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(221, 32)
        Me.txtSenha.SuperMascara = ""
        Me.txtSenha.SuperObrigatorio = True
        Me.txtSenha.SuperTravaErrors = False
        Me.txtSenha.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSenha.SuperTxtObrigatorio = "Nova Senha"
        Me.txtSenha.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtSenha.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nova Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Confirmação da senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuário"
        '
        'txtUsuario
        '
        Me.txtUsuario.Alterado = False
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtUsuario.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(78, 78)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(314, 32)
        Me.txtUsuario.SuperMascara = ""
        Me.txtUsuario.SuperObrigatorio = False
        Me.txtUsuario.SuperTravaErrors = False
        Me.txtUsuario.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtUsuario.SuperTxtObrigatorio = ""
        Me.txtUsuario.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtUsuario.TabIndex = 0
        '
        'ImgUsuar
        '
        Me.ImgUsuar.ImageStream = CType(resources.GetObject("ImgUsuar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgUsuar.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgUsuar.Images.SetKeyName(0, "iconUsuar.png")
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbBotoes.Controls.Add(Me.btnSalvar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBotoes.Location = New System.Drawing.Point(0, 568)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1203, 85)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnSalvar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconSalvar
        Me.btnSalvar.Location = New System.Drawing.Point(462, 20)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(267, 52)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 653)
        Me.Controls.Add(Me.tabCtrlUsuar)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsuario"
        Me.Text = "frmUsuario"
        Me.tabCtrlUsuar.ResumeLayout(False)
        Me.tabCadastro.ResumeLayout(False)
        Me.tabCadastro.PerformLayout()
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        Me.gbAlterarSenha.ResumeLayout(False)
        Me.gbAlterarSenha.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlUsuar As TabControl
    Friend WithEvents tabCadastro As TabPage
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents ImgUsuar As ImageList
    Friend WithEvents gbDados As GroupBox
    Friend WithEvents gbAlterarSenha As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As GFT.Util.SuperTextBox
    Friend WithEvents chkAlteraSenha As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents txtConfirmSenha As GFT.Util.SuperTextBox
    Friend WithEvents txtSenha As GFT.Util.SuperTextBox
    Friend WithEvents chkLogin As CheckBox
End Class
