<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNovaCobranca
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovaCobranca))
        Me.tabCtrlNovaCobranca = New System.Windows.Forms.TabControl()
        Me.tabNovaCobranca = New System.Windows.Forms.TabPage()
        Me.pblNovaCobranca = New System.Windows.Forms.Panel()
        Me.picBanco = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.cbConta = New GFT.Util.SuperComboBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValor = New GFT.Util.SuperTextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cbStatus = New GFT.Util.SuperComboBox()
        Me.txtNome = New GFT.Util.SuperTextBox()
        Me.dtregistro = New System.Windows.Forms.DateTimePicker()
        Me.SuperLetreiro1 = New GFT.Util.SuperLetreiro()
        Me.ImgNewCobr = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.tabCtrlNovaCobranca.SuspendLayout()
        Me.tabNovaCobranca.SuspendLayout()
        Me.pblNovaCobranca.SuspendLayout()
        CType(Me.picBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCtrlNovaCobranca
        '
        Me.tabCtrlNovaCobranca.Controls.Add(Me.tabNovaCobranca)
        Me.tabCtrlNovaCobranca.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlNovaCobranca.ImageList = Me.ImgNewCobr
        Me.tabCtrlNovaCobranca.Location = New System.Drawing.Point(65, 43)
        Me.tabCtrlNovaCobranca.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCtrlNovaCobranca.Name = "tabCtrlNovaCobranca"
        Me.tabCtrlNovaCobranca.Padding = New System.Drawing.Point(50, 10)
        Me.tabCtrlNovaCobranca.SelectedIndex = 0
        Me.tabCtrlNovaCobranca.Size = New System.Drawing.Size(777, 475)
        Me.tabCtrlNovaCobranca.TabIndex = 0
        '
        'tabNovaCobranca
        '
        Me.tabNovaCobranca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabNovaCobranca.Controls.Add(Me.pblNovaCobranca)
        Me.tabNovaCobranca.Controls.Add(Me.SuperLetreiro1)
        Me.tabNovaCobranca.ImageIndex = 1
        Me.tabNovaCobranca.Location = New System.Drawing.Point(4, 69)
        Me.tabNovaCobranca.Margin = New System.Windows.Forms.Padding(4)
        Me.tabNovaCobranca.Name = "tabNovaCobranca"
        Me.tabNovaCobranca.Padding = New System.Windows.Forms.Padding(4)
        Me.tabNovaCobranca.Size = New System.Drawing.Size(769, 402)
        Me.tabNovaCobranca.TabIndex = 0
        Me.tabNovaCobranca.Text = "Nova Cobrança"
        '
        'pblNovaCobranca
        '
        Me.pblNovaCobranca.AutoScroll = True
        Me.pblNovaCobranca.BackColor = System.Drawing.SystemColors.Control
        Me.pblNovaCobranca.Controls.Add(Me.picBanco)
        Me.pblNovaCobranca.Controls.Add(Me.CheckBox1)
        Me.pblNovaCobranca.Controls.Add(Me.lblConta)
        Me.pblNovaCobranca.Controls.Add(Me.cbConta)
        Me.pblNovaCobranca.Controls.Add(Me.lblData)
        Me.pblNovaCobranca.Controls.Add(Me.lblValor)
        Me.pblNovaCobranca.Controls.Add(Me.txtValor)
        Me.pblNovaCobranca.Controls.Add(Me.lblNome)
        Me.pblNovaCobranca.Controls.Add(Me.lblStatus)
        Me.pblNovaCobranca.Controls.Add(Me.cbStatus)
        Me.pblNovaCobranca.Controls.Add(Me.txtNome)
        Me.pblNovaCobranca.Controls.Add(Me.dtregistro)
        Me.pblNovaCobranca.Location = New System.Drawing.Point(50, 25)
        Me.pblNovaCobranca.Name = "pblNovaCobranca"
        Me.pblNovaCobranca.Size = New System.Drawing.Size(677, 323)
        Me.pblNovaCobranca.TabIndex = 2
        '
        'picBanco
        '
        Me.picBanco.Location = New System.Drawing.Point(331, 216)
        Me.picBanco.Name = "picBanco"
        Me.picBanco.Size = New System.Drawing.Size(48, 48)
        Me.picBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBanco.TabIndex = 21
        Me.picBanco.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(418, 205)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(189, 22)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Quero ser lembrado"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(16, 206)
        Me.lblConta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(139, 18)
        Me.lblConta.TabIndex = 19
        Me.lblConta.Text = "Conta Báncaria:"
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.CorFundo = System.Drawing.Color.White
        Me.cbConta.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbConta.CorTexto = System.Drawing.Color.Black
        Me.cbConta.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.Location = New System.Drawing.Point(19, 228)
        Me.cbConta.Margin = New System.Windows.Forms.Padding(4)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(305, 26)
        Me.cbConta.SuperObrigatorio = True
        Me.cbConta.SuperTxtObrigatorio = "Conta Báncaria"
        Me.cbConta.TabIndex = 15
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(16, 17)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(54, 18)
        Me.lblData.TabIndex = 18
        Me.lblData.Text = "Data:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(413, 118)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(56, 18)
        Me.lblValor.TabIndex = 17
        Me.lblValor.Text = "Valor:"
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(418, 147)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(227, 27)
        Me.txtValor.SuperMascara = ""
        Me.txtValor.SuperObrigatorio = False
        Me.txtValor.SuperTravaErrors = False
        Me.txtValor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor.SuperTxtObrigatorio = ""
        Me.txtValor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor.TabIndex = 13
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(16, 118)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(147, 18)
        Me.lblNome.TabIndex = 16
        Me.lblNome.Text = "Nome (devedor):"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(413, 17)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 18)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Status:"
        '
        'cbStatus
        '
        Me.cbStatus.Alterado = False
        Me.cbStatus.CorFundo = System.Drawing.Color.White
        Me.cbStatus.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbStatus.CorTexto = System.Drawing.Color.Black
        Me.cbStatus.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(418, 46)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(227, 26)
        Me.cbStatus.SuperObrigatorio = True
        Me.cbStatus.SuperTxtObrigatorio = "Status"
        Me.cbStatus.TabIndex = 11
        '
        'txtNome
        '
        Me.txtNome.Alterado = False
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(19, 147)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(391, 27)
        Me.txtNome.SuperMascara = ""
        Me.txtNome.SuperObrigatorio = False
        Me.txtNome.SuperTravaErrors = False
        Me.txtNome.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNome.SuperTxtObrigatorio = ""
        Me.txtNome.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNome.TabIndex = 12
        '
        'dtregistro
        '
        Me.dtregistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtregistro.Location = New System.Drawing.Point(19, 46)
        Me.dtregistro.Margin = New System.Windows.Forms.Padding(4)
        Me.dtregistro.Name = "dtregistro"
        Me.dtregistro.Size = New System.Drawing.Size(209, 27)
        Me.dtregistro.TabIndex = 10
        '
        'SuperLetreiro1
        '
        Me.SuperLetreiro1.CorSombraTexto = System.Drawing.Color.White
        Me.SuperLetreiro1.Location = New System.Drawing.Point(405, 360)
        Me.SuperLetreiro1.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperLetreiro1.Name = "SuperLetreiro1"
        Me.SuperLetreiro1.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
        Me.SuperLetreiro1.Size = New System.Drawing.Size(312, 34)
        Me.SuperLetreiro1.TabIndex = 1
        Me.SuperLetreiro1.TextoLetreiro = "Se você fez empréstimo para alguém, faça o lançamento para o sistema te lembrar!"
        Me.SuperLetreiro1.VelocidadeRolagem = 1
        '
        'ImgNewCobr
        '
        Me.ImgNewCobr.ImageStream = CType(resources.GetObject("ImgNewCobr.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgNewCobr.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgNewCobr.Images.SetKeyName(0, "iconCobr.png")
        Me.ImgNewCobr.Images.SetKeyName(1, "iconeCObr.png")
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(307, 535)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(271, 52)
        Me.btnSalvar.TabIndex = 5
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(832, -2)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 57)
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmAddCobranca
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(905, 624)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.tabCtrlNovaCobranca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddCobranca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.tabCtrlNovaCobranca.ResumeLayout(False)
        Me.tabNovaCobranca.ResumeLayout(False)
        Me.pblNovaCobranca.ResumeLayout(False)
        Me.pblNovaCobranca.PerformLayout()
        CType(Me.picBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlNovaCobranca As TabControl
    Friend WithEvents tabNovaCobranca As TabPage
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents SuperLetreiro1 As GFT.Util.SuperLetreiro
    Friend WithEvents ImgNewCobr As ImageList
    Friend WithEvents pblNovaCobranca As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblConta As Label
    Friend WithEvents cbConta As GFT.Util.SuperComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents txtValor As GFT.Util.SuperTextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbStatus As GFT.Util.SuperComboBox
    Friend WithEvents txtNome As GFT.Util.SuperTextBox
    Friend WithEvents dtregistro As DateTimePicker
    Friend WithEvents picBanco As PictureBox
End Class
