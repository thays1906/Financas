<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta))
		Me.lvConsulta = New GFT.Util.SuperLV()
		Me.btnPesquisar = New GFT.Util.SuperButton()
		Me.SuspendLayout()
		'
		'lvConsulta
		'
		Me.lvConsulta.HabilitaOrdem = True
		Me.lvConsulta.HideSelection = False
		Me.lvConsulta.Location = New System.Drawing.Point(28, 80)
		Me.lvConsulta.Name = "lvConsulta"
		Me.lvConsulta.SelecionaVarios = False
		Me.lvConsulta.Size = New System.Drawing.Size(732, 305)
		Me.lvConsulta.TabIndex = 0
		Me.lvConsulta.UseCompatibleStateImageBehavior = False
		'
		'btnPesquisar
		'
		Me.btnPesquisar.BackColor = System.Drawing.Color.Transparent
		Me.btnPesquisar.BackgroundImage = CType(resources.GetObject("btnPesquisar.BackgroundImage"), System.Drawing.Image)
		Me.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnPesquisar.ForeColor = System.Drawing.Color.Black
		Me.btnPesquisar.Location = New System.Drawing.Point(28, 39)
		Me.btnPesquisar.Name = "btnPesquisar"
		Me.btnPesquisar.Size = New System.Drawing.Size(113, 35)
		Me.btnPesquisar.TabIndex = 1
		Me.btnPesquisar.Text = "Pesquisar"
		Me.btnPesquisar.UseVisualStyleBackColor = False
		'
		'frmConsulta
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnPesquisar)
		Me.Controls.Add(Me.lvConsulta)
		Me.Name = "frmConsulta"
		Me.Text = "frmConsulta"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lvConsulta As GFT.Util.SuperLV
	Friend WithEvents btnPesquisar As GFT.Util.SuperButton
End Class
