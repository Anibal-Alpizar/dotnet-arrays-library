using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Layers.DAL
{
    public class DALCategoryMovie : IDALCategoryMovie
    {
        private static List<CategoryMovie> categoryMovies = new List<CategoryMovie>(20);

        public async Task<List<CategoryMovie>> GetAllCategoryMovies()
        {
            return await Task.FromResult(categoryMovies);
        }


        public async Task<CategoryMovie> SaveCategoryMovie(CategoryMovie pCategoryMovie)
        {
            if (categoryMovies.Any(cat => cat.IdCategory == pCategoryMovie.IdCategory)) throw new Exception("IdCategory already exists");

            if (categoryMovies.Count >= 20) throw new Exception("CategoryMovie list is full");

            categoryMovies.Add(pCategoryMovie);

            return pCategoryMovie;
        }
    }
}
