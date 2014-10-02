Public Class ProjectFilm ' a film styled project
    Inherits Project

    Dim FilmType As FilmTypes ' the types of film
    Enum FilmTypes
        FeatureFilm
        ShortFilm
        Series
    End Enum

    Dim Genre As FilmGenres 'the genre of film
    Enum FilmGenres
        Documentary
        Comedy
        Drama
        Romance
        'etc
    End Enum
End Class
