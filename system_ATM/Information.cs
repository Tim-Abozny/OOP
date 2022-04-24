using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace system_ATM
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\progr\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Information_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select * from Account where AccNum = '" + Login.AccNumber + "' ", Connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                AccNum_TB.Text = dt.Rows[0][0].ToString();
                Name_TB.Text = dt.Rows[0][1].ToString();
                FName_TB.Text = dt.Rows[0][2].ToString();
                DobTB.Text = dt.Rows[0][3].ToString();
                Phone_TB.Text = dt.Rows[0][4].ToString();
                Address_TB.Text = dt.Rows[0][5].ToString();
                EducationTB.Text = dt.Rows[0][6].ToString();
                OccupationTB.Text = dt.Rows[0][7].ToString();
                Pin_TB.Text = dt.Rows[0][8].ToString();

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }
    }
}
