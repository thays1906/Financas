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
        Me.pnlNovaCobranca = New System.Windows.Forms.Panel()
        Me.lblContaAviso = New System.Windows.Forms.Label()
        Me.lblStatusAviso = New System.Windows.Forms.Label()
        Me.lblDevedorAviso = New System.Windows.Forms.Label()
        Me.lblValorAviso = New System.Windows.Forms.Label()
        Me.gbFrequencia = New System.Windows.Forms.GroupBox()
        Me.cbfrquencia = New GFT.Util.SuperComboBox()
        Me.rbFrequente = New System.Windows.Forms.RadioButton()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.dtLembrete = New System.Windows.Forms.DateTimePicker()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.picBanco = New System.Windows.Forms.PictureBox()
        Me.chkLembrete = New System.Windows.Forms.CheckBox()
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
        Me.letreiroCobranca = New GFT.Util.SuperLetreiro()
        Me.ImgNewCobr = New System.Windows.Forms.ImageList(Me.components)
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.tabCtrlNovaCobranca.SuspendLayout()
        Me.tabNovaCobranca.SuspendLayout()
        Me.pnlNovaCobranca.SuspendLayout()
        Me.gbFrequencia.SuspendLayout()
        Me.gbData.SuspendLayout()
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
        Me.tabNovaCobranca.Controls.Add(Me.pnlNovaCobranca)
        Me.tabNovaCobranca.Controls.Add(Me.letreiroCobranca)
        Me.tabNovaCobranca.ImageIndex = 1
        Me.tabNovaCobranca.Location = New System.Drawing.Point(4, 69)
        Me.tabNovaCobranca.Margin = New System.Windows.Forms.Padding(4)
        Me.tabNovaCobranca.Name = "tabNovaCobranca"
        Me.tabNovaCobranca.Padding = New System.Windows.Forms.Padding(4)
        Me.tabNovaCobranca.Size = New System.Drawing.Size(769, 402)
        Me.tabNovaCobranca.TabIndex = 0
        Me.tabNovaCobranca.Text = "Nova Cobrança"
        '
        'pnlNovaCobranca
        '
        Me.pnlNovaCobranca.AutoScroll = True
        Me.pnlNovaCobranca.AutoScrollMargin = New System.Drawing.Size(0, 15)
        Me.pnlNovaCobranca.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNovaCobranca.Controls.Add(Me.lblContaAviso)
        Me.pnlNovaCobranca.Controls.Add(Me.lblStatusAviso)
        Me.pnlNovaCobranca.Controls.Add(Me.lblDevedorAviso)
        Me.pnlNovaCobranca.Controls.Add(Me.lblValorAviso)
        Me.pnlNovaCobranca.Controls.Add(Me.gbFrequencia)
        Me.pnlNovaCobranca.Controls.Add(Me.gbData)
        Me.pnlNovaCobranca.Controls.Add(Me.picBanco)
        Me.pnlNovaCobranca.Controls.Add(Me.chkLembrete)
        Me.pnlNovaCobranca.Controls.Add(Me.lblConta)
        Me.pnlNovaCobranca.Controls.Add(Me.cbConta)
        Me.pnlNovaCobranca.Controls.Add(Me.lblData)
        Me.pnlNovaCobranca.Controls.Add(Me.lblValor)
        Me.pnlNovaCobranca.Controls.Add(Me.txtValor)
        Me.pnlNovaCobranca.Controls.Add(Me.lblNome)
        Me.pnlNovaCobranca.Controls.Add(Me.lblStatus)
        Me.pnlNovaCobranca.Controls.Add(Me.cbStatus)
        Me.pnlNovaCobranca.Controls.Add(Me.txtNome)
        Me.pnlNovaCobranca.Controls.Add(Me.dtregistro)
        Me.pnlNovaCobranca.Location = New System.Drawing.Point(34, 30)
        Me.pnlNovaCobranca.Name = "pnlNovaCobranca"
        Me.pnlNovaCobranca.Size = New System.Drawing.Size(701, 334)
        Me.pnlNovaCobranca.TabIndex = 2
        '
        'lblContaAviso
        '
        Me.lblContaAviso.AutoEllipsis = True
        Me.lblContaAviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblContaAviso.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblContaAviso.ForeColor = System.Drawing.Color.Red
        Me.lblContaAviso.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblContaAviso.Location = New System.Drawing.Point(6, 262)
        Me.lblContaAviso.Name = "lblContaAviso"
        Me.lblContaAviso.Size = New System.Drawing.Size(308, 55)
        Me.lblContaAviso.TabIndex = 29
        Me.lblContaAviso.Text = "Label1"
        Me.lblContaAviso.Visible = False
        '
        'lblStatusAviso
        '
        Me.lblStatusAviso.AutoSize = True
        Me.lblStatusAviso.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatusAviso.ForeColor = System.Drawing.Color.Red
        Me.lblStatusAviso.Location = New System.Drawing.Point(437, 65)
        Me.lblStatusAviso.Name = "lblStatusAviso"
        Me.lblStatusAviso.Size = New System.Drawing.Size(59, 17)
        Me.lblStatusAviso.TabIndex = 28
        Me.lblStatusAviso.Text = "Label1"
        Me.lblStatusAviso.Visible = False
        '
        'lblDevedorAviso
        '
        Me.lblDevedorAviso.AutoSize = True
        Me.lblDevedorAviso.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDevedorAviso.ForeColor = System.Drawing.Color.Red
        Me.lblDevedorAviso.Location = New System.Drawing.Point(6, 168)
        Me.lblDevedorAviso.Name = "lblDevedorAviso"
        Me.lblDevedorAviso.Size = New System.Drawing.Size(59, 17)
        Me.lblDevedorAviso.TabIndex = 27
        Me.lblDevedorAviso.Text = "Label1"
        Me.lblDevedorAviso.Visible = False
        '
        'lblValorAviso
        '
        Me.lblValorAviso.AutoSize = True
        Me.lblValorAviso.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblValorAviso.ForeColor = System.Drawing.Color.Red
        Me.lblValorAviso.Location = New System.Drawing.Point(437, 168)
        Me.lblValorAviso.Name = "lblValorAviso"
        Me.lblValorAviso.Size = New System.Drawing.Size(59, 17)
        Me.lblValorAviso.TabIndex = 26
        Me.lblValorAviso.Text = "Label1"
        Me.lblValorAviso.Visible = False
        '
        'gbFrequencia
        '
        Me.gbFrequencia.Controls.Add(Me.cbfrquencia)
        Me.gbFrequencia.Controls.Add(Me.rbFrequente)
        Me.gbFrequencia.Location = New System.Drawing.Point(401, 244)
        Me.gbFrequencia.Name = "gbFrequencia"
        Me.gbFrequencia.Size = New System.Drawing.Size(279, 100)
        Me.gbFrequencia.TabIndex = 25
        Me.gbFrequencia.TabStop = False
        Me.gbFrequencia.Visible = False
        '
        'cbfrquencia
        '
        Me.cbfrquencia.Alterado = False
        Me.cbfrquencia.CorFundo = System.Drawing.Color.White
        Me.cbfrquencia.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbfrquencia.CorTexto = System.Drawing.Color.Black
        Me.cbfrquencia.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbfrquencia.Enabled = False
        Me.cbfrquencia.FormattingEnabled = True
        Me.cbfrquencia.Location = New System.Drawing.Point(6, 57)
        Me.cbfrquencia.Name = "cbfrquencia"
        Me.cbfrquencia.Size = New System.Drawing.Size(202, 26)
        Me.cbfrquencia.SuperObrigatorio = False
        Me.cbfrquencia.SuperTxtObrigatorio = ""
        Me.cbfrquencia.TabIndex = 24
        '
        'rbFrequente
        '
        Me.rbFrequente.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.rbFrequente.FlatAppearance.BorderSize = 20
        Me.rbFrequente.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rbFrequente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.rbFrequente.Image = CType(resources.GetObject("rbFrequente.Image"), System.Drawing.Image)
        Me.rbFrequente.Location = New System.Drawing.Point(6, 22)
        Me.rbFrequente.Name = "rbFrequente"
        Me.rbFrequente.Size = New System.Drawing.Size(132, 26)
        Me.rbFrequente.TabIndex = 23
        Me.rbFrequente.Text = "Frequente"
        Me.rbFrequente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbFrequente.UseCompatibleTextRendering = True
        Me.rbFrequente.UseVisualStyleBackColor = True
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.dtLembrete)
        Me.gbData.Controls.Add(Me.rbData)
        Me.gbData.Location = New System.Drawing.Point(401, 331)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(279, 111)
        Me.gbData.TabIndex = 24
        Me.gbData.TabStop = False
        Me.gbData.Visible = False
        '
        'dtLembrete
        '
        Me.dtLembrete.Enabled = False
        Me.dtLembrete.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtLembrete.Location = New System.Drawing.Point(6, 73)
        Me.dtLembrete.Name = "dtLembrete"
        Me.dtLembrete.Size = New System.Drawing.Size(200, 27)
        Me.dtLembrete.TabIndex = 0
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(6, 31)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(222, 22)
        Me.rbData.TabIndex = 22
        Me.rbData.TabStop = True
        Me.rbData.Text = "Em uma data específica"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'picBanco
        '
        Me.picBanco.Location = New System.Drawing.Point(321, 217)
        Me.picBanco.Name = "picBanco"
        Me.picBanco.Size = New System.Drawing.Size(48, 48)
        Me.picBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBanco.TabIndex = 21
        Me.picBanco.TabStop = False
        '
        'chkLembrete
        '
        Me.chkLembrete.AutoSize = True
        Me.chkLembrete.Location = New System.Drawing.Point(402, 217)
        Me.chkLembrete.Name = "chkLembrete"
        Me.chkLembrete.Size = New System.Drawing.Size(189, 22)
        Me.chkLembrete.TabIndex = 20
        Me.chkLembrete.Text = "Quero ser lembrado"
        Me.chkLembrete.UseVisualStyleBackColor = True
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(4, 203)
        Me.lblConta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(142, 18)
        Me.lblConta.TabIndex = 19
        Me.lblConta.Text = "Conta Báncaria*"
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.CorFundo = System.Drawing.Color.White
        Me.cbConta.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbConta.CorTexto = System.Drawing.Color.Black
        Me.cbConta.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.Location = New System.Drawing.Point(9, 232)
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
        Me.lblData.Location = New System.Drawing.Point(4, 6)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(54, 18)
        Me.lblData.TabIndex = 18
        Me.lblData.Text = "Data:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(435, 108)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(162, 18)
        Me.lblValor.TabIndex = 17
        Me.lblValor.Text = "Valor emprestado*"
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(440, 137)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(227, 27)
        Me.txtValor.SuperMascara = ""
        Me.txtValor.SuperObrigatorio = True
        Me.txtValor.SuperTravaErrors = False
        Me.txtValor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor.SuperTxtObrigatorio = ""
        Me.txtValor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor.TabIndex = 13
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(6, 115)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(183, 18)
        Me.lblNome.TabIndex = 16
        Me.lblNome.Text = "Quem está devendo*"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(435, 6)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(71, 18)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Status*"
        '
        'cbStatus
        '
        Me.cbStatus.Alterado = False
        Me.cbStatus.CorFundo = System.Drawing.Color.White
        Me.cbStatus.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbStatus.CorTexto = System.Drawing.Color.Black
        Me.cbStatus.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(440, 35)
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
        Me.txtNome.Location = New System.Drawing.Point(9, 137)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(391, 27)
        Me.txtNome.SuperMascara = ""
        Me.txtNome.SuperObrigatorio = True
        Me.txtNome.SuperTravaErrors = False
        Me.txtNome.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNome.SuperTxtObrigatorio = ""
        Me.txtNome.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNome.TabIndex = 12
        '
        'dtregistro
        '
        Me.dtregistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtregistro.Location = New System.Drawing.Point(9, 36)
        Me.dtregistro.Margin = New System.Windows.Forms.Padding(4)
        Me.dtregistro.Name = "dtregistro"
        Me.dtregistro.Size = New System.Drawing.Size(209, 27)
        Me.dtregistro.TabIndex = 10
        '
        'letreiroCobranca
        '
        Me.letreiroCobranca.CorSombraTexto = System.Drawing.Color.White
        Me.letreiroCobranca.Location = New System.Drawing.Point(39, 361)
        Me.letreiroCobranca.Margin = New System.Windows.Forms.Padding(4)
        Me.letreiroCobranca.Name = "letreiroCobranca"
        Me.letreiroCobranca.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
        Me.letreiroCobranca.Size = New System.Drawing.Size(696, 34)
        Me.letreiroCobranca.TabIndex = 1
        Me.letreiroCobranca.TextoLetreiro = "Emprestou aquela grana para um amigo? Sem problemas, a gente te lembra :)"
        Me.letreiroCobranca.VelocidadeRolagem = 1
        '
        'ImgNewCobr
        '
        Me.ImgNewCobr.ImageStream = CType(resources.GetObject("ImgNewCobr.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgNewCobr.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgNewCobr.Images.SetKeyName(0, "iconCobr.png")
        Me.ImgNewCobr.Images.SetKeyName(1, "iconeCObr.png")
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
        'frmNovaCobranca
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(905, 624)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.tabCtrlNovaCobranca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNovaCobranca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.tabCtrlNovaCobranca.ResumeLayout(False)
        Me.tabNovaCobranca.ResumeLayout(False)
        Me.pnlNovaCobranca.ResumeLayout(False)
        Me.pnlNovaCobranca.PerformLayout()
        Me.gbFrequencia.ResumeLayout(False)
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        CType(Me.picBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlNovaCobranca As TabControl
    Friend WithEvents tabNovaCobranca As TabPage
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents letreiroCobranca As GFT.Util.SuperLetreiro
    Friend WithEvents ImgNewCobr As ImageList
    Friend WithEvents pnlNovaCobranca As Panel
    Friend WithEvents chkLembrete As CheckBox
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
    Friend WithEvents rbFrequente As RadioButton
    Friend WithEvents rbData As RadioButton
    Friend WithEvents gbFrequencia As GroupBox
    Friend WithEvents cbfrquencia As GFT.Util.SuperComboBox
    Friend WithEvents gbData As GroupBox
    Friend WithEvents dtLembrete As DateTimePicker
    Friend WithEvents lblValorAviso As Label
    Friend WithEvents lblDevedorAviso As Label
    Friend WithEvents lblStatusAviso As Label
    Friend WithEvents lblContaAviso As Label
End Class
