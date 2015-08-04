<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeliculaBaja
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPelicula = New System.Windows.Forms.ComboBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnDarDeBaja = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPelicula)
        Me.GroupBox1.Controls.Add(Me.btnAtras)
        Me.GroupBox1.Controls.Add(Me.btnDarDeBaja)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(752, 236)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pelicula a dar de baja"
        '
        'cmbPelicula
        '
        Me.cmbPelicula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPelicula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPelicula.FormattingEnabled = True
        Me.cmbPelicula.Location = New System.Drawing.Point(216, 55)
        Me.cmbPelicula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPelicula.Name = "cmbPelicula"
        Me.cmbPelicula.Size = New System.Drawing.Size(320, 24)
        Me.cmbPelicula.Sorted = True
        Me.cmbPelicula.TabIndex = 5
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(393, 144)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(173, 66)
        Me.btnAtras.TabIndex = 4
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnDarDeBaja
        '
        Me.btnDarDeBaja.Location = New System.Drawing.Point(185, 144)
        Me.btnDarDeBaja.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDarDeBaja.Name = "btnDarDeBaja"
        Me.btnDarDeBaja.Size = New System.Drawing.Size(173, 66)
        Me.btnDarDeBaja.TabIndex = 3
        Me.btnDarDeBaja.Text = "Dar de Baja"
        Me.btnDarDeBaja.UseVisualStyleBackColor = True
        '
        'frmPeliculaBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 263)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPeliculaBaja"
        Me.Text = "PeliculaBaja"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPelicula As System.Windows.Forms.ComboBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnDarDeBaja As System.Windows.Forms.Button
End Class
