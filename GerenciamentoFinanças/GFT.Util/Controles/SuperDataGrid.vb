Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class SuperDataGridView
    Inherits DataGridView

    Private btnEditar As Boolean = False
    Private btnExcluir As Boolean = False

    Private bgCorSelecionado As Color = SystemColors.ControlDarkDark
    Private ColorTextSelecionado As Color = Color.White
    Private bgCorNaoSelecionado As Color = SystemColors.ButtonFace
    Private ColorTextNaoSelecionado As Color = Color.Black

    'ColumnCheckBox
    Private checkbox As DataGridViewCheckBoxColumn
    Private bChkBox As Boolean

    'BackgroundColor DataGrid
    Private bgColor As Color = Color.White

    'Cabeçalho
    Private bgColorHeader As Color = Color.LightSlateGray
    Private fontText As Font = New Font("Verdana", 12)
    Private colorText As Color = Color.White
    Public Property CorDoFundoCabeçalho As Color
        Get
            Return bgColorHeader

        End Get
        Set(value As Color)
            bgColorHeader = value
        End Set
    End Property

    Public Property CorTextoCabeçalho As Color
        Get
            Return colorText
        End Get
        Set(value As Color)
            colorText = value
        End Set
    End Property
    <Description("Adiciona uma coluna com CheckBox")>
    Public Property AdicionarCheckBox As Boolean

        Get
            Return bChkBox

        End Get
        Set(value As Boolean)
            bChkBox = value
            AdicionaCheckBoxColumn()
        End Set
    End Property


    Sub New()
        Me.MultiSelect = True

        Me.EnableHeadersVisualStyles = False
        Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom)
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False

        'Define a distribuição das colunas no DataGrid
        Me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill     'Redimensiona as colunas para ocupar todo o DatGrid
        Me.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells 'Redimensiona as rows
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect        'Select row inteira

        'Define a borda/grade das colunas
        Me.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Me.BackgroundColor = bgColor

        'Style Columns
        Me.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.ColumnHeadersDefaultCellStyle.BackColor = bgColorHeader
        Me.ColumnHeadersDefaultCellStyle.Font = fontText
        Me.ColumnHeadersDefaultCellStyle.ForeColor = colorText
        Me.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue
        Me.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText

        'Style Rows
        Me.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        Me.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        Me.BorderStyle = BorderStyle.None
        Me.DefaultCellStyle.BackColor = SystemColors.ButtonFace
        Me.DefaultCellStyle.ForeColor = Color.Black
        Me.DefaultCellStyle.Font = fontText
        'Me.DefaultCellStyle.SelectionBackColor = SystemColors.ControlDarkDark
        'Me.DefaultCellStyle.SelectionForeColor = Color.White
        Me.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.RowHeadersVisible = False








    End Sub

    Public Sub AdicionaCheckBoxColumn()
        Try
            If bChkBox = True Then

                checkbox = New DataGridViewCheckBoxColumn()

                If Me.DataSource IsNot Nothing Then

                    If Me.Columns.Count = 0 Then

                        checkbox.Name = "chkDataGrid"
                        checkbox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        checkbox.HeaderText = ""
                        checkbox.DisplayIndex = 0
                        Me.Columns.Add(checkbox)
                    End If
                ElseIf bChkBox = False Then
                    If Me.Columns.Count <> 0 Then
                        Me.Columns.Remove(checkbox)

                    End If
                End If

            End If



        Catch ex As Exception
            LogaErro("Erro em Util::AdicionaCheckBoxColumn: " & ex.ToString())
        End Try
    End Sub
    Public Sub PreencheDataGrid(ByVal oDataSet As SuperDataSet,
                                Optional ByVal nTable As Integer = 0,
                                Optional ByVal posicaoId As Integer = Nothing,
                                Optional ByRef letreiro As SuperLetreiro = Nothing)
        Dim column As String = Nothing
        Dim ID As String = Nothing
        Try
            If oDataSet.TotalRegistros <> Nothing Then

                For i = 0 To oDataSet.TotalColunas - 1

                    column = oDataSet.NomeColuna(i, nTable)

                    If column.Substring(0, 3) = "as_" Or
                       column.Substring(0, 3) = "me_" Or
                       column.Substring(0, 3) = "nu_" Then

                        column = column.Substring(3)
                        If column.Contains("#") Then
                            column = column.Substring(0, column.IndexOf("#"))
                        End If
                        If column.Contains("_") Then
                            column = column.Replace("_", " ")
                        End If

                    ElseIf column.Substring(0, 3) = "id_" Then
                        ID = column
                    End If
                    Me.DataSource = oDataSet.Tables(nTable)

                    If bChkBox Then

                        Me.Columns(i + 1).HeaderText = column

                    Else
                        Me.Columns(i).HeaderText = column

                    End If

                Next

                If ID Is Nothing Then

                    If posicaoId <> Nothing Then

                        If bChkBox Then
                            Me.Columns(posicaoId).DisplayIndex = 1
                        Else
                            Me.Columns(posicaoId).DisplayIndex = 0
                        End If

                        Me.Columns(posicaoId).Visible = False
                    End If

                Else
                    If bChkBox Then
                        Me.Columns(ID).DisplayIndex = 1
                    Else
                        Me.Columns(ID).DisplayIndex = 0
                    End If

                    Me.Columns(ID).Visible = False
                End If


                Me.AutoResizeColumns()
                Me.Refresh()
            Else
                Me.Dispose()
                LogaErro("SuperLV::PreencheDataGrid [" & Me.Name & "] - ATENÇÃO: RecordSet=Nothing, por favor, verifique.")
                Exit Sub
            End If
            If Not letreiro Is Nothing Then
                letreiro.TextoLetreiro = oDataSet.InfoPesquisa
            End If

        Catch ex As Exception
            LogaErro("Erro em Util::PreencheDataGrid: " & ex.ToString())
        End Try
    End Sub
    Public Function ObterChavesCheckBox(Optional ByVal columnId As Integer = 0) As String
        Dim rChave As String = Nothing
        Try
            If columnId = 0 Then
                columnId = 1
            End If
            For Each item As DataGridViewRow In Me.Rows
                If CBool(item.Cells(0).Value) = True Then
                    rChave += String.Concat(item.Cells(columnId).Value.ToString, ";")
                End If
            Next

            Return rChave

        Catch ex As Exception
            LogaErro("Erro em Util::ObterChavesCheckBox: " & ex.ToString())
            Return Nothing
        End Try

    End Function
    Public Function ObterTodasChaves(Optional ByVal columnId As Integer = 0) As String
        Dim rChave As String = Nothing
        Try

            If columnId = 0 Then
                columnId = 1
            End If


            For Each item As DataGridViewRow In Me.Rows
                If CBool(item.Selected) = True Then
                    rChave += String.Concat(item.Cells(columnId).Value.ToString, ";")
                End If
            Next

            Return rChave

        Catch ex As Exception
            LogaErro("Erro em Util::ObterTodasChaves: " & ex.ToString())
            Return Nothing
        End Try

    End Function
    Public Function ObterChave(Optional columnId As Integer = 0) As Decimal
        Dim cChave As Decimal = Nothing
        Try

            For Each item As DataGridViewRow In Me.Rows
                If CBool(item.Selected) = True Then
                    cChave = CDec(item.Cells(columnId).Value)
                    Exit For
                End If
            Next

            Return cChave

        Catch ex As Exception
            LogaErro("Erro em Util::ObterChave: " & ex.ToString())
            Return Nothing
        End Try

    End Function

    Public Sub AdicionaImgColumn(ByRef oDataset As SuperDataSet,
                                 ByVal column As String,
                                 ByVal img As Bitmap)

        Dim image As ImageConverter
        Try
            image = New ImageConverter()

            For Each linha As DataRow In oDataset.Tables(0).Rows

                'Adiciona uma coluna do tipo ImageColumn no DataSet antes de carregar o DataGrid 
                'Seta a Imagem na coluna.

                linha(column) = image.ConvertTo(img, System.Type.GetType("System.Byte[]"))

            Next

        Catch ex As Exception
            LogaErro("Erro em Util::AdicionaImgColumn: " & ex.ToString())
        End Try
    End Sub


    Public Sub SelecionaTodos(ByRef chkTodos As CheckBox)
        Try
            'Seleciona/ Desmarca todos os CheckBox do DataGRid
            If Me.MultiSelect Then
                If bChkBox Then

                    If Me.Rows.Count > 0 Then

                        For i = 0 To Me.Rows.Count - 1

                            If chkTodos.Checked Then

                                Me.Rows(i).Selected = True
                                If bChkBox Then
                                    Me.Rows(i).Cells(0).Value = True
                                End If
                                'adicionar select bgcolor
                            Else
                                Me.Rows(i).Selected = False
                                If bChkBox Then
                                    Me.Rows(i).Cells(0).Value = False
                                End If
                                Me.ClearSelection()
                            End If
                        Next
                    End If
                End If
            Else
                LogaErro("SuperDataGridView::SelecionaTodosCheck [" & Me.Name & "] - ATENÇÃO: Propriedade do DataGrid [MultiSelect = false].")
            End If

        Catch ex As Exception
            LogaErro("Erro em Util::SelecionaTodosCheck: " & ex.ToString())
        End Try
    End Sub

    Private Sub SelectRowLeave_CheckBox(sender As Object, e As DataGridViewCellEventArgs) Handles Me.RowLeave

        Try
            'Mantém a linha selecionada, quando clicar em outra linha.


            If bChkBox Then

                If Me.MultiSelect Then

                    If CBool(Me.Rows(e.RowIndex).Cells(0).Value) = True Then

                        Me.Rows(e.RowIndex).Selected = True
                        Me.Rows(e.RowIndex).DefaultCellStyle.BackColor = bgCorSelecionado
                        Me.Rows(e.RowIndex).DefaultCellStyle.ForeColor = ColorTextSelecionado
                    End If

                Else
                    If CBool(Me.Rows(e.RowIndex).Cells(0).Value) = True Then

                        Me.Rows(e.RowIndex).Selected = False
                        Me.Rows(e.RowIndex).Cells(0).Value = False
                        Me.Rows(e.RowIndex).DefaultCellStyle.BackColor = bgCorNaoSelecionado
                        Me.Rows(e.RowIndex).DefaultCellStyle.ForeColor = ColorTextNaoSelecionado
                    End If

                End If
            End If

        Catch ex As Exception
            LogaErro("Erro em Util::SelectRowLeave_CheckBox: " & ex.ToString())
        End Try
    End Sub

    Public Function ObterTodosChecados() As Decimal
        Dim total As Decimal = 0
        Try
            For Each row As DataGridViewRow In Me.Rows
                If row.Selected = True Then
                    total += 1
                End If
            Next

            Return total
        Catch ex As Exception
            LogaErro("Erro em Util::ObterTodosChecados: " & ex.ToString())
            Return Nothing
        End Try
    End Function
    'Public Function ObterTodosCheckBoxChecados() As Decimal
    '    Dim total As Decimal = 0
    '    Try
    '        For Each row As DataGridViewRow In Me.Rows
    '            If CBool(row.Cells(0).Value) = True Then
    '                total += 1
    '            End If
    '        Next

    '        Return total

    '    Catch ex As Exception
    '        LogaErro("Erro em Util::ObterTodosCheckBoxChecados: " & ex.ToString())
    '        Return Nothing
    '    End Try
    'End Function
    Public Sub HabilitarDesabilitarEdicao(Optional ByRef SuperEditar As SuperButton = Nothing,
                                          Optional ByRef btnEditar As Button = Nothing)
        Try
            If SuperEditar Is Nothing And btnEditar Is Nothing Then

                LogaErro("SuperDataGridView::HabilitarDesabilitarEditar [" & Me.Name & "] - ATENÇÃO: Nenhum botao informado no parâmetro, por favor, informe.")

            Else
                If SuperEditar IsNot Nothing Then

                    If Me.SelectedRows.Count = 1 Then

                        SuperEditar.Enabled = True
                    Else
                        SuperEditar.Enabled = False

                    End If

                ElseIf btnEditar IsNot Nothing Then

                    If Me.SelectedRows.Count = 1 Then

                        btnEditar.Enabled = True
                    Else
                        btnEditar.Enabled = False

                    End If
                End If
            End If

        Catch ex As Exception
            LogaErro("Erro em Util::HabilitarDesabilitarEdicao: " & ex.ToString())
        End Try
    End Sub
    Public Sub HabilitarDesabilitarExclusao(Optional ByRef SuperExcluir As SuperButton = Nothing,
                                            Optional ByRef btnExcluir As Button = Nothing)
        Try
            If SuperExcluir Is Nothing And btnExcluir Is Nothing Then

                LogaErro("SuperDataGridView::HabilitarDesabilitarExclusao [" & Me.Name & "] - ATENÇÃO: Nenhum botao informado no parâmetro, por favor, informe.")
            Else
                If SuperExcluir IsNot Nothing Then

                    If Me.MultiSelect = True Then
                        If Me.SelectedRows.Count >= 1 Then
                            SuperExcluir.Enabled = True
                        Else
                            SuperExcluir.Enabled = False
                        End If

                    Else
                        If Me.SelectedRows.Count = 1 Then
                            SuperExcluir.Enabled = True
                        Else
                            SuperExcluir.Enabled = False
                        End If

                    End If

                ElseIf btnExcluir IsNot Nothing Then

                    If Me.MultiSelect = True Then

                        If Me.SelectedRows.Count >= 1 Then
                            btnExcluir.Enabled = True
                        Else
                            btnExcluir.Enabled = False
                        End If

                    Else
                        If Me.SelectedRows.Count = 1 Then
                            btnExcluir.Enabled = True
                        Else
                            btnExcluir.Enabled = False
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::HabilitarDesabilitarExclusao: " & ex.ToString())
        End Try
    End Sub

    Private Sub SuperDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Me.DataBindingComplete
        Try
            'Quando o DataGrid estiver carregado, desmarca a linha que estiver selecionada.
            For i = 0 To Me.Rows.Count - 1

                If Me.Rows(i).Selected Then

                    If Me.AdicionarCheckBox Then
                        Me.Rows(i).Cells(0).Value = False
                    End If

                    Me.ClearSelection()

                    'Ativa ReadOnly para todas as células, exceto a coluna do checkbox.
                    For l = 0 To Me.Columns.Count - 1
                        If bChkBox Then
                            If Me.Columns(l).Index <> Me.Columns(0).Index Then

                                Me.Columns(l).ReadOnly = True
                            End If
                        Else
                            Me.Columns(l).ReadOnly = True
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            LogaErro("Erro em Util::SuperDataGridView_DataBindingComplete: " & ex.ToString())
        End Try
    End Sub

    Private Sub SuperDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles Me.CurrentCellChanged
        Try
            'Caso tenha checkbox no DataGrid, ativa o select na linha que estiver selecionada.

            If bChkBox Then
                For i = 0 To Me.Rows.Count - 1
                    If CBool(Me.Rows(i).Cells(0).Value) = True Then
                        Me.Rows(i).Selected = True
                    Else
                        Me.Rows(i).Selected = False
                    End If
                Next
            End If


        Catch ex As Exception
            LogaErro("Erro em Util::SuperDataGridView_CurrentCellChanged: " & ex.ToString())
        End Try
    End Sub

    Private Sub SuperDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Me.CellMouseClick
        Try
            'Seleciona a linha, checkbox, e altera cor da linha selecionada.

            If e.RowIndex <> -1 Then

                'Se o click for com Ctrl pressionado ou sem.

                If Control.ModifierKeys = Keys.Control Or Control.ModifierKeys = Keys.None Then

                    If bChkBox Then

                        If CBool(Me.Rows(e.RowIndex).Cells(0).Value) = False Then

                            Me.Rows(e.RowIndex).Cells(0).Value = True
                            Me.Rows(e.RowIndex).Selected = True

                            Me.Refresh()

                        ElseIf CBool(Me.Rows(e.RowIndex).Cells(0).Value) = True Then

                            Me.Rows(e.RowIndex).Selected = False
                            Me.Rows(e.RowIndex).Cells(0).Value = False
                            Me.Rows(e.RowIndex).DefaultCellStyle.BackColor = bgCorNaoSelecionado
                            Me.Rows(e.RowIndex).DefaultCellStyle.ForeColor = ColorTextNaoSelecionado

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::SelecionarCheckBoxDataGrid: " & ex.ToString())
        End Try
    End Sub
End Class
