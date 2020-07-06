<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtUsuario = New GFT.Util.SuperTextBox()
        Me.txtSenha = New GFT.Util.SuperTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSenhaInfo = New System.Windows.Forms.Label()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.btnAcessar = New System.Windows.Forms.Button()
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(17, 48)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(79, 22)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuário:"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(17, 110)
        Me.lblSenha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(69, 22)
        Me.lblSenha.TabIndex = 1
        Me.lblSenha.Text = "Senha:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Alterado = False
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(113, 41)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(237, 29)
        Me.txtUsuario.SuperMascara = ""
        Me.txtUsuario.SuperObrigatorio = False
        Me.txtUsuario.SuperTravaErrors = False
        Me.txtUsuario.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtUsuario.SuperTxtObrigatorio = ""
        Me.txtUsuario.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtUsuario.TabIndex = 2
        '
        'txtSenha
        '
        Me.txtSenha.Alterado = False
        Me.txtSenha.BackColor = System.Drawing.Color.White
        Me.txtSenha.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtSenha.Location = New System.Drawing.Point(113, 107)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(237, 29)
        Me.txtSenha.SuperMascara = ""
        Me.txtSenha.SuperObrigatorio = False
        Me.txtSenha.SuperTravaErrors = False
        Me.txtSenha.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSenha.SuperTxtObrigatorio = ""
        Me.txtSenha.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtSenha.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(553, 51)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 375)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip2.Size = New System.Drawing.Size(553, 22)
        Me.StatusStrip2.SizingGrip = False
        Me.StatusStrip2.TabIndex = 7
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.lblSenhaInfo)
        Me.GroupBox1.Controls.Add(Me.lblUserInfo)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.lblSenha)
        Me.GroupBox1.Controls.Add(Me.txtSenha)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(90, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 162)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'lblSenhaInfo
        '
        Me.lblSenhaInfo.AutoSize = True
        Me.lblSenhaInfo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSenhaInfo.ForeColor = System.Drawing.Color.Red
        Me.lblSenhaInfo.Location = New System.Drawing.Point(85, 131)
        Me.lblSenhaInfo.Name = "lblSenhaInfo"
        Me.lblSenhaInfo.Size = New System.Drawing.Size(0, 18)
        Me.lblSenhaInfo.TabIndex = 5
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserInfo.ForeColor = System.Drawing.Color.Red
        Me.lblUserInfo.Location = New System.Drawing.Point(84, 69)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(0, 18)
        Me.lblUserInfo.TabIndex = 4
        '
        'btnAcessar
        '
        Me.btnAcessar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconLogin32
        Me.btnAcessar.Location = New System.Drawing.Point(165, 313)
        Me.btnAcessar.Name = "btnAcessar"
        Me.btnAcessar.Size = New System.Drawing.Size(203, 42)
        Me.btnAcessar.TabIndex = 4
        Me.btnAcessar.Text = "  &Acessar"
        Me.btnAcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcessar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAcessar.UseVisualStyleBackColor = True
        '
        'StatusStrip3
        '
        Me.StatusStrip3.AutoSize = False
        Me.StatusStrip3.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip3.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2})
        Me.StatusStrip3.Location = New System.Drawing.Point(0, 51)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip3.Size = New System.Drawing.Size(553, 41)
        Me.StatusStrip3.SizingGrip = False
        Me.StatusStrip3.TabIndex = 9
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Image = Global.GerenciamentoFinanças.My.Resources.Resources.LOGO1_2_fw
        Me.ToolStripStatusLabel2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(424, 35)
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(490, 1)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(63, 50)
        Me.btnFechar.TabIndex = 10
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(553, 397)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.StatusStrip3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnAcessar)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acesso ao sistema ::."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip3.ResumeLayout(False)
        Me.StatusStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtUsuario As GFT.Util.SuperTextBox
    Friend WithEvents txtSenha As GFT.Util.SuperTextBox
    Friend WithEvents btnAcessar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSenhaInfo As Label
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents StatusStrip3 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents btnFechar As Button
End Class
