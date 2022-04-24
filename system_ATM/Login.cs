using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace system_ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }
        public static String AccNumber;
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\progr\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Account where AccNum = '" + AccNum_TB.Text + "' and PIN = '" + Pin_TB.Text + "' ", Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNumber = AccNum_TB.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                Connection.Close();
            }
            else
            {
                MessageBox.Show("WRONG ACCOUNT NUMBER OR PIN CODE");
                Connection.Close();
            }
        }
    }
}
