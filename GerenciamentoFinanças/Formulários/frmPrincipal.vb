Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmPrincipal
    Public button As Button
    Public oDataSet As SuperDataSet
    Public oform As Form
    Public splash As SplashScreen
    Public Verifica As Boolean
    Public cLoga As DialogResult
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.Visible = False
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click

        oform = New frmConsulta
        controleFormulario(Me, oform, eTela.Consulta)
    End Sub

    Private Sub ReceitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceitasToolStripMenuItem.Click
        AbrirReceita()


    End Sub

    Private Sub DespesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespesasToolStripMenuItem.Click
        AbrirDespesa()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#If DEBUG Then
        Verifica = False
#Else
        Verifica = TRUE
#End If
        If Verifica Then
            pInicializacao.Iniciar()
        End If

        InicializaTelas()
        Cor(CType(SScima, Control), Collor.CinzaEscuro)
        Cor(CType(SsBaixo, Control), Collor.CinzaEscuro)
        Cor(CType(ssTituloTela, Control), Collor.CinzaEscuro)
        gbPricnipal.Visible = True

        'Me.Visible = False
        'If cLoga = DialogResult.None Then
        '    splash = New SplashScreen
        '    splash.ShowDialog()
        'ElseIf cLoga = DialogResult.OK Then
        '    Me.Visible = True
        'End If


        'If splash.DialogResult = DialogResult.Yes Then
        '    oform = New frmLogin
        '    cLoga = oform.ShowDialog()
        '    Me.Visible = True
        'Else
        '    Me.Visible = True
        'End If



        CarregaTabHome()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtCaptionHora.Text = Now.ToString
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If clsMsgBox.S_MsgBox("Deseja sair da aplicação?", clsMsgBox.eBotoes.SimNao, ".:Logout", clsMsgBox.eImagens.Interrogacao) = eSimNao.Sim Then
            Me.Close()
        End If
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        Dim log As frmLogin
        log = New frmLogin
        log.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalizacaoToolStripMenuItem.Click
        Dim oForm As Form
        oForm = New frmConfiguracao
        controleFormulario(Me, oForm, eTela.Configuracao)
    End Sub

    Private Sub ContasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbrirConta()
    End Sub

    Private Sub txtCaption_TextChanged(sender As Object, e As EventArgs) Handles txtCaption.TextChanged
        If txtCaption.Text <> "Dashboard" Then
            gbPricnipal.Visible = False
        Else
            gbPricnipal.Visible = True
        End If
    End Sub

    Private Sub btnAddReceita_Click(sender As Object, e As EventArgs) Handles btnAddReceita.Click
        Dim oForm As frmNovaReceita
        oForm = New frmNovaReceita
        oForm.Show()
    End Sub

    Private Sub btnAddDespesa_Click(sender As Object, e As EventArgs) Handles btnAddDespesa.Click
        Dim oForm As frmNovaDespesa
        oForm = New frmNovaDespesa(0)
        oForm.Show()

    End Sub

    Private Sub btnAddConta_Click(sender As Object, e As EventArgs) Handles btnAddConta.Click
        Dim oForm As frmNovaConta
        oForm = New frmNovaConta(0)
        oForm.Show()
    End Sub
    Private Sub AbrirDespesa()
        Dim oform As Form
        oform = New frmDespesa()
        controleFormulario(Me, oform, eTela.Despesa)
    End Sub
    Private Sub AbrirConta()
        Dim oForm As Form
        oForm = New frmConta
        controleFormulario(Me, oForm, eTela.conta_Bancaria)
    End Sub

    Private Sub CarregaTabHome(Optional saldo As Decimal = 0,
                               Optional receita As Decimal = 0,
                               Optional despesa As Decimal = 0)
        Try
            If saldo = 0 And receita = 0 And despesa = 0 Then

                oDataSet = pDespesa.ObterTotal
                If oDataSet.TotalRegistros <> Nothing Then
                    btnDespesa.Text = oDataSet("TOTAL").ToString
                    tabCtrlDespesa.Refresh()
                End If

                oDataSet = pReceita.ObterTotal

                If oDataSet("TOTAL").ToString <> "" Then
                    btnReceita.Text = oDataSet("TOTAL").ToString
                    tabCtrlPrincReceita.Refresh()
                Else
                    btnReceita.Text = "R$ 0,00"
                End If

                AtualizarSaldo()

            Else
                If saldo = 1 Then
                    AtualizarSaldo()

                ElseIf receita = 1 Then
                    oDataSet = pReceita.ObterTotal

                    If oDataSet.TotalRegistros.ToString <> "" Then
                        btnReceita.Text = oDataSet("TOTAL").ToString
                    Else
                        btnReceita.Text = "R$ 0,00"
                    End If

                ElseIf despesa = 1 Then
                    oDataSet = pDespesa.ObterTotal

                    If oDataSet("TOTAL").ToString <> "" Then
                        btnDespesa.Text = oDataSet("TOTAL").ToString
                    Else
                        btnDespesa.Text = "R$ 0,00"

                    End If
                End If
            End If

            oDataSet.Dispose()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnDespesa_Click(sender As Object, e As EventArgs) Handles btnDespesa.Click
        AbrirDespesa()
    End Sub

    Private Sub btnSaldo_Click(sender As Object, e As EventArgs)
        AbrirConta()
    End Sub

    Private Sub btnReceita_Click(sender As Object, e As EventArgs) Handles btnReceita.Click
        AbrirReceita()
    End Sub

    Private Sub AbrirReceita()
        Dim oform As Form
        oform = New frmReceita
        controleFormulario(Me, oform, eTela.Receita)
    End Sub

    Private Sub btnRefreshSaldo_Click(sender As Object, e As EventArgs) Handles btnRefreshSaldo.Click
        CarregaTabHome(1, 0, 0)
    End Sub

    Private Sub btnRefreshReceita_Click(sender As Object, e As EventArgs) Handles btnRefreshReceita.Click
        CarregaTabHome(0, 1, 0)
    End Sub

    Private Sub btnRefreshDespesa_Click(sender As Object, e As EventArgs) Handles btnRefreshDespesa.Click
        CarregaTabHome(0, 0, 1)
    End Sub
    Private Sub AtualizarSaldo()
        Dim text As String
        Try
            button = New Button
            oDataSet = pContaBancaria.ObterTotal

            If oDataSet.TotalRegistros > 1 Then

                For i = 0 To oDataSet.TotalRegistros - 1



                    If oDataSet.TotalRegistros.ToString <> "" Then
                        text = oDataSet("TOTAL", i).ToString
                    Else
                        text = "R$ 0,00"
                    End If

                    GeraButton(button, i, text)

                Next
            Else
                If oDataSet.TotalRegistros.ToString <> "" Then
                    text = oDataSet("TOTAL").ToString
                Else
                    text = "R$ 0,00"
                End If
                GeraButton(button, 0, text)
            End If

            button.Dispose()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub GeraButton(ByVal button As Button,
                           ByVal i As Integer,
                           ByVal texto As String)
        Dim Y As Integer

        Try
            Y = 11
            If i > 0 Then
                Y += 133 * i
            End If
            button = New Button
            button.Text = texto
            button.Name = "btn" & i
            button.SetBounds(69, Y, 191, 103)
            button.BackColor = Color.WhiteSmoke
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = 2
            button.Font = New Font("Verdana", 12, FontStyle.Bold)
            button.ForeColor = Color.DeepSkyBlue
            button.FlatAppearance.MouseOverBackColor = Color.White
            button.TextImageRelation = TextImageRelation.Overlay
            button.ImageAlign = ContentAlignment.TopCenter
            button.TextAlign = ContentAlignment.BottomCenter
            AddHandler button.Click, AddressOf Me.EventoBotao

            If oDataSet("rBanco", i).ToString = "Nubank" Then

                button.Image = My.Resources.iconNubank_fw

            ElseIf oDataSet("rBanco", i).ToString = "Bradesco" Then

                button.Image = My.Resources.iconBradesco

            ElseIf oDataSet("rBanco", i).ToString = "Itau" Then

                button.Image = My.Resources.iconItau_fw

            ElseIf oDataSet("rBanco", i).ToString = "Santander" Then

                button.Image = My.Resources.iconSantander

            ElseIf oDataSet("rBanco", i).ToString = "Pic Pay" Then

                button.Image = My.Resources.iconPicPay

            ElseIf oDataSet("rBanco", i).ToString = "MercadoPago" Then

                button.Image = My.Resources.iconMercadoPago_fw
            Else
                button.Image = My.Resources.iconBank
            End If

            tabCtrlSaldo.TabPages(0).Controls.Add(button)

            tabCtrlSaldo.Refresh()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub EventoBotao(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            AbrirConta()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CobrançaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobrançaToolStripMenuItem.Click
        oform = New frmCobranca()
        controleFormulario(Me, oform, eTela.cobranca)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContaToolStripMenuItem.Click
        AbrirConta()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        oform = New frmAbout()
        oform.ShowDialog()
    End Sub

    Private Sub VerificaInstall()
        Try
            pInicializacao.Iniciar()
            Dispose()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub UsuárioSenhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigLoginToolStripMenuItem.Click
        oform = New frmUsuario
        controleFormulario(Me, oform, eTela.Usuario)
    End Sub

    Private Sub ServiçoDeEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiçoDeEmailToolStripMenuItem.Click
        oform = New frmEmail()
        controleFormulario(Me, oform, eTela.Email)
    End Sub
End Class