<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNovaDespesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovaDespesa))
        Me.tabDespesa = New GFT.Util.SuperTabControl()
        Me.tpAddDespesa = New System.Windows.Forms.TabPage()
        Me.btnFechar = New GFT.Util.SuperButton()
        Me.btnSalvar = New GFT.Util.SuperButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuperComboBox2 = New GFT.Util.SuperComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuperComboBox1 = New GFT.Util.SuperComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuperDatePicker1 = New GFT.Util.SuperDatePicker()
        Me.SuperTextBox1 = New GFT.Util.SuperTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabDespesa.SuspendLayout()
        Me.tpAddDespesa.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabDespesa
        '
        Me.tabDespesa.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabDespesa.Controls.Add(Me.tpAddDespesa)
        Me.tabDespesa.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDespesa.HotTrack = True
        Me.tabDespesa.Location = New System.Drawing.Point(30, 24)
        Me.tabDespesa.Name = "tabDespesa"
        Me.tabDespesa.Padding = New System.Drawing.Point(50, 10)
        Me.tabDespesa.SelectedIndex = 0
        Me.tabDespesa.Size = New System.Drawing.Size(443, 296)
        Me.tabDespesa.TabIndex = 4
        '
        'tpAddDespesa
        '
        Me.tpAddDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpAddDespesa.Controls.Add(Me.btnFechar)
        Me.tpAddDespesa.Controls.Add(Me.btnSalvar)
        Me.tpAddDespesa.Controls.Add(Me.Label4)
        Me.tpAddDespesa.Controls.Add(Me.SuperComboBox2)
        Me.tpAddDespesa.Controls.Add(Me.Label3)
        Me.tpAddDespesa.Controls.Add(Me.SuperComboBox1)
        Me.tpAddDespesa.Controls.Add(Me.Label2)
        Me.tpAddDespesa.Controls.Add(Me.SuperDatePicker1)
        Me.tpAddDespesa.Controls.Add(Me.SuperTextBox1)
        Me.tpAddDespesa.Controls.Add(Me.Label1)
        Me.tpAddDespesa.Location = New System.Drawing.Point(4, 43)
        Me.tpAddDespesa.Name = "tpAddDespesa"
        Me.tpAddDespesa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAddDespesa.Size = New System.Drawing.Size(435, 249)
        Me.tpAddDespesa.TabIndex = 0
        Me.tpAddDespesa.Text = "Adicionar Despesa"
        Me.tpAddDespesa.UseVisualStyleBackColor = True
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
        Me.btnFechar.Location = New System.Drawing.Point(274, 183)
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
        Me.btnSalvar.Location = New System.Drawing.Point(67, 183)
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
        Me.Label4.Location = New System.Drawing.Point(258, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Categoria:"
        '
        'SuperComboBox2
        '
        Me.SuperComboBox2.Alterado = False
        Me.SuperComboBox2.FormattingEnabled = True
        Me.SuperComboBox2.Location = New System.Drawing.Point(261, 92)
        Me.SuperComboBox2.Name = "SuperComboBox2"
        Me.SuperComboBox2.Size = New System.Drawing.Size(168, 25)
        Me.SuperComboBox2.SuperObrigatorio = False
        Me.SuperComboBox2.SuperTxtObrigatorio = ""
        Me.SuperComboBox2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Conta:"
        '
        'SuperComboBox1
        '
        Me.SuperComboBox1.Alterado = False
        Me.SuperComboBox1.FormattingEnabled = True
        Me.SuperComboBox1.Location = New System.Drawing.Point(261, 40)
        Me.SuperComboBox1.Name = "SuperComboBox1"
        Me.SuperComboBox1.Size = New System.Drawing.Size(168, 25)
        Me.SuperComboBox1.SuperObrigatorio = False
        Me.SuperComboBox1.SuperTxtObrigatorio = ""
        Me.SuperComboBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data:"
        '
        'SuperDatePicker1
        '
        Me.SuperDatePicker1.Alterado = False
        Me.SuperDatePicker1.BackColor = System.Drawing.Color.White
        Me.SuperDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SuperDatePicker1.Location = New System.Drawing.Point(15, 37)
        Me.SuperDatePicker1.Name = "SuperDatePicker1"
        Me.SuperDatePicker1.Size = New System.Drawing.Size(97, 25)
        Me.SuperDatePicker1.TabIndex = 2
        '
        'SuperTextBox1
        '
        Me.SuperTextBox1.Alterado = False
        Me.SuperTextBox1.BackColor = System.Drawing.Color.White
        Me.SuperTextBox1.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.SuperTextBox1.Location = New System.Drawing.Point(15, 92)
        Me.SuperTextBox1.Name = "SuperTextBox1"
        Me.SuperTextBox1.Size = New System.Drawing.Size(151, 25)
        Me.SuperTextBox1.SuperMascara = "0.00"
        Me.SuperTextBox1.SuperObrigatorio = False
        Me.SuperTextBox1.SuperTravaErrors = False
        Me.SuperTextBox1.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.SuperTextBox1.SuperTxtObrigatorio = ""
        Me.SuperTextBox1.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.SuperTextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor"
        '
        'frmNovaDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(501, 342)
        Me.Controls.Add(Me.tabDespesa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNovaDespesa"
        Me.Text = "frmNovaDespesa"
        Me.tabDespesa.ResumeLayout(False)
        Me.tpAddDespesa.ResumeLayout(False)
        Me.tpAddDespesa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabDespesa As GFT.Util.SuperTabControl
    Friend WithEvents tpAddDespesa As TabPage
    Friend WithEvents btnFechar As GFT.Util.SuperButton
    Friend WithEvents btnSalvar As GFT.Util.SuperButton
    Friend WithEvents Label4 As Label
    Friend WithEvents SuperComboBox2 As GFT.Util.SuperComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SuperComboBox1 As GFT.Util.SuperComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SuperDatePicker1 As GFT.Util.SuperDatePicker
    Friend WithEvents SuperTextBox1 As GFT.Util.SuperTextBox
    Friend WithEvents Label1 As Label
End Class
