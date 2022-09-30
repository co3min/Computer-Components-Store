using Pavel_Cosmin_Proiect_Paw_1056_D.Database;
using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Repository
{
    public interface IPaymentInvoiceRepository
    {
        void Add(PaymentInvoice payment);
        List<PaymentInvoice> GetListById(Guid Id);

        PaymentInvoice GetById(Guid clientId);

        List<PaymentInvoice> GetAllPaymentInvoices();
    }
}
