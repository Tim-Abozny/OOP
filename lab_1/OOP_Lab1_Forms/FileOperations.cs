using System;
using System.IO;

namespace OOP_Lab1_Forms
{
    class FileOperations
    {
        public static string currentLogsPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\LogsDB\";
        public static string currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
        public static void CurrentPath()
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
        public static void CurrentPath(string role)
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
        }
        public static void LogPath()
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
        public static void sendCreditClientRequest(int id, double wantCash, int creditTime)
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

            string fileRequest = $"{id}/{wantCash}/{creditTime}/";
            if (!File.Exists(currentPath))
            {
                File.WriteAllText(currentPath, fileRequest);
            }
            currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
        }
        public static string[] GetClientsData(string role)
        {
            if (role == "client")
            {
                CurrentPath();

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

            CurrentPath();

            File.AppendAllText(currentPath, clientData);
            currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
        }
        public static int GetClientID()
        {
            CurrentPath();

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
    }
}
