using System;
using System.Collections.Generic;

class Movie {

    public int MovieId {get; set;}
    private string title;
    private int year;
    private List<string> genres = new List<string>();

    public Movie(int movieId, string title, int year, string genres) {

        this.MovieId = movieId;
        this.title = title;
        this.year = year;
        addGenre(genres);
    }

    public string getTitle() {
        return $"{title} ({year})";
    }

    public string getGenres() {
        return String.Join("|", this.genres);
    }

    private void addGenre(string genre) {

        string[] genreArr = genre.Split(",");

        foreach (string g in genreArr) {
            this.genres.Add(g);
        }
    }

}