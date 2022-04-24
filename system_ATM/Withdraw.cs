using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace system_ATM
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
        private void ShowBalance()
        {
            Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account where AccNum = '" + Login.AccNumber + "' ", Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceNumLabel.Text = dt.Rows[0][0].ToString() + " $";
            Connection.Close();
        }
        private void AddTransaction()
        {
            string TransactionType = "Withdraw";
            try
            {
                Connection.Open();
                string query = $"INSERT INTO [Transaction] (AccNum, Type, Amount, TDate) VALUES (N'{Login.AccNumber}', N'{TransactionType}', '{Convert.ToInt32(WithrdawTB.Text)}', N'{DateTime.Today.Date.ToString()}')";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\progr\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (WithrdawTB.Text == "" || Convert.ToInt32(WithrdawTB.Text) <= 0)
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
                        if (Balance >= Convert.ToInt32(WithrdawTB.Text))
                        {
                            Balance -= Convert.ToInt32(WithrdawTB.Text);
                            string query = "update Account set Balance = '" + Balance + "' where AccNum = '" + Login.AccNumber + "'";
                            SqlCommand cmd = new SqlCommand(query, Connection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("OPERATION SUCCESSFULL");
                            Connection.Close();
                            AddTransaction();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"INVALID INPUT\nEXCEPTION: {ex.Message}");
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            ShowBalance();
        }
    }
}
