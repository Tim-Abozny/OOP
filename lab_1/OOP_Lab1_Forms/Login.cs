using System;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static int ClientIDst = -1;
        public static int ClientPinst = 0;
        public static string ClientNamest = "";
        public static string ClientSurnamest = "";
        public static string ClientLoginst = "";
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
                    string tempData = "";
                    while (clientsData[i][k] != '/')
                    {
                        tempData += clientsData[i][k];
                        k++;
                    }
                    ClientIDst = Convert.ToInt32(tempData);

                    k++;
                    tempData = "";
                    while (clientsData[i][k] != '/')
                    {
                        tempData += clientsData[i][k];
                        k++;
                    }
                    ClientNamest = tempData;

                    k++;
                    tempData = "";
                    while (clientsData[i][k] != '/')
                    {
                        tempData += clientsData[i][k];
                        k++;
                    }
                    ClientSurnamest = tempData;

                    k++;
                    tempData = "";
                    while (clientsData[i][k] != '/')
                    {
                        tempData += clientsData[i][k];
                        k++;
                    }
                    ClientLoginst = tempData;

                    k++;
                    tempData = "";
                    while (clientsData[i][k] != '/')
                    {
                        tempData += clientsData[i][k];
                        k++;
                    }
                    ClientPinst = Convert.ToInt32(tempData);

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
        public static void AccountLogout()
        {
            ClientIDst                  = -1;
            ClientPinst                 = 0;
            ClientNamest                = "";
            ClientSurnamest             = "";
            ClientLoginst               = "";
        }
        public static void ChooseBank()
        {
            BankStartPage.BSUIR_Login = 0;
            BankStartPage.BETA_Login = 0;
            BankStartPage.FOREST_Login = 0;
        }

        private void my_Button1_Click(object sender, EventArgs e)
        {
            Login.AccountLogout();
            Login.ChooseBank();

            BankStartPage startPage = new BankStartPage();
            this.Hide();
            startPage.Show();
        }
    }
}
