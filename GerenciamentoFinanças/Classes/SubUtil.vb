Imports GFT.Util
Public Module SubUtil
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, byvalMax As Int32) As Boolean

    '=======================================
    'Enums
    '=======================================
    Public Enum eTela

        Consulta = 100
        Receita = 101
        Despesa = 102
        Configuracao = 103

        cobranca = 200
        conta_Bancaria = 201
        Usuario = 202
        about = 210

    End Enum
    Public Enum eCadastroCategoria
        FormaPagamento = 1
        CategoriaDespesa = 2
        CategoriaReceita = 3
    End Enum

    Public Enum eSimNao
        Sim = 1
        Nao = 2
    End Enum
    Public Enum Collor
        Preto = 1
        VerdeEscuro = 2
        VerdeClaro = 3
        Amarelo = 4
        Marrom = 5
        Branco = 6
        DarkTurquoise = 7
        DarkSlateGray = 8
        DimGray = 9
        CinzaMedio = 10
        CinzaAzulado = 11
        Gelo = 12
        Azul = 13
        Azul4 = 16
        CinzaClaro
        CinzaBranco
        CinzaEscuro
        Nenhuma
    End Enum
    Public Enum eStatusDespesa
        Pago = 1
        Pendente = 2
        Atrasado = 3
    End Enum
    Public Enum eDespesaFixa
        Diario = 1
        Semanal = 7
        Quinzenal = 15
        Mensal = 30
        Bimestral = 60
        Trimestral = 90
        Semestral = 182
        Anual = 365
    End Enum
    Public Enum eStatus
        Ativo = 1
        Inativo = 2
    End Enum
    Public Enum eTipoConta
        Corrente = 1
        Poupanca = 2
        Digital = 3
    End Enum
    Public Enum eAcao
        Novo = 1
        Editar = 2
        Excluir = 3
    End Enum
    Public Enum eTipoMensagem
        OK = 1
        Question = 2
        Erro = 3
    End Enum
    Public Enum eBanco
        Nubank = 1
        Santander = 2
        Bradesco = 3
        Itau = 4
        MercadoPago = 5
        PicPay = 6
        Stone = 7
        HSBC = 8
        Citibank = 9
        CaixaEconomica = 10
        Safra = 11
        original = 12
        Neon = 13
        Pan = 14
        Mercantil = 15
        Brasil = 16
        Daycoval = 17
        Crefisa = 18
        Cetelem = 19
        Bs2 = 20
        Bovespa = 21
        Agibank = 22
        [Next] = 23
        Inter = 24
        PagBank = 25
        Ame = 26
        PayPal = 27
    End Enum
    Public Function Banco(ByVal rBanco As String) As Bitmap
        Dim img As Bitmap = Nothing

        Try

            If rBanco = "Nubank" Then

                img = My.Resources.iconNubank_fw

            ElseIf rBanco = "Bradesco" Then

                img = My.Resources.iconBradesco

            ElseIf rBanco = "Itau" Then

                img = My.Resources.iconItau_fw

            ElseIf rBanco = "Santander" Then

                img = My.Resources.iconSantander

            ElseIf rBanco = "Caixa Economica" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Ame" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "PicPay" Then

                img = My.Resources.iconPicPay

            ElseIf rBanco = "Mercado Pago" Then

                img = My.Resources.iconMercadoPago_fw

            ElseIf rBanco = "Inter" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "HSBC" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Agibank" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Bovespa" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Safra" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Stone" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Original" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Brasil" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Citibank" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Cetelem" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Neon" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Next" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Bs2" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Daycoval" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "PagBank" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Mercantil" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "PayPal" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Crefisa" Then

                img = My.Resources.iconBank

            ElseIf rBanco = "Pan" Then

                img = My.Resources.iconBank

            End If



            Return img

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    '=======================================
    'FIM --- Enums
    '=======================================
    '=======================================
    'Cores
    Public Sub Cor(ByRef Controle As Control, ByVal Cor As Collor)

        If Cor = Collor.Preto Then
            Controle.BackColor = Color.FromArgb(64, 62, 63)

        ElseIf Cor = Collor.VerdeEscuro Then
            Controle.BackColor = Color.FromArgb(28, 89, 54)

        ElseIf Cor = Collor.VerdeClaro Then
            Controle.BackColor = Color.FromArgb(3, 166, 74)

        ElseIf Cor = Collor.Amarelo Then

            'Controle.BackColor = Color.FromArgb(242, 192, 41)
            Controle.BackColor = Color.Goldenrod

        ElseIf Cor = Collor.Marrom Then
            Controle.BackColor = Color.FromArgb(115, 100, 56)

        ElseIf Cor = Collor.Branco Then
            Controle.BackColor = Color.White

        ElseIf Cor = Collor.DarkTurquoise Then
            Controle.BackColor = Color.DarkTurquoise

        ElseIf Cor = Collor.DarkSlateGray Then
            Controle.BackColor = Color.DarkSlateGray

        ElseIf Cor = Collor.CinzaMedio Then
            Controle.BackColor = Color.FromArgb(96, 122, 143)

        ElseIf Cor = Collor.CinzaAzulado Then
            Controle.BackColor = Color.FromArgb(113, 143, 168)

        ElseIf Cor = Collor.Azul Then
            Controle.BackColor = Color.FromArgb(0, 55, 105)

        ElseIf Cor = Collor.Azul4 Then
            Controle.BackColor = Color.Teal

        ElseIf Cor = Collor.CinzaClaro Then
            Controle.BackColor = Color.FromArgb(223, 223, 223)

        ElseIf Cor = Collor.CinzaBranco Then
            Controle.BackColor = Color.FromArgb(248, 248, 255)

        ElseIf Cor = Collor.CinzaEscuro Then
            Controle.BackColor = Color.FromArgb(80, 87, 86)

        ElseIf cor = Collor.Gelo Then
            Controle.BackColor = Color.WhiteSmoke
        End If
    End Sub
    Public Sub CorButton(ByRef button As Button,
                         ByVal Cor As Collor,
                         ByVal corText As Color,
                         ByVal corHover As Color,
                         ByVal corDown As Color)

        button.ForeColor = corText
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.FlatAppearance.MouseOverBackColor = corHover
        button.FlatAppearance.MouseDownBackColor = corDown

        If Cor = Collor.DarkSlateGray Then
            button.BackColor = Color.DarkSlateGray

        ElseIf Cor = Collor.DarkTurquoise Then
            button.BackColor = Color.DarkTurquoise

        ElseIf Cor = Collor.VerdeEscuro Then
            button.BackColor = Color.FromArgb(28, 89, 54)

        ElseIf Cor = Collor.Amarelo Then
            button.BackColor = Color.FromArgb(242, 192, 41)

        ElseIf Cor = Collor.DimGray Then
            button.BackColor = Color.DimGray

        ElseIf Cor = Collor.Preto Then
            button.BackColor = Color.Black

        ElseIf Cor = Collor.CinzaMedio Then
            button.BackColor = Color.DarkGray

        ElseIf Cor = Collor.CinzaAzulado Then
            button.BackColor = Color.FromArgb(113, 143, 168)

        ElseIf Cor = Collor.Gelo Then
            button.BackColor = Color.WhiteSmoke

        ElseIf Cor = collor.Branco Then
            button.BackColor = Color.White

        ElseIf Cor = Collor.CinzaEscuro Then
            button.BackColor = Color.FromArgb(80, 87, 86)

        ElseIf Cor = Collor.Nenhuma Then
            button.BackColor = Color.Transparent
        End If
    End Sub
    Public Sub CorList(ByRef lv As SuperLV)

        lv.BackColor = Color.WhiteSmoke
        lv.GridLines = False
        lv.FullRowSelect = True
        lv.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)

    End Sub

    Public Sub CorTab(ByRef tab As SuperTabControl, ByVal Cor As Collor)


        If Cor = Collor.CinzaEscuro Then
            For Each tabPage As TabPage In tab.TabPages

                tabPage.BackColor = Color.FromArgb(80, 87, 86)

            Next

            tab.SelectedTab.BackColor = Color.FromArgb(64, 62, 63)

        ElseIf Cor = Collor.CinzaAzulado Then
            For Each tabPage As TabPage In tab.TabPages

                tab.BackColor = SystemColors.InactiveBorder
            Next

        ElseIf Cor = Collor.CinzaClaro Then
            For Each tabPage As TabPage In tab.TabPages

                tab.BackColor = SystemColors.Control
            Next
            'ElseIf Cor = Collor.Amarelo Then
            'tab.BackColor = Color.FromArgb(242, 192, 41)

            'ElseIf Cor = Collor.Marrom Then
            '    tab.BackColor = Color.FromArgb(115, 100, 56)

        End If
    End Sub

    '=======================================
    'FIM------Cores
    '=======================================
    Public Function MinHora(ByVal _date As Date) As Date
        Dim data As Date
        Try
            data = New Date(_date.Year, _date.Month, _date.Day, 0, 0, 0)

            Return data

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function MaxHora(ByVal _data As Date) As Date
        Dim data As Date
        Try
            data = New Date(_data.Year, _data.Month, _data.Day, 23, 59, 59)
            Return data
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub AdicionaImgColumn(ByVal oDataset As SuperDataSet, ByVal column As String)
        Dim image As ImageConverter
        Try
            image = New ImageConverter()

            For Each linha As DataRow In oDataset.Tables(0).Rows

                linha(column) = image.ConvertTo(Banco(linha.ItemArray(5).ToString),
                                                System.Type.GetType("System.Byte[]"))

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub restaurarMDI()
        Lixeiro()
        frmPrincipal.txtCaption.Text = "Home"
    End Sub

    Public Sub Lixeiro()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.WaitForFullGCComplete()
        GC.Collect()
        LiberaMemoria()
    End Sub
    Public Function LiberaMemoria() As Boolean
        Dim mem As Process = Process.GetCurrentProcess
        Try
            SetProcessWorkingSetSize(mem.Handle, -1, -1)
            'Lixeiro()
            Return True
        Catch ex As Exception
            mem.Dispose()
            Return False
        End Try
    End Function
    Public Sub alterarCaptionFormPrincipal(ByVal n_nova_tela As Integer)
        Dim arrstr As String()
        Dim strDescricaoForm As String

        Try
            arrstr = CType(collNomeTela(Int(n_nova_tela).ToString), String())
            strDescricaoForm = arrstr(1)
            frmPrincipal.txtCaption.Text = strDescricaoForm
        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo("Util") & ": " & ex.Message)
        End Try

    End Sub

    '------------------------------------------------------------------------
    ' centralizarGrupoTab(ByVal oGrp As SuperTabControl)
    '------------------------------------------------------------------------
    Public Sub centralizarGrupoTab(ByVal oGrp As SuperTabControl)
        oGrp.Left = CInt((oGrp.Parent.Width / 2) - (oGrp.Width / 2))
    End Sub

    Public Sub centralizarGrupoTab(ByVal oGrp As TabControl)
        oGrp.Left = CInt((oGrp.Parent.Width / 2) - (oGrp.Width / 2))
    End Sub

    Public Sub centralizarGrupoBotoes(ByRef oGrp As GroupBox)
        oGrp.Left = CInt((oGrp.Parent.Width / 2) - (oGrp.Width / 2))
    End Sub

    Public Sub centralizarPainel(ByRef oGrp As Panel)
        oGrp.Left = CInt((oGrp.Parent.Width / 2) - (oGrp.Width / 2))
    End Sub

    Public Sub InicializaTelas()
        Try

            LogaErro("Iniciando strings telas...")

            collNomeTela = New Collection()

            collNomeTela.Add(New String() {" ", "Consulta"}, Int(eTela.Consulta).ToString)
            collNomeTela.Add(New String() {" ", "Receitas"}, Int(eTela.Receita).ToString)
            collNomeTela.Add(New String() {" ", "Despesas"}, Int(eTela.Despesa).ToString)
            collNomeTela.Add(New String() {" ", "Configurações"}, Int(eTela.Configuracao).ToString)

            collNomeTela.Add(New String() {" ", "Cobrança"}, Int(eTela.cobranca).ToString)
            collNomeTela.Add(New String() {" ", "Contas"}, Int(eTela.conta_Bancaria).ToString)
            collNomeTela.Add(New String() {" ", "Usuário"}, Int(eTela.Usuario).ToString)

            collNomeTela.Add(New String() {" ", "Sobre"}, Int(eTela.about).ToString)

        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo("Util") & ": " & ex.Message)
        End Try

    End Sub

End Module
