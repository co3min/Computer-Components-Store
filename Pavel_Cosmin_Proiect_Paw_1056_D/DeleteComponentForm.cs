using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
using Pavel_Cosmin_Proiect_Paw_1056_D.Extensions;
using Pavel_Cosmin_Proiect_Paw_1056_D.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavel_Cosmin_Proiect_Paw_1056_D
{
    public partial class DeleteComponentForm : Form
    {
        private IComponentRepository _repository;
        public DeleteComponentForm()
        {
            InitializeComponent();
            _repository = new ComponentsRepository();

            gridDelete.DataSource = _repository.GetAllComponents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDeleteName.Text == "")
            {
                errorProvider1.SetError(txtDeleteName, "Enter a Id !");
            }
            else
            {
                errorProvider1.Clear();
                Guid id = System.Guid.Parse(txtDeleteName.Text);
                //FakeDatabase.Clients.FirstOrDefault(x => x.ID == id);
                ComputerComponent componentDelete = _repository.GetAllComponents().FirstOrDefault(x => x.ID == id);

                _repository.Delete(componentDelete);

                gridDelete.RefreshDataGrid(_repository.GetAllComponents());
                txtDeleteName.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
