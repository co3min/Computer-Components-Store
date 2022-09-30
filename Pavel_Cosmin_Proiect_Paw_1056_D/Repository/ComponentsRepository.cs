using Pavel_Cosmin_Proiect_Paw_1056_D.Database;
using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Repository
{
    public class ComponentsRepository : IComponentRepository
    {
        public List<ComputerComponent> GetAllComponents()
        {
            return FakeDatabase.Components;
        }

        public ComputerComponent GetByID(Guid id)
        {
            return FakeDatabase.Components.FirstOrDefault(x => x.ID == id);
        }

        public List<ComputerComponent> GetCartShop()
        {
            return FakeDatabase.CartShop;
        }

        public void Delete(ComputerComponent computer)
        {
            FakeDatabase.Components.Remove(computer);
        }

        public void Add(ComputerComponent computer)
        {
            computer.ID = Guid.NewGuid();
            FakeDatabase.Components.Add(computer);
        }
    }
}
