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
    public partial class AdministrationForm : Form
    {
        private IComponentRepository _repository;
        private IClientsRepository _clients;
        private IPaymentInvoiceRepository _payment;
        public AdministrationForm()
        {
            InitializeComponent();
            _repository = new ComponentsRepository();
            _clients = new ClientsRepository();
            _payment = new PaymentInvoiceRepository();

            dataClinetGrid.AutoGenerateColumns = false;

            dataClinetGrid
                .AddColumn(0, "FirstName", "FirstName")
                .AddColumn(1, "LastName", "LastName")
                .AddColumn(2, "Adress", "Adress");


            // dataClinetGrid.DataSource = _clients.GetAllClients();

            //dataInvoiceGrid.DataSource = _payment.GetAllPaymentInvoices();

            MessageBox.Show("This part contain binary file exemple !" + "\n"
                            + "If you want to view clients and invoices\n" +
                            "First you may to export the data in a binary file from export button\n" +
                            "Second you must to import the data from the binary file previous create\n" +
                            "After that you will see the data when press one of the button, view clints or view invoices !");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataInvoiceGrid.Visible = false;
            dataClinetGrid.Visible = false;
            pictureBoss.Visible = false;

            txtAdd.Visible = true;
            txtAdd.Text = "Add a Component";
            txtDelete.Visible = true;
            txtDelete.Text = "Delete a Component";

            addBtn.Visible = true;
            addBtn.Text = "Add";
            deleteBtn.Visible = true;
            deleteBtn.Text = "Delete";

            txtUpdate.Visible = true;
            txtUpdate.Text = "Update a Component";
            updateBtn.Visible = true;
            updateBtn.Text = "Update";

            txtView.Visible = true;
            txtView.Text = "View All Components";
            viewBtn.Visible = true;
            viewBtn.Text = "View";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddComponentForm();
            addForm.ShowDialog();
            //Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteComponentForm();
            deleteForm.ShowDialog();

            //Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataClinetGrid.Visible = true;
            dataInvoiceGrid.Visible = false;
            txtAdd.Visible = false;
            txtDelete.Visible = false;
            addBtn.Visible = false;
            deleteBtn.Visible = false;
            txtUpdate.Visible = false;
            updateBtn.Visible = false;
            txtView.Visible = false;
            viewBtn.Visible = false;
            pictureBoss.Visible = false;
        }

        private void dataClinetGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataInvoiceGrid.Visible = true;
            dataClinetGrid.Visible = false;
            txtAdd.Visible = false;
            txtDelete.Visible = false;
            addBtn.Visible = false;
            deleteBtn.Visible = false;
            txtUpdate.Visible = false;
            updateBtn.Visible = false;
            txtView.Visible = false;
            viewBtn.Visible = false;
            pictureBoss.Visible = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var update = new UpdateFormcs();
            update.ShowDialog();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            var view = new ViewAllForm();
            view.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void exportClinetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    binary.Serialize(stream, _clients.GetAllClients());
                    stream.Close();
                }
            }

        }

        private void exportInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    binary.Serialize(stream, _payment.GetAllPaymentInvoices());
                    stream.Close();
                }
            }
        }

        private void importClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary file|.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    _clients.GetAllClients().Clear();
                    _clients.GetAllClients().AddRange(binary.Deserialize(stream) as List<Client>);
                }
                dataClinetGrid.DataSource = _clients.GetAllClients();

            }

        }

        private void importInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary file|.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    _payment.GetAllPaymentInvoices().Clear();
                    _payment.GetAllPaymentInvoices().AddRange(binary.Deserialize(stream) as List<PaymentInvoice>);
                }
                dataInvoiceGrid.DataSource = _payment.GetAllPaymentInvoices();
            }
        }
    }
}
