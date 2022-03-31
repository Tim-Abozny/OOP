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
            ClientHome home = new ClientHome();
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
                    Login.ClientBalancest += Convert.ToDouble(DepositTB.Text);
                    FileOperations.BalanceOperaion(Convert.ToDouble(DepositTB.Text), "DEPOSIT");

                    //rewrite DB
                    string[] clientsData = FileOperations.GetClientsData("client");
                    string depClient = "";
                    int index = 0;
                    string tempData = "";
                    foreach (var client in clientsData)
                    {
                        while (client[index] != '/')
                        {
                            tempData += client[index];
                            index++;
                        }
                        if (Convert.ToInt32(tempData) == Login.ClientIDst)
                        {
                            index = 0; tempData = "";
                            int slashCount = 0;

                            while (slashCount != 5)// find index where start balance
                            {
                                depClient += client[index];
                                if (client[index] == '/')
                                {
                                    slashCount++;
                                }
                                index++;
                            }

                            while (client[index] != '/') //oldBalance -> tempData
                            {
                                tempData += client[index];
                                index++;
                            }
                            depClient += (Convert.ToDouble(tempData) + Convert.ToDouble(DepositTB.Text)).ToString() + '/';
                        }
                        tempData = ""; index = 0;
                    }//end foreach
                    clientsData[Login.ClientIDst] = depClient;
                    FileOperations.RewriteDB("client", clientsData);
                    MessageBox.Show("OPERATION SUCCESSFUL");

                    ClientHome home = new ClientHome();
                    this.Hide();
                    home.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
