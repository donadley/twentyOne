using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace twentyone
{
    class Dealer
    {
        
        private string Username;
        private int Funds;
        private Hand hand;
        private Pack pack;

       
         public Dealer(string username)
        {
            Username = username;
            Funds = 100000000;
            hand = new Hand();
            pack = new Pack();
        }

         public int getFunds()
         {
             return Funds;
         }

         public Hand getHand()
         {
             return hand;
         }

         public PlayingCard deal()
         {
             return pack.DealCardFromPack();
         }
    }
}
