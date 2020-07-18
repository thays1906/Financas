Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmEmail
    Public oDataSet As SuperDataSet
    Private Sub frmEmail_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        alterarCaptionFormPrincipal(eTela.Email)
    End Sub

    Private Sub frmEmail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        restaurarMDI()
    End Sub
    Private Sub Pesquisar()
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pContaBancaria.PesquisarConta
            dgConsulta.PreencheDataGrid(oDataSet)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pesquisar()
    End Sub
End Class