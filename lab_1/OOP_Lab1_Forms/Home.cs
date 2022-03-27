using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Login.ClientIDst > 9)
            {
                AccNumLabel.Text = "00" + Login.ClientIDst.ToString();
            }
            else if (Login.ClientIDst > 99)
            {
                AccNumLabel.Text = "0" + Login.ClientIDst.ToString();
            }
            else
            {
                AccNumLabel.Text = "000" + Login.ClientIDst.ToString();
            }
        }

        private void AccountInfoButton_Click(object sender, EventArgs e)
        {
            AccInfo info = new AccInfo();
            this.Hide();
            info.Show();
        }

        private void Logout_label_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
