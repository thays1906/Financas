﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta))
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbConsulta = New GFT.Util.SuperTabControl()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.cbConta = New GFT.Util.SuperComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTipoFiltro = New GFT.Util.SuperComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbStatusFiltro = New GFT.Util.SuperComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFinalFiltro = New GFT.Util.SuperDatePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtInicialFiltro = New GFT.Util.SuperDatePicker()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.tbConsulta.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.BackColor = System.Drawing.Color.White
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.Icon_search
        Me.btnPesquisar.Location = New System.Drawing.Point(138, 19)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(271, 52)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(930, 19)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(271, 52)
        Me.btnFechar.TabIndex = 7
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnExportar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(519, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(271, 52)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = " &Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "iconFileExplorer.png")
        '
        'tbConsulta
        '
        Me.tbConsulta.Controls.Add(Me.tpPesquisa)
        Me.tbConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbConsulta.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tbConsulta.ImageList = Me.ImageList1
        Me.tbConsulta.Location = New System.Drawing.Point(0, 0)
        Me.tbConsulta.Name = "tbConsulta"
        Me.tbConsulta.Padding = New System.Drawing.Point(50, 6)
        Me.tbConsulta.SelectedIndex = 0
        Me.tbConsulta.Size = New System.Drawing.Size(1284, 569)
        Me.tbConsulta.TabIndex = 3
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.Controls.Add(Me.lvConsulta)
        Me.tpPesquisa.ImageIndex = 0
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 61)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(5)
        Me.tpPesquisa.Size = New System.Drawing.Size(1276, 504)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Consulta"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'gbFiltro
        '
        Me.gbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltro.Controls.Add(Me.lblConta)
        Me.gbFiltro.Controls.Add(Me.cbConta)
        Me.gbFiltro.Controls.Add(Me.Label4)
        Me.gbFiltro.Controls.Add(Me.cbTipoFiltro)
        Me.gbFiltro.Controls.Add(Me.Label3)
        Me.gbFiltro.Controls.Add(Me.cbStatusFiltro)
        Me.gbFiltro.Controls.Add(Me.Label1)
        Me.gbFiltro.Controls.Add(Me.dtFinalFiltro)
        Me.gbFiltro.Controls.Add(Me.Label2)
        Me.gbFiltro.Controls.Add(Me.dtInicialFiltro)
        Me.gbFiltro.Location = New System.Drawing.Point(44, 22)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(1187, 95)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(877, 26)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(175, 25)
        Me.lblConta.TabIndex = 12
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
        Me.cbConta.Location = New System.Drawing.Point(891, 54)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(290, 33)
        Me.cbConta.SuperObrigatorio = False
        Me.cbConta.SuperTxtObrigatorio = ""
        Me.cbConta.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(599, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Receita/ Despesa:"
        '
        'cbTipoFiltro
        '
        Me.cbTipoFiltro.Alterado = False
        Me.cbTipoFiltro.CorFundo = System.Drawing.Color.White
        Me.cbTipoFiltro.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTipoFiltro.CorTexto = System.Drawing.Color.Black
        Me.cbTipoFiltro.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbTipoFiltro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoFiltro.FormattingEnabled = True
        Me.cbTipoFiltro.Location = New System.Drawing.Point(603, 59)
        Me.cbTipoFiltro.Name = "cbTipoFiltro"
        Me.cbTipoFiltro.Size = New System.Drawing.Size(253, 30)
        Me.cbTipoFiltro.SuperObrigatorio = False
        Me.cbTipoFiltro.SuperTxtObrigatorio = ""
        Me.cbTipoFiltro.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Status:"
        '
        'cbStatusFiltro
        '
        Me.cbStatusFiltro.Alterado = False
        Me.cbStatusFiltro.CorFundo = System.Drawing.Color.White
        Me.cbStatusFiltro.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbStatusFiltro.CorTexto = System.Drawing.Color.Black
        Me.cbStatusFiltro.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbStatusFiltro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatusFiltro.FormattingEnabled = True
        Me.cbStatusFiltro.Location = New System.Drawing.Point(326, 59)
        Me.cbStatusFiltro.Name = "cbStatusFiltro"
        Me.cbStatusFiltro.Size = New System.Drawing.Size(244, 30)
        Me.cbStatusFiltro.SuperObrigatorio = False
        Me.cbStatusFiltro.SuperTxtObrigatorio = ""
        Me.cbStatusFiltro.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "De:"
        '
        'dtFinalFiltro
        '
        Me.dtFinalFiltro.Alterado = False
        Me.dtFinalFiltro.BackColor = System.Drawing.Color.White
        Me.dtFinalFiltro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinalFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinalFiltro.Location = New System.Drawing.Point(173, 60)
        Me.dtFinalFiltro.Name = "dtFinalFiltro"
        Me.dtFinalFiltro.Size = New System.Drawing.Size(138, 29)
        Me.dtFinalFiltro.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Até:"
        '
        'dtInicialFiltro
        '
        Me.dtInicialFiltro.Alterado = False
        Me.dtInicialFiltro.BackColor = System.Drawing.Color.White
        Me.dtInicialFiltro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicialFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicialFiltro.Location = New System.Drawing.Point(19, 60)
        Me.dtInicialFiltro.Name = "dtInicialFiltro"
        Me.dtInicialFiltro.Size = New System.Drawing.Size(134, 29)
        Me.dtInicialFiltro.TabIndex = 3
        '
        'lvConsulta
        '
        Me.lvConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.HoverSelection = True
        Me.lvConsulta.Location = New System.Drawing.Point(44, 123)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = False
        Me.lvConsulta.Size = New System.Drawing.Size(1187, 378)
        Me.lvConsulta.TabIndex = 0
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBotoes.Location = New System.Drawing.Point(0, 569)
        Me.gbBotoes.Margin = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Padding = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Size = New System.Drawing.Size(1284, 90)
        Me.gbBotoes.TabIndex = 27
        Me.gbBotoes.TabStop = False
        '
        'frmConsulta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1284, 659)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbConsulta)
        Me.Controls.Add(Me.gbBotoes)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsulta"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "frmConsulta"
        Me.tbConsulta.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvConsulta As GFT.Util.SuperLV
    Friend WithEvents tbConsulta As GFT.Util.SuperTabControl
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents gbFiltro As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbStatusFiltro As GFT.Util.SuperComboBox
    Friend WithEvents dtFinalFiltro As GFT.Util.SuperDatePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtInicialFiltro As GFT.Util.SuperDatePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTipoFiltro As GFT.Util.SuperComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblConta As Label
    Friend WithEvents cbConta As GFT.Util.SuperComboBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents gbBotoes As GroupBox
End Class
