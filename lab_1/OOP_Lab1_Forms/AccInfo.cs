using System;
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
            ClientHome home = new ClientHome();
            this.Hide();
            home.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccInfo_Load(object sender, EventArgs e)
        {
            Name_TB.Text        = Login.ClientNamest;
            Surname_TB.Text     = Login.ClientSurnamest;
            ClientLogin_TB.Text = Login.ClientLoginst;
            ID_TB.Text          = Login.ClientIDst.ToString();
            Pin_TB.Text         = Login.ClientPinst;
        }
    }
}
