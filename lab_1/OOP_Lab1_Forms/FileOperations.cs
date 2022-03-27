using System;
using System.IO;

namespace OOP_Lab1_Forms
{
    class FileOperations
    {
        private static string currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
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
        public static string[] GetClientsData()
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

            string[] clientsData = File.ReadAllLines(currentPath);
            currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
            return clientsData;
        }
        public static void AddClient
            (
                string ClientName,
                string ClientSurname,
                string ClientLogin,
                int ClientID, 
                int ClientPIN
            )
        {
            string clientData = $"{ClientID}/{ClientName}/{ClientSurname}/{ClientLogin}/{ClientPIN}/" + Environment.NewLine;
            
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

            File.AppendAllText(currentPath, clientData);
            currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\";
        }
        public static int GetClientID()
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
    }
}
