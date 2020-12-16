Imports System.Data.SqlClient

Public Class frmBaixa

    Public Const strConexao As String = "Data Source=localhost;Initial Catalog=***;Integrated Security=True;MultipleActiveResultSets=True"
    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(strConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)

    Private Sub frmBaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCodigoParcela.Text = String.Empty

        PreencherComboConveniados()
        PesquisaBaixas()

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

    Public Sub PesquisaBaixas()

        Try

            If cbmConveniados.Items.Count > 0 Then

                Dim idConveniado As String = cbmConveniados.SelectedValue.ToString()

                gdvParcela.DataSource = BindingSource
                strInstrucao = "Select pa.id, pa.valor, pa.vencimento, " +
                                    "CASE (Select 1 From tbComissaoItem ci where ci.parcelaId = pa.id ) " +
                                        "WHEN '1' THEN 'PAGO'" +
                                        "Else 'EM ABERTO'" +
                                    "END As Situação " +
                                "From tbParcela pa Where pa.conveniadoId = " + idConveniado

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

    Private Sub btnBaixa_Click(sender As Object, e As EventArgs) Handles btnBaixa.Click

        Try
            ExecuteProcedureCARGA()

            PesquisaBaixas()

            Dim retorno As String = String.Empty
            Dim idconveniado As String = RetornaIdConveniado()

            strInstrucao = "Select pa.id, pa.valor, pa.vencimento, " +
                                "CASE (Select 1 From tbComissaoItem ci where ci.parcelaId = pa.id ) " +
                                    "WHEN '1' THEN 'PAGO'" +
                                    "Else 'EM ABERTO'" +
                                "END As Situação " +
                            "From tbParcela pa Where pa.conveniadoId = @idConveniado " +
                            "And pa.id = @idparcela "

            objCommand = New SqlCommand(strInstrucao, objConexao)
            objCommand.Parameters.AddWithValue("@idConveniado", SqlDbType.Int).Value = Convert.ToInt32(idconveniado)
            objCommand.Parameters.AddWithValue("@idparcela", SqlDbType.Int).Value = Convert.ToInt32(lblCodigoParcela.Text)

            objConexao.Open()


            Using r = objCommand.ExecuteReader()

                If r.Read() Then

                    lblSituacao.Text = r.GetString(3)

                End If
            End Using

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Sub

    Public Sub ExecuteProcedureCARGA()

        Try

            Dim retorno As String = String.Empty
            Dim idcorrector As String = RetornaIdConveniado()

            objCommand = New SqlCommand("sp_Gerar_Carga_Comissionado", objConexao)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@INdcmValorTotalCarga", SqlDbType.Decimal).Value = Convert.ToDecimal(txtValorParcela.Text)
            objCommand.Parameters.AddWithValue("@INidParcela", SqlDbType.Int).Value = Convert.ToInt32(lblCodigoParcela.Text)
            objCommand.Parameters.AddWithValue("@INidCorretora", SqlDbType.Int).Value = Convert.ToInt32(idcorrector)

            objConexao.Open()
            objCommand.ExecuteReader()

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Sub

    Public Function RetornaIdConveniado() As String

        Try

            Dim idConveniado As String = cbmConveniados.SelectedValue.ToString()
            Dim idcorrector As String = String.Empty

            objConexao.Open()
            Dim dataset As New DataSet
            Dim adapter As New SqlDataAdapter()
            adapter.SelectCommand = New SqlCommand("Select corretoraId from tbConveniado Where id = " + idConveniado, objConexao)
            adapter.Fill(dataset)

            For Each item As DataTable In dataset.Tables()
                For Each row As DataRow In item.Rows
                    For Each column As DataColumn In item.Columns
                        idcorrector = row(column).ToString()
                    Next
                Next
            Next

            Return idcorrector

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Function

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
            If linha.Cells(3).Value.ToString().Equals("PAGO") Then

                MsgBox("Parcela já foi paga!")

            Else

                lblCodigoParcela.Text = linha.Cells(0).Value.ToString()
                txtValorParcela.Text = linha.Cells(1).Value.ToString()
                txtVencimentoParcela.Text = Format(Convert.ToDateTime(linha.Cells(2).Value.ToString()), "dd/MM/yyyy")
                lblSituacao.Text = linha.Cells(3).Value.ToString()

            End If

        Catch ex As Exception
            MsgBox("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub cbmConveniados_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbmConveniados.SelectionChangeCommitted

        PesquisaBaixas()
        limpaDesabilitaHabilitaCampos()

    End Sub
End Class