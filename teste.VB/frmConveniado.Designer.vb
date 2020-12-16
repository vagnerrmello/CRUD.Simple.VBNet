<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConveniado
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
        Me.lblCorretora = New System.Windows.Forms.Label()
        Me.lblCodigoConveniado = New System.Windows.Forms.Label()
        Me.lblNomeConveniado = New System.Windows.Forms.Label()
        Me.lblNascimentoConveniado = New System.Windows.Forms.Label()
        Me.cmbCorretora = New System.Windows.Forms.ComboBox()
        Me.txtNomeConveniado = New System.Windows.Forms.TextBox()
        Me.txtNascimentoConveniado = New System.Windows.Forms.TextBox()
        Me.gdvCorretora = New System.Windows.Forms.DataGridView()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnInserirAtualizar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.gdvCorretora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCorretora
        '
        Me.lblCorretora.AutoSize = True
        Me.lblCorretora.Location = New System.Drawing.Point(33, 19)
        Me.lblCorretora.Name = "lblCorretora"
        Me.lblCorretora.Size = New System.Drawing.Size(72, 17)
        Me.lblCorretora.TabIndex = 0
        Me.lblCorretora.Text = "Corretora:"
        '
        'lblCodigoConveniado
        '
        Me.lblCodigoConveniado.AutoSize = True
        Me.lblCodigoConveniado.Location = New System.Drawing.Point(33, 49)
        Me.lblCodigoConveniado.Name = "lblCodigoConveniado"
        Me.lblCodigoConveniado.Size = New System.Drawing.Size(127, 17)
        Me.lblCodigoConveniado.TabIndex = 1
        Me.lblCodigoConveniado.Text = "CodigoConveniado"
        '
        'lblNomeConveniado
        '
        Me.lblNomeConveniado.AutoSize = True
        Me.lblNomeConveniado.Location = New System.Drawing.Point(33, 76)
        Me.lblNomeConveniado.Name = "lblNomeConveniado"
        Me.lblNomeConveniado.Size = New System.Drawing.Size(49, 17)
        Me.lblNomeConveniado.TabIndex = 2
        Me.lblNomeConveniado.Text = "Nome:"
        '
        'lblNascimentoConveniado
        '
        Me.lblNascimentoConveniado.AutoSize = True
        Me.lblNascimentoConveniado.Location = New System.Drawing.Point(33, 108)
        Me.lblNascimentoConveniado.Name = "lblNascimentoConveniado"
        Me.lblNascimentoConveniado.Size = New System.Drawing.Size(86, 17)
        Me.lblNascimentoConveniado.TabIndex = 3
        Me.lblNascimentoConveniado.Text = "Nascimento:"
        '
        'cmbCorretora
        '
        Me.cmbCorretora.FormattingEnabled = True
        Me.cmbCorretora.Location = New System.Drawing.Point(127, 22)
        Me.cmbCorretora.Name = "cmbCorretora"
        Me.cmbCorretora.Size = New System.Drawing.Size(188, 24)
        Me.cmbCorretora.TabIndex = 4
        '
        'txtNomeConveniado
        '
        Me.txtNomeConveniado.Location = New System.Drawing.Point(127, 76)
        Me.txtNomeConveniado.Name = "txtNomeConveniado"
        Me.txtNomeConveniado.Size = New System.Drawing.Size(188, 22)
        Me.txtNomeConveniado.TabIndex = 5
        '
        'txtNascimentoConveniado
        '
        Me.txtNascimentoConveniado.Location = New System.Drawing.Point(127, 108)
        Me.txtNascimentoConveniado.Name = "txtNascimentoConveniado"
        Me.txtNascimentoConveniado.Size = New System.Drawing.Size(100, 22)
        Me.txtNascimentoConveniado.TabIndex = 6
        '
        'gdvCorretora
        '
        Me.gdvCorretora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvCorretora.Location = New System.Drawing.Point(27, 187)
        Me.gdvCorretora.Name = "gdvCorretora"
        Me.gdvCorretora.RowTemplate.Height = 24
        Me.gdvCorretora.Size = New System.Drawing.Size(434, 98)
        Me.gdvCorretora.TabIndex = 13
        '
        'btnDeletar
        '
        Me.btnDeletar.Location = New System.Drawing.Point(334, 149)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(127, 23)
        Me.btnDeletar.TabIndex = 16
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(27, 149)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(127, 23)
        Me.btnNovo.TabIndex = 15
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnInserirAtualizar
        '
        Me.btnInserirAtualizar.Location = New System.Drawing.Point(178, 149)
        Me.btnInserirAtualizar.Name = "btnInserirAtualizar"
        Me.btnInserirAtualizar.Size = New System.Drawing.Size(127, 23)
        Me.btnInserirAtualizar.TabIndex = 14
        Me.btnInserirAtualizar.Text = "Inserir/Atualizar"
        Me.btnInserirAtualizar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(334, 314)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(127, 23)
        Me.btnSair.TabIndex = 17
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmConveniado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 362)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnInserirAtualizar)
        Me.Controls.Add(Me.gdvCorretora)
        Me.Controls.Add(Me.txtNascimentoConveniado)
        Me.Controls.Add(Me.txtNomeConveniado)
        Me.Controls.Add(Me.cmbCorretora)
        Me.Controls.Add(Me.lblNascimentoConveniado)
        Me.Controls.Add(Me.lblNomeConveniado)
        Me.Controls.Add(Me.lblCodigoConveniado)
        Me.Controls.Add(Me.lblCorretora)
        Me.MaximizeBox = False
        Me.Name = "frmConveniado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conveniado"
        CType(Me.gdvCorretora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCorretora As System.Windows.Forms.Label
    Friend WithEvents lblCodigoConveniado As System.Windows.Forms.Label
    Friend WithEvents lblNomeConveniado As System.Windows.Forms.Label
    Friend WithEvents lblNascimentoConveniado As System.Windows.Forms.Label
    Friend WithEvents cmbCorretora As System.Windows.Forms.ComboBox
    Friend WithEvents txtNomeConveniado As System.Windows.Forms.TextBox
    Friend WithEvents txtNascimentoConveniado As System.Windows.Forms.TextBox
    Friend WithEvents gdvCorretora As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnInserirAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
