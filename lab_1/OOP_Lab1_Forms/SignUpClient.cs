using System;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class SignUpClient : Form
    {
        public SignUpClient()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            client.ClientName = Name_TB.Text;
            client.ClientSurname = Surname_TB.Text;
            client.ClientLogin = ClientLogin_TB.Text;
            client.ClientID = Convert.ToInt32(ID_TB.Text);
            client.ClientPIN = Pin_TB.Text;

            Client transferClient = client.Clone();//Prototype pattern

            FileOperations.AddClient
                (
                    transferClient.ClientName,
                    transferClient.ClientSurname,
                    transferClient.ClientLogin,
                    transferClient.ClientID,
                    transferClient.ClientPIN
                );
            MessageBox.Show("OPERATION SUCCESS");
            
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void SignUpClient_Load(object sender, EventArgs e)
        {
            if (FileOperations.GetClientID() == 0)
            {
                ID_TB.Text = "0";
            }
            else
            {
                ID_TB.Text = "" + Convert.ToChar(FileOperations.GetClientID()); 
            }
        }
    }
}
