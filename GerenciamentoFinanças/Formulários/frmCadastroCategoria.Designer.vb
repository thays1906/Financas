<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroCategoria
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
        Me.components = New System.ComponentModel.Container()
        Me.txtNovaCategoria = New GFT.Util.SuperTextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblNovaPag = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtNovaCategoria
        '
        Me.txtNovaCategoria.Alterado = False
        Me.txtNovaCategoria.BackColor = System.Drawing.Color.White
        Me.txtNovaCategoria.CorFundoSelecionado = System.Drawing.Color.White
        Me.txtNovaCategoria.Location = New System.Drawing.Point(137, 82)
        Me.txtNovaCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNovaCategoria.Name = "txtNovaCategoria"
        Me.txtNovaCategoria.Size = New System.Drawing.Size(262, 28)
        Me.txtNovaCategoria.SuperMascara = ""
        Me.txtNovaCategoria.SuperObrigatorio = False
        Me.txtNovaCategoria.SuperTravaErrors = False
        Me.txtNovaCategoria.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNovaCategoria.SuperTxtObrigatorio = ""
        Me.txtNovaCategoria.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNovaCategoria.TabIndex = 0
        Me.txtNovaCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.icon_Salvar_png
        Me.btnSalvar.Location = New System.Drawing.Point(165, 134)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(199, 42)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'lblNovaPag
        '
        Me.lblNovaPag.AutoSize = True
        Me.lblNovaPag.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNovaPag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNovaPag.Location = New System.Drawing.Point(132, 49)
        Me.lblNovaPag.Name = "lblNovaPag"
        Me.lblNovaPag.Size = New System.Drawing.Size(67, 29)
        Me.lblNovaPag.TabIndex = 2
        Me.lblNovaPag.Text = "Novo"
        '
        'btnFechar
        '
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(480, 0)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(47, 42)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnFechar, "Fechar")
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmCadastroCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 202)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.txtNovaCategoria)
        Me.Controls.Add(Me.lblNovaPag)
        Me.Controls.Add(Me.btnSalvar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCadastroCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFormaPagamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNovaCategoria As GFT.Util.SuperTextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents lblNovaPag As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
