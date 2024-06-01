using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnet_arrays_library.Layers.Entities;

namespace dotnet_arrays_library.Interfaces
{
    public interface IDALCategoryMovie
    {
        Task<CategoryMovie> SaveCategoryMovie(CategoryMovie pCategoryMovie);
        Task<List<CategoryMovie>> GetAllCategoryMovies();

    }
}
