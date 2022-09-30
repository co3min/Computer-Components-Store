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
    public partial class UpdateFormularForm : Form
    {
        private IComponentRepository _componentRepository;
        private readonly Guid _id;
        List<TextBox> listaTB = new List<TextBox>();
        public UpdateFormularForm(Guid id)
        {
            InitializeComponent();
            _componentRepository = new ComponentsRepository();
            _id = id;
            var component = _componentRepository.GetByID(id);
            txtType.Text = component.Type;
            txtName.Text = component.Name;
            txtBrand.Text = component.Name;
            txtDescription.Text = component.Description;
            txtPrice.Text = component.Price.ToString();

            listaTB.Add(txtType);
            listaTB.Add(txtName);
            listaTB.Add(txtBrand);
            listaTB.Add(txtDescription);
            listaTB.Add(txtPrice); 
            txtPrice.KeyPress += new KeyPressEventHandler(txtPrice_KeyPress);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9'||e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void saveChangeBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaTB.Count; i += 5)
            {
                if (listaTB[i].Text == "")
                {
                    errorProvider1.SetError(listaTB[i], "Enter Type !");
                    errorProvider1.SetError(listaTB[i + 1], "Enter Name !");
                    errorProvider1.SetError(listaTB[i + 2], "Enter Brand !");
                    errorProvider1.SetError(listaTB[i + 3], "Enter Description !");
                    errorProvider1.SetError(listaTB[i + 4], "Enter Price !");
                }
                else if (listaTB[i + 1].Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(listaTB[i + 1], "Enter Name !");
                    errorProvider1.SetError(listaTB[i + 2], "Enter Brand !");
                    errorProvider1.SetError(listaTB[i + 3], "Enter Description !");
                    errorProvider1.SetError(listaTB[i + 4], "Enter Price !");
                }
                else if (listaTB[i + 2].Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(listaTB[i + 2], "Enter Brand !");
                    errorProvider1.SetError(listaTB[i + 3], "Enter Description !");
                    errorProvider1.SetError(listaTB[i + 4], "Enter Price !");
                }
                else if (listaTB[i + 3].Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(listaTB[i + 3], "Enter Description !");
                    errorProvider1.SetError(listaTB[i + 4], "Enter Price !");
                }
                else if (listaTB[i + 4].Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(listaTB[i + 4], "Enter Price !");
                }
                else
                {
                    errorProvider1.Clear();
                    var component = _componentRepository.GetByID(_id);
                    component.Type = txtType.Text;
                    component.Name = txtName.Text;
                    component.Brand = txtBrand.Text;
                    component.Description = txtDescription.Text;
                    component.Price = Convert.ToDouble(txtPrice.Text);
                    Hide();
                }
            }
        }
    }
}
