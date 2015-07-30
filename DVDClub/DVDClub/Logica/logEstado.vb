Public Class logEstado
    Dim estadoID As Integer
    Dim nombre, descripcion, ambito As String

    Public Property gEstadoID
        Get
            Return estadoID
        End Get
        Set(ByVal value)
            estadoID = value
        End Set
    End Property
    Public Property gNombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property
    Public Property gDescripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property
    Public Property gAmbito
        Get
            Return ambito
        End Get
        Set(ByVal value)
            ambito = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(estadoID As Integer, nombre As String, descripcion As String, ambito As String)
        gEstadoID = estadoID
        gNombre = nombre
        gDescripcion = descripcion
        gAmbito = ambito
    End Sub
End Class
