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
        Me.listClientesActivos.Location = New System.Drawing.Point(12, 12)
        Me.listClientesActivos.Name = "listClientesActivos"
        Me.listClientesActivos.Size = New System.Drawing.Size(487, 407)
        Me.listClientesActivos.TabIndex = 0
        Me.listClientesActivos.UseCompatibleStateImageBehavior = False
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(424, 428)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 43
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'ClientesActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 463)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.listClientesActivos)
        Me.Name = "ClientesActivos"
        Me.Text = "ClientesActivos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listClientesActivos As System.Windows.Forms.ListView
    Friend WithEvents btnAtras As System.Windows.Forms.Button
End Class
