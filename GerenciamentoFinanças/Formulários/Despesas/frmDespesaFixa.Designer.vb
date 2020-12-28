<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespesaFixa
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
        Me.btnAlteraDespesaFixa = New System.Windows.Forms.Button()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbSomenteEste = New System.Windows.Forms.RadioButton()
        Me.rbProximos = New System.Windows.Forms.RadioButton()
        Me.SuperLetreiro1 = New GFT.Util.SuperLetreiro()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInformativo = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAlteraDespesaFixa
        '
        Me.btnAlteraDespesaFixa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAlteraDespesaFixa.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconPago
        Me.btnAlteraDespesaFixa.Location = New System.Drawing.Point(132, 253)
        Me.btnAlteraDespesaFixa.Name = "btnAlteraDespesaFixa"
        Me.btnAlteraDespesaFixa.Size = New System.Drawing.Size(203, 42)
        Me.btnAlteraDespesaFixa.TabIndex = 1
        Me.btnAlteraDespesaFixa.Text = " &Confirmar"
        Me.btnAlteraDespesaFixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlteraDespesaFixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlteraDespesaFixa.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.ForeColor = System.Drawing.Color.Black
        Me.rbTodos.Location = New System.Drawing.Point(178, 102)
        Me.rbTodos.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(266, 29)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Alterar todos registros."
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbSomenteEste
        '
        Me.rbSomenteEste.AutoSize = True
        Me.rbSomenteEste.ForeColor = System.Drawing.Color.Black
        Me.rbSomenteEste.Location = New System.Drawing.Point(178, 27)
        Me.rbSomenteEste.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbSomenteEste.Name = "rbSomenteEste"
        Me.rbSomenteEste.Size = New System.Drawing.Size(337, 29)
        Me.rbSomenteEste.TabIndex = 6
        Me.rbSomenteEste.TabStop = True
        Me.rbSomenteEste.Text = "Alterar somente este registro."
        Me.rbSomenteEste.UseVisualStyleBackColor = True
        '
        'rbProximos
        '
        Me.rbProximos.AutoSize = True
        Me.rbProximos.ForeColor = System.Drawing.Color.Black
        Me.rbProximos.Location = New System.Drawing.Point(178, 64)
        Me.rbProximos.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbProximos.Name = "rbProximos"
        Me.rbProximos.Size = New System.Drawing.Size(401, 29)
        Me.rbProximos.TabIndex = 5
        Me.rbProximos.TabStop = True
        Me.rbProximos.Text = "Alterar este e os próximos registros."
        Me.rbProximos.UseVisualStyleBackColor = True
        '
        'SuperLetreiro1
        '
        Me.SuperLetreiro1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SuperLetreiro1.CorSombraTexto = System.Drawing.Color.White
        Me.SuperLetreiro1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SuperLetreiro1.ForeColor = System.Drawing.Color.Black
        Me.SuperLetreiro1.Location = New System.Drawing.Point(1, 26)
        Me.SuperLetreiro1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SuperLetreiro1.Name = "SuperLetreiro1"
        Me.SuperLetreiro1.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
        Me.SuperLetreiro1.Size = New System.Drawing.Size(694, 33)
        Me.SuperLetreiro1.TabIndex = 3
        Me.SuperLetreiro1.TextoLetreiro = "Atenção: Essa Despesa se repete em outras datas  "
        Me.SuperLetreiro1.VelocidadeRolagem = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.txtInformativo)
        Me.GroupBox1.Controls.Add(Me.rbSomenteEste)
        Me.GroupBox1.Controls.Add(Me.rbTodos)
        Me.GroupBox1.Controls.Add(Me.rbProximos)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 193)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'txtInformativo
        '
        Me.txtInformativo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInformativo.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtInformativo.Location = New System.Drawing.Point(0, 143)
        Me.txtInformativo.Multiline = True
        Me.txtInformativo.Name = "txtInformativo"
        Me.txtInformativo.ReadOnly = True
        Me.txtInformativo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInformativo.Size = New System.Drawing.Size(694, 50)
        Me.txtInformativo.TabIndex = 10
        Me.txtInformativo.Text = "Não será modificada a data de Despesa Fixa que se repete :  Diariamente, Semanalm" &
    "ente e Quinzenal."
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(387, 253)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(203, 42)
        Me.btnFechar.TabIndex = 8
        Me.btnFechar.Text = " &Cancelar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmDespesaFixa
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(695, 307)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SuperLetreiro1)
        Me.Controls.Add(Me.btnAlteraDespesaFixa)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDespesaFixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAlteraDespesaFixa As Button
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbSomenteEste As RadioButton
    Friend WithEvents rbProximos As RadioButton
    Friend WithEvents SuperLetreiro1 As GFT.Util.SuperLetreiro
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents txtInformativo As TextBox
End Class
