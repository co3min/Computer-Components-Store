using Pavel_Cosmin_Proiect_Paw_1056_D.Database;
using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
using Pavel_Cosmin_Proiect_Paw_1056_D.Extensions;
using Pavel_Cosmin_Proiect_Paw_1056_D.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavel_Cosmin_Proiect_Paw_1056_D
{
    public partial class InvoiceForm : Form
    {
        private IClientsRepository _clientsRepository;
        private IPaymentInvoiceRepository _paymentInvoice;
        private IComponentRepository _componentRepo;
        private Guid _clientID;
        public InvoiceForm(Guid id)
        {
            InitializeComponent();
            _componentRepo = new ComponentsRepository();

            _clientID = id;
            _paymentInvoice = new PaymentInvoiceRepository();
            var invoicePay = _paymentInvoice.GetById(id);
            txtName.Text = invoicePay.InvoiceName;
            txtAdress.Text = invoicePay.Adress;

            _clientsRepository = new ClientsRepository();
            var client = _clientsRepository.GetByID(invoicePay.ClientID);
            txtClient.Text = client.FirstName + " " + client.LastName;
            txtClientAdress.Text = client.Adress;
            txtPayMtethod.Text = invoicePay.Payment.ToString();
            txtBalance.Text = BalanceResult(_componentRepo.GetCartShop()).ToString();

            invoicePay.Balance = BalanceResult(_componentRepo.GetCartShop());

            _clientID = id;
        }


        public static double BalanceResult(List<ComputerComponent> computers)
        {
            double balance = 0;

            foreach(var cmp in computers)
            {
                balance = balance + cmp.Price;
            }

            return balance;
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
