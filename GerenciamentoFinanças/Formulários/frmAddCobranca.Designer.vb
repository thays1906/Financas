<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCobranca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCobranca))
        Me.tabCtrlNovaCobranca = New System.Windows.Forms.TabControl()
        Me.tabNovaCobranca = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.SuperLetreiro1 = New GFT.Util.SuperLetreiro()
        Me.dtregistro = New System.Windows.Forms.DateTimePicker()
        Me.txtNome = New GFT.Util.SuperTextBox()
        Me.cbStatus = New GFT.Util.SuperComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtValor = New GFT.Util.SuperTextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.cbConta = New GFT.Util.SuperComboBox()
        Me.tabCtrlNovaCobranca.SuspendLayout()
        Me.tabNovaCobranca.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlNovaCobranca
        '
        Me.tabCtrlNovaCobranca.Controls.Add(Me.tabNovaCobranca)
        Me.tabCtrlNovaCobranca.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlNovaCobranca.Location = New System.Drawing.Point(49, 35)
        Me.tabCtrlNovaCobranca.Name = "tabCtrlNovaCobranca"
        Me.tabCtrlNovaCobranca.Padding = New System.Drawing.Point(100, 6)
        Me.tabCtrlNovaCobranca.SelectedIndex = 0
        Me.tabCtrlNovaCobranca.Size = New System.Drawing.Size(583, 379)
        Me.tabCtrlNovaCobranca.TabIndex = 0
        '
        'tabNovaCobranca
        '
        Me.tabNovaCobranca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabNovaCobranca.Controls.Add(Me.SuperLetreiro1)
        Me.tabNovaCobranca.Controls.Add(Me.GroupBox1)
        Me.tabNovaCobranca.Location = New System.Drawing.Point(4, 33)
        Me.tabNovaCobranca.Name = "tabNovaCobranca"
        Me.tabNovaCobranca.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNovaCobranca.Size = New System.Drawing.Size(575, 342)
        Me.tabNovaCobranca.TabIndex = 0
        Me.tabNovaCobranca.Text = "Nova Cobrança"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblConta)
        Me.GroupBox1.Controls.Add(Me.cbConta)
        Me.GroupBox1.Controls.Add(Me.lblData)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.lblNome)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.cbStatus)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.dtregistro)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(27, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(230, 435)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 42)
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
        Me.btnFechar.Location = New System.Drawing.Point(624, -2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(56, 46)
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'SuperLetreiro1
        '
        Me.SuperLetreiro1.CorSombraTexto = System.Drawing.Color.White
        Me.SuperLetreiro1.Location = New System.Drawing.Point(44, 296)
        Me.SuperLetreiro1.Name = "SuperLetreiro1"
        Me.SuperLetreiro1.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
        Me.SuperLetreiro1.Size = New System.Drawing.Size(487, 28)
        Me.SuperLetreiro1.TabIndex = 1
        Me.SuperLetreiro1.TextoLetreiro = "Se você fez empréstimo para alguém, faça o lançamento para o sistema te lembrar!"
        Me.SuperLetreiro1.VelocidadeRolagem = 1
        '
        'dtregistro
        '
        Me.dtregistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtregistro.Location = New System.Drawing.Point(16, 70)
        Me.dtregistro.Name = "dtregistro"
        Me.dtregistro.Size = New System.Drawing.Size(158, 27)
        Me.dtregistro.TabIndex = 0
        '
        'txtNome
        '
        Me.txtNome.Alterado = False
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(16, 145)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(294, 27)
        Me.txtNome.SuperMascara = ""
        Me.txtNome.SuperObrigatorio = False
        Me.txtNome.SuperTravaErrors = False
        Me.txtNome.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNome.SuperTxtObrigatorio = ""
        Me.txtNome.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNome.TabIndex = 2
        '
        'cbStatus
        '
        Me.cbStatus.Alterado = False
        Me.cbStatus.CorFundo = System.Drawing.Color.White
        Me.cbStatus.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbStatus.CorTexto = System.Drawing.Color.Black
        Me.cbStatus.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(334, 73)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(153, 26)
        Me.cbStatus.SuperObrigatorio = False
        Me.cbStatus.SuperTxtObrigatorio = ""
        Me.cbStatus.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(331, 52)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 18)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Status:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(13, 124)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(147, 18)
        Me.lblNome.TabIndex = 4
        Me.lblNome.Text = "Nome (devedor):"
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(316, 145)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(171, 27)
        Me.txtValor.SuperMascara = ""
        Me.txtValor.SuperObrigatorio = False
        Me.txtValor.SuperTravaErrors = False
        Me.txtValor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor.SuperTxtObrigatorio = ""
        Me.txtValor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor.TabIndex = 3
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(313, 124)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(56, 18)
        Me.lblValor.TabIndex = 6
        Me.lblValor.Text = "Valor:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(13, 49)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(54, 18)
        Me.lblData.TabIndex = 7
        Me.lblData.Text = "Data:"
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(14, 190)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(63, 18)
        Me.lblConta.TabIndex = 9
        Me.lblConta.Text = "Conta:"
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.CorFundo = System.Drawing.Color.White
        Me.cbConta.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbConta.CorTexto = System.Drawing.Color.Black
        Me.cbConta.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.Location = New System.Drawing.Point(16, 211)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(230, 26)
        Me.cbConta.SuperObrigatorio = False
        Me.cbConta.SuperTxtObrigatorio = ""
        Me.cbConta.TabIndex = 4
        '
        'frmAddCobranca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 507)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.tabCtrlNovaCobranca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddCobranca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.tabCtrlNovaCobranca.ResumeLayout(False)
        Me.tabNovaCobranca.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlNovaCobranca As TabControl
    Friend WithEvents tabNovaCobranca As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents SuperLetreiro1 As GFT.Util.SuperLetreiro
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
End Class
