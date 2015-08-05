Public Class logSesion
    Dim sesionID As Integer
    Dim usuario As logUsuario
    Dim fechaHoraInicioSesion, fechaHoraCierreSesion As DateTime

    Public Property gSesionID
        Get
            Return sesionID
        End Get
        Set(ByVal value)
            sesionID = value
        End Set
    End Property
    Public Property gUsuario
        Get
            Return usuario
        End Get
        Set(ByVal value)
            usuario = value
        End Set
    End Property
    Public Property gFechaHoraInicioSesion
        Get
            Return fechaHoraInicioSesion
        End Get
        Set(ByVal value)
            fechaHoraInicioSesion = value
        End Set
    End Property
    Public Property gFechaHoraCierreSesion
        Get
            Return fechaHoraCierreSesion
        End Get
        Set(ByVal value)
            fechaHoraCierreSesion = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(sesionID As Integer, usuario As logUsuario, fechaHoraInicioSesion As Date, fechaHoraCierreSesion As Date)
        gSesionID = sesionID
        gUsuario = usuario
        gFechaHoraInicioSesion = fechaHoraInicioSesion
        gFechaHoraCierreSesion = fechaHoraCierreSesion
    End Sub

End Class
