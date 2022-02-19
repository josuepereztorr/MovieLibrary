using System;
using System.Collections.Generic;

class Library {
    private List<Movie> library = new List<Movie>();

    public List<Movie> getLibrary() {
        return library;
    }

    public void setLibrary(List<Movie> library) {
        this.library = library;
    }

    public void addMovie(Movie movie) {
        library.Add(movie);
    }
}