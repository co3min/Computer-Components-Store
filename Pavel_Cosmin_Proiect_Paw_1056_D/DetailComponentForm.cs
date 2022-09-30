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
    public partial class DetailComponentForm : Form
    {
        private IComponentRepository _componentRepository;
        private Guid _componentID;
        public DetailComponentForm(Guid id)
        {
            InitializeComponent();
            _componentRepository = new ComponentsRepository();

            var component = _componentRepository.GetByID(id);
            txttype.Text = component.Type;
            txtName.Text = component.Name;
            txtBrand.Text = component.Brand;
            txtDescription.Text = component.Description;
            txtPrice.Text = component.Price.ToString() + " $";

            _componentID = id;
        }
    }
}
