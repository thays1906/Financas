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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImgContaBancaria = New System.Windows.Forms.ImageList(Me.components)
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAddConta = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.tabCtrlConta = New GFT.Util.SuperTabControl()
        Me.tabConta = New System.Windows.Forms.TabPage()
        Me.gbListConta = New System.Windows.Forms.GroupBox()
        Me.dgConta = New GFT.Util.SuperDataGridView()
        Me.gbDadosConta = New System.Windows.Forms.GroupBox()
        Me.lblPrincipalConta = New System.Windows.Forms.Label()
        Me.picBank = New System.Windows.Forms.PictureBox()
        Me.lblContaPrincipal = New System.Windows.Forms.Label()
        Me.gbBotoes.SuspendLayout()
        Me.tabCtrlConta.SuspendLayout()
        Me.tabConta.SuspendLayout()
        Me.gbListConta.SuspendLayout()
        CType(Me.dgConta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDadosConta.SuspendLayout()
        CType(Me.picBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImgContaBancaria
        '
        Me.ImgContaBancaria.ImageStream = CType(resources.GetObject("ImgContaBancaria.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgContaBancaria.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgContaBancaria.Images.SetKeyName(0, "iconBank.png")
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
        Me.gbBotoes.Location = New System.Drawing.Point(0, 746)
        Me.gbBotoes.Margin = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Padding = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Size = New System.Drawing.Size(1892, 90)
        Me.gbBotoes.TabIndex = 26
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1541, 23)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnExportar.Location = New System.Drawing.Point(1247, 23)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnExcluir.Location = New System.Drawing.Point(955, 23)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnAddConta.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddBlue
        Me.btnAddConta.Location = New System.Drawing.Point(360, 23)
        Me.btnAddConta.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnEditar.Location = New System.Drawing.Point(661, 23)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(60, 23)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(271, 52)
        Me.btnPesquisar.TabIndex = 29
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'tabCtrlConta
        '
        Me.tabCtrlConta.Controls.Add(Me.tabConta)
        Me.tabCtrlConta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlConta.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlConta.ImageList = Me.ImgContaBancaria
        Me.tabCtrlConta.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlConta.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCtrlConta.Name = "tabCtrlConta"
        Me.tabCtrlConta.Padding = New System.Drawing.Point(30, 10)
        Me.tabCtrlConta.SelectedIndex = 0
        Me.tabCtrlConta.Size = New System.Drawing.Size(1892, 746)
        Me.tabCtrlConta.TabIndex = 0
        '
        'tabConta
        '
        Me.tabConta.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tabConta.Controls.Add(Me.gbListConta)
        Me.tabConta.Controls.Add(Me.gbDadosConta)
        Me.tabConta.ImageIndex = 0
        Me.tabConta.Location = New System.Drawing.Point(4, 69)
        Me.tabConta.Margin = New System.Windows.Forms.Padding(4)
        Me.tabConta.Name = "tabConta"
        Me.tabConta.Padding = New System.Windows.Forms.Padding(4)
        Me.tabConta.Size = New System.Drawing.Size(1884, 673)
        Me.tabConta.TabIndex = 0
        Me.tabConta.Text = "Conta Báncaria"
        '
        'gbListConta
        '
        Me.gbListConta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbListConta.Controls.Add(Me.dgConta)
        Me.gbListConta.Location = New System.Drawing.Point(56, 199)
        Me.gbListConta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbListConta.Name = "gbListConta"
        Me.gbListConta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbListConta.Size = New System.Drawing.Size(1752, 453)
        Me.gbListConta.TabIndex = 29
        Me.gbListConta.TabStop = False
        Me.gbListConta.Text = "Todas as contas"
        '
        'dgConta
        '
        Me.dgConta.AdicionarCheckBox = True
        Me.dgConta.AllowUserToAddRows = False
        Me.dgConta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgConta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgConta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgConta.BackgroundColor = System.Drawing.Color.White
        Me.dgConta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgConta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgConta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgConta.ColumnHeadersHeight = 50
        Me.dgConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgConta.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgConta.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgConta.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgConta.EnableHeadersVisualStyles = False
        Me.dgConta.Location = New System.Drawing.Point(-1, 31)
        Me.dgConta.Margin = New System.Windows.Forms.Padding(4)
        Me.dgConta.MultiSelect = False
        Me.dgConta.Name = "dgConta"
        Me.dgConta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgConta.RowHeadersVisible = False
        Me.dgConta.RowHeadersWidth = 51
        Me.dgConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConta.Size = New System.Drawing.Size(1753, 422)
        Me.dgConta.TabIndex = 28
        '
        'gbDadosConta
        '
        Me.gbDadosConta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDadosConta.BackColor = System.Drawing.Color.White
        Me.gbDadosConta.Controls.Add(Me.lblPrincipalConta)
        Me.gbDadosConta.Controls.Add(Me.picBank)
        Me.gbDadosConta.Controls.Add(Me.lblContaPrincipal)
        Me.gbDadosConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbDadosConta.Location = New System.Drawing.Point(56, 18)
        Me.gbDadosConta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDadosConta.Name = "gbDadosConta"
        Me.gbDadosConta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDadosConta.Size = New System.Drawing.Size(1752, 158)
        Me.gbDadosConta.TabIndex = 25
        Me.gbDadosConta.TabStop = False
        Me.gbDadosConta.Text = "Conta Principal"
        '
        'lblPrincipalConta
        '
        Me.lblPrincipalConta.AutoSize = True
        Me.lblPrincipalConta.BackColor = System.Drawing.Color.SlateGray
        Me.lblPrincipalConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrincipalConta.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPrincipalConta.Location = New System.Drawing.Point(173, 103)
        Me.lblPrincipalConta.Name = "lblPrincipalConta"
        Me.lblPrincipalConta.Size = New System.Drawing.Size(89, 27)
        Me.lblPrincipalConta.TabIndex = 5
        Me.lblPrincipalConta.Text = "♣♣♣"
        Me.lblPrincipalConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBank
        '
        Me.picBank.Location = New System.Drawing.Point(62, 82)
        Me.picBank.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picBank.Name = "picBank"
        Me.picBank.Size = New System.Drawing.Size(48, 48)
        Me.picBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBank.TabIndex = 4
        Me.picBank.TabStop = False
        '
        'lblContaPrincipal
        '
        Me.lblContaPrincipal.AutoSize = True
        Me.lblContaPrincipal.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContaPrincipal.Location = New System.Drawing.Point(169, 66)
        Me.lblContaPrincipal.Name = "lblContaPrincipal"
        Me.lblContaPrincipal.Size = New System.Drawing.Size(404, 23)
        Me.lblContaPrincipal.TabIndex = 1
        Me.lblContaPrincipal.Text = "Banco • Agência • Conta • Tipo de Conta"
        '
        'frmConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1892, 836)
        Me.Controls.Add(Me.tabCtrlConta)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConta"
        Me.Text = "frmConta"
        Me.gbBotoes.ResumeLayout(False)
        Me.tabCtrlConta.ResumeLayout(False)
        Me.tabConta.ResumeLayout(False)
        Me.gbListConta.ResumeLayout(False)
        CType(Me.dgConta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDadosConta.ResumeLayout(False)
        Me.gbDadosConta.PerformLayout()
        CType(Me.picBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlConta As GFT.Util.SuperTabControl
    Friend WithEvents tabConta As TabPage
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents gbDadosConta As GroupBox
    Friend WithEvents btnAddConta As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents ImgContaBancaria As ImageList
    Friend WithEvents lblContaPrincipal As Label
    Friend WithEvents gbListConta As GroupBox
    Friend WithEvents picBank As PictureBox
    Friend WithEvents dgConta As GFT.Util.SuperDataGridView
    Friend WithEvents lblPrincipalConta As Label
End Class
