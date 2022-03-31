using System;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        private void Transfer_Load(object sender, EventArgs e)
        {
            BalanceNumLabel.Text = Login.ClientBalancest.ToString();

            string[] clientsData = FileOperations.GetClientsData("client");

            string tempData = "";
            int index;
            string clearData = "";
            foreach (string client in clientsData)
            {
                index = 0;
                while (client[index] != '/')
                {
                    tempData += client[index];
                    index++;
                }
                if (Convert.ToInt32(tempData) != Login.ClientIDst)
                {
                    clearData += tempData + ". ";

                    tempData = ""; index++;
                    while (client[index] != '/')
                    {
                        tempData += client[index];
                        index++;
                    }

                    clearData += tempData + " ";

                    tempData = ""; index++;
                    while (client[index] != '/')
                    {
                        tempData += client[index];
                        index++;
                    }
                    clearData += tempData;
                    tempData = "";

                    clientsListBox.Items.Add(clearData);
                }
                tempData = "";
                clearData = "";
            }
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
        private string resultAccepter()
        {
            string accepterWithNewBalance = "";
            string accepterNewData = "";
            string tempData = ""; //idCashAccepter

            string comboText = clientsListBox.Text;
            int index = 0;

            while (comboText[index] != '.') // get id accepter
            {
                tempData += comboText[index];
                index++;
            }
            int idCashAccepter = Convert.ToInt32(tempData);

            index = 0; tempData = ""; 

            string[] clientsData = FileOperations.GetClientsData("client");

            foreach (string client in clientsData) // find accepter in clientsDB
            {
                while (client[index] != '/')
                {
                    tempData += client[index];
                    index++;
                }
                if (Convert.ToInt32(tempData) == idCashAccepter)
                {
                    accepterNewData = client;
                }
                index = 0; tempData = "";
            }
            int slashCounter = 0;

            while (slashCounter != 5) // find index where start balance
            {
                accepterWithNewBalance += accepterNewData[index];
                if (accepterNewData[index] == '/')
                {
                    slashCounter++;
                }
                index++;
            }
            while (accepterNewData[index] != '/') // write old balance
            {
                tempData += accepterNewData[index];
                index++;
            }

            double balance = Convert.ToDouble(tempData) + Convert.ToDouble(ResultTB.Text);
            accepterWithNewBalance += balance.ToString() + "/";
            
            return accepterWithNewBalance;
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            string tempData = "";
            string aceptName = "";
            string aceptSurname = "";

            string accepter = resultAccepter();
            while (accepter[index] != '/')
            {
                tempData += accepter[index];
                index++;
            }
            int id = Convert.ToInt32(tempData);
            while (accepter[index] != '/')
            {
                aceptName += accepter[index];
                index++;
            }
            while (accepter[index] != '/')
            {
                aceptSurname += accepter[index];
                index++;
            }

            string[] clientsData = FileOperations.GetClientsData("client");
            clientsData[id] = accepter; // db to rewrite

            try
            {
                if (Convert.ToInt32(TransferTB.Text) < 0 || Convert.ToInt32(TransferTB.Text) > 20000)
                {
                    MessageBox.Show("CORRECT SUM: | 0 < SUM < 20000 |\nTRY AGAIN");
                }
                else if (Convert.ToDouble(TransferTB.Text) < Login.ClientBalancest)
                {
                    Login.ClientBalancest -= Convert.ToDouble(TransferTB.Text);

                    FileOperations.RewriteDB("client", clientsData);

                    FileOperations.BalanceOperaion(Convert.ToDouble(ResultTB.Text), "TRANSFER", aceptName, aceptSurname, id);



                    MessageBox.Show("OPERATION SUCCESSFUL");

                    ClientHome home = new ClientHome();
                    this.Hide();
                    home.Show();
                }
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

        private void TransferTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ResultTB.Text = (Convert.ToDouble(TransferTB.Text) - 0.03 * Convert.ToDouble(TransferTB.Text)).ToString();
            }
            catch (Exception ex)
            {
                ResultTB.Text = ex.Message;
            }
        }
    }
}
