using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace system_ATM
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\progr\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowBalance()
        {
            Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account where AccNum = '" + Login.AccNumber + "' ", Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceNumLabel.Text = dt.Rows[0][0].ToString() + " $";
            Connection.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumLabel.Text = Login.AccNumber;
            ShowBalance();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
