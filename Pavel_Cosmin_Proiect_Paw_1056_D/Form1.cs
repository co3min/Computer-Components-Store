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
    public partial class Form1 : Form
    {
        private IComponentRepository _componentRepository;
        private int elemNo = 0; 
        public Form1()
        {
            InitializeComponent();
            

            _componentRepository = new ComponentsRepository();
            

            dataGridComponent.AutoGenerateColumns = false;

            dataGridComponent
                .AddColumn(0, "Type", "Type")
                .AddColumn(1, "Name", "Name")
                .AddColumn(2, "Price $", "Price")
                .AddButtonColumn("detailColumn", "Details", "Details")
                .AddButtonColumn("addColumn", "Add", "Add to Cart");

            dataGridComponent.DataSource = _componentRepository.GetAllComponents();

            dataGridComponent.CellClick += dataGridComponent_cellClick;
        }

        private void dataGridComponent_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridComponent.Columns["detailColumn"].Index)
            {
                var currentObject = (ComputerComponent)dataGridComponent.CurrentRow.DataBoundItem;
                var detailComponentForm = new DetailComponentForm(currentObject.ID);
                detailComponentForm.ShowDialog();
            }

            if(e.ColumnIndex == dataGridComponent.Columns["addColumn"].Index)
            {
                var currentObject = (ComputerComponent)dataGridComponent.CurrentRow.DataBoundItem;
                _componentRepository.GetCartShop().Add(currentObject);
                elemNo++;
                ComponentsCount.Text = Convert.ToString(elemNo);
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            elemNo = 0;
            ComponentsCount.Text = Convert.ToString(elemNo);
            var cartForm = new CartForm();
            cartForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            var admin = new LoginAdminForm();
            admin.ShowDialog();

            var data = _componentRepository.GetAllComponents();
            dataGridComponent.RefreshDataGrid(data);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
