type Genre = 
    |Horror 
    | Drama 
    | Thriller 
    | Comedy 
    | Fantasy 
    | Sport

type Director = {
    Name: string
    Movies: int
}
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDbRating: float
}
let genreToString (genre: Genre) =
    match genre with
    | Horror -> "Horror"
    | Drama -> "Drama"
    | Thriller -> "Thriller"
    | Comedy -> "Comedy"
    | Fantasy -> "Fantasy"
    | Sport -> "Sport"

let movies : Movie list = [
    {
        Name = "CODA"
        RunLength = 111
        Genre = Drama
        Director = { Name = "Sian Heder"; Movies = 9 }
        IMDbRating = 8.1
    }
    {
        Name = "Belfast"
        RunLength = 98
        Genre = Comedy
        Director = { Name = "Kenneth Branagh"; Movies = 23 }
        IMDbRating = 7.3
    }
    {
        Name = "Don't Look Up"
        RunLength = 138
        Genre = Comedy
        Director = { Name = "Adam McKay"; Movies = 27 }
        IMDbRating = 7.2
    }
    {
        Name = "Drive My Car"
        RunLength = 155
        Genre = Drama
        Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }
        IMDbRating = 7.6
    }
    {
        Name = "Dune"
        RunLength = 179
        Genre = Fantasy
        Director = { Name = "Denis Villeneuve"; Movies = 24 }
        IMDbRating = 8.1
    }
    {
        Name = "King Richard"
        RunLength = 144
        Genre = Sport
        Director = { Name = "Reinaldo Marcus Green"; Movies = 22 }
        IMDbRating = 7.5
    }
    {
        Name = "Licorice Pizza"
        RunLength = 133
        Genre = Comedy
        Director = { Name = "Paul Thomas Anderson"; Movies = 8 }
        IMDbRating = 7.4
    }
    {
        Name = "Nightmare Alley"
        RunLength = 150
        Genre = Thriller
        Director = { Name = "Guillermo Del Toro"; Movies = 15 }
        IMDbRating = 7.1
    }
]

let probableOscarWinners = movies |> List.filter (fun movie -> movie.IMDbRating > 7.4)

let convertRunLengthToHours (runLength: int) =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

printfn "D. Oscar Winners (Probable):"
probableOscarWinners |> List.iter (fun movie -> printfn "%s (%s) - IMDb Rating: %.1f" movie.Name (genreToString movie.Genre) movie.IMDbRating)

printfn "E. Run Lengths of movies in Hours:"
movies
|> List.iter (fun movie ->
    let runLengthInHours = convertRunLengthToHours movie.RunLength
    printfn "%s - %s" movie.Name runLengthInHours
)

printfn "C. All Movie Names:"
movies |> List.iter (fun movie -> printfn "%s" movie.Name)
