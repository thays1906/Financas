Imports GFT.Util
Public Class frmReceita
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frmReceita_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmReceita_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Receita)
    End Sub

    Private Sub btnAddReceita_Click(sender As Object, e As EventArgs) Handles btnAddReceita.Click
        Dim oform As Form
        oform = New frmNovaReceita

        oform.Show()

    End Sub
End Class