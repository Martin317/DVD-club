<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevaPelicula = New System.Windows.Forms.Button()
        Me.btnModificarPelicula = New System.Windows.Forms.Button()
        Me.btnConsultarPelicula = New System.Windows.Forms.Button()
        Me.btnBajaPelicula = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pongo Links a los formularios que me tocan y los agrego al proyecto"
        '
        'btnNuevaPelicula
        '
        Me.btnNuevaPelicula.Location = New System.Drawing.Point(12, 100)
        Me.btnNuevaPelicula.Name = "btnNuevaPelicula"
        Me.btnNuevaPelicula.Size = New System.Drawing.Size(123, 43)
        Me.btnNuevaPelicula.TabIndex = 1
        Me.btnNuevaPelicula.Text = "Nueva Pelicula"
        Me.btnNuevaPelicula.UseVisualStyleBackColor = True
        '
        'btnModificarPelicula
        '
        Me.btnModificarPelicula.Location = New System.Drawing.Point(157, 100)
        Me.btnModificarPelicula.Name = "btnModificarPelicula"
        Me.btnModificarPelicula.Size = New System.Drawing.Size(123, 43)
        Me.btnModificarPelicula.TabIndex = 1
        Me.btnModificarPelicula.Text = "Modificar Pelicula"
        Me.btnModificarPelicula.UseVisualStyleBackColor = True
        '
        'btnConsultarPelicula
        '
        Me.btnConsultarPelicula.Location = New System.Drawing.Point(302, 100)
        Me.btnConsultarPelicula.Name = "btnConsultarPelicula"
        Me.btnConsultarPelicula.Size = New System.Drawing.Size(123, 43)
        Me.btnConsultarPelicula.TabIndex = 1
        Me.btnConsultarPelicula.Text = "Consultar Pelicula"
        Me.btnConsultarPelicula.UseVisualStyleBackColor = True
        '
        'btnBajaPelicula
        '
        Me.btnBajaPelicula.Location = New System.Drawing.Point(447, 100)
        Me.btnBajaPelicula.Name = "btnBajaPelicula"
        Me.btnBajaPelicula.Size = New System.Drawing.Size(123, 43)
        Me.btnBajaPelicula.TabIndex = 1
        Me.btnBajaPelicula.Text = "Baja Pelicula"
        Me.btnBajaPelicula.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 381)
        Me.Controls.Add(Me.btnBajaPelicula)
        Me.Controls.Add(Me.btnConsultarPelicula)
        Me.Controls.Add(Me.btnModificarPelicula)
        Me.Controls.Add(Me.btnNuevaPelicula)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNuevaPelicula As System.Windows.Forms.Button
    Friend WithEvents btnModificarPelicula As System.Windows.Forms.Button
    Friend WithEvents btnConsultarPelicula As System.Windows.Forms.Button
    Friend WithEvents btnBajaPelicula As System.Windows.Forms.Button

End Class
