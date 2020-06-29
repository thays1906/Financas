<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConta))
        Me.tabCtrlConta = New GFT.Util.SuperTabControl()
        Me.tabConta = New System.Windows.Forms.TabPage()
        Me.gbListConta = New System.Windows.Forms.GroupBox()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.gbDadosConta = New System.Windows.Forms.GroupBox()
        Me.lblTipoPrincipal = New System.Windows.Forms.Label()
        Me.txtPrincipalTipo = New System.Windows.Forms.TextBox()
        Me.lblContaPrincipal = New System.Windows.Forms.Label()
        Me.txtPrincipalConta = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAddConta = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.tabCtrlConta.SuspendLayout()
        Me.tabConta.SuspendLayout()
        Me.gbListConta.SuspendLayout()
        Me.gbDadosConta.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlConta
        '
        Me.tabCtrlConta.Controls.Add(Me.tabConta)
        Me.tabCtrlConta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlConta.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlConta.ImageList = Me.ImageList1
        Me.tabCtrlConta.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlConta.Name = "tabCtrlConta"
        Me.tabCtrlConta.Padding = New System.Drawing.Point(30, 6)
        Me.tabCtrlConta.SelectedIndex = 0
        Me.tabCtrlConta.Size = New System.Drawing.Size(1419, 606)
        Me.tabCtrlConta.TabIndex = 0
        '
        'tabConta
        '
        Me.tabConta.Controls.Add(Me.gbListConta)
        Me.tabConta.Controls.Add(Me.gbDadosConta)
        Me.tabConta.ImageIndex = 1
        Me.tabConta.Location = New System.Drawing.Point(4, 48)
        Me.tabConta.Name = "tabConta"
        Me.tabConta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConta.Size = New System.Drawing.Size(1411, 554)
        Me.tabConta.TabIndex = 0
        Me.tabConta.Text = "Conta Báncaria"
        Me.tabConta.UseVisualStyleBackColor = True
        '
        'gbListConta
        '
        Me.gbListConta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbListConta.Controls.Add(Me.lvConsulta)
        Me.gbListConta.Location = New System.Drawing.Point(42, 164)
        Me.gbListConta.Margin = New System.Windows.Forms.Padding(2)
        Me.gbListConta.Name = "gbListConta"
        Me.gbListConta.Padding = New System.Windows.Forms.Padding(2)
        Me.gbListConta.Size = New System.Drawing.Size(1314, 385)
        Me.gbListConta.TabIndex = 29
        Me.gbListConta.TabStop = False
        Me.gbListConta.Text = "Todas as contas"
        '
        'lvConsulta
        '
        Me.lvConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.Location = New System.Drawing.Point(4, 23)
        Me.lvConsulta.Margin = New System.Windows.Forms.Padding(2)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = False
        Me.lvConsulta.Size = New System.Drawing.Size(1306, 358)
        Me.lvConsulta.TabIndex = 27
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        '
        'gbDadosConta
        '
        Me.gbDadosConta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDadosConta.Controls.Add(Me.lblTipoPrincipal)
        Me.gbDadosConta.Controls.Add(Me.txtPrincipalTipo)
        Me.gbDadosConta.Controls.Add(Me.lblContaPrincipal)
        Me.gbDadosConta.Controls.Add(Me.txtPrincipalConta)
        Me.gbDadosConta.Location = New System.Drawing.Point(42, 15)
        Me.gbDadosConta.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDadosConta.Name = "gbDadosConta"
        Me.gbDadosConta.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDadosConta.Size = New System.Drawing.Size(1314, 145)
        Me.gbDadosConta.TabIndex = 25
        Me.gbDadosConta.TabStop = False
        Me.gbDadosConta.Text = "Conta Principal"
        '
        'lblTipoPrincipal
        '
        Me.lblTipoPrincipal.AutoSize = True
        Me.lblTipoPrincipal.Location = New System.Drawing.Point(474, 49)
        Me.lblTipoPrincipal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoPrincipal.Name = "lblTipoPrincipal"
        Me.lblTipoPrincipal.Size = New System.Drawing.Size(130, 18)
        Me.lblTipoPrincipal.TabIndex = 3
        Me.lblTipoPrincipal.Text = "Tipo de Conta:"
        '
        'txtPrincipalTipo
        '
        Me.txtPrincipalTipo.Location = New System.Drawing.Point(478, 80)
        Me.txtPrincipalTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrincipalTipo.Name = "txtPrincipalTipo"
        Me.txtPrincipalTipo.Size = New System.Drawing.Size(194, 27)
        Me.txtPrincipalTipo.TabIndex = 2
        '
        'lblContaPrincipal
        '
        Me.lblContaPrincipal.AutoSize = True
        Me.lblContaPrincipal.Location = New System.Drawing.Point(36, 49)
        Me.lblContaPrincipal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContaPrincipal.Name = "lblContaPrincipal"
        Me.lblContaPrincipal.Size = New System.Drawing.Size(207, 18)
        Me.lblContaPrincipal.TabIndex = 1
        Me.lblContaPrincipal.Text = "Banco / Agência / Conta"
        '
        'txtPrincipalConta
        '
        Me.txtPrincipalConta.Location = New System.Drawing.Point(40, 80)
        Me.txtPrincipalConta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrincipalConta.Name = "txtPrincipalConta"
        Me.txtPrincipalConta.Size = New System.Drawing.Size(406, 27)
        Me.txtPrincipalConta.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "iconeBank.png")
        Me.ImageList1.Images.SetKeyName(1, "iconeBanco.png")
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnAddConta)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBotoes.Location = New System.Drawing.Point(0, 606)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1419, 73)
        Me.gbBotoes.TabIndex = 26
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1156, 19)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(203, 42)
        Me.btnFechar.TabIndex = 33
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(935, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(203, 42)
        Me.btnExportar.TabIndex = 34
        Me.btnExportar.Text = " &Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(716, 19)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(203, 42)
        Me.btnExcluir.TabIndex = 32
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAddConta
        '
        Me.btnAddConta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddConta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddConta.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddBlue
        Me.btnAddConta.Location = New System.Drawing.Point(270, 19)
        Me.btnAddConta.Name = "btnAddConta"
        Me.btnAddConta.Size = New System.Drawing.Size(203, 42)
        Me.btnAddConta.TabIndex = 31
        Me.btnAddConta.Text = " &Conta"
        Me.btnAddConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddConta.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditar
        Me.btnEditar.Location = New System.Drawing.Point(496, 19)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(203, 42)
        Me.btnEditar.TabIndex = 30
        Me.btnEditar.Text = " &Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(45, 19)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(203, 42)
        Me.btnPesquisar.TabIndex = 29
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'frmConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1419, 679)
        Me.Controls.Add(Me.tabCtrlConta)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConta"
        Me.Text = "frmConta"
        Me.tabCtrlConta.ResumeLayout(False)
        Me.tabConta.ResumeLayout(False)
        Me.gbListConta.ResumeLayout(False)
        Me.gbDadosConta.ResumeLayout(False)
        Me.gbDadosConta.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlConta As GFT.Util.SuperTabControl
    Friend WithEvents tabConta As TabPage
    Friend WithEvents lvConsulta As GFT.Util.SuperLV
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents gbDadosConta As GroupBox
    Friend WithEvents btnAddConta As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblContaPrincipal As Label
    Friend WithEvents txtPrincipalConta As TextBox
    Friend WithEvents lblTipoPrincipal As Label
    Friend WithEvents txtPrincipalTipo As TextBox
    Friend WithEvents gbListConta As GroupBox
End Class
