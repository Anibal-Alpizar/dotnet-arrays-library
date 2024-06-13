using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Layers.DAL
{
    public class DALBranch : IDALBranch
    {
        private static List<Branch> branches = new List<Branch>(5);
        private readonly DALManager _DALManager = new DALManager();

        public async Task<List<Branch>> GetBranches()
        {
            return await Task.FromResult(branches);
        }

        public async Task<List<Branch>> GetAvailableBranches()
        {
            var branches = await GetBranches();

            return branches.Where(br => br.Active).Select(br => new Branch { Name = br.Name }).ToList();
        }

        public async Task<Branch> SaveBranch(Branch pBranch)
        {
            var managers = await _DALManager.GetManagers();

            if (!managers.Any()) throw new Exception("At least one manager is required to save a branch");

            if (!managers.Any(managers => managers.IdManager == pBranch.Manager.IdManager)) throw new Exception("The specified manager does not exist");

            if (branches.Any(br => br.IdBranch == pBranch.IdBranch)) throw new Exception("Branch id already exists");

            if (branches.Count >= 5) throw new Exception("The maximum number of branches has been reached");

            branches.Add(pBranch);

            return pBranch;
        }
    }
}
