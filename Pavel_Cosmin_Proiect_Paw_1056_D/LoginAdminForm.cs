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
    public partial class LoginAdminForm : Form
    {
        public LoginAdminForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "Admin" && txtPassword.Text == "admin")
            {
                var admin = new AdministrationForm();
                admin.ShowDialog();

                Hide();
            }
            else
            {
                MessageBox.Show("Enter your User Name and Password !");
            }
        }
    }
}
