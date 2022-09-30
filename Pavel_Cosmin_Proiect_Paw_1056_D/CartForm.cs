using Pavel_Cosmin_Proiect_Paw_1056_D.Database;
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
    public partial class CartForm : Form
    {
        private IComponentRepository _componentRepo;
        public CartForm()
        {
            InitializeComponent();
            _componentRepo = new ComponentsRepository();

            cartDataGrid.AutoGenerateColumns = false;

            cartDataGrid
                .AddColumn(0, "Type", "Type")
                .AddColumn(1, "Name", "Name")
                .AddColumn(2, "Price $", "Price")
                .AddButtonColumn("deleteColumn", "Remove", "Remove From Cart");

            cartDataGrid.DataSource = _componentRepo.GetCartShop();

            cartDataGrid.CellClick += cartDataGrid_cellClick;
        }

        private void cartDataGrid_cellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == cartDataGrid.Columns["deleteColumn"].Index)
            {
                var currentObject = (ComputerComponent)cartDataGrid.CurrentRow.DataBoundItem;
                _componentRepo.GetCartShop().Remove(currentObject);
            }

            var data = _componentRepo.GetCartShop();
            cartDataGrid.RefreshDataGrid(data);
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (_componentRepo.GetCartShop().Count(x => x.ID == x.ID) > 0)
            {
                var clientForm = new ClientForm();
                clientForm.ShowDialog();

                FakeDatabase.CartShop = new List<ComputerComponent>();
                var data = _componentRepo.GetCartShop();
                cartDataGrid.RefreshDataGrid(data);

                Hide();

            }
            else
            {
                MessageBox.Show("Your cart is empty !");
            }
        }


    }
}
