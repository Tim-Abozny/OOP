using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace system_ATM
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\progr\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddTransaction()
        {
            string TransactionType = "Deposit";
            try
            {
                Connection.Open();
                string query = $"INSERT INTO [Transaction] (AccNum, Type, Amount, TDate) VALUES (N'{Login.AccNumber}', N'{TransactionType}', '{Convert.ToInt32(DepositTB.Text)}', N'{DateTime.Today.Date.ToString()}')";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepositTB.Text == "" || Convert.ToInt32(DepositTB.Text) <= 0)
                {
                    MessageBox.Show("ENTER AMOUNT");
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account where AccNum = '" + Login.AccNumber + "' ", Connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        int Balance = Convert.ToInt32(dt.Rows[0][0]);
                        Balance += Convert.ToInt32(DepositTB.Text);

                        string query = "update Account set Balance = '" + Balance + "' where AccNum = '" + Login.AccNumber + "'";
                        SqlCommand cmd = new SqlCommand(query, Connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("OPERATION SUCCESSFULL");
                        Connection.Close();
                        
                        AddTransaction();

                        Home home = new Home();
                        this.Hide();
                        home.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"INVALID INPUT\nEXCEPTION: {ex.Message}");
            }
            
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
    }
}
