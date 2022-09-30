using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Repository
{
    public interface IClientsRepository
    {
        Client GetByID(Guid id);

        void Add(Client client);

        List<Client> GetAllClients();
    }
}
