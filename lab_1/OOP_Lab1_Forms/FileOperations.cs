using System;
using System.IO;
using System.Text;

namespace OOP_Lab1_Forms
{
    class FileOperations
    {
        public static void sendCreditClientRequest(int id, double wantCash, int creditTime)
        {
            string fileRequest = $"{id}/{wantCash}/{creditTime}/";
            string currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\BSUIRClientsDB.txt";
            if (!File.Exists(currentPath))
            {
                File.WriteAllText(currentPath, fileRequest);
            }
        }
        public static string[] GetClientsData()
        {
            string currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\BSUIRClientsDB.txt";
            string[] clientsData = File.ReadAllLines(currentPath);
          
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
            string currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\BSUIRClientsDB.txt";
            
            File.AppendAllText(currentPath, clientData);
            
        }
        public static int GetClientID()
        {
            string currentPath = @"C:\Users\progr\source\repos\C#\2022\OOP\lab_1\OOP_Lab1_Forms\SystemDB\BSUIRClientsDB.txt";
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

            return ClientFileID;
        }
    }
}
