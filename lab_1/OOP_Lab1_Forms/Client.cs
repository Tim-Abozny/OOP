﻿
namespace OOP_Lab1_Forms
{
    class Client
    {
        private double _clientBalance;

        public double ClientBalance
        {
            get { return _clientBalance; }
            set { _clientBalance = value; }
        }


        private string _clientName;

        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }

        private string _clientSurname;

        public string ClientSurname
        {
            get { return _clientSurname; }
            set { _clientSurname = value; }
        }

        private string _clientPIN;

        public string ClientPIN
        {
            get { return _clientPIN; }
            set { _clientPIN = value; }
        }

        private string _clientAccLogin;

        public string ClientLogin
        {
            get { return _clientAccLogin; }
            set { _clientAccLogin = value; }
        }
        private int _clientID;

        public int ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }
        public Client Clone() // Prototype pattern realiz.
        {
            Client clone = (Client)this.MemberwiseClone();
            clone.ClientName = ClientName;
            clone.ClientSurname = ClientSurname;
            clone.ClientLogin = ClientLogin;
            clone.ClientID = ClientID;
            clone.ClientPIN = ClientPIN;

            return clone;
        }
        public Client() { }
    }
}
