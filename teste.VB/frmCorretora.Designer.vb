<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorretora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblCodigoCorretora = New System.Windows.Forms.Label()
        Me.lblNomeCorretora = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gdvCorretora = New System.Windows.Forms.DataGridView()
        Me.txtNomeCorretora = New System.Windows.Forms.TextBox()
        Me.txtPercentualCorretora = New System.Windows.Forms.TextBox()
        Me.btnInserirAtualizar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.gdvCorretora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigoCorretora
        '
        Me.lblCodigoCorretora.AutoSize = True
        Me.lblCodigoCorretora.Location = New System.Drawing.Point(27, 25)
        Me.lblCodigoCorretora.Name = "lblCodigoCorretora"
        Me.lblCodigoCorretora.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigoCorretora.TabIndex = 1
        Me.lblCodigoCorretora.Text = "Codigo"
        '
        'lblNomeCorretora
        '
        Me.lblNomeCorretora.AutoSize = True
        Me.lblNomeCorretora.Location = New System.Drawing.Point(27, 57)
        Me.lblNomeCorretora.Name = "lblNomeCorretora"
        Me.lblNomeCorretora.Size = New System.Drawing.Size(49, 17)
        Me.lblNomeCorretora.TabIndex = 2
        Me.lblNomeCorretora.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Percentual:"
        '
        'gdvCorretora
        '
        Me.gdvCorretora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvCorretora.Location = New System.Drawing.Point(30, 158)
        Me.gdvCorretora.Name = "gdvCorretora"
        Me.gdvCorretora.RowTemplate.Height = 24
        Me.gdvCorretora.Size = New System.Drawing.Size(434, 150)
        Me.gdvCorretora.TabIndex = 4
        '
        'txtNomeCorretora
        '
        Me.txtNomeCorretora.Location = New System.Drawing.Point(123, 54)
        Me.txtNomeCorretora.Name = "txtNomeCorretora"
        Me.txtNomeCorretora.Size = New System.Drawing.Size(215, 22)
        Me.txtNomeCorretora.TabIndex = 5
        '
        'txtPercentualCorretora
        '
        Me.txtPercentualCorretora.Location = New System.Drawing.Point(123, 89)
        Me.txtPercentualCorretora.Name = "txtPercentualCorretora"
        Me.txtPercentualCorretora.Size = New System.Drawing.Size(100, 22)
        Me.txtPercentualCorretora.TabIndex = 6
        '
        'btnInserirAtualizar
        '
        Me.btnInserirAtualizar.Location = New System.Drawing.Point(181, 129)
        Me.btnInserirAtualizar.Name = "btnInserirAtualizar"
        Me.btnInserirAtualizar.Size = New System.Drawing.Size(127, 23)
        Me.btnInserirAtualizar.TabIndex = 7
        Me.btnInserirAtualizar.Text = "Inserir/Atualizar"
        Me.btnInserirAtualizar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(30, 129)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(127, 23)
        Me.btnNovo.TabIndex = 8
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnDeletar
        '
        Me.btnDeletar.Location = New System.Drawing.Point(337, 129)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(127, 23)
        Me.btnDeletar.TabIndex = 9
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(337, 326)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(127, 23)
        Me.btnSair.TabIndex = 18
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmCorretora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 362)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnInserirAtualizar)
        Me.Controls.Add(Me.txtPercentualCorretora)
        Me.Controls.Add(Me.txtNomeCorretora)
        Me.Controls.Add(Me.gdvCorretora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNomeCorretora)
        Me.Controls.Add(Me.lblCodigoCorretora)
        Me.MaximizeBox = False
        Me.Name = "frmCorretora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corretora"
        CType(Me.gdvCorretora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigoCorretora As System.Windows.Forms.Label
    Friend WithEvents lblNomeCorretora As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gdvCorretora As System.Windows.Forms.DataGridView
    Friend WithEvents txtNomeCorretora As System.Windows.Forms.TextBox
    Friend WithEvents txtPercentualCorretora As System.Windows.Forms.TextBox
    Friend WithEvents btnInserirAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
