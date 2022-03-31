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
    public partial class AccBalance : Form
    {
        public AccBalance()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            ClientHome home = new ClientHome();
            this.Hide();
            home.Show();
        }

        private void AccBalance_Load(object sender, EventArgs e)
        {
            accNumLabel.Text = Login.ClientIDst.ToString();
            balanceNumLabel.Text = Login.ClientBalancest.ToString();
        }
    }
}
