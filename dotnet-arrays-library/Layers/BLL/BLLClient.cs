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
    public class BLLClient : IBLLClient
    {
        public async Task<List<Client>> GetClients()
        {
            IDALClient _DALClient = new DALClient();
            return await  _DALClient.GetClients();
        }

        public Task<Client> SaveClient(Client pclient)
        {
            IDALClient _DALClient = new DALClient();
            Task<Client> oClient = null;
            oClient = _DALClient.SaveClient(pclient);
            return oClient;
        }
    }
}
