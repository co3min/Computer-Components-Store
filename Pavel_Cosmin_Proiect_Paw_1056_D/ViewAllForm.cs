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
    public partial class ViewAllForm : Form
    {
        private IComponentRepository _repo; 
        public ViewAllForm()
        {
            InitializeComponent();
            _repo = new ComponentsRepository();

            dataViewGrid.DataSource = _repo.GetAllComponents();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
