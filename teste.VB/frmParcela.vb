Imports System.Data.SqlClient

Public Class frmParcela
    Public Const strConexao As String = "Data Source=localhost;Initial Catalog=***;Integrated Security=True;MultipleActiveResultSets=True"
    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(strConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)

    Private Sub frmParcela_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCodigoParcela.Text = String.Empty
        btnDeletar.Enabled = False

        If lblCodigoParcela.Text.Equals(String.Empty) Then

            btnInserirAtualizar.Enabled = False
            txtValorParcela.Text = String.Empty
            txtVencimentoParcela.Text = String.Empty
            txtValorParcela.Enabled = False
            txtVencimentoParcela.Enabled = False

        End If

        PreencherComboConveniados()
        PreencherGridParcelas()

    End Sub

    Public Sub PreencherComboConveniados()

        Try

            objConexao.Open()
            Dim dataset As New DataSet
            Dim adapter As New SqlDataAdapter()
            adapter.SelectCommand = New SqlCommand("Select id, nome, nascimento from tbConveniado", objConexao)
            adapter.Fill(dataset)

            cbmConveniados.DataSource = dataset.Tables(0)
            cbmConveniados.DisplayMember = "nome"
            cbmConveniados.ValueMember = "id"

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Sub

    Public Sub PreencherGridParcelas()

        Try

            If cbmConveniados.Items.Count > 0 Then

                Dim idConveniado As String = cbmConveniados.SelectedValue.ToString()

                gdvParcela.DataSource = BindingSource
                strInstrucao = "Select id, valor, vencimento, conveniadoId from tbParcela Where conveniadoId = " + idConveniado

                Dim dataAdapter As New SqlDataAdapter(strInstrucao, strConexao)
                Dim commandBuilder As New SqlCommandBuilder(dataAdapter)
                Dim table As New DataTable()
                table.Locale = System.Globalization.CultureInfo.InvariantCulture
                dataAdapter.Fill(table)
                BindingSource.DataSource = table
                gdvParcela.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)

            End If

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Sub


    Private Sub cbmConveniados_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbmConveniados.SelectionChangeCommitted

        PreencherGridParcelas()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Me.Close()

    End Sub

    Public Sub limpaHabilitaCampos()

        lblCodigoParcela.Text = String.Empty
        txtValorParcela.Text = String.Empty
        txtVencimentoParcela.Text = String.Empty
        txtValorParcela.Enabled = True
        txtVencimentoParcela.Enabled = True

    End Sub

    Public Sub limpaDesabilitaHabilitaCampos()

        lblCodigoParcela.Text = String.Empty
        txtValorParcela.Text = String.Empty
        txtVencimentoParcela.Text = String.Empty
        txtValorParcela.Enabled = False
        txtVencimentoParcela.Enabled = False

    End Sub

    Private Sub gdvParcela_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdvParcela.CellClick

        Try

            limpaHabilitaCampos()

            Dim index As Integer
            index = e.RowIndex
            Dim linha As DataGridViewRow
            linha = gdvParcela.Rows(index)
            lblCodigoParcela.Text = linha.Cells(0).Value.ToString()
            txtValorParcela.Text = linha.Cells(1).Value.ToString()
            txtVencimentoParcela.Text = Format(Convert.ToDateTime(linha.Cells(2).Value.ToString()), "dd/MM/yyyy")

            btnNovo.Text = "Novo"
            btnNovo.Enabled = True
            btnInserirAtualizar.Enabled = True
            btnInserirAtualizar.Enabled = True
            btnDeletar.Enabled = True

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub btnInserirAtualizar_Click(sender As Object, e As EventArgs) Handles btnInserirAtualizar.Click

        Try
            If GetDateString(txtVencimentoParcela.Text) Then
                Dim result As Decimal
                If Decimal.TryParse(txtValorParcela.Text, result) Then
                    If lblCodigoParcela.Text.Equals(String.Empty) Then

                        Insere()

                    Else

                        Atualiza()

                    End If

                    PreencherGridParcelas()
                    btnNovo.Text = "Novo"
                    btnDeletar.Enabled = True

                Else
                    MsgBox("Digite o valor da parcela válida!")
                End If



            Else

                MsgBox("É necessário digitar um vencimento válido!")

            End If

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        End Try

    End Sub

    Private Function GetDateString(input As String) As Boolean

        Dim output As Boolean = False
        Dim dt As Date

        If Date.TryParseExact(input, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dt) Then
            output = True
        ElseIf Date.TryParseExact(input, "dd.MM.yyyy", Nothing, Globalization.DateTimeStyles.None, dt) Then
            output = True
        End If

        Return output

    End Function


    Public Sub Insere()

        Try

            Dim currentID As Integer
            objCommand = New SqlCommand

            strInstrucao = "Insert Into tbParcela (valor, vencimento, conveniadoId) Values(@valor, @vencimento, @conveniadoId); " + "SELECT SCOPE_IDENTITY()"
            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao
            objCommand.Parameters.AddWithValue("@valor", txtValorParcela.Text)
            objCommand.Parameters.AddWithValue("@vencimento", SqlDbType.Date).Value = Convert.ToDateTime(txtVencimentoParcela.Text)
            objCommand.Parameters.AddWithValue("@conveniadoId", Convert.ToInt32(cbmConveniados.SelectedValue.ToString()))

            objConexao.Open()
            currentID = objCommand.ExecuteScalar()
            lblCodigoParcela.Text = currentID.ToString()

            MsgBox("Registro inserido com sucesso!")

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Sub

    Public Sub Atualiza()

        Try

            objCommand = New SqlCommand

            strInstrucao = "Update tbParcela Set valor = @valor, vencimento = @vencimento, conveniadoId = @conveniadoId Where id = @idUP "
            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao
            objCommand.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValorParcela.Text))
            objCommand.Parameters.AddWithValue("@vencimento", txtVencimentoParcela.Text)
            objCommand.Parameters.AddWithValue("@conveniadoId", Convert.ToInt32(cbmConveniados.SelectedValue.ToString()))
            objCommand.Parameters.AddWithValue("@idUP", Convert.ToInt32(lblCodigoParcela.Text))

            objConexao.Open()
            objCommand.ExecuteNonQuery()

            MsgBox("Registro atualizado com sucesso!")

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        If btnNovo.Text.Equals("Novo") Then

            btnInserirAtualizar.Enabled = True
            limpaHabilitaCampos()
            btnDeletar.Enabled = False
            btnNovo.Text = "Cancelar Novo"

        Else

            btnNovo.Text = "Novo"
            limpaDesabilitaHabilitaCampos()
            btnInserirAtualizar.Enabled = False

        End If

    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click

        Try

            Dim result As DialogResult = MessageBox.Show("Confirma a exclusão da parcela no valor: '" + txtValorParcela.Text + "'?", "Title", MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then

                If (lblCodigoParcela.Text.Equals(String.Empty)) = False Then

                    strInstrucao = "Delete From tbParcela Where id = @idUP "

                    objCommand.CommandText = strInstrucao
                    objCommand.Connection = objConexao
                    objCommand.Parameters.AddWithValue("@idUP", Convert.ToInt32(lblCodigoParcela.Text))

                    objConexao.Open()
                    objCommand.ExecuteNonQuery()

                End If

                objConexao.Close()

                limpaDesabilitaHabilitaCampos()
                btnInserirAtualizar.Enabled = False
                btnDeletar.Enabled = False

                PreencherGridParcelas()
                MsgBox("Parcela Excluída com sucesso!")

            End If

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        End Try

    End Sub
End Class