using dotnet_arrays_library.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Interfaces
{
    public interface IDALManager
    {
        Task<Manager> SaveManager(Manager oManager);
        Task<List<Manager>> GetManagers();
    }
}
