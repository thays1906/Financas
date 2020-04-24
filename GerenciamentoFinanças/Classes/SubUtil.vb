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

        nova_Receita = 200
        conta_Bancaria = 201

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
    End Enum

    Public Enum eStatusDespesa
        Pago = 1
        Pendente = 2
    End Enum
    'Cores
    Public Sub Cor(ByRef Controle As Control, ByVal Cor As Collor)

        If Cor = Collor.Preto Then
            Controle.BackColor = Color.FromArgb(64, 62, 63)

        ElseIf Cor = Collor.VerdeEscuro Then
            Controle.BackColor = Color.FromArgb(28, 89, 54)

        ElseIf Cor = Collor.VerdeClaro Then
            Controle.BackColor = Color.FromArgb(3, 166, 74)

        ElseIf Cor = Collor.Amarelo Then
            Controle.BackColor = Color.FromArgb(242, 192, 41)

        ElseIf Cor = Collor.Marrom Then
            Controle.BackColor = Color.FromArgb(115, 100, 56)

        End If


        '    Control.BackColor = Color.FromArgb(64, 62, 63)
    End Sub
    'Public Sub CorTab(ByRef tab As TabControl, ByVal Cor As Collor)
    '    If Cor = Collor.Preto Then
    '        tab.s
    '        '    tab.SelectedTab.BackColor = Color.FromArgb(64, 62, 63)

    '        'ElseIf Cor = Collor.VerdeEscuro Then
    '        '    tab.BackColor = Color.FromArgb(28, 89, 54)

    '        'ElseIf Cor = Collor.VerdeClaro Then
    '        '    tab.BackColor = Color.FromArgb(3, 166, 74)

    '        'ElseIf Cor = Collor.Amarelo Then
    '        '    tab.BackColor = Color.FromArgb(242, 192, 41)

    '        'ElseIf Cor = Collor.Marrom Then
    '        '    tab.BackColor = Color.FromArgb(115, 100, 56)

    '    End If
    'End Sub
    Public Sub restaurarMDI()
        Lixeiro()
        frmPrincipal.txtCaption.Text = ""
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

            collNomeTela.Add(New String() {"frmConsulta", "Consulta"}, Int(eTela.Consulta).ToString)
            collNomeTela.Add(New String() {"frmReceita", "Receitas"}, Int(eTela.Receita).ToString)
            collNomeTela.Add(New String() {"frmDespesa", "Despesas"}, Int(eTela.Despesa).ToString)

            collNomeTela.Add(New String() {"frmNovaReceita", "Nova receita"}, Int(eTela.nova_Receita).ToString)
            collNomeTela.Add(New String() {"frmContaBancaria", "Contas"}, Int(eTela.conta_Bancaria).ToString)


        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo("Util") & ": " & ex.Message)
        End Try

    End Sub

End Module
