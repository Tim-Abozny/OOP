using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace system_ATM
{
    public partial class ChangePin : Form
    {
        public ChangePin()
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
        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NewPinTB.Text == ConfirmPinTB.Text && NewPinTB.Text != "")
                {
                    try
                    {
                        Connection.Open();
                        string query = "update Account set PIN=" + Convert.ToInt32(NewPinTB.Text) + " where AccNum = '" + Login.AccNumber + "'";
                        SqlCommand cmd = new SqlCommand(query, Connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("OPERATION SUCCESSFULL");
                        Connection.Close();
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"EXCEPTION: {ex.Message}");
                        Connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("PINCODES ARE DIFFERENT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"INVALID INPUT\nEXCEPTION: {ex.Message}");
            }
        }
    }
}
