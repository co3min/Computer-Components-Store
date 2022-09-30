using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
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
    public partial class ClientForm : Form
    {
        private IClientsRepository _clientRepository;
        private IPaymentInvoiceRepository _payment;

        public ClientForm()
        {
            InitializeComponent();
            _clientRepository = new ClientsRepository();
            _payment = new PaymentInvoiceRepository();

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text == "")
            {
                errorProvider1.SetError(txtFirstName, "Enter your First Name !");
                errorProvider1.SetError(txtLastName, "Enter your Last Name !");
                errorProvider1.SetError(txtAdress, "Enter your Adress !");
                errorProvider1.SetError(groupBox1, "Set smth");

            }
            else if (txtLastName.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtLastName, "Enter your Last Name !");
                errorProvider1.SetError(txtAdress, "Enter your Adress !");
                errorProvider1.SetError(groupBox1, "Set smth");
            }
            else if (txtAdress.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAdress, "Enter your Adress !");
                errorProvider1.SetError(groupBox1, "Set smth");
            }
            else if (!cashBtn.Checked && !cardBtn.Checked)
            {
                errorProvider1.SetError(groupBox1, "Set smth");
            }
            else
            {
                errorProvider1.Clear();
                var client = new Client();
                client.FirstName = txtFirstName.Text;
                client.LastName = txtLastName.Text;
                client.Adress = txtAdress.Text;
                _clientRepository.Add(client);


                var invoicePay = new PaymentInvoice();
                invoicePay.InvoiceName = "Computer Invoice";
                invoicePay.Adress = "Bucharest, Sector 6, Chibzuintei Street, No.2";
                invoicePay.ClientID = client.ID;
                if (cardBtn.Checked)
                {
                    invoicePay.Payment = PaymentMethod.Card;
                }

                if (cashBtn.Checked)
                {
                    invoicePay.Payment = PaymentMethod.Cash;
                    //cashBtn.se
                }
                _payment.Add(invoicePay);


                var invoiceForm = new InvoiceForm(client.ID);
                invoiceForm.ShowDialog();
                Hide();
            }
        }

    }
}
