
Public Class logAlquiler
    Dim alquilerID As Integer
    Dim cliente As logCliente
    Dim fechaDevolucion, fechaEntrega As String
    Dim horaDevolucion, horaEntrega As String
    'TODO revisar tipo de dato SQLDATATIME
    Dim sesion As logSesion

    Public Property gAlquilerID
        Get
            Return alquilerID
        End Get
        Set(value)
            alquilerID = value
        End Set
    End Property
    Public Property gCliente
        Get
            Return cliente
        End Get
        Set(ByVal value)
            cliente = value
        End Set
    End Property
    Public Property gFechaDevolucion
        Get
            Return fechaDevolucion
        End Get
        Set(ByVal value)
            fechaDevolucion = value
        End Set
    End Property
    Public Property gFechaEntrega
        Get
            Return fechaEntrega
        End Get
        Set(ByVal value)
            fechaEntrega = value
        End Set
    End Property
    Public Property gHoraDevolucion
        Get
            Return horaDevolucion
        End Get
        Set(ByVal value)
            horaDevolucion = value
        End Set
    End Property
    Public Property gHoraEntrega
        Get
            Return horaEntrega
        End Get
        Set(ByVal value)
            horaEntrega = value
        End Set
    End Property
    Public Property gSesion
        Get
            Return sesion
        End Get
        Set(ByVal value)
            sesion = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(alquilerID As Integer, cliente As logCliente, fechaDevolucion As Date, fechaEntrega As Date, horaDevolucion As SqlTypes.SqlDateTime, horaEntrega As SqlTypes.SqlDateTime)
        gAlquilerID = alquilerID
        gCliente = cliente
        gFechaDevolucion = fechaDevolucion
        gFechaEntrega = fechaEntrega
        gHoraDevolucion = horaDevolucion
        gHoraEntrega = horaEntrega
    End Sub
End Class
