using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.Entities;
using dotnet_arrays_library.Layers.Entities.dto;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Layers.DAL
{
    public class DALMovieBranch : IDALMovieBranch
    {
        private static List<MovieBranch> movieBranches = new List<MovieBranch>(100);
        private readonly DALBranch _DALBranch = new DALBranch();
        private readonly DALMovie _DALMovie = new DALMovie();

        public async Task<List<MovieBranch>> GetMovieBranches()
        {
            return await Task.FromResult(movieBranches);
        }

        public async Task<MovieBranch> SaveMovieBranch(MovieBranch oMovieBranch)
        {
            var branches = await _DALBranch.GetBranches();

            if (!branches.Any()) throw new Exception("At least one branch is required to save a movie branch");

            if (movieBranches.Any(mb => mb.Branch.IdBranch == oMovieBranch.Branch.IdBranch && mb.Movie.IdMovie == oMovieBranch.Movie.IdMovie))
                throw new Exception("MoviexBranch combination already exists");

            movieBranches.Add(oMovieBranch);

            return await Task.FromResult(oMovieBranch);
        }

        public async Task<List<Movie>> GetAvailableMovies()
        {
            var movies = await _DALMovie.GetAllMovies();
            var associatedMovies = movieBranches.Select(mb => mb.Movie.IdMovie).Distinct().ToList();

            var availableMovies = movies.Where(m => !associatedMovies.Contains(m.IdMovie)).ToList();

            if (!availableMovies.Any()) throw new Exception("At least one movie is required to associate");

            return await Task.FromResult(availableMovies);
        }

        public async Task<List<MovieBranchDTO>> GetFullMovieBranchInfo()
        {
            var branches = await _DALBranch.GetBranches();
            var movies = await _DALMovie.GetAllMovies();

            var fullInfoList = new List<MovieBranchDTO>();

            foreach (var mb in movieBranches)
            {
                var branch = branches.FirstOrDefault(b => b.Name == mb.Branch.Name);
                var movie = movies.FirstOrDefault(m => m.IdMovie == mb.Movie.IdMovie);

                if (branch != null && movie != null)
                {
                    var fullInfo = new MovieBranchDTO
                    {
                        BranchId = branch.IdBranch,
                        BranchName = branch.Name,
                        BranchManager = branch.Manager,
                        BranchAddress = branch.Address,
                        BranchPhone = branch.Phone,
                        BranchActive = branch.Active,
                        MovieId = movie.IdMovie,
                        MovieTitle = movie.Title,
                        MovieCategory = movie.CategoryMovie,
                        MovieYear = movie.Year,
                        MovieLanguage = movie.Language,
                        Quantity = mb.Quantity
                    };

                    fullInfoList.Add(fullInfo);
                }
            }

            return fullInfoList;
        }

    }
}
