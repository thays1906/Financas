<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceita))
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnAddReceita = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExporta = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbConsulta = New GFT.Util.SuperTabControl()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.lblTotalReceita = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.txtTotalReceita = New GFT.Util.SuperTextBox()
        Me.cbMes = New GFT.Util.SuperComboBox()
        Me.lblContaFiltro = New System.Windows.Forms.Label()
        Me.cbContaFiltro = New GFT.Util.SuperComboBox()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.gbBotoes.SuspendLayout()
        Me.tbConsulta.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnAddReceita)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnExporta)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBotoes.Location = New System.Drawing.Point(0, 571)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1354, 73)
        Me.gbBotoes.TabIndex = 8
        Me.gbBotoes.TabStop = False
        '
        'btnAddReceita
        '
        Me.btnAddReceita.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddReceita.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnAddReceita.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddReceita1
        Me.btnAddReceita.Location = New System.Drawing.Point(231, 17)
        Me.btnAddReceita.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddReceita.Name = "btnAddReceita"
        Me.btnAddReceita.Size = New System.Drawing.Size(203, 42)
        Me.btnAddReceita.TabIndex = 13
        Me.btnAddReceita.Text = " &Receita"
        Me.btnAddReceita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddReceita.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(11, 17)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(203, 42)
        Me.btnPesquisar.TabIndex = 8
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnEditar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditar
        Me.btnEditar.Location = New System.Drawing.Point(449, 17)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(203, 42)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = " &Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(668, 17)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(203, 42)
        Me.btnExcluir.TabIndex = 10
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1104, 17)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(203, 42)
        Me.btnFechar.TabIndex = 12
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnExporta
        '
        Me.btnExporta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExporta.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnExporta.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcel
        Me.btnExporta.Location = New System.Drawing.Point(887, 17)
        Me.btnExporta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExporta.Name = "btnExporta"
        Me.btnExporta.Size = New System.Drawing.Size(203, 42)
        Me.btnExporta.TabIndex = 11
        Me.btnExporta.Text = " &Exportar"
        Me.btnExporta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExporta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExporta.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "iconReceita.fw.png")
        Me.ImageList1.Images.SetKeyName(1, "iconMOneyGreen.png")
        '
        'tbConsulta
        '
        Me.tbConsulta.Controls.Add(Me.tpPesquisa)
        Me.tbConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbConsulta.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConsulta.ImageList = Me.ImageList1
        Me.tbConsulta.Location = New System.Drawing.Point(0, 0)
        Me.tbConsulta.Name = "tbConsulta"
        Me.tbConsulta.Padding = New System.Drawing.Point(50, 6)
        Me.tbConsulta.SelectedIndex = 0
        Me.tbConsulta.Size = New System.Drawing.Size(1354, 571)
        Me.tbConsulta.TabIndex = 4
        '
        'tpPesquisa
        '
        Me.tpPesquisa.BackColor = System.Drawing.Color.White
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.Controls.Add(Me.lvConsulta)
        Me.tpPesquisa.ImageIndex = 1
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 53)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(5)
        Me.tpPesquisa.Size = New System.Drawing.Size(1346, 514)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Receitas"
        '
        'gbFiltro
        '
        Me.gbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbFiltro.Controls.Add(Me.lblTotalReceita)
        Me.gbFiltro.Controls.Add(Me.lblMes)
        Me.gbFiltro.Controls.Add(Me.txtTotalReceita)
        Me.gbFiltro.Controls.Add(Me.cbMes)
        Me.gbFiltro.Controls.Add(Me.lblContaFiltro)
        Me.gbFiltro.Controls.Add(Me.cbContaFiltro)
        Me.gbFiltro.Location = New System.Drawing.Point(33, 18)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(1282, 97)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'lblTotalReceita
        '
        Me.lblTotalReceita.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalReceita.AutoSize = True
        Me.lblTotalReceita.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalReceita.Location = New System.Drawing.Point(1101, 21)
        Me.lblTotalReceita.Name = "lblTotalReceita"
        Me.lblTotalReceita.Size = New System.Drawing.Size(148, 18)
        Me.lblTotalReceita.TabIndex = 9
        Me.lblTotalReceita.Text = "Total das Receitas:"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(366, 21)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(45, 18)
        Me.lblMes.TabIndex = 12
        Me.lblMes.Text = "Mês:"
        '
        'txtTotalReceita
        '
        Me.txtTotalReceita.Alterado = False
        Me.txtTotalReceita.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalReceita.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotalReceita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalReceita.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtTotalReceita.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalReceita.ForeColor = System.Drawing.Color.Green
        Me.txtTotalReceita.Location = New System.Drawing.Point(1104, 51)
        Me.txtTotalReceita.Name = "txtTotalReceita"
        Me.txtTotalReceita.ReadOnly = True
        Me.txtTotalReceita.Size = New System.Drawing.Size(166, 25)
        Me.txtTotalReceita.SuperMascara = ""
        Me.txtTotalReceita.SuperObrigatorio = False
        Me.txtTotalReceita.SuperTravaErrors = False
        Me.txtTotalReceita.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTotalReceita.SuperTxtObrigatorio = ""
        Me.txtTotalReceita.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTotalReceita.TabIndex = 8
        Me.txtTotalReceita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbMes
        '
        Me.cbMes.Alterado = False
        Me.cbMes.BackColor = System.Drawing.Color.LightGray
        Me.cbMes.CorFundo = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.cbMes.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.cbMes.CorTexto = System.Drawing.Color.WhiteSmoke
        Me.cbMes.CorTextoSelecionado = System.Drawing.Color.White
        Me.cbMes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbMes.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.ForeColor = System.Drawing.Color.Black
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(369, 51)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(244, 26)
        Me.cbMes.SuperObrigatorio = False
        Me.cbMes.SuperTxtObrigatorio = ""
        Me.cbMes.TabIndex = 11
        '
        'lblContaFiltro
        '
        Me.lblContaFiltro.AutoSize = True
        Me.lblContaFiltro.Location = New System.Drawing.Point(89, 21)
        Me.lblContaFiltro.Name = "lblContaFiltro"
        Me.lblContaFiltro.Size = New System.Drawing.Size(60, 18)
        Me.lblContaFiltro.TabIndex = 8
        Me.lblContaFiltro.Text = "Conta:"
        '
        'cbContaFiltro
        '
        Me.cbContaFiltro.Alterado = False
        Me.cbContaFiltro.BackColor = System.Drawing.Color.Gainsboro
        Me.cbContaFiltro.CorFundo = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.cbContaFiltro.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.cbContaFiltro.CorTexto = System.Drawing.Color.White
        Me.cbContaFiltro.CorTextoSelecionado = System.Drawing.Color.WhiteSmoke
        Me.cbContaFiltro.DropDownHeight = 150
        Me.cbContaFiltro.DropDownWidth = 200
        Me.cbContaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbContaFiltro.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbContaFiltro.ForeColor = System.Drawing.Color.Black
        Me.cbContaFiltro.FormattingEnabled = True
        Me.cbContaFiltro.IntegralHeight = False
        Me.cbContaFiltro.Location = New System.Drawing.Point(92, 51)
        Me.cbContaFiltro.Name = "cbContaFiltro"
        Me.cbContaFiltro.Size = New System.Drawing.Size(245, 26)
        Me.cbContaFiltro.SuperObrigatorio = False
        Me.cbContaFiltro.SuperTxtObrigatorio = ""
        Me.cbContaFiltro.TabIndex = 7
        '
        'lvConsulta
        '
        Me.lvConsulta.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lvConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvConsulta.FullRowSelect = True
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.HoverSelection = True
        Me.lvConsulta.Location = New System.Drawing.Point(33, 121)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = False
        Me.lvConsulta.Size = New System.Drawing.Size(1284, 385)
        Me.lvConsulta.TabIndex = 0
        Me.lvConsulta.TileSize = New System.Drawing.Size(400, 38)
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        Me.lvConsulta.View = System.Windows.Forms.View.Tile
        '
        'frmReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 644)
        Me.Controls.Add(Me.tbConsulta)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceita"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReceita"
        Me.gbBotoes.ResumeLayout(False)
        Me.tbConsulta.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbConsulta As GFT.Util.SuperTabControl
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents gbFiltro As GroupBox
    Friend WithEvents lblContaFiltro As Label
    Friend WithEvents cbContaFiltro As GFT.Util.SuperComboBox
    Friend WithEvents lvConsulta As GFT.Util.SuperLV
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents txtTotalReceita As GFT.Util.SuperTextBox
    Friend WithEvents lblMes As Label
    Friend WithEvents cbMes As GFT.Util.SuperComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblTotalReceita As Label
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnAddReceita As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnExporta As Button
End Class
