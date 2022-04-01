using System;
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
                else if (Convert.ToDouble(WithrdawTB.Text) < Login.ClientBalancest)
                {
                    Login.ClientBalancest -= Convert.ToDouble(WithrdawTB.Text);
                    FileOperations.BalanceOperaion(Convert.ToDouble(WithrdawTB.Text), "WITHDRAW");

                    //rewrite DB
                    string[] clientsData = FileOperations.GetClientsData("client");
                    string withClient = "";
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
                                withClient += client[index];
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
                            withClient += (Convert.ToDouble(tempData) - Convert.ToDouble(WithrdawTB.Text)).ToString() + '/';
                        }
                        tempData = ""; index = 0;
                    }//end foreach
                    clientsData[Login.ClientIDst] = withClient;
                    FileOperations.RewriteDB("client", clientsData);
                    MessageBox.Show("OPERATION SUCCESSFUL");

                    ClientHome home = new ClientHome();
                    this.Hide();
                    home.Show();
                }//end rewrite db
                else
                {
                    MessageBox.Show("YOU ARE NOT RICH");
                }
            }
            catch (Exception ex)
            {
                MessageRect message = new MessageRect();
                MessageRect.exMessage = ex.Message;
                message.Show();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            ClientHome home = new ClientHome();
            this.Hide();
            home.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
