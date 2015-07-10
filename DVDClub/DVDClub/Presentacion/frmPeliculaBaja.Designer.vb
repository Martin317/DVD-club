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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDarDeBaja = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPelicula)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnDarDeBaja)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 192)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pelicula a dar de baja"
        '
        'cmbPelicula
        '
        Me.cmbPelicula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPelicula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPelicula.FormattingEnabled = True
        Me.cmbPelicula.Location = New System.Drawing.Point(162, 45)
        Me.cmbPelicula.Name = "cmbPelicula"
        Me.cmbPelicula.Size = New System.Drawing.Size(241, 21)
        Me.cmbPelicula.Sorted = True
        Me.cmbPelicula.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(295, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 54)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDarDeBaja
        '
        Me.btnDarDeBaja.Location = New System.Drawing.Point(139, 117)
        Me.btnDarDeBaja.Name = "btnDarDeBaja"
        Me.btnDarDeBaja.Size = New System.Drawing.Size(130, 54)
        Me.btnDarDeBaja.TabIndex = 3
        Me.btnDarDeBaja.Text = "Dar de Baja"
        Me.btnDarDeBaja.UseVisualStyleBackColor = True
        '
        'PeliculaBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 214)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PeliculaBaja"
        Me.Text = "PeliculaBaja"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPelicula As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnDarDeBaja As System.Windows.Forms.Button
End Class
