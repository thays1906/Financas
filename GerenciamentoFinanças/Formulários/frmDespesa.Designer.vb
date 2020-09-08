<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDespesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDespesa))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnStatusPago = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAddDespesa = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.ImgDespesa = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCtrlDespesa = New GFT.Util.SuperTabControl()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.gbLegenda = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgDespesa = New GFT.Util.SuperDataGridView()
        Me.txtLetreiroDespesa = New GFT.Util.SuperLetreiro()
        Me.chkList = New System.Windows.Forms.CheckBox()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.cbAno = New GFT.Util.SuperComboBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbMes = New GFT.Util.SuperComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalDespesa = New GFT.Util.SuperTextBox()
        Me.cbStatusFiltro = New GFT.Util.SuperComboBox()
        Me.tabDespesaFixa = New System.Windows.Forms.TabPage()
        Me.btnLancamentoFuturo = New System.Windows.Forms.Button()
        Me.txtLetreiroFixa = New GFT.Util.SuperLetreiro()
        Me.gbDespesaFixa = New System.Windows.Forms.GroupBox()
        Me.cbCategoriaFixa = New GFT.Util.SuperComboBox()
        Me.cbMesFixa = New GFT.Util.SuperComboBox()
        Me.cbPeriodo = New GFT.Util.SuperComboBox()
        Me.lblMesFixa = New System.Windows.Forms.Label()
        Me.lblCategoriaFixa = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.tabDetalhe = New System.Windows.Forms.TabPage()
        Me.gbDetalhe = New System.Windows.Forms.GroupBox()
        Me.gbDadosDetalhe = New System.Windows.Forms.GroupBox()
        Me.lblNaoPago = New System.Windows.Forms.Label()
        Me.txtPago = New GFT.Util.SuperTextBox()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.txtNaoPago = New GFT.Util.SuperTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalDespesaDetalhe = New GFT.Util.SuperTextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtDescriaoDetalhe = New GFT.Util.SuperTextBox()
        Me.pnlDetalhe = New System.Windows.Forms.Panel()
        Me.dgDespesaFixa = New GFT.Util.SuperDataGridView()
        Me.gbBotoes.SuspendLayout()
        Me.tabCtrlDespesa.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbLegenda.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDespesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltro.SuspendLayout()
        Me.tabDespesaFixa.SuspendLayout()
        Me.gbDespesaFixa.SuspendLayout()
        Me.tabDetalhe.SuspendLayout()
        Me.gbDetalhe.SuspendLayout()
        Me.gbDadosDetalhe.SuspendLayout()
        CType(Me.dgDespesaFixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnStatusPago)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnAddDespesa)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.Location = New System.Drawing.Point(0, 546)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Padding = New System.Windows.Forms.Padding(0)
        Me.gbBotoes.Size = New System.Drawing.Size(1552, 67)
        Me.gbBotoes.TabIndex = 9
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1325, 16)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(217, 42)
        Me.btnFechar.TabIndex = 19
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(7, 16)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(214, 42)
        Me.btnPesquisar.TabIndex = 8
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnStatusPago
        '
        Me.btnStatusPago.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStatusPago.Enabled = False
        Me.btnStatusPago.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnStatusPago.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconOk
        Me.btnStatusPago.Location = New System.Drawing.Point(886, 16)
        Me.btnStatusPago.Name = "btnStatusPago"
        Me.btnStatusPago.Size = New System.Drawing.Size(217, 42)
        Me.btnStatusPago.TabIndex = 17
        Me.btnStatusPago.Text = " &Pagar"
        Me.btnStatusPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStatusPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatusPago.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnExportar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(1105, 16)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(217, 42)
        Me.btnExportar.TabIndex = 18
        Me.btnExportar.Text = " &Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.Enabled = False
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnEditar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditar
        Me.btnEditar.Location = New System.Drawing.Point(445, 16)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(217, 42)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = " &Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAddDespesa
        '
        Me.btnAddDespesa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddDespesa.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnAddDespesa.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddDespesa
        Me.btnAddDespesa.Location = New System.Drawing.Point(225, 16)
        Me.btnAddDespesa.Name = "btnAddDespesa"
        Me.btnAddDespesa.Size = New System.Drawing.Size(217, 42)
        Me.btnAddDespesa.TabIndex = 14
        Me.btnAddDespesa.Text = " &Despesa"
        Me.btnAddDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddDespesa.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(666, 16)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(217, 42)
        Me.btnExcluir.TabIndex = 16
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'ImgDespesa
        '
        Me.ImgDespesa.ImageStream = CType(resources.GetObject("ImgDespesa.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgDespesa.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgDespesa.Images.SetKeyName(0, "iconCalandar.png")
        Me.ImgDespesa.Images.SetKeyName(1, "iconSearchFile.png")
        Me.ImgDespesa.Images.SetKeyName(2, "icon_Despesa01.png")
        Me.ImgDespesa.Images.SetKeyName(3, "business_salesreport_salesreport_negocio_2353 (1).png")
        Me.ImgDespesa.Images.SetKeyName(4, "icon_Despesa32x.png")
        '
        'tabCtrlDespesa
        '
        Me.tabCtrlDespesa.Controls.Add(Me.tpPesquisa)
        Me.tabCtrlDespesa.Controls.Add(Me.tabDespesaFixa)
        Me.tabCtrlDespesa.Controls.Add(Me.tabDetalhe)
        Me.tabCtrlDespesa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlDespesa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlDespesa.ImageList = Me.ImgDespesa
        Me.tabCtrlDespesa.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlDespesa.Name = "tabCtrlDespesa"
        Me.tabCtrlDespesa.Padding = New System.Drawing.Point(50, 6)
        Me.tabCtrlDespesa.SelectedIndex = 0
        Me.tabCtrlDespesa.Size = New System.Drawing.Size(1552, 546)
        Me.tabCtrlDespesa.TabIndex = 4
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.gbLegenda)
        Me.tpPesquisa.Controls.Add(Me.dgDespesa)
        Me.tpPesquisa.Controls.Add(Me.txtLetreiroDespesa)
        Me.tpPesquisa.Controls.Add(Me.chkList)
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.ImageIndex = 2
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 61)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.tpPesquisa.Size = New System.Drawing.Size(1544, 481)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Despesas"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'gbLegenda
        '
        Me.gbLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLegenda.BackColor = System.Drawing.SystemColors.Control
        Me.gbLegenda.Controls.Add(Me.PictureBox3)
        Me.gbLegenda.Controls.Add(Me.Label6)
        Me.gbLegenda.Controls.Add(Me.PictureBox2)
        Me.gbLegenda.Controls.Add(Me.Label5)
        Me.gbLegenda.Controls.Add(Me.PictureBox1)
        Me.gbLegenda.Controls.Add(Me.Label2)
        Me.gbLegenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbLegenda.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.gbLegenda.Location = New System.Drawing.Point(1144, 441)
        Me.gbLegenda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbLegenda.Name = "gbLegenda"
        Me.gbLegenda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbLegenda.Size = New System.Drawing.Size(356, 46)
        Me.gbLegenda.TabIndex = 11
        Me.gbLegenda.TabStop = False
        Me.gbLegenda.Text = "Legenda•Status"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconStatusAtrasado20x20
        Me.PictureBox3.Location = New System.Drawing.Point(260, 24)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(280, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Atrasado"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconStatusPago20x20
        Me.PictureBox2.Location = New System.Drawing.Point(179, 24)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Pago"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconStatusPendente20x20
        Me.PictureBox1.Location = New System.Drawing.Point(74, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pendente"
        '
        'dgDespesa
        '
        Me.dgDespesa.AdicionarCheckBox = True
        Me.dgDespesa.AllowUserToAddRows = False
        Me.dgDespesa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDespesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDespesa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgDespesa.BackgroundColor = System.Drawing.Color.White
        Me.dgDespesa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDespesa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgDespesa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDespesa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDespesa.ColumnHeadersHeight = 50
        Me.dgDespesa.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgDespesa.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDespesa.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgDespesa.EnableHeadersVisualStyles = False
        Me.dgDespesa.Location = New System.Drawing.Point(35, 137)
        Me.dgDespesa.Margin = New System.Windows.Forms.Padding(2)
        Me.dgDespesa.Name = "dgDespesa"
        Me.dgDespesa.ReadOnly = True
        Me.dgDespesa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgDespesa.RowHeadersVisible = False
        Me.dgDespesa.RowHeadersWidth = 51
        Me.dgDespesa.RowTemplate.Height = 24
        Me.dgDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDespesa.Size = New System.Drawing.Size(1465, 298)
        Me.dgDespesa.TabIndex = 10
        '
        'txtLetreiroDespesa
        '
        Me.txtLetreiroDespesa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiroDespesa.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiroDespesa.Location = New System.Drawing.Point(35, 455)
        Me.txtLetreiroDespesa.Name = "txtLetreiroDespesa"
        Me.txtLetreiroDespesa.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Direita
        Me.txtLetreiroDespesa.Size = New System.Drawing.Size(286, 18)
        Me.txtLetreiroDespesa.TabIndex = 9
        Me.txtLetreiroDespesa.TextoLetreiro = "0,00 Registros"
        Me.txtLetreiroDespesa.VelocidadeRolagem = 1
        '
        'chkList
        '
        Me.chkList.AutoSize = True
        Me.chkList.Location = New System.Drawing.Point(35, 108)
        Me.chkList.Name = "chkList"
        Me.chkList.Size = New System.Drawing.Size(226, 22)
        Me.chkList.TabIndex = 8
        Me.chkList.Text = "Marcar/Desmarcar Todos"
        Me.chkList.UseVisualStyleBackColor = True
        '
        'gbFiltro
        '
        Me.gbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltro.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.gbFiltro.Controls.Add(Me.lblAno)
        Me.gbFiltro.Controls.Add(Me.cbAno)
        Me.gbFiltro.Controls.Add(Me.lblMes)
        Me.gbFiltro.Controls.Add(Me.Label4)
        Me.gbFiltro.Controls.Add(Me.cbMes)
        Me.gbFiltro.Controls.Add(Me.Label3)
        Me.gbFiltro.Controls.Add(Me.txtTotalDespesa)
        Me.gbFiltro.Controls.Add(Me.cbStatusFiltro)
        Me.gbFiltro.Location = New System.Drawing.Point(35, 20)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(1465, 73)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(570, 21)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(46, 18)
        Me.lblAno.TabIndex = 12
        Me.lblAno.Text = "Ano:"
        '
        'cbAno
        '
        Me.cbAno.Alterado = False
        Me.cbAno.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbAno.CorFundo = System.Drawing.SystemColors.ControlLightLight
        Me.cbAno.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.cbAno.CorTexto = System.Drawing.Color.Black
        Me.cbAno.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbAno.FormattingEnabled = True
        Me.cbAno.Location = New System.Drawing.Point(575, 42)
        Me.cbAno.Name = "cbAno"
        Me.cbAno.Size = New System.Drawing.Size(267, 26)
        Me.cbAno.SuperObrigatorio = False
        Me.cbAno.SuperTxtObrigatorio = ""
        Me.cbAno.TabIndex = 11
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(291, 21)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(47, 18)
        Me.lblMes.TabIndex = 10
        Me.lblMes.Text = "Mês:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1277, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total de Despesas:"
        '
        'cbMes
        '
        Me.cbMes.Alterado = False
        Me.cbMes.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbMes.CorFundo = System.Drawing.SystemColors.ControlLightLight
        Me.cbMes.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.cbMes.CorTexto = System.Drawing.Color.Black
        Me.cbMes.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(295, 42)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(267, 26)
        Me.cbMes.SuperObrigatorio = False
        Me.cbMes.SuperTxtObrigatorio = ""
        Me.cbMes.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Status:"
        '
        'txtTotalDespesa
        '
        Me.txtTotalDespesa.Alterado = False
        Me.txtTotalDespesa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDespesa.BackColor = System.Drawing.Color.White
        Me.txtTotalDespesa.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtTotalDespesa.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDespesa.ForeColor = System.Drawing.Color.Red
        Me.txtTotalDespesa.Location = New System.Drawing.Point(1280, 42)
        Me.txtTotalDespesa.Name = "txtTotalDespesa"
        Me.txtTotalDespesa.ReadOnly = True
        Me.txtTotalDespesa.Size = New System.Drawing.Size(178, 26)
        Me.txtTotalDespesa.SuperMascara = ""
        Me.txtTotalDespesa.SuperObrigatorio = False
        Me.txtTotalDespesa.SuperTravaErrors = False
        Me.txtTotalDespesa.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTotalDespesa.SuperTxtObrigatorio = ""
        Me.txtTotalDespesa.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTotalDespesa.TabIndex = 8
        Me.txtTotalDespesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbStatusFiltro
        '
        Me.cbStatusFiltro.Alterado = False
        Me.cbStatusFiltro.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbStatusFiltro.CorFundo = System.Drawing.SystemColors.ControlLightLight
        Me.cbStatusFiltro.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.cbStatusFiltro.CorTexto = System.Drawing.Color.Black
        Me.cbStatusFiltro.CorTextoSelecionado = System.Drawing.SystemColors.MenuText
        Me.cbStatusFiltro.FormattingEnabled = True
        Me.cbStatusFiltro.Location = New System.Drawing.Point(95, 42)
        Me.cbStatusFiltro.Name = "cbStatusFiltro"
        Me.cbStatusFiltro.Size = New System.Drawing.Size(186, 26)
        Me.cbStatusFiltro.SuperObrigatorio = False
        Me.cbStatusFiltro.SuperTxtObrigatorio = ""
        Me.cbStatusFiltro.TabIndex = 7
        '
        'tabDespesaFixa
        '
        Me.tabDespesaFixa.Controls.Add(Me.dgDespesaFixa)
        Me.tabDespesaFixa.Controls.Add(Me.btnLancamentoFuturo)
        Me.tabDespesaFixa.Controls.Add(Me.txtLetreiroFixa)
        Me.tabDespesaFixa.Controls.Add(Me.gbDespesaFixa)
        Me.tabDespesaFixa.ImageIndex = 0
        Me.tabDespesaFixa.Location = New System.Drawing.Point(4, 61)
        Me.tabDespesaFixa.Margin = New System.Windows.Forms.Padding(2)
        Me.tabDespesaFixa.Name = "tabDespesaFixa"
        Me.tabDespesaFixa.Padding = New System.Windows.Forms.Padding(2)
        Me.tabDespesaFixa.Size = New System.Drawing.Size(1544, 481)
        Me.tabDespesaFixa.TabIndex = 2
        Me.tabDespesaFixa.Text = "Despesas Fixas"
        Me.tabDespesaFixa.UseVisualStyleBackColor = True
        '
        'btnLancamentoFuturo
        '
        Me.btnLancamentoFuturo.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddDespesa
        Me.btnLancamentoFuturo.Location = New System.Drawing.Point(42, 105)
        Me.btnLancamentoFuturo.Name = "btnLancamentoFuturo"
        Me.btnLancamentoFuturo.Size = New System.Drawing.Size(254, 42)
        Me.btnLancamentoFuturo.TabIndex = 11
        Me.btnLancamentoFuturo.Text = " &Gerar despesas futuras"
        Me.btnLancamentoFuturo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLancamentoFuturo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLancamentoFuturo.UseVisualStyleBackColor = True
        '
        'txtLetreiroFixa
        '
        Me.txtLetreiroFixa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiroFixa.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiroFixa.Location = New System.Drawing.Point(42, 434)
        Me.txtLetreiroFixa.Name = "txtLetreiroFixa"
        Me.txtLetreiroFixa.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Direita
        Me.txtLetreiroFixa.Size = New System.Drawing.Size(230, 18)
        Me.txtLetreiroFixa.TabIndex = 10
        Me.txtLetreiroFixa.TextoLetreiro = "0,00 Registros"
        Me.txtLetreiroFixa.VelocidadeRolagem = 1
        '
        'gbDespesaFixa
        '
        Me.gbDespesaFixa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDespesaFixa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbDespesaFixa.Controls.Add(Me.cbCategoriaFixa)
        Me.gbDespesaFixa.Controls.Add(Me.cbMesFixa)
        Me.gbDespesaFixa.Controls.Add(Me.cbPeriodo)
        Me.gbDespesaFixa.Controls.Add(Me.lblMesFixa)
        Me.gbDespesaFixa.Controls.Add(Me.lblCategoriaFixa)
        Me.gbDespesaFixa.Controls.Add(Me.lblPeriodo)
        Me.gbDespesaFixa.Location = New System.Drawing.Point(42, 5)
        Me.gbDespesaFixa.Name = "gbDespesaFixa"
        Me.gbDespesaFixa.Size = New System.Drawing.Size(1394, 94)
        Me.gbDespesaFixa.TabIndex = 0
        Me.gbDespesaFixa.TabStop = False
        Me.gbDespesaFixa.Text = "Filtro"
        '
        'cbCategoriaFixa
        '
        Me.cbCategoriaFixa.Alterado = False
        Me.cbCategoriaFixa.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbCategoriaFixa.CorFundo = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbCategoriaFixa.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbCategoriaFixa.CorTexto = System.Drawing.Color.Black
        Me.cbCategoriaFixa.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbCategoriaFixa.FormattingEnabled = True
        Me.cbCategoriaFixa.Location = New System.Drawing.Point(289, 50)
        Me.cbCategoriaFixa.Name = "cbCategoriaFixa"
        Me.cbCategoriaFixa.Size = New System.Drawing.Size(247, 26)
        Me.cbCategoriaFixa.SuperObrigatorio = False
        Me.cbCategoriaFixa.SuperTxtObrigatorio = ""
        Me.cbCategoriaFixa.TabIndex = 8
        '
        'cbMesFixa
        '
        Me.cbMesFixa.Alterado = False
        Me.cbMesFixa.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbMesFixa.CorFundo = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbMesFixa.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbMesFixa.CorTexto = System.Drawing.Color.Black
        Me.cbMesFixa.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbMesFixa.FormattingEnabled = True
        Me.cbMesFixa.Location = New System.Drawing.Point(575, 50)
        Me.cbMesFixa.Name = "cbMesFixa"
        Me.cbMesFixa.Size = New System.Drawing.Size(216, 26)
        Me.cbMesFixa.SuperObrigatorio = False
        Me.cbMesFixa.SuperTxtObrigatorio = ""
        Me.cbMesFixa.TabIndex = 7
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Alterado = False
        Me.cbPeriodo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbPeriodo.CorFundo = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbPeriodo.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbPeriodo.CorTexto = System.Drawing.Color.Black
        Me.cbPeriodo.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.Location = New System.Drawing.Point(70, 50)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(184, 26)
        Me.cbPeriodo.SuperObrigatorio = False
        Me.cbPeriodo.SuperTxtObrigatorio = ""
        Me.cbPeriodo.TabIndex = 6
        '
        'lblMesFixa
        '
        Me.lblMesFixa.AutoSize = True
        Me.lblMesFixa.Location = New System.Drawing.Point(572, 30)
        Me.lblMesFixa.Name = "lblMesFixa"
        Me.lblMesFixa.Size = New System.Drawing.Size(40, 18)
        Me.lblMesFixa.TabIndex = 5
        Me.lblMesFixa.Text = "Mês"
        '
        'lblCategoriaFixa
        '
        Me.lblCategoriaFixa.AutoSize = True
        Me.lblCategoriaFixa.Location = New System.Drawing.Point(286, 30)
        Me.lblCategoriaFixa.Name = "lblCategoriaFixa"
        Me.lblCategoriaFixa.Size = New System.Drawing.Size(87, 18)
        Me.lblCategoriaFixa.TabIndex = 3
        Me.lblCategoriaFixa.Text = "Categoria"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(67, 30)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(63, 18)
        Me.lblPeriodo.TabIndex = 1
        Me.lblPeriodo.Text = "A cada"
        '
        'tabDetalhe
        '
        Me.tabDetalhe.Controls.Add(Me.gbDetalhe)
        Me.tabDetalhe.ImageIndex = 3
        Me.tabDetalhe.Location = New System.Drawing.Point(4, 61)
        Me.tabDetalhe.Margin = New System.Windows.Forms.Padding(2)
        Me.tabDetalhe.Name = "tabDetalhe"
        Me.tabDetalhe.Padding = New System.Windows.Forms.Padding(2)
        Me.tabDetalhe.Size = New System.Drawing.Size(1544, 481)
        Me.tabDetalhe.TabIndex = 1
        Me.tabDetalhe.Text = "Detalhamento da Dívida"
        Me.tabDetalhe.UseVisualStyleBackColor = True
        '
        'gbDetalhe
        '
        Me.gbDetalhe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalhe.Controls.Add(Me.gbDadosDetalhe)
        Me.gbDetalhe.Controls.Add(Me.pnlDetalhe)
        Me.gbDetalhe.Location = New System.Drawing.Point(30, 4)
        Me.gbDetalhe.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDetalhe.Name = "gbDetalhe"
        Me.gbDetalhe.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDetalhe.Size = New System.Drawing.Size(1110, 426)
        Me.gbDetalhe.TabIndex = 9
        Me.gbDetalhe.TabStop = False
        Me.gbDetalhe.Text = "Despesa Parcelada"
        '
        'gbDadosDetalhe
        '
        Me.gbDadosDetalhe.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbDadosDetalhe.Controls.Add(Me.lblNaoPago)
        Me.gbDadosDetalhe.Controls.Add(Me.txtPago)
        Me.gbDadosDetalhe.Controls.Add(Me.lblPago)
        Me.gbDadosDetalhe.Controls.Add(Me.txtNaoPago)
        Me.gbDadosDetalhe.Controls.Add(Me.Label1)
        Me.gbDadosDetalhe.Controls.Add(Me.txtTotalDespesaDetalhe)
        Me.gbDadosDetalhe.Controls.Add(Me.lblTitulo)
        Me.gbDadosDetalhe.Controls.Add(Me.txtDescriaoDetalhe)
        Me.gbDadosDetalhe.Location = New System.Drawing.Point(41, 24)
        Me.gbDadosDetalhe.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDadosDetalhe.Name = "gbDadosDetalhe"
        Me.gbDadosDetalhe.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDadosDetalhe.Size = New System.Drawing.Size(1225, 116)
        Me.gbDadosDetalhe.TabIndex = 9
        Me.gbDadosDetalhe.TabStop = False
        '
        'lblNaoPago
        '
        Me.lblNaoPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNaoPago.AutoSize = True
        Me.lblNaoPago.Location = New System.Drawing.Point(893, 34)
        Me.lblNaoPago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNaoPago.Name = "lblNaoPago"
        Me.lblNaoPago.Size = New System.Drawing.Size(86, 18)
        Me.lblNaoPago.TabIndex = 15
        Me.lblNaoPago.Text = "Não Pago"
        '
        'txtPago
        '
        Me.txtPago.Alterado = False
        Me.txtPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtPago.BackColor = System.Drawing.Color.White
        Me.txtPago.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtPago.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtPago.Location = New System.Drawing.Point(721, 60)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.ReadOnly = True
        Me.txtPago.Size = New System.Drawing.Size(168, 24)
        Me.txtPago.SuperMascara = ""
        Me.txtPago.SuperObrigatorio = False
        Me.txtPago.SuperTravaErrors = False
        Me.txtPago.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtPago.SuperTxtObrigatorio = ""
        Me.txtPago.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtPago.TabIndex = 14
        '
        'lblPago
        '
        Me.lblPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPago.AutoSize = True
        Me.lblPago.Location = New System.Drawing.Point(718, 34)
        Me.lblPago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(48, 18)
        Me.lblPago.TabIndex = 13
        Me.lblPago.Text = "Pago"
        '
        'txtNaoPago
        '
        Me.txtNaoPago.Alterado = False
        Me.txtNaoPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtNaoPago.BackColor = System.Drawing.Color.White
        Me.txtNaoPago.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtNaoPago.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaoPago.ForeColor = System.Drawing.Color.Red
        Me.txtNaoPago.Location = New System.Drawing.Point(896, 60)
        Me.txtNaoPago.Name = "txtNaoPago"
        Me.txtNaoPago.ReadOnly = True
        Me.txtNaoPago.Size = New System.Drawing.Size(168, 24)
        Me.txtNaoPago.SuperMascara = ""
        Me.txtNaoPago.SuperObrigatorio = False
        Me.txtNaoPago.SuperTravaErrors = False
        Me.txtNaoPago.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNaoPago.SuperTxtObrigatorio = ""
        Me.txtNaoPago.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNaoPago.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(543, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Total da Despesa"
        '
        'txtTotalDespesaDetalhe
        '
        Me.txtTotalDespesaDetalhe.Alterado = False
        Me.txtTotalDespesaDetalhe.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTotalDespesaDetalhe.BackColor = System.Drawing.Color.White
        Me.txtTotalDespesaDetalhe.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtTotalDespesaDetalhe.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDespesaDetalhe.Location = New System.Drawing.Point(546, 60)
        Me.txtTotalDespesaDetalhe.Name = "txtTotalDespesaDetalhe"
        Me.txtTotalDespesaDetalhe.ReadOnly = True
        Me.txtTotalDespesaDetalhe.Size = New System.Drawing.Size(168, 24)
        Me.txtTotalDespesaDetalhe.SuperMascara = ""
        Me.txtTotalDespesaDetalhe.SuperObrigatorio = False
        Me.txtTotalDespesaDetalhe.SuperTravaErrors = False
        Me.txtTotalDespesaDetalhe.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTotalDespesaDetalhe.SuperTxtObrigatorio = ""
        Me.txtTotalDespesaDetalhe.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTotalDespesaDetalhe.TabIndex = 10
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(2, 34)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(188, 18)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Descrição da Despesa"
        '
        'txtDescriaoDetalhe
        '
        Me.txtDescriaoDetalhe.Alterado = False
        Me.txtDescriaoDetalhe.BackColor = System.Drawing.Color.White
        Me.txtDescriaoDetalhe.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtDescriaoDetalhe.Location = New System.Drawing.Point(6, 57)
        Me.txtDescriaoDetalhe.Name = "txtDescriaoDetalhe"
        Me.txtDescriaoDetalhe.ReadOnly = True
        Me.txtDescriaoDetalhe.Size = New System.Drawing.Size(506, 27)
        Me.txtDescriaoDetalhe.SuperMascara = ""
        Me.txtDescriaoDetalhe.SuperObrigatorio = False
        Me.txtDescriaoDetalhe.SuperTravaErrors = False
        Me.txtDescriaoDetalhe.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtDescriaoDetalhe.SuperTxtObrigatorio = ""
        Me.txtDescriaoDetalhe.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtDescriaoDetalhe.TabIndex = 6
        '
        'pnlDetalhe
        '
        Me.pnlDetalhe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetalhe.AutoScroll = True
        Me.pnlDetalhe.Location = New System.Drawing.Point(4, 128)
        Me.pnlDetalhe.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlDetalhe.Name = "pnlDetalhe"
        Me.pnlDetalhe.Size = New System.Drawing.Size(1105, 294)
        Me.pnlDetalhe.TabIndex = 10
        '
        'dgDespesaFixa
        '
        Me.dgDespesaFixa.AdicionarCheckBox = False
        Me.dgDespesaFixa.AllowUserToAddRows = False
        Me.dgDespesaFixa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDespesaFixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDespesaFixa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgDespesaFixa.BackgroundColor = System.Drawing.Color.White
        Me.dgDespesaFixa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDespesaFixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgDespesaFixa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDespesaFixa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgDespesaFixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDespesaFixa.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgDespesaFixa.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDespesaFixa.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgDespesaFixa.EnableHeadersVisualStyles = False
        Me.dgDespesaFixa.Location = New System.Drawing.Point(42, 153)
        Me.dgDespesaFixa.Name = "dgDespesaFixa"
        Me.dgDespesaFixa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgDespesaFixa.RowHeadersVisible = False
        Me.dgDespesaFixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDespesaFixa.Size = New System.Drawing.Size(1394, 275)
        Me.dgDespesaFixa.TabIndex = 12
        '
        'frmDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1552, 613)
        Me.Controls.Add(Me.tabCtrlDespesa)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDespesa"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbBotoes.ResumeLayout(False)
        Me.tabCtrlDespesa.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        Me.gbLegenda.ResumeLayout(False)
        Me.gbLegenda.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDespesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.tabDespesaFixa.ResumeLayout(False)
        Me.gbDespesaFixa.ResumeLayout(False)
        Me.gbDespesaFixa.PerformLayout()
        Me.tabDetalhe.ResumeLayout(False)
        Me.gbDetalhe.ResumeLayout(False)
        Me.gbDadosDetalhe.ResumeLayout(False)
        Me.gbDadosDetalhe.PerformLayout()
        CType(Me.dgDespesaFixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlDespesa As GFT.Util.SuperTabControl
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents gbFiltro As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbStatusFiltro As GFT.Util.SuperComboBox
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalDespesa As GFT.Util.SuperTextBox
    Friend WithEvents lblMes As Label
    Friend WithEvents cbMes As GFT.Util.SuperComboBox
    Friend WithEvents tabDetalhe As TabPage
    Friend WithEvents tabDespesaFixa As TabPage
    Friend WithEvents txtDescriaoDetalhe As GFT.Util.SuperTextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbDetalhe As GroupBox
    Friend WithEvents gbDadosDetalhe As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalDespesaDetalhe As GFT.Util.SuperTextBox
    Friend WithEvents lblNaoPago As Label
    Friend WithEvents txtPago As GFT.Util.SuperTextBox
    Friend WithEvents lblPago As Label
    Friend WithEvents txtNaoPago As GFT.Util.SuperTextBox
    Friend WithEvents pnlDetalhe As Panel
    Friend WithEvents gbDespesaFixa As GroupBox
    Friend WithEvents lblMesFixa As Label
    Friend WithEvents lblCategoriaFixa As Label
    Friend WithEvents lblPeriodo As Label
    Friend WithEvents cbCategoriaFixa As GFT.Util.SuperComboBox
    Friend WithEvents cbMesFixa As GFT.Util.SuperComboBox
    Friend WithEvents cbPeriodo As GFT.Util.SuperComboBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnStatusPago As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAddDespesa As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents chkList As CheckBox
    Friend WithEvents lblAno As Label
    Friend WithEvents cbAno As GFT.Util.SuperComboBox
    Friend WithEvents txtLetreiroDespesa As GFT.Util.SuperLetreiro
    Friend WithEvents txtLetreiroFixa As GFT.Util.SuperLetreiro
    Friend WithEvents btnLancamentoFuturo As Button
    Friend WithEvents ImgDespesa As ImageList
    Friend WithEvents dgDespesa As GFT.Util.SuperDataGridView
    Friend WithEvents gbLegenda As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgDespesaFixa As GFT.Util.SuperDataGridView
End Class
