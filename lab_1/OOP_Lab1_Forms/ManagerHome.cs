using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab1_Forms
{
    public partial class ManagerHome : Form
    {
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerLogin manager = new ManagerLogin();
            this.Close();
            manager.Show();
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            string[] requests = FileOperations.GetClientsRequests();
            requestsListBox.Items.Clear();

            string head = "OPERATION/ID/SUM/MONTH/PAYBACK";
            requestsListBox.Items.Add(head);

            int index = 0; string tempData = "";
            foreach (string request in requests)
            {
                while (request[index] != '/')
                {
                    tempData += request[index];
                    index++;
                }
                if (tempData == "CREDIT")
                {
                    requestsListBox.Items.Add(request);
                }
                index = 0; tempData = "";
            }
        }

        private void installmentButton_Click(object sender, EventArgs e)
        {
            string[] requests = FileOperations.GetClientsRequests();
            requestsListBox.Items.Clear();

            string head = "OPERATION/ID/SUM/MONTH/PAYBACK";
            requestsListBox.Items.Add(head);

            int index = 0; string tempData = "";
            foreach (string request in requests)
            {
                while (request[index] != '/')
                {
                    tempData += request[index];
                    index++;
                }
                if (tempData == "INSTALLMENT")
                {
                    requestsListBox.Items.Add(request);
                }
                index = 0; tempData = "";
            }
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            string[] requests = FileOperations.GetClientsRequests();
            requestsListBox.Items.Clear();

            string head = "OPERATION/ID/SUM";
            requestsListBox.Items.Add(head);

            int index = 0; string tempData = "";
            foreach (string request in requests)
            {
                while (request[index] != '/')
                {
                    tempData += request[index];
                    index++;
                }
                if (tempData == "SALARY")
                {
                    requestsListBox.Items.Add(request);
                }
                index = 0; tempData = "";
            }
        }
    }
}
