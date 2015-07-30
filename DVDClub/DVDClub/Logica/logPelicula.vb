Public Class logPelicula
    Dim peliculaID As Integer
    Dim nombre, idioma, genero, descripcion As String
    Dim fechaLanzamiento As Date

    Public Property gPeliculaID
        Get
            Return peliculaID
        End Get
        Set(ByVal value)
            peliculaID = value
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
    Public Property gIdioma
        Get
            Return idioma
        End Get
        Set(ByVal value)
            idioma = value
        End Set
    End Property
    Public Property gGenero
        Get
            Return genero
        End Get
        Set(ByVal value)
            genero = value
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
    Public Property gFechaLanzamiento
        Get
            Return fechaLanzamiento
        End Get
        Set(ByVal value)
            fechaLanzamiento = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(peliculaID As Integer, nombre As String, idioma As String, genero As String, descripcion As String, fechaLanzamiento As Date)
        gPeliculaID = peliculaID
        gNombre = nombre
        gIdioma = idioma
        gGenero = genero
        gDescripcion = descripcion
        gFechaLanzamiento = fechaLanzamiento
    End Sub

End Class
