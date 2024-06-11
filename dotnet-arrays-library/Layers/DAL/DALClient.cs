using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_arrays_library.Layers.DAL
{
    public class DALClient : IDALClient
    {
        private static List<Client> clients = new List<Client>(20);
        public async Task<List<Client>> GetClients()
        {
            return await Task.FromResult(clients);
        }

        public async Task<Client> SaveClient(Client oClient)
        {
            if (clients.Any(cli => cli.IdClient == oClient.IdClient)) throw new Exception("IdClient already exists");

            if (clients.Any(cli => cli.Identification == oClient.Identification && cli.IdClient != oClient.IdClient))
                throw new Exception("Identification already exists for another client");

            if (clients.Count >= 20) throw new Exception("Client list is full");

            clients.Add(oClient);

            return oClient;
        }
    }
}
