using System;
using System.IO;

namespace OOP_Lab1_Forms
{
    class FileOperations
    {
        private static string currentLogsPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\LogsDB\";
        private static string currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
        private static string requestPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\ClientRequests\";
        private static void CurrentPath(string role)
        {
            if (role == "manager")
            {
                if (BankStartPage.BSUIR_Login == 1)
                {
                    currentPath += "BSUIRManagers.txt";
                }
                if (BankStartPage.BETA_Login == 1)
                {
                    currentPath += "BETAManagers.txt";
                }
                if (BankStartPage.FOREST_Login == 1)
                {
                    currentPath += "FORESTManagers.txt";
                }
            }
            else if (role == "client")
            {
                if (BankStartPage.BSUIR_Login == 1)
                {
                    currentPath += "BSUIRClientsDB.txt";
                }
                if (BankStartPage.BETA_Login == 1)
                {
                    currentPath += "BETAClientsDB.txt";
                }
                if (BankStartPage.FOREST_Login == 1)
                {
                    currentPath += "FORESTClientsDB.txt";
                }
            }
        }
        private static void LogPath()
        {
            if (BankStartPage.BSUIR_Login == 1)
            {
                currentLogsPath += "BSUIRLogs.txt";
            }
            if (BankStartPage.BETA_Login == 1)
            {
                currentLogsPath += "BETALogs.txt";
            }
            if (BankStartPage.FOREST_Login == 1)
            {
                currentLogsPath += "FORESTLogs.txt";
            }
        }
        private static void RequestPath()
        {
            if (BankStartPage.BSUIR_Login == 1)
            {
                requestPath += "BSUIRRequests.txt";
            }
            if (BankStartPage.BETA_Login == 1)
            {
                requestPath += "BETARequests.txt";
            }
            if (BankStartPage.FOREST_Login == 1)
            {
                requestPath += "FORESTRequests.txt";
            }
        }
        public static string[] GetClientsData(string role)
        {
            if (role == "client")
            {
                CurrentPath("client");

                string[] clientsData = File.ReadAllLines(currentPath);
                currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
                return clientsData;
            }
            else
            {
                CurrentPath("manager");

                string[] managersData = File.ReadAllLines(currentPath);
                currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
                return managersData;
            }
        }
        public static void AddClient(string ClientName, string ClientSurname,string ClientLogin, int ClientID,string ClientPIN)
        {
            string clientData = $"{ClientID}/{ClientName}/{ClientSurname}/{ClientLogin}/{ClientPIN}/0/" + Environment.NewLine;

            CurrentPath("client");

            File.AppendAllText(currentPath, clientData);
            currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
        }
        public static int GetClientID()
        {
            CurrentPath("client");

            int ClientFileID = 0;

            string[] fileData = File.ReadAllLines(currentPath);

            if (fileData.Length == 0)
            {
                ClientFileID = 0;
            }
            else
            {
                ClientFileID = Convert.ToInt32(fileData[fileData.Length - 1][0]) + 1;
            }
            currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";

            return ClientFileID;
        }
        public static void BalanceOperaion(double sum, string operation)
        {
            LogPath();

            string clientOperation = $"{Login.ClientIDst}/{Login.ClientNamest}/{Login.ClientSurnamest}/{operation}/{sum}/" + Environment.NewLine;
            File.AppendAllText(currentLogsPath, clientOperation);

            currentLogsPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\LogsDB\";
        }
        public static void BalanceOperaion(double sum, string operation, string acceptorName, string acceptorSurname, int acceptorID)
        {
            LogPath();

            string clientOperation = $"{Login.ClientIDst}/{Login.ClientNamest}/{Login.ClientSurnamest}/{operation}/{sum}/{acceptorID}/{acceptorName}/{acceptorSurname}/" + Environment.NewLine;
            File.AppendAllText(currentLogsPath, clientOperation);

            currentLogsPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\LogsDB\";
        }
        public static void RewriteDB(string role, string[] DB)
        {
            if (role == "client")
            {
                CurrentPath("client");

                File.WriteAllLines(currentPath, DB);
                currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
            }
            else
            {
                CurrentPath("manager");

                File.WriteAllLines(currentPath, DB);
                currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
            }
        }
        public static void sendSalaryClientRequest(int id, double sum)
        {
            RequestPath();

            string clientRequest = $"SALARY/{id}/{sum}/" + Environment.NewLine;
            File.AppendAllText(requestPath, clientRequest);

            requestPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\ClientRequests\";
        }
        public static void sendCredInstClientRequest(string operation, int id, double sum, int period, double payBackSum)
        {
            //SALARY/ID/SUM/PERIOD/PAYBACKSUM/
            RequestPath();
            if (operation == "CREDIT")
            {
                string clientRequest = $"CREDIT/{id}/{sum}/{period}/{payBackSum}/" + Environment.NewLine;
                File.AppendAllText(requestPath, clientRequest);
            }
            else
            {
                string clientRequest = $"INSTALLMENT/{id}/{sum}/{period}/{payBackSum}/" + Environment.NewLine;
                File.AppendAllText(requestPath, clientRequest);
            }

            requestPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\ClientRequests\";
        }
        public static string[] GetClientsRequests()
        {
                RequestPath();

                string[] clientsRequests = File.ReadAllLines(requestPath);
                requestPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\ClientRequests\";
                
                return clientsRequests;
        }
    }
}
