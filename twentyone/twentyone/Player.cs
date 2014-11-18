using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace twentyone
{
    public class Player
    {
        private int PlayerID;
        private string Username;
        private string Password;
        private int Funds;
        private Hand Hand;

        public Player(int playerID, string username, string password, int funds)
        {
            PlayerID = playerID;
            Username = username;
            Password = password;
            Funds = funds;
            Hand = new Hand();
        }

        public string getUsername()
        {
            return Username;
        }
        public string getPassword()
        {
            return Password;
        }
        public int getFunds()
        {
            return Funds;
        }

        public Hand getHand()
        {
            return Hand;
        }

    }
    
}
