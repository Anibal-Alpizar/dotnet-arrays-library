using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Layers.DAL
{
    public class DALManager : IDALManager
    {
        private static List<Manager> managers = new List<Manager>(20);

        public async Task<List<Manager>> GetManagers()
        {
            return await Task.FromResult(managers);
        }

        public async Task<Manager> SaveManager(Manager oManager)
        {
            if (managers.Any(man => man.IdManager == oManager.IdManager)) throw new Exception("IdManager already exists");

            if (managers.Any(man => man.Identification == oManager.Identification && man.IdManager != oManager.IdManager))
                throw new Exception("Identification already exists for another manager");

            if (managers.Count >= 20) throw new Exception("Manager list is full");

            managers.Add(oManager);

            return oManager;
        }
    }
}
