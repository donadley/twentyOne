using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace twentyone
{
    public class Player
    {
        public Hand hand = new Hand();

        public Player()
        {
            
            
        }
        public void Stand()
        {

        }
        public void Hit(PlayingCard card)
        {
            hand.AddCardToHand(card);  
        }
        public void Split()
        { 

        }
    }
}
