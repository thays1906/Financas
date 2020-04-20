<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNovaReceita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovaReceita))
        Me.SuperTextBox1 = New GFT.Util.SuperTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuperDatePicker1 = New GFT.Util.SuperDatePicker()
        Me.SuperTabControl1 = New GFT.Util.SuperTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuperComboBox1 = New GFT.Util.SuperComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuperComboBox2 = New GFT.Util.SuperComboBox()
        Me.btnSalvar = New GFT.Util.SuperButton()
        Me.btnFechar = New GFT.Util.SuperButton()
        Me.SuperTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SuperTextBox1
        '
        Me.SuperTextBox1.Alterado = False
        Me.SuperTextBox1.BackColor = System.Drawing.Color.White
        Me.SuperTextBox1.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.SuperTextBox1.Location = New System.Drawing.Point(15, 92)
        Me.SuperTextBox1.Name = "SuperTextBox1"
        Me.SuperTextBox1.Size = New System.Drawing.Size(151, 20)
        Me.SuperTextBox1.SuperMascara = ""
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
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor"
        '
        'SuperDatePicker1
        '
        Me.SuperDatePicker1.Alterado = False
        Me.SuperDatePicker1.BackColor = System.Drawing.Color.White
        Me.SuperDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SuperDatePicker1.Location = New System.Drawing.Point(15, 37)
        Me.SuperDatePicker1.Name = "SuperDatePicker1"
        Me.SuperDatePicker1.Size = New System.Drawing.Size(97, 20)
        Me.SuperDatePicker1.TabIndex = 2
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.Controls.Add(Me.TabPage1)
        Me.SuperTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.SelectedIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(443, 296)
        Me.SuperTabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnFechar)
        Me.TabPage1.Controls.Add(Me.btnSalvar)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.SuperComboBox2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.SuperComboBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.SuperDatePicker1)
        Me.TabPage1.Controls.Add(Me.SuperTextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(435, 270)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Adicionar Receita"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data:"
        '
        'SuperComboBox1
        '
        Me.SuperComboBox1.Alterado = False
        Me.SuperComboBox1.FormattingEnabled = True
        Me.SuperComboBox1.Location = New System.Drawing.Point(261, 40)
        Me.SuperComboBox1.Name = "SuperComboBox1"
        Me.SuperComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.SuperComboBox1.SuperObrigatorio = False
        Me.SuperComboBox1.SuperTxtObrigatorio = ""
        Me.SuperComboBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Conta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Categoria:"
        '
        'SuperComboBox2
        '
        Me.SuperComboBox2.Alterado = False
        Me.SuperComboBox2.FormattingEnabled = True
        Me.SuperComboBox2.Location = New System.Drawing.Point(261, 92)
        Me.SuperComboBox2.Name = "SuperComboBox2"
        Me.SuperComboBox2.Size = New System.Drawing.Size(168, 21)
        Me.SuperComboBox2.SuperObrigatorio = False
        Me.SuperComboBox2.SuperTxtObrigatorio = ""
        Me.SuperComboBox2.TabIndex = 6
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
        'frmNovaReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(467, 320)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNovaReceita"
        Me.Text = "Receita"
        Me.SuperTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SuperTextBox1 As GFT.Util.SuperTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SuperDatePicker1 As GFT.Util.SuperDatePicker
    Friend WithEvents SuperTabControl1 As GFT.Util.SuperTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSalvar As GFT.Util.SuperButton
    Friend WithEvents Label4 As Label
    Friend WithEvents SuperComboBox2 As GFT.Util.SuperComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SuperComboBox1 As GFT.Util.SuperComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFechar As GFT.Util.SuperButton
End Class
