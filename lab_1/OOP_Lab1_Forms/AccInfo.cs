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
    public partial class AccInfo : Form
    {
        public AccInfo()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccInfo_Load(object sender, EventArgs e)
        {
            Client client = new Client();

            client.ClientName = Name_TB.Text;
            client.ClientSurname = Surname_TB.Text;
            client.ClientLogin = ClientLogin_TB.Text;
            client.ClientID = Convert.ToInt32(ID_TB.Text);
            client.ClientPIN = Convert.ToInt32(Pin_TB.Text);
        }
    }
}
