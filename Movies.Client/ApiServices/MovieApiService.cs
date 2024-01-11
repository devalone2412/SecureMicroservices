using Movies.Client.Models;

namespace Movies.Client.ApiServices;

public class MovieApiService : IMovieApiService
{
    public async Task<IEnumerable<Movie>> GetMovies()
    {
        var movieList = new List<Movie>();
        movieList.Add(new Movie
        {
            Id = 1,
            Title = "Pulp Fiction",
            Genre = "Crime, Drama",
            Rating = "8.9",
            ReleaseDate = new DateTime(1994, 10, 14),
            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51oDrzK%2BQFL._AC_.jpg",
            Owner = "james"
        });

        return await Task.FromResult(movieList);
    }

    public Task<Movie> GetMovie(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> CreateMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> UpdateMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMovie(int id)
    {
        throw new NotImplementedException();
    }
}