Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmPrincipal
    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click

        Dim oform As Form
        oform = New frmConsulta
        controleFormulario(Me, oform, eTela.Consulta)
    End Sub

    Private Sub ReceitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceitasToolStripMenuItem.Click
        Dim oform As Form
        oform = New frmReceita
        controleFormulario(Me, oform, eTela.Receita)
    End Sub

    Private Sub DespesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespesasToolStripMenuItem.Click
        Dim oform As Form
        oform = New frmDespesa()
        controleFormulario(Me, oform, eTela.Despesa)
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCaptionHora.Text = ""
        InicializaTelas()
        Cor(CType(StatusStrip1, Control), Collor.Preto)
        gbPricnipal.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtCaptionHora.Text = Now.ToString
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If clsMsgBox.S_MsgBox("Deseja sair da aplicação?", clsMsgBox.eBotoes.SimNao, ".:Logout", clsMsgBox.eImagens.Interrogacao) = eSimNao.Sim Then
            Me.Close()
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        If WindowState = FormWindowState.Normal = True Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        Dim log As frmLogin
        log = New frmLogin
        log.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim oForm As Form
        oForm = New frmConfiguracao
        controleFormulario(Me, oForm, eTela.Configuracao)
    End Sub

    Private Sub ContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasToolStripMenuItem.Click
        Dim oForm As Form
        oForm = New frmConta
        controleFormulario(Me, oForm, eTela.conta_Bancaria)
    End Sub

    Private Sub txtCaption_TextChanged(sender As Object, e As EventArgs) Handles txtCaption.TextChanged
        If txtCaption.Text <> "Home" Then
            gbPricnipal.Visible = False
        Else
            gbPricnipal.Visible = True
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim oForm As Form
        oForm = New Form1
        controleFormulario(Me, oForm, eTela.nova_Receita)
    End Sub
End Class