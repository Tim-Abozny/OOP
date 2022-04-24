using System;
using System.Windows.Forms;

namespace system_ATM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            this.Hide();
            balance.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AccNumLabel.Text = Login.AccNumber;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            this.Hide();
            deposit.Show();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            this.Hide();
            withdraw.Show();
        }

        private void changePinButton_Click(object sender, EventArgs e)
        {
            ChangePin Pin = new ChangePin();
            this.Hide();
            Pin.Show();
        }

        private void fastCashButton_Click(object sender, EventArgs e)
        {
            Fastcash fastcash = new Fastcash();
            this.Hide();
            fastcash.Show();
        }

        private void operationsButton_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            this.Hide();
            operations.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            this.Hide();
            information.Show();
        }
    }
}
