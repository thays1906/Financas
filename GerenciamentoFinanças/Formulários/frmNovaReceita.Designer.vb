﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNovaReceita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovaReceita))
        Me.tabAddReceita = New GFT.Util.SuperTabControl()
        Me.tpAddReceita = New System.Windows.Forms.TabPage()
        Me.lblTipoConta = New System.Windows.Forms.Label()
        Me.cbTipoConta = New GFT.Util.SuperComboBox()
        Me.txtDescricao = New GFT.Util.SuperTextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblTipoReceita = New System.Windows.Forms.Label()
        Me.cbTipoReceita = New GFT.Util.SuperComboBox()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.cbConta = New GFT.Util.SuperComboBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtReceita = New GFT.Util.SuperDatePicker()
        Me.txtValor = New GFT.Util.SuperTextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.btnSalvar = New GFT.Util.SuperButton()
        Me.btnFechar = New GFT.Util.SuperButton()
        Me.tabAddReceita.SuspendLayout()
        Me.tpAddReceita.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabAddReceita
        '
        Me.tabAddReceita.Controls.Add(Me.tpAddReceita)
        Me.tabAddReceita.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAddReceita.HotTrack = True
        Me.tabAddReceita.Location = New System.Drawing.Point(37, 15)
        Me.tabAddReceita.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAddReceita.Name = "tabAddReceita"
        Me.tabAddReceita.Padding = New System.Drawing.Point(50, 5)
        Me.tabAddReceita.SelectedIndex = 0
        Me.tabAddReceita.Size = New System.Drawing.Size(719, 324)
        Me.tabAddReceita.TabIndex = 3
        '
        'tpAddReceita
        '
        Me.tpAddReceita.Controls.Add(Me.lblTipoConta)
        Me.tpAddReceita.Controls.Add(Me.cbTipoConta)
        Me.tpAddReceita.Controls.Add(Me.txtDescricao)
        Me.tpAddReceita.Controls.Add(Me.lblDescricao)
        Me.tpAddReceita.Controls.Add(Me.lblTipoReceita)
        Me.tpAddReceita.Controls.Add(Me.cbTipoReceita)
        Me.tpAddReceita.Controls.Add(Me.lblConta)
        Me.tpAddReceita.Controls.Add(Me.cbConta)
        Me.tpAddReceita.Controls.Add(Me.lblData)
        Me.tpAddReceita.Controls.Add(Me.dtReceita)
        Me.tpAddReceita.Controls.Add(Me.txtValor)
        Me.tpAddReceita.Controls.Add(Me.lblValor)
        Me.tpAddReceita.Location = New System.Drawing.Point(4, 37)
        Me.tpAddReceita.Margin = New System.Windows.Forms.Padding(4)
        Me.tpAddReceita.Name = "tpAddReceita"
        Me.tpAddReceita.Padding = New System.Windows.Forms.Padding(4)
        Me.tpAddReceita.Size = New System.Drawing.Size(711, 283)
        Me.tpAddReceita.TabIndex = 0
        Me.tpAddReceita.Text = "Adicionar Receita"
        Me.tpAddReceita.UseVisualStyleBackColor = True
        '
        'lblTipoConta
        '
        Me.lblTipoConta.AutoSize = True
        Me.lblTipoConta.Location = New System.Drawing.Point(23, 240)
        Me.lblTipoConta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoConta.Name = "lblTipoConta"
        Me.lblTipoConta.Size = New System.Drawing.Size(142, 24)
        Me.lblTipoConta.TabIndex = 13
        Me.lblTipoConta.Text = "Tipo de Conta:"
        '
        'cbTipoConta
        '
        Me.cbTipoConta.Alterado = False
        Me.cbTipoConta.BackColor = System.Drawing.Color.White
        Me.cbTipoConta.CorFundo = System.Drawing.Color.White
        Me.cbTipoConta.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTipoConta.CorTexto = System.Drawing.SystemColors.InfoText
        Me.cbTipoConta.CorTextoSelecionado = System.Drawing.SystemColors.WindowText
        Me.cbTipoConta.DropDownHeight = 200
        Me.cbTipoConta.DropDownWidth = 200
        Me.cbTipoConta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoConta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cbTipoConta.FormattingEnabled = True
        Me.cbTipoConta.IntegralHeight = False
        Me.cbTipoConta.Location = New System.Drawing.Point(197, 237)
        Me.cbTipoConta.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTipoConta.Name = "cbTipoConta"
        Me.cbTipoConta.Size = New System.Drawing.Size(316, 32)
        Me.cbTipoConta.SuperObrigatorio = True
        Me.cbTipoConta.SuperTxtObrigatorio = "Tipo de receita"
        Me.cbTipoConta.TabIndex = 12
        '
        'txtDescricao
        '
        Me.txtDescricao.Alterado = False
        Me.txtDescricao.BackColor = System.Drawing.Color.White
        Me.txtDescricao.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtDescricao.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(197, 73)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(506, 32)
        Me.txtDescricao.SuperMascara = "0.00"
        Me.txtDescricao.SuperObrigatorio = False
        Me.txtDescricao.SuperTravaErrors = False
        Me.txtDescricao.SuperTxtCorDesabilitado = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescricao.SuperTxtObrigatorio = ""
        Me.txtDescricao.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtDescricao.TabIndex = 10
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(23, 73)
        Me.lblDescricao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(103, 24)
        Me.lblDescricao.TabIndex = 11
        Me.lblDescricao.Text = "Descricão:"
        '
        'lblTipoReceita
        '
        Me.lblTipoReceita.AutoSize = True
        Me.lblTipoReceita.Location = New System.Drawing.Point(23, 159)
        Me.lblTipoReceita.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoReceita.Name = "lblTipoReceita"
        Me.lblTipoReceita.Size = New System.Drawing.Size(156, 24)
        Me.lblTipoReceita.TabIndex = 7
        Me.lblTipoReceita.Text = "Tipo de Receita:"
        '
        'cbTipoReceita
        '
        Me.cbTipoReceita.Alterado = False
        Me.cbTipoReceita.BackColor = System.Drawing.Color.White
        Me.cbTipoReceita.CorFundo = System.Drawing.Color.White
        Me.cbTipoReceita.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTipoReceita.CorTexto = System.Drawing.SystemColors.InfoText
        Me.cbTipoReceita.CorTextoSelecionado = System.Drawing.SystemColors.WindowText
        Me.cbTipoReceita.DropDownHeight = 200
        Me.cbTipoReceita.DropDownWidth = 200
        Me.cbTipoReceita.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoReceita.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cbTipoReceita.FormattingEnabled = True
        Me.cbTipoReceita.IntegralHeight = False
        Me.cbTipoReceita.Location = New System.Drawing.Point(197, 156)
        Me.cbTipoReceita.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTipoReceita.Name = "cbTipoReceita"
        Me.cbTipoReceita.Size = New System.Drawing.Size(244, 32)
        Me.cbTipoReceita.SuperObrigatorio = True
        Me.cbTipoReceita.SuperTxtObrigatorio = "Tipo de receita"
        Me.cbTipoReceita.TabIndex = 6
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(23, 199)
        Me.lblConta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(69, 24)
        Me.lblConta.TabIndex = 5
        Me.lblConta.Text = "Conta:"
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.BackColor = System.Drawing.Color.White
        Me.cbConta.CorFundo = System.Drawing.Color.White
        Me.cbConta.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbConta.CorTexto = System.Drawing.SystemColors.InfoText
        Me.cbConta.CorTextoSelecionado = System.Drawing.SystemColors.WindowText
        Me.cbConta.DropDownHeight = 300
        Me.cbConta.DropDownWidth = 200
        Me.cbConta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.IntegralHeight = False
        Me.cbConta.ItemHeight = 24
        Me.cbConta.Location = New System.Drawing.Point(197, 196)
        Me.cbConta.Margin = New System.Windows.Forms.Padding(4)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(316, 32)
        Me.cbConta.SuperObrigatorio = True
        Me.cbConta.SuperTxtObrigatorio = "Conta bancária"
        Me.cbConta.TabIndex = 4
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(23, 13)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(60, 24)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data:"
        '
        'dtReceita
        '
        Me.dtReceita.Alterado = False
        Me.dtReceita.BackColor = System.Drawing.Color.White
        Me.dtReceita.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.dtReceita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReceita.Location = New System.Drawing.Point(91, 7)
        Me.dtReceita.Margin = New System.Windows.Forms.Padding(4)
        Me.dtReceita.Name = "dtReceita"
        Me.dtReceita.Size = New System.Drawing.Size(161, 32)
        Me.dtReceita.TabIndex = 2
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(197, 112)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(244, 32)
        Me.txtValor.SuperMascara = ""
        Me.txtValor.SuperObrigatorio = False
        Me.txtValor.SuperTravaErrors = False
        Me.txtValor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor.SuperTxtObrigatorio = "Valor da Receita"
        Me.txtValor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor.TabIndex = 0
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(23, 115)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(56, 24)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor"
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.icon_Salvar_png
        Me.btnSalvar.Location = New System.Drawing.Point(191, 357)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(183, 49)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "  &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.BackgroundImage = CType(resources.GetObject("btnFechar.BackgroundImage"), System.Drawing.Image)
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(432, 357)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(183, 49)
        Me.btnFechar.TabIndex = 9
        Me.btnFechar.Text = "  &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmNovaReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 425)
        Me.Controls.Add(Me.tabAddReceita)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnFechar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNovaReceita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receita"
        Me.tabAddReceita.ResumeLayout(False)
        Me.tpAddReceita.ResumeLayout(False)
        Me.tpAddReceita.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtValor As GFT.Util.SuperTextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents dtReceita As GFT.Util.SuperDatePicker
    Friend WithEvents tabAddReceita As GFT.Util.SuperTabControl
    Friend WithEvents tpAddReceita As TabPage
    Friend WithEvents btnSalvar As GFT.Util.SuperButton
    Friend WithEvents lblTipoReceita As Label
    Friend WithEvents cbTipoReceita As GFT.Util.SuperComboBox
    Friend WithEvents lblConta As Label
    Friend WithEvents cbConta As GFT.Util.SuperComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents btnFechar As GFT.Util.SuperButton
    Friend WithEvents txtDescricao As GFT.Util.SuperTextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblTipoConta As Label
    Friend WithEvents cbTipoConta As GFT.Util.SuperComboBox
End Class
