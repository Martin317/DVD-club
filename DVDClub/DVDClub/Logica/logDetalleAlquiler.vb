Public Class logDetalleAlquiler
    Dim detalleAlquilerID As Integer
    Dim alquiler As logAlquiler
    Dim peliculaEspecifica As logPeliculaEspecifica

    Public Property gDetalleAlquilerID
        Get
            Return detalleAlquilerID
        End Get
        Set(ByVal value)
            detalleAlquilerID = value
        End Set
    End Property
    Public Property gAlquiler
        Get
            Return alquiler
        End Get
        Set(ByVal value)
            alquiler = value
        End Set
    End Property
    Public Property gPeliculaEspecifica
        Get
            Return peliculaEspecifica
        End Get
        Set(ByVal value)
            peliculaEspecifica = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(detalleAlquilerID As Integer, alquiler As logAlquiler, peliculaEspecifica As logPeliculaEspecifica)
        gDetalleAlquilerID = detalleAlquilerID
        gAlquiler = alquiler
        gPeliculaEspecifica = peliculaEspecifica
    End Sub

End Class
