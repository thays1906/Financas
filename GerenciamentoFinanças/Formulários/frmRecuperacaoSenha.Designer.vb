<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperacaoSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecuperacaoSenha))
        Me.ssCima = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssBaixo = New System.Windows.Forms.StatusStrip()
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.LetreiroRecupera = New GFT.Util.SuperLetreiro()
        Me.lblConfirmInfo = New System.Windows.Forms.Label()
        Me.lblSenhaInfo = New System.Windows.Forms.Label()
        Me.lblDataInfo = New System.Windows.Forms.Label()
        Me.dtpNasc = New System.Windows.Forms.DateTimePicker()
        Me.lblDataNasc = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblNova = New System.Windows.Forms.Label()
        Me.txtSenha = New GFT.Util.SuperTextBox()
        Me.txtSenhaConfirm = New GFT.Util.SuperTextBox()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.txtUsuario = New GFT.Util.SuperTextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.ssCima.SuspendLayout()
        Me.gbDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssCima
        '
        Me.ssCima.AutoSize = False
        Me.ssCima.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ssCima.Dock = System.Windows.Forms.DockStyle.Top
        Me.ssCima.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssCima.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.ssCima.Location = New System.Drawing.Point(0, 0)
        Me.ssCima.Name = "ssCima"
        Me.ssCima.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ssCima.Size = New System.Drawing.Size(835, 48)
        Me.ssCima.SizingGrip = False
        Me.ssCima.TabIndex = 0
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(238, 42)
        Me.ToolStripStatusLabel1.Text = "Recuperação de senha"
        '
        'ssBaixo
        '
        Me.ssBaixo.AutoSize = False
        Me.ssBaixo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssBaixo.Location = New System.Drawing.Point(0, 423)
        Me.ssBaixo.Name = "ssBaixo"
        Me.ssBaixo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ssBaixo.Size = New System.Drawing.Size(835, 48)
        Me.ssBaixo.TabIndex = 1
        Me.ssBaixo.Text = "StatusStrip1"
        '
        'gbDados
        '
        Me.gbDados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbDados.Controls.Add(Me.LetreiroRecupera)
        Me.gbDados.Controls.Add(Me.lblConfirmInfo)
        Me.gbDados.Controls.Add(Me.lblSenhaInfo)
        Me.gbDados.Controls.Add(Me.lblDataInfo)
        Me.gbDados.Controls.Add(Me.dtpNasc)
        Me.gbDados.Controls.Add(Me.lblDataNasc)
        Me.gbDados.Controls.Add(Me.lblConfirm)
        Me.gbDados.Controls.Add(Me.lblNova)
        Me.gbDados.Controls.Add(Me.txtSenha)
        Me.gbDados.Controls.Add(Me.txtSenhaConfirm)
        Me.gbDados.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.gbDados.Location = New System.Drawing.Point(80, 114)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(676, 238)
        Me.gbDados.TabIndex = 2
        Me.gbDados.TabStop = False
        '
        'LetreiroRecupera
        '
        Me.LetreiroRecupera.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LetreiroRecupera.CorSombraTexto = System.Drawing.Color.Black
        Me.LetreiroRecupera.ForeColor = System.Drawing.Color.Red
        Me.LetreiroRecupera.Location = New System.Drawing.Point(155, 19)
        Me.LetreiroRecupera.Name = "LetreiroRecupera"
        Me.LetreiroRecupera.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
        Me.LetreiroRecupera.Size = New System.Drawing.Size(363, 21)
        Me.LetreiroRecupera.TabIndex = 11
        Me.LetreiroRecupera.TextoLetreiro = ""
        Me.LetreiroRecupera.VelocidadeRolagem = 1
        '
        'lblConfirmInfo
        '
        Me.lblConfirmInfo.AutoSize = True
        Me.lblConfirmInfo.ForeColor = System.Drawing.Color.Red
        Me.lblConfirmInfo.Location = New System.Drawing.Point(319, 118)
        Me.lblConfirmInfo.Name = "lblConfirmInfo"
        Me.lblConfirmInfo.Size = New System.Drawing.Size(78, 25)
        Me.lblConfirmInfo.TabIndex = 10
        Me.lblConfirmInfo.Text = "Label2"
        Me.lblConfirmInfo.Visible = False
        '
        'lblSenhaInfo
        '
        Me.lblSenhaInfo.AutoSize = True
        Me.lblSenhaInfo.ForeColor = System.Drawing.Color.Red
        Me.lblSenhaInfo.Location = New System.Drawing.Point(20, 118)
        Me.lblSenhaInfo.Name = "lblSenhaInfo"
        Me.lblSenhaInfo.Size = New System.Drawing.Size(78, 25)
        Me.lblSenhaInfo.TabIndex = 9
        Me.lblSenhaInfo.Text = "Label2"
        Me.lblSenhaInfo.Visible = False
        '
        'lblDataInfo
        '
        Me.lblDataInfo.AutoSize = True
        Me.lblDataInfo.ForeColor = System.Drawing.Color.Red
        Me.lblDataInfo.Location = New System.Drawing.Point(240, 197)
        Me.lblDataInfo.Name = "lblDataInfo"
        Me.lblDataInfo.Size = New System.Drawing.Size(78, 25)
        Me.lblDataInfo.TabIndex = 8
        Me.lblDataInfo.Text = "Label2"
        Me.lblDataInfo.Visible = False
        '
        'dtpNasc
        '
        Me.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNasc.Location = New System.Drawing.Point(25, 190)
        Me.dtpNasc.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.dtpNasc.Name = "dtpNasc"
        Me.dtpNasc.Size = New System.Drawing.Size(200, 32)
        Me.dtpNasc.TabIndex = 7
        '
        'lblDataNasc
        '
        Me.lblDataNasc.AutoSize = True
        Me.lblDataNasc.BackColor = System.Drawing.Color.Transparent
        Me.lblDataNasc.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.lblDataNasc.Location = New System.Drawing.Point(21, 164)
        Me.lblDataNasc.Name = "lblDataNasc"
        Me.lblDataNasc.Size = New System.Drawing.Size(202, 23)
        Me.lblDataNasc.TabIndex = 6
        Me.lblDataNasc.Text = "Data de Nascimento"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirm.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.lblConfirm.Location = New System.Drawing.Point(320, 59)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(178, 23)
        Me.lblConfirm.TabIndex = 4
        Me.lblConfirm.Text = "Confirme a senha"
        '
        'lblNova
        '
        Me.lblNova.AutoSize = True
        Me.lblNova.BackColor = System.Drawing.Color.Transparent
        Me.lblNova.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.lblNova.Location = New System.Drawing.Point(21, 59)
        Me.lblNova.Name = "lblNova"
        Me.lblNova.Size = New System.Drawing.Size(121, 23)
        Me.lblNova.TabIndex = 3
        Me.lblNova.Text = "Nova senha"
        '
        'txtSenha
        '
        Me.txtSenha.Alterado = False
        Me.txtSenha.BackColor = System.Drawing.Color.White
        Me.txtSenha.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.txtSenha.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.txtSenha.Location = New System.Drawing.Point(25, 85)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtSenha.Size = New System.Drawing.Size(271, 30)
        Me.txtSenha.SuperMascara = ""
        Me.txtSenha.SuperObrigatorio = False
        Me.txtSenha.SuperTravaErrors = False
        Me.txtSenha.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSenha.SuperTxtObrigatorio = ""
        Me.txtSenha.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtSenha.TabIndex = 0
        '
        'txtSenhaConfirm
        '
        Me.txtSenhaConfirm.Alterado = False
        Me.txtSenhaConfirm.BackColor = System.Drawing.Color.White
        Me.txtSenhaConfirm.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.txtSenhaConfirm.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.txtSenhaConfirm.Location = New System.Drawing.Point(324, 85)
        Me.txtSenhaConfirm.Name = "txtSenhaConfirm"
        Me.txtSenhaConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtSenhaConfirm.Size = New System.Drawing.Size(271, 30)
        Me.txtSenhaConfirm.SuperMascara = ""
        Me.txtSenhaConfirm.SuperObrigatorio = False
        Me.txtSenhaConfirm.SuperTravaErrors = False
        Me.txtSenhaConfirm.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSenhaConfirm.SuperTxtObrigatorio = ""
        Me.txtSenhaConfirm.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtSenhaConfirm.TabIndex = 1
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRecuperar.BackColor = System.Drawing.Color.DarkGray
        Me.btnRecuperar.FlatAppearance.BorderSize = 0
        Me.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecuperar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnRecuperar.ForeColor = System.Drawing.Color.White
        Me.btnRecuperar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconPago
        Me.btnRecuperar.Location = New System.Drawing.Point(278, 378)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(245, 42)
        Me.btnRecuperar.TabIndex = 4
        Me.btnRecuperar.Text = "  &Recuperar"
        Me.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecuperar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecuperar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(769, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(66, 48)
        Me.btnFechar.TabIndex = 5
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Alterado = False
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.txtUsuario.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.txtUsuario.Location = New System.Drawing.Point(278, 85)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(379, 30)
        Me.txtUsuario.SuperMascara = ""
        Me.txtUsuario.SuperObrigatorio = False
        Me.txtUsuario.SuperTravaErrors = False
        Me.txtUsuario.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtUsuario.SuperTxtObrigatorio = ""
        Me.txtUsuario.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtUsuario.TabIndex = 5
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.lblUsuario.Location = New System.Drawing.Point(175, 92)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(83, 23)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "Usuário"
        '
        'frmRecuperacaoSenha
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(835, 471)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.gbDados)
        Me.Controls.Add(Me.ssBaixo)
        Me.Controls.Add(Me.ssCima)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecuperacaoSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmRecuperacaoSenha"
        Me.ssCima.ResumeLayout(False)
        Me.ssCima.PerformLayout()
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ssCima As StatusStrip
    Friend WithEvents ssBaixo As StatusStrip
    Friend WithEvents gbDados As GroupBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblConfirm As Label
    Friend WithEvents lblNova As Label
    Friend WithEvents txtSenha As GFT.Util.SuperTextBox
    Friend WithEvents txtSenhaConfirm As GFT.Util.SuperTextBox
    Friend WithEvents btnRecuperar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents txtUsuario As GFT.Util.SuperTextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents dtpNasc As DateTimePicker
    Friend WithEvents lblDataNasc As Label
    Friend WithEvents lblDataInfo As Label
    Friend WithEvents lblConfirmInfo As Label
    Friend WithEvents lblSenhaInfo As Label
    Friend WithEvents LetreiroRecupera As GFT.Util.SuperLetreiro
End Class
