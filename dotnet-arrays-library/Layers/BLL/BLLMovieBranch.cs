using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.DAL;
using dotnet_arrays_library.Layers.Entities;
using dotnet_arrays_library.Layers.Entities.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Layers.BLL
{
    public class BLLMovieBranch : IBLLMovieBranch
    {
        public async Task<List<MovieBranch>> GetMovieBranches()
        {
            IDALMovieBranch _DALMovieBranch = new DALMovieBranch();
            return await _DALMovieBranch.GetMovieBranches();
        }

        public async Task<MovieBranch> SaveMovieBranch(MovieBranch movieBranch)
        {
            IDALMovieBranch _DALMovieBranch = new DALMovieBranch();
            return await _DALMovieBranch.SaveMovieBranch(movieBranch);
        }

        public async Task<List<Movie>> GetAvailableMovies()
        {
            IDALMovieBranch _DALMovieBranch = new DALMovieBranch();
            return await _DALMovieBranch.GetAvailableMovies();
        }

        public async Task<List<MovieBranchDTO>> GetFullMovieBranchInfo()
        {
            IDALMovieBranch _DALMovieBranch = new DALMovieBranch();
            return await _DALMovieBranch.GetFullMovieBranchInfo();
        }
    }
}
