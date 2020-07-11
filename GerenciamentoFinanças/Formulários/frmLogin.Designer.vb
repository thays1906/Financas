<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtUsuario = New GFT.Util.SuperTextBox()
        Me.txtSenha = New GFT.Util.SuperTextBox()
        Me.ssCima = New System.Windows.Forms.StatusStrip()
        Me.ssBaixo = New System.Windows.Forms.StatusStrip()
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.lblSenhaInfo = New System.Windows.Forms.Label()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.llEsqueceuSenha = New System.Windows.Forms.LinkLabel()
        Me.btnPrimeiroAcesso = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAcessar = New System.Windows.Forms.Button()
        Me.gbDados.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(135, 52)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(98, 25)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuário:"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(148, 115)
        Me.lblSenha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(85, 25)
        Me.lblSenha.TabIndex = 1
        Me.lblSenha.Text = "Senha:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Alterado = False
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.txtUsuario.Location = New System.Drawing.Point(241, 45)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(237, 32)
        Me.txtUsuario.SuperMascara = ""
        Me.txtUsuario.SuperObrigatorio = True
        Me.txtUsuario.SuperTravaErrors = False
        Me.txtUsuario.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtUsuario.SuperTxtObrigatorio = ""
        Me.txtUsuario.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtUsuario.TabIndex = 0
        '
        'txtSenha
        '
        Me.txtSenha.Alterado = False
        Me.txtSenha.BackColor = System.Drawing.Color.White
        Me.txtSenha.CorFundoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.txtSenha.Location = New System.Drawing.Point(241, 108)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtSenha.Size = New System.Drawing.Size(237, 32)
        Me.txtSenha.SuperMascara = ""
        Me.txtSenha.SuperObrigatorio = False
        Me.txtSenha.SuperTravaErrors = False
        Me.txtSenha.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSenha.SuperTxtObrigatorio = ""
        Me.txtSenha.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtSenha.TabIndex = 1
        '
        'ssCima
        '
        Me.ssCima.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ssCima.AutoSize = False
        Me.ssCima.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ssCima.Dock = System.Windows.Forms.DockStyle.None
        Me.ssCima.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssCima.Location = New System.Drawing.Point(0, -1)
        Me.ssCima.Name = "ssCima"
        Me.ssCima.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.ssCima.Size = New System.Drawing.Size(792, 51)
        Me.ssCima.SizingGrip = False
        Me.ssCima.TabIndex = 6
        Me.ssCima.Text = "StatusStrip1"
        '
        'ssBaixo
        '
        Me.ssBaixo.AutoSize = False
        Me.ssBaixo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ssBaixo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssBaixo.Location = New System.Drawing.Point(0, 490)
        Me.ssBaixo.Name = "ssBaixo"
        Me.ssBaixo.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.ssBaixo.Size = New System.Drawing.Size(792, 29)
        Me.ssBaixo.SizingGrip = False
        Me.ssBaixo.TabIndex = 7
        Me.ssBaixo.Text = "StatusStrip2"
        '
        'gbDados
        '
        Me.gbDados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbDados.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.gbDados.Controls.Add(Me.PictureBox2)
        Me.gbDados.Controls.Add(Me.lblSenhaInfo)
        Me.gbDados.Controls.Add(Me.llEsqueceuSenha)
        Me.gbDados.Controls.Add(Me.lblUserInfo)
        Me.gbDados.Controls.Add(Me.txtUsuario)
        Me.gbDados.Controls.Add(Me.lblUsuario)
        Me.gbDados.Controls.Add(Me.lblSenha)
        Me.gbDados.Controls.Add(Me.txtSenha)
        Me.gbDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbDados.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.gbDados.ForeColor = System.Drawing.Color.Black
        Me.gbDados.Location = New System.Drawing.Point(142, 129)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(508, 210)
        Me.gbDados.TabIndex = 8
        Me.gbDados.TabStop = False
        Me.gbDados.Text = "Login"
        '
        'lblSenhaInfo
        '
        Me.lblSenhaInfo.AutoSize = True
        Me.lblSenhaInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblSenhaInfo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSenhaInfo.ForeColor = System.Drawing.Color.Red
        Me.lblSenhaInfo.Location = New System.Drawing.Point(240, 140)
        Me.lblSenhaInfo.Name = "lblSenhaInfo"
        Me.lblSenhaInfo.Size = New System.Drawing.Size(0, 18)
        Me.lblSenhaInfo.TabIndex = 5
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblUserInfo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserInfo.ForeColor = System.Drawing.Color.Red
        Me.lblUserInfo.Location = New System.Drawing.Point(240, 80)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(0, 18)
        Me.lblUserInfo.TabIndex = 4
        '
        'llEsqueceuSenha
        '
        Me.llEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue
        Me.llEsqueceuSenha.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.llEsqueceuSenha.AutoSize = True
        Me.llEsqueceuSenha.BackColor = System.Drawing.Color.Transparent
        Me.llEsqueceuSenha.LinkColor = System.Drawing.Color.DimGray
        Me.llEsqueceuSenha.Location = New System.Drawing.Point(298, 182)
        Me.llEsqueceuSenha.Name = "llEsqueceuSenha"
        Me.llEsqueceuSenha.Size = New System.Drawing.Size(204, 25)
        Me.llEsqueceuSenha.TabIndex = 3
        Me.llEsqueceuSenha.TabStop = True
        Me.llEsqueceuSenha.Text = "Esqueceu a senha?"
        Me.llEsqueceuSenha.VisitedLinkColor = System.Drawing.Color.Black
        '
        'btnPrimeiroAcesso
        '
        Me.btnPrimeiroAcesso.BackColor = System.Drawing.Color.DimGray
        Me.btnPrimeiroAcesso.FlatAppearance.BorderSize = 0
        Me.btnPrimeiroAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimeiroAcesso.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.btnPrimeiroAcesso.ForeColor = System.Drawing.Color.White
        Me.btnPrimeiroAcesso.Location = New System.Drawing.Point(265, 435)
        Me.btnPrimeiroAcesso.Name = "btnPrimeiroAcesso"
        Me.btnPrimeiroAcesso.Size = New System.Drawing.Size(245, 42)
        Me.btnPrimeiroAcesso.TabIndex = 5
        Me.btnPrimeiroAcesso.Text = " Primeiro acesso?"
        Me.btnPrimeiroAcesso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrimeiroAcesso.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(779, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(729, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(63, 50)
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconUsuario95x75
        Me.PictureBox2.Location = New System.Drawing.Point(17, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(95, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'btnAcessar
        '
        Me.btnAcessar.BackColor = System.Drawing.Color.DimGray
        Me.btnAcessar.FlatAppearance.BorderSize = 0
        Me.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcessar.ForeColor = System.Drawing.Color.White
        Me.btnAcessar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconLogin32
        Me.btnAcessar.Location = New System.Drawing.Point(265, 359)
        Me.btnAcessar.Name = "btnAcessar"
        Me.btnAcessar.Size = New System.Drawing.Size(245, 42)
        Me.btnAcessar.TabIndex = 4
        Me.btnAcessar.Text = "  &Sign in"
        Me.btnAcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcessar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAcessar.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(792, 519)
        Me.Controls.Add(Me.btnPrimeiroAcesso)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.gbDados)
        Me.Controls.Add(Me.ssBaixo)
        Me.Controls.Add(Me.ssCima)
        Me.Controls.Add(Me.btnAcessar)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acesso ao sistema ::."
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtUsuario As GFT.Util.SuperTextBox
    Friend WithEvents txtSenha As GFT.Util.SuperTextBox
    Friend WithEvents btnAcessar As Button
    Friend WithEvents ssCima As StatusStrip
    Friend WithEvents ssBaixo As StatusStrip
    Friend WithEvents gbDados As GroupBox
    Friend WithEvents lblSenhaInfo As Label
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents llEsqueceuSenha As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPrimeiroAcesso As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
