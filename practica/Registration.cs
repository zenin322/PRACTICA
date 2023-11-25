using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void loginRegistr_TextChanged(object sender, EventArgs e)
        {
            loginRegistr.Text = "Введите имя";
            loginRegistr.ForeColor = Color.Red;
        }

        private void loginRegistr_Enter(object sender, EventArgs e)
        {
            if (loginRegistr.Text == "Введите имя")
            {
                loginRegistr.Text = "";
                loginRegistr.ForeColor = Color.Black;
            }
        }

        private void loginRegistr_Leave(object sender, EventArgs e)
        {
            if (loginRegistr.Text == "")
            {

                loginRegistr.Text = "Введите имя";
                loginRegistr.ForeColor = Color.Red;
            }
        }

        private void passRegistr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
