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
        Me.txtValor = New GFT.Util.SuperTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtReceita = New GFT.Util.SuperDatePicker()
        Me.tabAddReceita = New GFT.Util.SuperTabControl()
        Me.tpAddReceita = New System.Windows.Forms.TabPage()
        Me.txtDescricao = New GFT.Util.SuperTextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.btnFechar = New GFT.Util.SuperButton()
        Me.btnSalvar = New GFT.Util.SuperButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTipoReceita = New GFT.Util.SuperComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbConta = New GFT.Util.SuperComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabAddReceita.SuspendLayout()
        Me.tpAddReceita.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValor.Location = New System.Drawing.Point(357, 103)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(168, 25)
        Me.txtValor.SuperMascara = ""
        Me.txtValor.SuperObrigatorio = False
        Me.txtValor.SuperTravaErrors = False
        Me.txtValor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor.SuperTxtObrigatorio = ""
        Me.txtValor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtValor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(354, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor"
        '
        'dtReceita
        '
        Me.dtReceita.Alterado = False
        Me.dtReceita.BackColor = System.Drawing.Color.White
        Me.dtReceita.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.dtReceita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReceita.Location = New System.Drawing.Point(15, 41)
        Me.dtReceita.Name = "dtReceita"
        Me.dtReceita.Size = New System.Drawing.Size(122, 25)
        Me.dtReceita.TabIndex = 2
        '
        'tabAddReceita
        '
        Me.tabAddReceita.Controls.Add(Me.tpAddReceita)
        Me.tabAddReceita.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAddReceita.Location = New System.Drawing.Point(28, 12)
        Me.tabAddReceita.Name = "tabAddReceita"
        Me.tabAddReceita.SelectedIndex = 0
        Me.tabAddReceita.Size = New System.Drawing.Size(539, 296)
        Me.tabAddReceita.TabIndex = 3
        '
        'tpAddReceita
        '
        Me.tpAddReceita.Controls.Add(Me.txtDescricao)
        Me.tpAddReceita.Controls.Add(Me.lblDescricao)
        Me.tpAddReceita.Controls.Add(Me.btnFechar)
        Me.tpAddReceita.Controls.Add(Me.btnSalvar)
        Me.tpAddReceita.Controls.Add(Me.Label4)
        Me.tpAddReceita.Controls.Add(Me.cbTipoReceita)
        Me.tpAddReceita.Controls.Add(Me.Label3)
        Me.tpAddReceita.Controls.Add(Me.cbConta)
        Me.tpAddReceita.Controls.Add(Me.Label2)
        Me.tpAddReceita.Controls.Add(Me.dtReceita)
        Me.tpAddReceita.Controls.Add(Me.txtValor)
        Me.tpAddReceita.Controls.Add(Me.Label1)
        Me.tpAddReceita.Location = New System.Drawing.Point(4, 26)
        Me.tpAddReceita.Name = "tpAddReceita"
        Me.tpAddReceita.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAddReceita.Size = New System.Drawing.Size(531, 266)
        Me.tpAddReceita.TabIndex = 0
        Me.tpAddReceita.Text = "Adicionar Receita"
        Me.tpAddReceita.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.Alterado = False
        Me.txtDescricao.BackColor = System.Drawing.Color.White
        Me.txtDescricao.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtDescricao.Location = New System.Drawing.Point(15, 103)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(238, 25)
        Me.txtDescricao.SuperMascara = "0.00"
        Me.txtDescricao.SuperObrigatorio = False
        Me.txtDescricao.SuperTravaErrors = False
        Me.txtDescricao.SuperTxtCorDesabilitado = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescricao.SuperTxtObrigatorio = ""
        Me.txtDescricao.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtDescricao.TabIndex = 10
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(12, 83)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(79, 17)
        Me.lblDescricao.TabIndex = 11
        Me.lblDescricao.Text = "Descricão:"
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
        Me.btnFechar.Location = New System.Drawing.Point(388, 220)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(137, 40)
        Me.btnFechar.TabIndex = 9
        Me.btnFechar.Text = "  &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
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
        Me.btnSalvar.Location = New System.Drawing.Point(245, 220)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(137, 40)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "  &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo de Receita:"
        '
        'cbTipoReceita
        '
        Me.cbTipoReceita.Alterado = False
        Me.cbTipoReceita.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbTipoReceita.DropDownHeight = 200
        Me.cbTipoReceita.DropDownWidth = 200
        Me.cbTipoReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoReceita.FormattingEnabled = True
        Me.cbTipoReceita.IntegralHeight = False
        Me.cbTipoReceita.Location = New System.Drawing.Point(161, 44)
        Me.cbTipoReceita.Name = "cbTipoReceita"
        Me.cbTipoReceita.Size = New System.Drawing.Size(168, 25)
        Me.cbTipoReceita.SuperObrigatorio = True
        Me.cbTipoReceita.SuperTxtObrigatorio = ""
        Me.cbTipoReceita.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Conta:"
        '
        'cbConta
        '
        Me.cbConta.Alterado = False
        Me.cbConta.BackColor = System.Drawing.SystemColors.Control
        Me.cbConta.DropDownHeight = 300
        Me.cbConta.DropDownWidth = 300
        Me.cbConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbConta.FormattingEnabled = True
        Me.cbConta.IntegralHeight = False
        Me.cbConta.ItemHeight = 17
        Me.cbConta.Location = New System.Drawing.Point(357, 44)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(153, 25)
        Me.cbConta.SuperObrigatorio = True
        Me.cbConta.SuperTxtObrigatorio = ""
        Me.cbConta.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data:"
        '
        'frmNovaReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(594, 320)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents dtReceita As GFT.Util.SuperDatePicker
    Friend WithEvents tabAddReceita As GFT.Util.SuperTabControl
    Friend WithEvents tpAddReceita As TabPage
    Friend WithEvents btnSalvar As GFT.Util.SuperButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTipoReceita As GFT.Util.SuperComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbConta As GFT.Util.SuperComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFechar As GFT.Util.SuperButton
    Friend WithEvents txtDescricao As GFT.Util.SuperTextBox
    Friend WithEvents lblDescricao As Label
End Class
