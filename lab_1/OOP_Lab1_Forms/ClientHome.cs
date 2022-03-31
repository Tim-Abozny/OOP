using System;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class ClientHome : Form
    {
        public ClientHome()
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

        private void balanceButton_Click(object sender, EventArgs e)
        {
            AccBalance balance = new AccBalance();
            this.Hide();
            balance.Show();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            this.Hide();
            transfer.Show();
        }
        private static int blockedTime = 150;
        private void blockButton_Click(object sender, EventArgs e)
        {
            MessageRect message = new MessageRect();
            MessageRect.exMessage = "YOU BLOCKED CARD ON 1 MINUTE!";
            
            message.Show();
            banTimer.Start();

            depositButton.Visible       = false;
            withdrawButton.Visible      = false;
            transferButton.Visible      = false;
            balanceButton.Visible       = false;
            Logout_label.Visible        = false;
            exitLabel.Visible           = false;
            AccountInfoButton.Visible   = false;
            blockButton.Visible         = false;
            companyButton.Visible       = false;
        }

        private void banTimer_Tick(object sender, EventArgs e)
        {
            blockedTime--;
            if (blockedTime == 0)
            {
                banTimer.Stop();
                blockedTime = 150;

                depositButton.Visible       = true;
                withdrawButton.Visible      = true;
                transferButton.Visible      = true;
                balanceButton.Visible       = true;
                Logout_label.Visible        = true;
                exitLabel.Visible           = true;
                AccountInfoButton.Visible   = true;
                blockButton.Visible         = true;
                companyButton.Visible       = true;
            }
        }
    }
}
