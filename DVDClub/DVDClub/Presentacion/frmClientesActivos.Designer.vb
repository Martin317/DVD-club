<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesActivos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listClientesActivos = New System.Windows.Forms.ListView()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listClientesActivos
        '
        Me.listClientesActivos.Location = New System.Drawing.Point(16, 15)
        Me.listClientesActivos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listClientesActivos.Name = "listClientesActivos"
        Me.listClientesActivos.Size = New System.Drawing.Size(648, 500)
        Me.listClientesActivos.TabIndex = 0
        Me.listClientesActivos.UseCompatibleStateImageBehavior = False
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(565, 527)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(100, 28)
        Me.btnAtras.TabIndex = 43
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmClientesActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 570)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.listClientesActivos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmClientesActivos"
        Me.Text = "ClientesActivos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listClientesActivos As System.Windows.Forms.ListView
    Friend WithEvents btnAtras As System.Windows.Forms.Button
End Class
