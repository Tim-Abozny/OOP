using System;
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
            Login.AccountLogout();

            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositClient deposit = new DepositClient();
            this.Hide();
            deposit.Show();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawClient withdraw = new WithdrawClient();
            this.Hide();
            withdraw.Show();
        }
    }
}
