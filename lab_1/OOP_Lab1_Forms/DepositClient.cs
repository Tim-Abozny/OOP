using System;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class DepositClient : Form
    {
        public DepositClient()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(DepositTB.Text) < 0 || Convert.ToInt32(DepositTB.Text) > 10000)
                {
                    MessageBox.Show("PLEASE, ENTER SUM LESS THEN 10000\nOR HIGER THEN 0");
                }
                else
                {
                    Login.ClientBalancest += Convert.ToInt32(DepositTB.Text);
                    FileOperations.WriteOperaion(Convert.ToInt32(DepositTB.Text), "DEPOSIT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
