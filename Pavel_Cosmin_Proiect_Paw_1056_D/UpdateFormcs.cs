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
    public partial class UpdateFormcs : Form
    {
        private IComponentRepository _componentRepository;
        
        public UpdateFormcs()
        {
            InitializeComponent();
            _componentRepository = new ComponentsRepository();

            dataUpdateGrid.AutoGenerateColumns = false;

            dataUpdateGrid
                .AddColumn(0, "Type", "Type")
                .AddColumn(1, "Name", "Name")
                .AddColumn(2, "Brand", "Brand")
                .AddColumn(3, "Description", "Description")
                .AddColumn(4, "Price", "Price")
                .AddButtonColumn("updateColumn", "Update", "Update Component");

            dataUpdateGrid.DataSource = _componentRepository.GetAllComponents();

            dataUpdateGrid.CellClick += dataUpdateGrid_cellClick;
        }

        private void dataUpdateGrid_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataUpdateGrid.Columns["updateColumn"].Index)
            {
                var component = dataUpdateGrid.CurrentRow.DataBoundItem as ComputerComponent;
                var updateFormular = new UpdateFormularForm(component.ID);
                updateFormular.ShowDialog();
                dataUpdateGrid.Refresh();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
