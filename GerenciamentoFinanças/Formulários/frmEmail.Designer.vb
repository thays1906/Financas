<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmail
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgNormal = New System.Windows.Forms.DataGridView()
        Me.chkEMail = New System.Windows.Forms.CheckBox()
        Me.txtObter = New System.Windows.Forms.TextBox()
        Me.btnObter = New System.Windows.Forms.Button()
        Me.dgConsulta = New GFT.Util.SuperDataGridView()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn2.HeaderText = ""
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 125
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn3.HeaderText = ""
        Me.DataGridViewCheckBoxColumn3.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 125
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn4.HeaderText = ""
        Me.DataGridViewCheckBoxColumn4.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 125
        '
        'dgNormal
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgNormal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgNormal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgNormal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgNormal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgNormal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgNormal.GridColor = System.Drawing.Color.Crimson
        Me.dgNormal.Location = New System.Drawing.Point(50, 12)
        Me.dgNormal.MultiSelect = False
        Me.dgNormal.Name = "dgNormal"
        Me.dgNormal.RowHeadersVisible = False
        Me.dgNormal.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgNormal.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgNormal.RowTemplate.Height = 24
        Me.dgNormal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgNormal.Size = New System.Drawing.Size(1190, 247)
        Me.dgNormal.TabIndex = 1
        '
        'chkEMail
        '
        Me.chkEMail.AutoSize = True
        Me.chkEMail.Location = New System.Drawing.Point(50, 265)
        Me.chkEMail.Name = "chkEMail"
        Me.chkEMail.Size = New System.Drawing.Size(142, 21)
        Me.chkEMail.TabIndex = 3
        Me.chkEMail.Text = "Marca/Desmarcar"
        Me.chkEMail.UseVisualStyleBackColor = True
        '
        'txtObter
        '
        Me.txtObter.Location = New System.Drawing.Point(231, 265)
        Me.txtObter.Name = "txtObter"
        Me.txtObter.Size = New System.Drawing.Size(129, 22)
        Me.txtObter.TabIndex = 5
        '
        'btnObter
        '
        Me.btnObter.Location = New System.Drawing.Point(402, 260)
        Me.btnObter.Name = "btnObter"
        Me.btnObter.Size = New System.Drawing.Size(145, 27)
        Me.btnObter.TabIndex = 6
        Me.btnObter.Text = "Obter"
        Me.btnObter.UseVisualStyleBackColor = True
        '
        'dgConsulta
        '
        Me.dgConsulta.AdicionarCheckBox = True
        Me.dgConsulta.AllowUserToAddRows = False
        Me.dgConsulta.AllowUserToDeleteRows = False
        Me.dgConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgConsulta.BackgroundColor = System.Drawing.Color.White
        Me.dgConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn5})
        Me.dgConsulta.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgConsulta.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgConsulta.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgConsulta.EnableHeadersVisualStyles = False
        Me.dgConsulta.Location = New System.Drawing.Point(50, 292)
        Me.dgConsulta.Name = "dgConsulta"
        Me.dgConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgConsulta.RowHeadersVisible = False
        Me.dgConsulta.RowHeadersWidth = 51
        Me.dgConsulta.RowTemplate.Height = 24
        Me.dgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsulta.Size = New System.Drawing.Size(1207, 203)
        Me.dgConsulta.TabIndex = 2
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn5.HeaderText = ""
        Me.DataGridViewCheckBoxColumn5.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.Width = 125
        '
        'frmEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1281, 526)
        Me.Controls.Add(Me.btnObter)
        Me.Controls.Add(Me.txtObter)
        Me.Controls.Add(Me.chkEMail)
        Me.Controls.Add(Me.dgConsulta)
        Me.Controls.Add(Me.dgNormal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEmail"
        Me.Text = "Envio de E-mail"
        CType(Me.dgNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents dgNormal As DataGridView
    Friend WithEvents dgConsulta As GFT.Util.SuperDataGridView
    Friend WithEvents chkEMail As CheckBox
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents txtObter As TextBox
    Friend WithEvents btnObter As Button
End Class
