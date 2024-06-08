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
    public class BLLBranch : IBLLBranch
    {
        public async Task<List<Branch>> GetBranches()
        {
            IDALBranch _DALBranch = new DALBranch();
            return await _DALBranch.GetBranches();
        }

        public Task<Branch> SaveBranch(Branch pBranch)
        {
            IDALBranch _DALBranch = new DALBranch();
            Task<Branch> oBranch = null;
            oBranch = _DALBranch.SaveBranch(pBranch);
            return oBranch;
        }
    }
}
