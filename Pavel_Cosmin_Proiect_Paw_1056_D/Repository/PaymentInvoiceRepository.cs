using Pavel_Cosmin_Proiect_Paw_1056_D.Database;
using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Repository
{
    public class PaymentInvoiceRepository : IPaymentInvoiceRepository
    {
        public void Add(PaymentInvoice payment)
        {
            payment.ID = Guid.NewGuid();
            FakeDatabase.Invoices.Add(payment);
        }
        public PaymentInvoice GetById(Guid clientId)
        {
            return FakeDatabase.Invoices.FirstOrDefault(x => x.ClientID == clientId);
        }

        public List<PaymentInvoice> GetListById(Guid Id)
        {
            return FakeDatabase.Invoices.Where(x => x.ID == Id).ToList();
        }

        public List<PaymentInvoice> GetAllPaymentInvoices()
        {
            return FakeDatabase.Invoices;
        }
    }
}
