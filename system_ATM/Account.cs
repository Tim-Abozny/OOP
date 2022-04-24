using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace system_ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\progr\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void signUpButton_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNum_TB.Text == "" || Name_TB.Text == "" ||
                FName_TB.Text == "" || AccNum_TB.Text == "" ||
                Address_TB.Text == "" || Phone_TB.Text == "" ||
                Pin_TB.Text == "" || Education_TB.Text == "" || 
                Occupation_TB.Text == "" || Dob_TB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "insert into Account values(N'" + AccNum_TB.Text + "', N'" + Name_TB.Text + "', N'" + FName_TB.Text + "', N'" + Dob_TB.Value.Date + "', N'" + Phone_TB.Text + "', N'" + Address_TB.Text + "', N'" + Education_TB.SelectedItem.ToString() + "', N'" + Occupation_TB.Text + "', " + Pin_TB.Text + ", " + bal + ")";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Connection.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
