using System;
using System.Collections.Generic;
using System.Linq;
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
        private static string whatUndo = "";
        private void creditButton_Click(object sender, EventArgs e)
        {
            whatUndo = "credit";

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
            whatUndo = "installment";

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
            whatUndo = "salary";

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
        private void undoRequest(string operation)
        {
            string[] clientsRequests = FileOperations.GetClientsRequests();
            if (clientsRequests.Length > 0)
            {
                string[] clientsData = FileOperations.GetClientsData("client");
                string undoLast = "";
                string tempData = "";

                double resultSum = 0;
                double requestSum = 0;
                double returnSum = 0;

                int startData = 0;
                int undoClientID = 0;
                List<string> req = new List<string>();
                int rewrIndex = 0;
                if (operation == "credit")
                {
                    for (int index = clientsRequests.Length - 1; index > 0; index--)
                    {
                        while (clientsRequests[index][startData] != '/')
                        {
                            tempData += clientsRequests[index][startData];
                            startData++;
                        }
                        if (tempData == "CREDIT")
                        {
                            undoLast = clientsRequests[index];
                            rewrIndex = index;
                            requestsListBox.Items.Remove(undoLast);
                            for (int i = 0; i < index; i++)
                            {
                                req.Add(clientsRequests[i]);
                            }
                            for (int i = index + 1; i < clientsRequests.Length; i++)
                            {
                                req.Add(clientsRequests[i]);
                            }
                            index = 0;
                        }
                        tempData = ""; startData = 0;
                    }
                    if (undoLast != "")
                    {
                        while (undoLast[startData] != '/') // skip request name
                        {
                            startData++;
                        }
                        startData++;
                        while (undoLast[startData] != '/') // write client ID
                        {
                            tempData += undoLast[startData];
                            startData++;
                        }
                        undoClientID = Convert.ToInt32(tempData);
                        tempData = ""; startData++;
                        while (undoLast[startData] != '/') // write request sum
                        {
                            tempData += undoLast[startData];
                            startData++;
                        }
                        requestSum = Convert.ToDouble(tempData);
                        tempData = ""; startData++;
                        while (undoLast[startData] != '/') // skip timePeriod
                        {
                            startData++;
                        }
                        startData++;
                        while (undoLast[startData] != '/') // write sum to return
                        {
                            tempData += undoLast[startData];
                            startData++;
                        }
                        returnSum = Convert.ToDouble(tempData);
                        tempData = "";

                        resultSum = requestSum - (returnSum - requestSum); // sum to add to client balance
                        string oldClientData = clientsData[undoClientID];
                        startData = 0;
                        string rewrString = "";
                        int index = 0;
                        while (startData != 5) // find old balance index | rewrite data
                        {
                            if (oldClientData[index] == '/')
                            {
                                startData++;
                            }
                            rewrString += oldClientData[index];
                            index++;
                        }
                        while (oldClientData[index] != '/') // write Old Balance
                        {
                            tempData += oldClientData[index];
                            index++;
                        }
                        resultSum += Convert.ToDouble(tempData);
                        rewrString += resultSum.ToString() + "/";
                        clientsData[undoClientID] = rewrString;

                        //rewriting request
                        string[] array = req.Select(n => n.ToString()).ToArray();

                        FileOperations.RewriteRequests(array);
                        FileOperations.RewriteDB("client", clientsData);

                        MessageBox.Show("OPERATION SUCCESSFUL");
                    }
                    undoLast = "";
                }
                else
                {
                    for (int index = clientsRequests.Length - 1; index > 0; index--)
                    {
                        while (clientsRequests[index][startData] != '/')
                        {
                            tempData += clientsRequests[index][startData];
                            startData++;
                        }
                        if (tempData == "INSTALLMENT")
                        {
                            undoLast = clientsRequests[index];
                            rewrIndex = index;
                            requestsListBox.Items.Remove(undoLast);
                            for (int i = 0; i < index; i++)
                            {
                                req.Add(clientsRequests[i]);
                            }
                            for (int i = index + 1; i < clientsRequests.Length; i++)
                            {
                                req.Add(clientsRequests[i]);
                            }
                            index = 0;
                        }
                        tempData = ""; startData = 0;
                    }
                    if (undoLast != "")
                    {
                        while (undoLast[startData] != '/') // skip request name
                        {
                            startData++;
                        }
                        startData++;
                        while (undoLast[startData] != '/') // write client ID
                        {
                            tempData += undoLast[startData];
                            startData++;
                        }
                        undoClientID = Convert.ToInt32(tempData);
                        tempData = ""; startData++;
                        while (undoLast[startData] != '/') // write request sum
                        {
                            tempData += undoLast[startData];
                            startData++;
                        }
                        requestSum = Convert.ToDouble(tempData);
                        tempData = ""; startData++;
                        while (undoLast[startData] != '/') // skip timePeriod
                        {
                            startData++;
                        }
                        startData++;
                        while (undoLast[startData] != '/') // write sum to return
                        {
                            tempData += undoLast[startData];
                            startData++;
                        }
                        returnSum = Convert.ToDouble(tempData);
                        tempData = "";

                        resultSum = requestSum - (returnSum - requestSum); // sum to add to client balance
                        string oldClientData = clientsData[undoClientID];
                        startData = 0;
                        string rewrString = "";
                        int index = 0;
                        while (startData != 5) // find old balance index | rewrite data
                        {
                            if (oldClientData[index] == '/')
                            {
                                startData++;
                            }
                            rewrString += oldClientData[index];
                            index++;
                        }
                        while (oldClientData[index] != '/') // write Old Balance
                        {
                            tempData += oldClientData[index];
                            index++;
                        }
                        resultSum += Convert.ToDouble(tempData);
                        rewrString += resultSum.ToString() + "/";
                        clientsData[undoClientID] = rewrString;

                        //rewriting request
                        string[] array = req.Select(n => n.ToString()).ToArray();

                        FileOperations.RewriteRequests(array);
                        FileOperations.RewriteDB("client", clientsData);

                        MessageBox.Show("OPERATION SUCCESSFUL");
                    }
                    undoLast = "";
                }
            }
        }
        private void undoButton_Click(object sender, EventArgs e)
        {
            if (whatUndo == "credit" || whatUndo == "installment")
            {
                undoRequest(whatUndo);
            }
            else if (whatUndo == "salary")
            {
                //undo salary logic
            }
            else
            {
                MessageBox.Show("CHOOSE OPERATION TO UNDO");
            }
        }
    }
}
