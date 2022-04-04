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
    }
}
