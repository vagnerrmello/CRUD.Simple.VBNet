Imports System.Data.SqlClient

Public Class frmCorretora

    Public Const strConexao As String = "Data Source=localhost;Initial Catalog=***;Integrated Security=True;MultipleActiveResultSets=True"
    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(strConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)

    Private Sub Corretora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCodigoCorretora.Text = String.Empty
        btnDeletar.Enabled = False

        If lblCodigoCorretora.Text.Equals(String.Empty) Then

            btnInserirAtualizar.Enabled = False
            txtNomeCorretora.Text = String.Empty
            txtPercentualCorretora.Text = String.Empty
            txtNomeCorretora.Enabled = False
            txtPercentualCorretora.Enabled = False

        End If

        PreencherGridCorretoras()

    End Sub

    Public Sub PreencherGridCorretoras()

        Try
            gdvCorretora.DataSource = BindingSource
            strInstrucao = "Select id, nome, percentual From tbCorretora "

            Dim dataAdapter As New SqlDataAdapter(strInstrucao, strConexao)
            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            dataAdapter.Fill(table)
            BindingSource.DataSource = table
            gdvCorretora.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub btnInserirAtualizar_Click(sender As Object, e As EventArgs) Handles btnInserirAtualizar.Click

        Try

            Dim result As Decimal
            If Decimal.TryParse(txtPercentualCorretora.Text, result) Then

                If txtNomeCorretora.Text.Equals(String.Empty) And txtPercentualCorretora.Text.Equals(String.Empty) Then

                    MsgBox("É necessário digitar o nome e o valor da percentagem!")

                Else
                    If lblCodigoCorretora.Text.Equals(String.Empty) Then

                        Insere()

                    Else

                        Atualiza()

                    End If

                    PreencherGridCorretoras()
                    btnNovo.Text = "Novo"
                    btnDeletar.Enabled = True

                End If

            Else
                MsgBox("O número percentual NÃO é válido!")
            End If

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)

        End Try

    End Sub

    Public Sub Insere()

        Try

            Dim currentID As Integer

            strInstrucao = "Insert Into tbCorretora (nome, percentual) Values (@nome, @percentual); " + "SELECT SCOPE_IDENTITY()"
            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao
            objCommand.Parameters.AddWithValue("@nome", txtNomeCorretora.Text)
            objCommand.Parameters.AddWithValue("@percentual", Convert.ToDecimal(txtPercentualCorretora.Text))

            objConexao.Open()
            currentID = objCommand.ExecuteScalar()
            lblCodigoCorretora.Text = currentID.ToString()

            MsgBox("Registro inserido com sucesso!")

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Sub

    Public Sub Atualiza()

        Try

            strInstrucao = "Update tbCorretora Set nome = @nomeUP, percentual = @percentualUP Where id = @idUP "
            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao
            objCommand.Parameters.AddWithValue("@nomeUP", txtNomeCorretora.Text)
            objCommand.Parameters.AddWithValue("@percentualUP", Convert.ToDecimal(txtPercentualCorretora.Text))
            objCommand.Parameters.AddWithValue("@idUP", Convert.ToInt32(lblCodigoCorretora.Text))

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

    Public Sub limpaHabilitaCampos()

        lblCodigoCorretora.Text = String.Empty
        txtNomeCorretora.Text = String.Empty
        txtPercentualCorretora.Text = String.Empty
        txtNomeCorretora.Enabled = True
        txtPercentualCorretora.Enabled = True

    End Sub

    Public Sub limpaDesabilitaHabilitaCampos()

        lblCodigoCorretora.Text = String.Empty
        txtNomeCorretora.Text = String.Empty
        txtPercentualCorretora.Text = String.Empty
        txtNomeCorretora.Enabled = False
        txtPercentualCorretora.Enabled = False

    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click

        Try

            Dim result As DialogResult = MessageBox.Show("Confirma a exclusão da corretora: '" + txtNomeCorretora.Text + "'?", "Title", MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then

                If (lblCodigoCorretora.Text.Equals(String.Empty)) = False Then

                    strInstrucao = "Delete From tbCorretora Where id = @idUP "

                    objCommand.CommandText = strInstrucao
                    objCommand.Connection = objConexao
                    objCommand.Parameters.AddWithValue("@idUP", Convert.ToInt32(lblCodigoCorretora.Text))

                    objConexao.Open()
                    objCommand.ExecuteNonQuery()

                End If

                objConexao.Close()

                limpaDesabilitaHabilitaCampos()
                btnInserirAtualizar.Enabled = False
                btnDeletar.Enabled = False

                PreencherGridCorretoras()
                MsgBox("Corretora Excluída com sucesso!")

            End If

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub gdvCorretora_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdvCorretora.CellClick

        Try

            limpaHabilitaCampos()

            Dim index As Integer
            index = e.RowIndex
            Dim linha As DataGridViewRow
            linha = gdvCorretora.Rows(index)
            lblCodigoCorretora.Text = linha.Cells(0).Value.ToString()
            txtNomeCorretora.Text = linha.Cells(1).Value.ToString()
            txtPercentualCorretora.Text = linha.Cells(2).Value.ToString()

            btnNovo.Text = "Novo"
            btnNovo.Enabled = True
            btnInserirAtualizar.Enabled = True
            btnInserirAtualizar.Enabled = True
            btnDeletar.Enabled = True

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class