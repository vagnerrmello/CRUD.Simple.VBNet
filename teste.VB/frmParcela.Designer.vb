<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParcela
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
        Me.lblCodigoParcela = New System.Windows.Forms.Label()
        Me.lblValorParcela = New System.Windows.Forms.Label()
        Me.lblVencimentoParcela = New System.Windows.Forms.Label()
        Me.lblConveniadoParcela = New System.Windows.Forms.Label()
        Me.txtValorParcela = New System.Windows.Forms.TextBox()
        Me.txtVencimentoParcela = New System.Windows.Forms.TextBox()
        Me.cbmConveniados = New System.Windows.Forms.ComboBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnInserirAtualizar = New System.Windows.Forms.Button()
        Me.gdvParcela = New System.Windows.Forms.DataGridView()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.gdvParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigoParcela
        '
        Me.lblCodigoParcela.AutoSize = True
        Me.lblCodigoParcela.Location = New System.Drawing.Point(22, 22)
        Me.lblCodigoParcela.Name = "lblCodigoParcela"
        Me.lblCodigoParcela.Size = New System.Drawing.Size(114, 17)
        Me.lblCodigoParcela.TabIndex = 0
        Me.lblCodigoParcela.Text = "lblCodigoParcela"
        '
        'lblValorParcela
        '
        Me.lblValorParcela.AutoSize = True
        Me.lblValorParcela.Location = New System.Drawing.Point(22, 51)
        Me.lblValorParcela.Name = "lblValorParcela"
        Me.lblValorParcela.Size = New System.Drawing.Size(45, 17)
        Me.lblValorParcela.TabIndex = 1
        Me.lblValorParcela.Text = "Valor:"
        '
        'lblVencimentoParcela
        '
        Me.lblVencimentoParcela.AutoSize = True
        Me.lblVencimentoParcela.Location = New System.Drawing.Point(22, 86)
        Me.lblVencimentoParcela.Name = "lblVencimentoParcela"
        Me.lblVencimentoParcela.Size = New System.Drawing.Size(86, 17)
        Me.lblVencimentoParcela.TabIndex = 2
        Me.lblVencimentoParcela.Text = "Vencimento:"
        '
        'lblConveniadoParcela
        '
        Me.lblConveniadoParcela.AutoSize = True
        Me.lblConveniadoParcela.Location = New System.Drawing.Point(22, 127)
        Me.lblConveniadoParcela.Name = "lblConveniadoParcela"
        Me.lblConveniadoParcela.Size = New System.Drawing.Size(87, 17)
        Me.lblConveniadoParcela.TabIndex = 3
        Me.lblConveniadoParcela.Text = "Conveniado:"
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Location = New System.Drawing.Point(114, 51)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(100, 22)
        Me.txtValorParcela.TabIndex = 4
        '
        'txtVencimentoParcela
        '
        Me.txtVencimentoParcela.Location = New System.Drawing.Point(114, 86)
        Me.txtVencimentoParcela.Name = "txtVencimentoParcela"
        Me.txtVencimentoParcela.Size = New System.Drawing.Size(100, 22)
        Me.txtVencimentoParcela.TabIndex = 5
        '
        'cbmConveniados
        '
        Me.cbmConveniados.FormattingEnabled = True
        Me.cbmConveniados.Location = New System.Drawing.Point(25, 147)
        Me.cbmConveniados.Name = "cbmConveniados"
        Me.cbmConveniados.Size = New System.Drawing.Size(310, 24)
        Me.cbmConveniados.TabIndex = 6
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(332, 359)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(127, 23)
        Me.btnSair.TabIndex = 22
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnDeletar
        '
        Me.btnDeletar.Location = New System.Drawing.Point(332, 194)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(127, 23)
        Me.btnDeletar.TabIndex = 21
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(25, 194)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(127, 23)
        Me.btnNovo.TabIndex = 20
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnInserirAtualizar
        '
        Me.btnInserirAtualizar.Location = New System.Drawing.Point(176, 194)
        Me.btnInserirAtualizar.Name = "btnInserirAtualizar"
        Me.btnInserirAtualizar.Size = New System.Drawing.Size(127, 23)
        Me.btnInserirAtualizar.TabIndex = 19
        Me.btnInserirAtualizar.Text = "Inserir/Atualizar"
        Me.btnInserirAtualizar.UseVisualStyleBackColor = True
        '
        'gdvParcela
        '
        Me.gdvParcela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvParcela.Location = New System.Drawing.Point(25, 232)
        Me.gdvParcela.Name = "gdvParcela"
        Me.gdvParcela.RowTemplate.Height = 24
        Me.gdvParcela.Size = New System.Drawing.Size(434, 98)
        Me.gdvParcela.TabIndex = 18
        '
        'frmParcela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 392)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnInserirAtualizar)
        Me.Controls.Add(Me.gdvParcela)
        Me.Controls.Add(Me.cbmConveniados)
        Me.Controls.Add(Me.txtVencimentoParcela)
        Me.Controls.Add(Me.txtValorParcela)
        Me.Controls.Add(Me.lblConveniadoParcela)
        Me.Controls.Add(Me.lblVencimentoParcela)
        Me.Controls.Add(Me.lblValorParcela)
        Me.Controls.Add(Me.lblCodigoParcela)
        Me.MaximizeBox = False
        Me.Name = "frmParcela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parcela"
        CType(Me.gdvParcela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigoParcela As System.Windows.Forms.Label
    Friend WithEvents lblValorParcela As System.Windows.Forms.Label
    Friend WithEvents lblVencimentoParcela As System.Windows.Forms.Label
    Friend WithEvents lblConveniadoParcela As System.Windows.Forms.Label
    Friend WithEvents txtValorParcela As System.Windows.Forms.TextBox
    Friend WithEvents txtVencimentoParcela As System.Windows.Forms.TextBox
    Friend WithEvents cbmConveniados As System.Windows.Forms.ComboBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnInserirAtualizar As System.Windows.Forms.Button
    Friend WithEvents gdvParcela As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
End Class
