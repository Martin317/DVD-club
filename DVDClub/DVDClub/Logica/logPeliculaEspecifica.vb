Public Class logPeliculaEspecifica
    Dim peliculaEspecificaID As Integer
    Dim estado As logEstado
    Dim pelicula As logPelicula

    Public Property gPeliculaEspecificaID
        Get
            Return peliculaEspecificaID
        End Get
        Set(ByVal value)
            peliculaEspecificaID = value
        End Set
    End Property
    Public Property gEstado
        Get
            Return estado
        End Get
        Set(ByVal value)
            estado = value
        End Set
    End Property
    Public Property gPelicula
        Get
            Return pelicula
        End Get
        Set(ByVal value)
            pelicula = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(peliculaEspecificaID As Integer, estado As logEstado, pelicula As logPelicula)
        gPeliculaEspecificaID = peliculaEspecificaID
        gEstado = estado
        gPelicula = pelicula
    End Sub


End Class
