using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Entities
{   
    [Serializable]
    public class Client
    {   
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        //public PaymentMethod Payment  { get; set; }
    }
}
