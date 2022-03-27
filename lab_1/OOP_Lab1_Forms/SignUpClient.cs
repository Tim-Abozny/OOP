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
    public partial class SignUpClient : Form
    {
        public SignUpClient()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            client.ClientName = Name_TB.Text;
            client.ClientSurname = Surname_TB.Text;
            client.ClientLogin = ClientLogin_TB.Text;
            client.ClientID = Convert.ToInt32(ID_TB.Text);
            client.ClientPIN = Convert.ToInt32(Pin_TB.Text);

            FileOperations.AddClient
                (
                    client.ClientName,
                    client.ClientSurname,
                    client.ClientLogin,
                    client.ClientID,
                    client.ClientPIN
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
