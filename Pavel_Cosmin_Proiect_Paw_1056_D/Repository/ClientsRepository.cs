using Pavel_Cosmin_Proiect_Paw_1056_D.Database;
using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Repository
{
    public class ClientsRepository : IClientsRepository
    {
        public void Add(Client client)
        {
            client.ID = Guid.NewGuid();
            FakeDatabase.Clients.Add(client);
        }

        public Client GetByID(Guid id)
        {
            return FakeDatabase.Clients.FirstOrDefault(x => x.ID == id);
        }
        
        public List<Client> GetAllClients()
        {
            return FakeDatabase.Clients;
        }
    }
}
