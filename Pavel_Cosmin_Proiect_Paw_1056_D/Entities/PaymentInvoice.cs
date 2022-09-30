using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Entities
{
    [Serializable]
    public class PaymentInvoice
    {
        public Guid ID { get; set; }
        public string InvoiceName { get; set; }
        public string Adress { get; set; }
        public Guid ClientID { get; set; }
        public PaymentMethod Payment { get; set; }
        public double Balance { get; set; }
    }
}
