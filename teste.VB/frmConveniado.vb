Imports System.Data.SqlClient

Public Class frmConveniado

    Public Const strConexao As String = "Data Source=localhost;Initial Catalog=***;Integrated Security=True;MultipleActiveResultSets=True"
    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(strConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)

    Private Sub frmConveniado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCodigoConveniado.Text = String.Empty
        btnDeletar.Enabled = False

        If lblCodigoConveniado.Text.Equals(String.Empty) Then

            btnInserirAtualizar.Enabled = False
            txtNomeConveniado.Text = String.Empty
            txtNascimentoConveniado.Text = String.Empty
            txtNomeConveniado.Enabled = False
            txtNascimentoConveniado.Enabled = False

        End If

        PreencherGridCorretoras()
        PreencherGridConveniados()

    End Sub

    Public Sub limpaHabilitaCampos()

        lblCodigoConveniado.Text = String.Empty
        txtNomeConveniado.Text = String.Empty
        txtNascimentoConveniado.Text = String.Empty
        txtNomeConveniado.Enabled = True
        txtNascimentoConveniado.Enabled = True

    End Sub

    Public Sub limpaDesabilitaHabilitaCampos()

        lblCodigoConveniado.Text = String.Empty
        txtNomeConveniado.Text = String.Empty
        txtNascimentoConveniado.Text = String.Empty
        txtNomeConveniado.Enabled = False
        txtNascimentoConveniado.Enabled = False

    End Sub

    Public Sub PreencherGridCorretoras()

        Try

            objConexao.Open()
            Dim dataset As New DataSet
            Dim adapter As New SqlDataAdapter()
            adapter.SelectCommand = New SqlCommand("Select id, nome, percentual from tbCorretora", objConexao)
            adapter.Fill(dataset)

            cmbCorretora.DataSource = dataset.Tables(0)
            cmbCorretora.DisplayMember = "nome"
            cmbCorretora.ValueMember = "id"

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Sub

    Public Sub PreencherGridConveniados()

        Try

            If cmbCorretora.Items.Count > 0 Then

                Dim idcorretora As String = cmbCorretora.SelectedValue.ToString()

                gdvCorretora.DataSource = BindingSource
                strInstrucao = "Select id, nome, nascimento from tbConveniado where corretoraId = " + idcorretora

                Dim dataAdapter As New SqlDataAdapter(strInstrucao, strConexao)
                Dim commandBuilder As New SqlCommandBuilder(dataAdapter)
                Dim table As New DataTable()
                table.Locale = System.Globalization.CultureInfo.InvariantCulture
                dataAdapter.Fill(table)
                BindingSource.DataSource = table
                gdvCorretora.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)

            End If

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Sub

    Private Sub cmbCorretora_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCorretora.SelectionChangeCommitted

        PreencherGridConveniados()

    End Sub

    Private Sub gdvCorretora_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdvCorretora.CellClick

        Try

            limpaHabilitaCampos()

            Dim index As Integer
            index = e.RowIndex
            Dim linha As DataGridViewRow
            linha = gdvCorretora.Rows(index)
            lblCodigoConveniado.Text = linha.Cells(0).Value.ToString()
            txtNomeConveniado.Text = linha.Cells(1).Value.ToString()
            txtNascimentoConveniado.Text = Format(Convert.ToDateTime(linha.Cells(2).Value.ToString()), "dd/MM/yyyy")

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
            If GetDateString(txtNascimentoConveniado.Text) Then
                If txtNomeConveniado.Text.Equals(String.Empty) And txtNascimentoConveniado.Text.Equals(String.Empty) Then

                    MsgBox("É necessário digitar nome e nascimento válidos!")

                Else

                    If lblCodigoConveniado.Text.Equals(String.Empty) Then

                        Insere()

                    Else

                        Atualiza()

                    End If

                    PreencherGridConveniados()
                    btnNovo.Text = "Novo"
                    btnDeletar.Enabled = True

                End If
            Else
                MsgBox("Data de nascimento inválida!")
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

            strInstrucao = "Insert Into tbConveniado (nome, corretoraId, nascimento) Values(@nome, @corretoraId, @nascimento); " + "SELECT SCOPE_IDENTITY()"
            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao
            objCommand.Parameters.AddWithValue("@nome", txtNomeConveniado.Text)
            objCommand.Parameters.AddWithValue("@corretoraId", Convert.ToInt32(cmbCorretora.SelectedValue.ToString()))
            objCommand.Parameters.AddWithValue("@nascimento", SqlDbType.Date).Value = Convert.ToDateTime(txtNascimentoConveniado.Text)

            objConexao.Open()
            currentID = objCommand.ExecuteScalar()
            lblCodigoConveniado.Text = currentID.ToString()

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

            strInstrucao = "Update tbConveniado Set nome = @nomeUP, corretoraId = @corretoraIdUP, nascimento = @nascimentoUP Where id = @idUP "
            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao
            objCommand.Parameters.AddWithValue("@nomeUP", txtNomeConveniado.Text)
            objCommand.Parameters.AddWithValue("@corretoraIdUP", Convert.ToInt32(cmbCorretora.SelectedValue.ToString()))
            objCommand.Parameters.AddWithValue("@nascimentoUP", txtNascimentoConveniado.Text)
            objCommand.Parameters.AddWithValue("@idUP", Convert.ToInt32(lblCodigoConveniado.Text))

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

        AcaoBtnNovo()

    End Sub

    Public Sub AcaoBtnNovo()

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

            Dim result As DialogResult = MessageBox.Show("Confirma a exclusão do conveniado: '" + txtNomeConveniado.Text + "'?", "Title", MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then

                If (lblCodigoConveniado.Text.Equals(String.Empty)) = False Then

                    strInstrucao = "Delete From tbConveniado Where id = @idUP "

                    objCommand.CommandText = strInstrucao
                    objCommand.Connection = objConexao
                    objCommand.Parameters.AddWithValue("@idUP", Convert.ToInt32(lblCodigoConveniado.Text))

                    objConexao.Open()
                    objCommand.ExecuteNonQuery()

                End If

                objConexao.Close()

                limpaDesabilitaHabilitaCampos()
                btnInserirAtualizar.Enabled = False
                btnDeletar.Enabled = False

                PreencherGridConveniados()
                MsgBox("Corretora Excluída com sucesso!")

            End If

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class