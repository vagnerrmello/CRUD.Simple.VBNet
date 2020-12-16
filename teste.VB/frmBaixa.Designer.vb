<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaixa
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
        Me.gdvParcela = New System.Windows.Forms.DataGridView()
        Me.cbmConveniados = New System.Windows.Forms.ComboBox()
        Me.lblConveniadoParcela = New System.Windows.Forms.Label()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtVencimentoParcela = New System.Windows.Forms.TextBox()
        Me.txtValorParcela = New System.Windows.Forms.TextBox()
        Me.lblVencimentoParcela = New System.Windows.Forms.Label()
        Me.lblValorParcela = New System.Windows.Forms.Label()
        Me.lblCodigoParcela = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSituacao = New System.Windows.Forms.Label()
        Me.btnBaixa = New System.Windows.Forms.Button()
        CType(Me.gdvParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdvParcela
        '
        Me.gdvParcela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvParcela.Location = New System.Drawing.Point(38, 248)
        Me.gdvParcela.Name = "gdvParcela"
        Me.gdvParcela.RowTemplate.Height = 24
        Me.gdvParcela.Size = New System.Drawing.Size(434, 98)
        Me.gdvParcela.TabIndex = 19
        '
        'cbmConveniados
        '
        Me.cbmConveniados.FormattingEnabled = True
        Me.cbmConveniados.Location = New System.Drawing.Point(38, 201)
        Me.cbmConveniados.Name = "cbmConveniados"
        Me.cbmConveniados.Size = New System.Drawing.Size(310, 24)
        Me.cbmConveniados.TabIndex = 21
        '
        'lblConveniadoParcela
        '
        Me.lblConveniadoParcela.AutoSize = True
        Me.lblConveniadoParcela.Location = New System.Drawing.Point(35, 181)
        Me.lblConveniadoParcela.Name = "lblConveniadoParcela"
        Me.lblConveniadoParcela.Size = New System.Drawing.Size(87, 17)
        Me.lblConveniadoParcela.TabIndex = 20
        Me.lblConveniadoParcela.Text = "Conveniado:"
        '
        'txtVencimentoParcela
        '
        Me.txtVencimentoParcela.Location = New System.Drawing.Point(154, 86)
        Me.txtVencimentoParcela.Name = "txtVencimentoParcela"
        Me.txtVencimentoParcela.Size = New System.Drawing.Size(100, 22)
        Me.txtVencimentoParcela.TabIndex = 26
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Location = New System.Drawing.Point(38, 86)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(100, 22)
        Me.txtValorParcela.TabIndex = 25
        '
        'lblVencimentoParcela
        '
        Me.lblVencimentoParcela.AutoSize = True
        Me.lblVencimentoParcela.Location = New System.Drawing.Point(151, 66)
        Me.lblVencimentoParcela.Name = "lblVencimentoParcela"
        Me.lblVencimentoParcela.Size = New System.Drawing.Size(86, 17)
        Me.lblVencimentoParcela.TabIndex = 24
        Me.lblVencimentoParcela.Text = "Vencimento:"
        '
        'lblValorParcela
        '
        Me.lblValorParcela.AutoSize = True
        Me.lblValorParcela.Location = New System.Drawing.Point(35, 66)
        Me.lblValorParcela.Name = "lblValorParcela"
        Me.lblValorParcela.Size = New System.Drawing.Size(45, 17)
        Me.lblValorParcela.TabIndex = 23
        Me.lblValorParcela.Text = "Valor:"
        '
        'lblCodigoParcela
        '
        Me.lblCodigoParcela.AutoSize = True
        Me.lblCodigoParcela.Location = New System.Drawing.Point(35, 37)
        Me.lblCodigoParcela.Name = "lblCodigoParcela"
        Me.lblCodigoParcela.Size = New System.Drawing.Size(114, 17)
        Me.lblCodigoParcela.TabIndex = 22
        Me.lblCodigoParcela.Text = "lblCodigoParcela"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Situação:"
        '
        'lblSituacao
        '
        Me.lblSituacao.AutoSize = True
        Me.lblSituacao.Location = New System.Drawing.Point(151, 120)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Size = New System.Drawing.Size(77, 17)
        Me.lblSituacao.TabIndex = 28
        Me.lblSituacao.Text = "lblSituacao"
        '
        'btnBaixa
        '
        Me.btnBaixa.Location = New System.Drawing.Point(269, 66)
        Me.btnBaixa.Name = "btnBaixa"
        Me.btnBaixa.Size = New System.Drawing.Size(203, 71)
        Me.btnBaixa.TabIndex = 29
        Me.btnBaixa.Text = "Baixar Parcela"
        Me.btnBaixa.UseVisualStyleBackColor = True
        '
        'frmBaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 414)
        Me.Controls.Add(Me.btnBaixa)
        Me.Controls.Add(Me.lblSituacao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVencimentoParcela)
        Me.Controls.Add(Me.txtValorParcela)
        Me.Controls.Add(Me.lblVencimentoParcela)
        Me.Controls.Add(Me.lblValorParcela)
        Me.Controls.Add(Me.lblCodigoParcela)
        Me.Controls.Add(Me.cbmConveniados)
        Me.Controls.Add(Me.lblConveniadoParcela)
        Me.Controls.Add(Me.gdvParcela)
        Me.MaximizeBox = False
        Me.Name = "frmBaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baixa"
        CType(Me.gdvParcela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gdvParcela As System.Windows.Forms.DataGridView
    Friend WithEvents cbmConveniados As System.Windows.Forms.ComboBox
    Friend WithEvents lblConveniadoParcela As System.Windows.Forms.Label
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtVencimentoParcela As System.Windows.Forms.TextBox
    Friend WithEvents txtValorParcela As System.Windows.Forms.TextBox
    Friend WithEvents lblVencimentoParcela As System.Windows.Forms.Label
    Friend WithEvents lblValorParcela As System.Windows.Forms.Label
    Friend WithEvents lblCodigoParcela As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSituacao As System.Windows.Forms.Label
    Friend WithEvents btnBaixa As System.Windows.Forms.Button
End Class
