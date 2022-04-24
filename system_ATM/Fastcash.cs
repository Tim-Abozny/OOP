using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace system_ATM
{
    public partial class Fastcash : Form
    {
        public Fastcash()
        {
            InitializeComponent();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\progr\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Fastcash_Load(object sender, EventArgs e)
        {
            Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account where AccNum = '" + Login.AccNumber + "' ", Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AvailableBalanceLabel.Text = dt.Rows[0][0].ToString() + " $";
            Connection.Close();
        }
        private void GetCash(int withdrawSum)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account where AccNum = '" + Login.AccNumber + "' ", Connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int Balance = Convert.ToInt32(dt.Rows[0][0]);
                if (Balance >= withdrawSum)
                {
                    Balance -= withdrawSum;
                    string query = "update Account set Balance = '" + Balance + "' where AccNum = '" + Login.AccNumber + "'";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("OPERATION SUCCESSFULL");
                    Connection.Close();

                }
                else
                {
                    MessageBox.Show("INSUFFICIENT FUNDS");
                    Connection.Close();
                }

                Home home = new Home();
                this.Hide();
                home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }
        private void AddTransaction(int Amount)
        {
            string TransactionType = "Withdraw";
            
            try
            {
                Connection.Open();
                string query = $"INSERT INTO [Transaction] (AccNum, Type, Amount, TDate) VALUES (N'{Login.AccNumber}', N'{TransactionType}', '{Amount}', N'{DateTime.Today.Date.ToString()}')";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Open();
            }
        }
        private void hundButton_Click(object sender, EventArgs e)
        {
            GetCash(100);
            AddTransaction(100);
        }

        private void fiveHundButton_Click(object sender, EventArgs e)
        {
            GetCash(500);
            AddTransaction(500);
        }

        private void thousandButton_Click(object sender, EventArgs e)
        {
            GetCash(1000);
            AddTransaction(1000);
        }

        private void twoThButton_Click(object sender, EventArgs e)
        {
            GetCash(2000);
            AddTransaction(2000);
        }

        private void fiveThButton_Click(object sender, EventArgs e)
        {
            GetCash(5000);
            AddTransaction(5000);
        }

        private void tenThButton_Click(object sender, EventArgs e)
        {
            GetCash(10000);
            AddTransaction(10000);
        }
    }
}
