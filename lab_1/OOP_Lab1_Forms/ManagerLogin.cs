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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }
        private int activeKey = 0;
        private void clientButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static void ManagerAccountLogout()
        {
            ManagerIDst = -1;
            ManagerPinst = "";
            ManagerNamest = "";
            ManagerSurnamest = "";
            ManagerLoginst = "";
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerLogin.ManagerAccountLogout();
            Login.ChooseBank();

            BankStartPage startPage = new BankStartPage();
            this.Hide();
            startPage.Show();
        }
        public static int ManagerIDst = -1;
        public static string ManagerPinst = "";
        public static string ManagerNamest = "";
        public static string ManagerSurnamest = "";
        public static string ManagerLoginst = "";

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (activeKey == 1)
            {
                string[] managersData = FileOperations.GetClientsData("manager");
                int slashCount = 0;
                string clientLogin = "";
                string clientPass = "";
                for (int i = 0; i < managersData.Length; i++)
                {
                    for (int j = 0; j < managersData[i].Length; j++)
                    {

                        if (managersData[i][j] == '/')
                        {
                            slashCount++;
                        }
                        if (slashCount == 3)
                        {
                            j++;
                            while (managersData[i][j] != '/')
                            {
                                clientLogin += managersData[i][j];
                                j++;
                            }
                            j++; // go to write pass
                            while (managersData[i][j] != '/')
                            {
                                clientPass += managersData[i][j];
                                j++;
                            }
                            j = managersData[i].Length;
                        }
                    }//end for[j] cycle

                    if (clientLogin == AccNum_TB.Text && clientPass == Pin_TB.Text)
                    {
                        int k = 0;
                        string tempData = "";
                        while (managersData[i][k] != '/')
                        {
                            tempData += managersData[i][k];
                            k++;
                        }
                        ManagerIDst = Convert.ToInt32(tempData);

                        k++;
                        tempData = "";
                        while (managersData[i][k] != '/')
                        {
                            tempData += managersData[i][k];
                            k++;
                        }
                        ManagerNamest = tempData;

                        k++;
                        tempData = "";
                        while (managersData[i][k] != '/')
                        {
                            tempData += managersData[i][k];
                            k++;
                        }
                        ManagerSurnamest = tempData;

                        k++;
                        tempData = "";
                        while (managersData[i][k] != '/')
                        {
                            tempData += managersData[i][k];
                            k++;
                        }
                        ManagerLoginst = tempData;

                        k++;
                        tempData = "";
                        while (managersData[i][k] != '/')
                        {
                            tempData += managersData[i][k];
                            k++;
                        }
                        ManagerPinst = tempData;

                        i = managersData[i].Length;
                    }
                    slashCount = 0;
                    clientLogin = "";
                    clientPass = "";
                }//end for[i] cycle
                if (ManagerIDst == -1)
                {
                    MessageBox.Show("WRONG LOGIN OR PASS");
                }
                else
                {
                    ClientHome home = new ClientHome();
                    this.Hide();
                    home.Show();
                }
            }
            else
            {
                MessageBox.Show("CONFIRM KEY!");
            }
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            activeKey = 1;
        }
    }
}
