using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace system_ATM
{
    public partial class Operations : Form
    {
        public Operations()
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

        private void Operations_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                string query = $"SELECT * FROM [Transaction] WHERE AccNum = N'{Login.AccNumber}'";
                
                SqlDataAdapter sda = new SqlDataAdapter(query,Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                DataSet dataSet = new DataSet();
                
                sda.Fill(dataSet);
                OperationsDGV.DataSource = dataSet.Tables[0];

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
