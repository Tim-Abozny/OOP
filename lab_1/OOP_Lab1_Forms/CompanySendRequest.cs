using System;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class CompanySendRequest : Form
    {
        public CompanySendRequest()
        {
            InitializeComponent();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            ClientHome client = new ClientHome();
            this.Close();
            client.Show();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreditTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (InstallmentTB.Text == "")
                {
                    double period = Convert.ToInt32(periodListBox.Text);
                    ResultTB.Text = (Convert.ToDouble(CreditTB.Text) + (0.17 + (period / 100)) * Convert.ToDouble(CreditTB.Text)).ToString();
                }
                else
                {
                    InstallmentTB.Text = "";
                }
            }
            catch (Exception ex)
            {
                ResultTB.Text = ex.Message;
            }
        }

        private void InstallmentTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CreditTB.Text == "")
                {
                    ResultTB.Text = (Convert.ToDouble(InstallmentTB.Text) + 0.23 * Convert.ToDouble(InstallmentTB.Text)).ToString();
                }
                else
                {
                    CreditTB.Text = "";
                }
            }
            catch (Exception ex)
            {
                ResultTB.Text = ex.Message;
            }
        }

        private void periodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreditTB.Text = "";
        }

        private void sendSalaryReq_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(SalaryTB.Text) > 20000)
                {
                    MessageBox.Show("YOU CAN'T EARN MORE THEN 20.000 $");
                }
                else if (Convert.ToDouble(SalaryTB.Text) < 500)
                {
                    MessageBox.Show("YOU CAN'T EARN LESS THEN 500 $");
                }
                else
                {
                    FileOperations.sendSalaryClientRequest(Login.ClientIDst, Convert.ToDouble(SalaryTB.Text));

                    ClientHome client = new ClientHome();
                    this.Close();
                    client.Show();
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("PLEASE, USE ',' TO DOUBLE SUM\nOR WRITE CORRECT SUM");
            }
        }

        private void sendCrInReq_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreditTB.Text != "")
                {
                    FileOperations.sendCredInstClientRequest("CREDIT", Login.ClientIDst, Convert.ToDouble(CreditTB.Text), Convert.ToInt32(periodListBox.SelectedItem), Convert.ToDouble(ResultTB.Text));
                }
                else if (InstallmentTB.Text != "")
                {
                    FileOperations.sendCredInstClientRequest("INSTALLMENT", Login.ClientIDst, Convert.ToDouble(InstallmentTB.Text), Convert.ToInt32(periodListBox.SelectedItem), Convert.ToDouble(ResultTB.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClientHome client = new ClientHome();
            this.Close();
            client.Show();
        }
    }
}
