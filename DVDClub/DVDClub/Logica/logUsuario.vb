Public Class logUsuario
    Dim usuarioID As Integer
    Dim nombre, apellido, nombreUsuario As String
    Dim dni As ULong

    Public Property gUsuarioID
        Get
            Return usuarioID
        End Get
        Set(ByVal value)
            usuarioID = value
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
    Public Property gApellido
        Get
            Return apellido
        End Get
        Set(ByVal value)
            apellido = value
        End Set
    End Property
    Public Property gNombreUsuario
        Get
            Return nombreUsuario
        End Get
        Set(ByVal value)
            nombreUsuario = value
        End Set
    End Property
    Public Property gDni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(usuarioID As Integer, nombre As String, apellido As String, nombreUsuario As String, dni As ULong)
        gUsuarioID = usuarioID
        gNombre = nombre
        gApellido = apellido
        gNombreUsuario = nombreUsuario
        gDni = dni
    End Sub
End Class
