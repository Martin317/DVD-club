Public Class logCliente
    Dim nombre, apellido, direccion, email As String
    Dim telefono, dni As Int64
    Dim dadoDeBaja, esDeudor As Boolean
    Dim estado As logEstado
    Dim fechaDeAlta As Date
    Dim clienteID As Integer

    Public Property gClienteID
        Get
            Return clienteID
        End Get
        Set(value)
            clienteID = value
        End Set
    End Property
    Public Property gNombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property
    Public Property gApellido
        Get
            Return apellido
        End Get
        Set(value)
            apellido = value
        End Set
    End Property
    Public Property gDireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property
    Public Property gEmail
        Get
            Return email
        End Get
        Set(value)
            email = value
        End Set
    End Property
    Public Property gTelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property
    Public Property gDni
        Get
            Return dni
        End Get
        Set(value)
            dni = value
        End Set
    End Property
    Public Property gDadoDeBaja
        Get
            Return dadoDeBaja
        End Get
        Set(value)
            dadoDeBaja = value
        End Set
    End Property
    Public Property gEsDeudor
        Get
            Return esDeudor
        End Get
        Set(value)
            esDeudor = value
        End Set
    End Property
    Public Property gEstado
        Get
            Return estado
        End Get
        Set(value)
            estado = value
        End Set
    End Property
    Public Property gFechaDeAlta
        Get
            Return fechaDeAlta
        End Get
        Set(value)
            fechaDeAlta = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(nombre As String, apellido As String, direccion As String, email As String, telefono As ULong, dni As ULong, dadoDeBaja As Boolean, esDeudor As Boolean, estado As logEstado, fechaDeAlta As Date, clienteID As Integer)
        gNombre = nombre
        gApellido = apellido
        gDireccion = direccion
        gEmail = email
        gTelefono = telefono
        gDni = dni
        gDadoDeBaja = dadoDeBaja
        gEsDeudor = esDeudor
        gEstado = estado
        gFechaDeAlta = fechaDeAlta
        gClienteID = clienteID
    End Sub
End Class
