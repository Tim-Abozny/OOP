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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static int ClientIDst = -1;
        private void loginButton_Click(object sender, EventArgs e)
        {
            string[] clientsData = FileOperations.GetClientsData();
            int slashCount = 0;
            string clientLogin = "";
            string clientPass = "";
            for (int i = 0; i < clientsData.Length; i++)
            {
                for (int j = 0; j < clientsData[i].Length; j++)
                {
                    
                    if (clientsData[i][j] == '/')
                    {
                        slashCount++;
                    }
                    if (slashCount == 3)
                    {
                        j++;
                        while (clientsData[i][j] != '/')
                        {
                            clientLogin += clientsData[i][j];
                            j++;
                        }
                        j++; // go to write pass
                        while (clientsData[i][j] != '/')
                        {
                            clientPass += clientsData[i][j];
                            j++;
                        }
                    }
                }
                if (clientLogin == AccNum_TB.Text && clientPass == Pin_TB.Text)
                {
                    int k = 0;
                    string tempID = "";
                    while (clientsData[i][k] != '/')
                    {
                        tempID += clientsData[i][k];
                        k++;
                    }
                    ClientIDst = Convert.ToInt32(tempID);
                    i = clientsData[i].Length;
                }
                slashCount = 0;
                clientLogin = "";
                clientPass = "";
            }
            if (ClientIDst == -1)
            {
                MessageBox.Show("WRONG LOGIN OR PASS");
            }
            else
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
        }

        private void signUP_label_Click(object sender, EventArgs e)
        {
            SignUpClient client = new SignUpClient();
            this.Hide();
            client.Show();
        }
    }
}
