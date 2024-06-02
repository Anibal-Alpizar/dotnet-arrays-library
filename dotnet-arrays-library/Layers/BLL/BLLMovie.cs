using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.DAL;
using dotnet_arrays_library.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Layers.BLL
{
    public class BLLMovie : IBLLMovie
    {
        public async Task<List<Movie>> GetAllMovies()
        {
            IDALMovie _DALCategoryMovie = new DALMovie();
            return await _DALCategoryMovie.GetAllMovies();
        }

        public Task<Movie> SaveMovie(Movie pmovie)
        {
            IDALMovie _DALMovie = new DALMovie();
            Task<Movie> oMovie = null;
            oMovie = _DALMovie.SaveMovie(pmovie);
            return oMovie;
        }
    }
}
