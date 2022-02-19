using System;
using System.Collections.Generic;

class Movie {
    public int MovieId {get; set;}
    public string Title {get; set;} 
    public int Year {get; set;}
    private List<string> genres = new List<string>();

    public List<string> getGenres() {
        return genres;
    }

    public void addGenre(string genre) {
        genres.Add(genre);
    }

}