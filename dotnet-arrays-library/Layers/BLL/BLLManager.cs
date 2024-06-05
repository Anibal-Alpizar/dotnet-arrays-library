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
    public class BLLManager : IBLLManager
    {
        public async Task<List<Manager>> GetManagers()
        {
            IDALManager _DALManager = new DALManager();
            return await _DALManager.GetManagers();
        }

        public Task<Manager> SaveManager(Manager pManager)
        {
            IDALManager _DALManager = new DALManager();
            Task<Manager> oManager = null;
            oManager = _DALManager.SaveManager(pManager);
            return oManager;
        }
    }
}
