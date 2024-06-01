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
    public class BLLCategoryMovie : IBLLCategoryMovie
    {
        public async Task<List<CategoryMovie>> GetAllCategoryMovies()
        {
            IDALCategoryMovie _DALCategoryMovie = new DALCategoryMovie();
            return await _DALCategoryMovie.GetAllCategoryMovies();
        }

        public Task<CategoryMovie> SaveCategoryMovie(CategoryMovie pCategoryMovie)
        {
            IDALCategoryMovie _DALCategoryMovie = new DALCategoryMovie();
            Task<CategoryMovie> oCategoryMovie = null;
            oCategoryMovie = _DALCategoryMovie.SaveCategoryMovie(pCategoryMovie);
            return oCategoryMovie;
        }
    }
}