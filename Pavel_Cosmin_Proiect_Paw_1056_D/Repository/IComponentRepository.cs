using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Repository
{
    public interface IComponentRepository
    {
        List<ComputerComponent> GetAllComponents();
        ComputerComponent GetByID(Guid id);
        List<ComputerComponent> GetCartShop();
        void Delete(ComputerComponent computer);
        void Add(ComputerComponent computer);
    }
}
