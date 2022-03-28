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
    public partial class WithdrawClient : Form
    {
        public WithdrawClient()
        {
            InitializeComponent();
        }

        private void WithdrawClient_Load(object sender, EventArgs e)
        {
            BalanceNumLabel.Text = Login.ClientBalancest.ToString();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(WithrdawTB.Text) < 0 || Convert.ToInt32(WithrdawTB.Text) > 10000)
                {
                    MessageBox.Show("CORRECT SUM: | 0 < SUM < 10000 |\nTRY AGAIN");
                }
                else if (Convert.ToInt32(WithrdawTB.Text) < Login.ClientBalancest)
                {
                    Login.ClientBalancest -= Convert.ToInt32(WithrdawTB.Text);
                    FileOperations.WriteOperaion(Convert.ToInt32(WithrdawTB.Text), "WITHDRAW");
                }
                else
                {
                    MessageBox.Show("YOU ARE NOT RICH");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
