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
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.tabAddReceita.SuspendLayout()
        Me.tpAddReceita.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabAddReceita
        '
        Me.tabAddReceita.Controls.Add(Me.tpAddReceita)
        Me.tabAddReceita.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAddReceita.HotTrack = True
        Me.tabAddReceita.Location = New System.Drawing.Point(29, 52)
        Me.tabAddReceita.Name = "tabAddReceita"
        Me.tabAddReceita.Padding = New System.Drawing.Point(50, 10)
        Me.tabAddReceita.SelectedIndex = 0
        Me.tabAddReceita.Size = New System.Drawing.Size(539, 278)
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
        Me.tpAddReceita.Location = New System.Drawing.Point(4, 42)
        Me.tpAddReceita.Name = "tpAddReceita"
        Me.tpAddReceita.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAddReceita.Size = New System.Drawing.Size(531, 232)
        Me.tpAddReceita.TabIndex = 0
        Me.tpAddReceita.Text = "Adicionar Receita"
        Me.tpAddReceita.UseVisualStyleBackColor = True
        '
        'lblTipoConta
        '
        Me.lblTipoConta.AutoSize = True
        Me.lblTipoConta.Location = New System.Drawing.Point(17, 195)
        Me.lblTipoConta.Name = "lblTipoConta"
        Me.lblTipoConta.Size = New System.Drawing.Size(115, 19)
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
        Me.cbTipoConta.Location = New System.Drawing.Point(148, 193)
        Me.cbTipoConta.Name = "cbTipoConta"
        Me.cbTipoConta.Size = New System.Drawing.Size(238, 27)
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
        Me.txtDescricao.Location = New System.Drawing.Point(148, 59)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(380, 27)
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
        Me.lblDescricao.Location = New System.Drawing.Point(17, 59)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(82, 19)
        Me.lblDescricao.TabIndex = 11
        Me.lblDescricao.Text = "Descricão:"
        '
        'lblTipoReceita
        '
        Me.lblTipoReceita.AutoSize = True
        Me.lblTipoReceita.Location = New System.Drawing.Point(17, 129)
        Me.lblTipoReceita.Name = "lblTipoReceita"
        Me.lblTipoReceita.Size = New System.Drawing.Size(124, 19)
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
        Me.cbTipoReceita.Location = New System.Drawing.Point(148, 127)
        Me.cbTipoReceita.Name = "cbTipoReceita"
        Me.cbTipoReceita.Size = New System.Drawing.Size(184, 27)
        Me.cbTipoReceita.SuperObrigatorio = True
        Me.cbTipoReceita.SuperTxtObrigatorio = "Tipo de receita"
        Me.cbTipoReceita.TabIndex = 6
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(17, 162)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(56, 19)
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
        Me.cbConta.ItemHeight = 19
        Me.cbConta.Location = New System.Drawing.Point(148, 159)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(238, 27)
        Me.cbConta.SuperObrigatorio = True
        Me.cbConta.SuperTxtObrigatorio = "Conta bancária"
        Me.cbConta.TabIndex = 4
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(17, 11)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(47, 19)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data:"
        '
        'dtReceita
        '
        Me.dtReceita.Alterado = False
        Me.dtReceita.BackColor = System.Drawing.Color.White
        Me.dtReceita.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.dtReceita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReceita.Location = New System.Drawing.Point(68, 6)
        Me.dtReceita.Name = "dtReceita"
        Me.dtReceita.Size = New System.Drawing.Size(122, 27)
        Me.dtReceita.TabIndex = 2
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(148, 91)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(184, 27)
        Me.txtValor.SuperMascara = "R$0,00"
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
        Me.lblValor.Location = New System.Drawing.Point(17, 93)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(46, 19)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor"
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(524, -2)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(71, 52)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.icon_Salvar_png
        Me.btnSalvar.Location = New System.Drawing.Point(181, 344)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 42)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'frmNovaReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(594, 406)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.tabAddReceita)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents lblTipoReceita As Label
    Friend WithEvents cbTipoReceita As GFT.Util.SuperComboBox
    Friend WithEvents lblConta As Label
    Friend WithEvents cbConta As GFT.Util.SuperComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents txtDescricao As GFT.Util.SuperTextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblTipoConta As Label
    Friend WithEvents cbTipoConta As GFT.Util.SuperComboBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
End Class
