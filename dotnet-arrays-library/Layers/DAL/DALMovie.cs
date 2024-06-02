using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Layers.DAL
{
    public class DALMovie : IDALMovie
    {
        private static List<Movie> movies = new List<Movie>(20);
        private readonly DALCategoryMovie _DALCategoryMovie = new DALCategoryMovie();

        public async Task<List<Movie>> GetAllMovies()
        {
            return await Task.FromResult(movies);
        }

        public async Task<Movie> SaveMovie(Movie pMovie)
        {
            var categories = await _DALCategoryMovie.GetAllCategoryMovies();

            if (!categories.Any()) throw new Exception("At least one category is required to save a movie");

            if (!categories.Any(cat => cat.Name == pMovie.CategoryMovie.Name))
                throw new Exception("The specified category does not exist");

            if (movies.Any(mov => mov.IdMovie == pMovie.IdMovie)) throw new Exception("Movie id already exists");

            if (movies.Count >= 20) throw new Exception("The maximum number of movies has been reached");

            movies.Add(pMovie);

            return pMovie;
        }
    }
}
