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
        Me.lblContas = New System.Windows.Forms.Label()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.gbDadosConta = New System.Windows.Forms.GroupBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAddConta = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtPrincipalConta = New System.Windows.Forms.TextBox()
        Me.lblContaPrincipal = New System.Windows.Forms.Label()
        Me.txtPrincipalTipo = New System.Windows.Forms.TextBox()
        Me.lblTipoPrincipal = New System.Windows.Forms.Label()
        Me.tabCtrlConta.SuspendLayout()
        Me.tabConta.SuspendLayout()
        Me.gbDadosConta.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlConta
        '
        Me.tabCtrlConta.Controls.Add(Me.tabConta)
        Me.tabCtrlConta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlConta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlConta.ImageList = Me.ImageList1
        Me.tabCtrlConta.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlConta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabCtrlConta.Name = "tabCtrlConta"
        Me.tabCtrlConta.Padding = New System.Drawing.Point(30, 6)
        Me.tabCtrlConta.SelectedIndex = 0
        Me.tabCtrlConta.Size = New System.Drawing.Size(1892, 713)
        Me.tabCtrlConta.TabIndex = 0
        '
        'tabConta
        '
        Me.tabConta.Controls.Add(Me.lblContas)
        Me.tabConta.Controls.Add(Me.lvConsulta)
        Me.tabConta.Controls.Add(Me.gbDadosConta)
        Me.tabConta.ImageIndex = 1
        Me.tabConta.Location = New System.Drawing.Point(4, 48)
        Me.tabConta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabConta.Name = "tabConta"
        Me.tabConta.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabConta.Size = New System.Drawing.Size(1884, 661)
        Me.tabConta.TabIndex = 0
        Me.tabConta.Text = "Conta Báncaria"
        Me.tabConta.UseVisualStyleBackColor = True
        '
        'lblContas
        '
        Me.lblContas.AutoSize = True
        Me.lblContas.Location = New System.Drawing.Point(72, 272)
        Me.lblContas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContas.Name = "lblContas"
        Me.lblContas.Size = New System.Drawing.Size(78, 24)
        Me.lblContas.TabIndex = 28
        Me.lblContas.Text = "Contas:"
        '
        'lvConsulta
        '
        Me.lvConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.Location = New System.Drawing.Point(77, 298)
        Me.lvConsulta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = False
        Me.lvConsulta.Size = New System.Drawing.Size(1708, 330)
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
        Me.gbDadosConta.Location = New System.Drawing.Point(77, 46)
        Me.gbDadosConta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDadosConta.Name = "gbDadosConta"
        Me.gbDadosConta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDadosConta.Size = New System.Drawing.Size(1709, 207)
        Me.gbDadosConta.TabIndex = 25
        Me.gbDadosConta.TabStop = False
        Me.gbDadosConta.Text = "Conta Principal"
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
        Me.gbBotoes.Location = New System.Drawing.Point(0, 713)
        Me.gbBotoes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbBotoes.Size = New System.Drawing.Size(1892, 123)
        Me.gbBotoes.TabIndex = 26
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1541, 37)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(271, 52)
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
        Me.btnExportar.Location = New System.Drawing.Point(1247, 36)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(271, 52)
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
        Me.btnExcluir.Location = New System.Drawing.Point(955, 36)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(271, 52)
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
        Me.btnAddConta.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddReceita
        Me.btnAddConta.Location = New System.Drawing.Point(360, 36)
        Me.btnAddConta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddConta.Name = "btnAddConta"
        Me.btnAddConta.Size = New System.Drawing.Size(271, 52)
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
        Me.btnEditar.Location = New System.Drawing.Point(661, 36)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(271, 52)
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
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(61, 36)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(271, 52)
        Me.btnPesquisar.TabIndex = 29
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtPrincipalConta
        '
        Me.txtPrincipalConta.Location = New System.Drawing.Point(59, 97)
        Me.txtPrincipalConta.Name = "txtPrincipalConta"
        Me.txtPrincipalConta.Size = New System.Drawing.Size(540, 32)
        Me.txtPrincipalConta.TabIndex = 0
        '
        'lblContaPrincipal
        '
        Me.lblContaPrincipal.AutoSize = True
        Me.lblContaPrincipal.Location = New System.Drawing.Point(55, 70)
        Me.lblContaPrincipal.Name = "lblContaPrincipal"
        Me.lblContaPrincipal.Size = New System.Drawing.Size(152, 24)
        Me.lblContaPrincipal.TabIndex = 1
        Me.lblContaPrincipal.Text = "Conta Báncaria:"
        '
        'txtPrincipalTipo
        '
        Me.txtPrincipalTipo.Location = New System.Drawing.Point(605, 97)
        Me.txtPrincipalTipo.Name = "txtPrincipalTipo"
        Me.txtPrincipalTipo.Size = New System.Drawing.Size(258, 32)
        Me.txtPrincipalTipo.TabIndex = 2
        '
        'lblTipoPrincipal
        '
        Me.lblTipoPrincipal.AutoSize = True
        Me.lblTipoPrincipal.Location = New System.Drawing.Point(601, 70)
        Me.lblTipoPrincipal.Name = "lblTipoPrincipal"
        Me.lblTipoPrincipal.Size = New System.Drawing.Size(142, 24)
        Me.lblTipoPrincipal.TabIndex = 3
        Me.lblTipoPrincipal.Text = "Tipo de Conta:"
        '
        'frmConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1892, 836)
        Me.Controls.Add(Me.tabCtrlConta)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmConta"
        Me.Text = "frmConta"
        Me.tabCtrlConta.ResumeLayout(False)
        Me.tabConta.ResumeLayout(False)
        Me.tabConta.PerformLayout()
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
    Friend WithEvents lblContas As Label
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
End Class
