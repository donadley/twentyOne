using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace twentyone
{
    public class Dealer
    {
        public Pack pack = new Pack();
        public Hand hand = new Hand();

        public void Stand()
        {

        }
        public void Hit(PlayingCard card)
        {
            hand.AddCardToHand(card);
        }
        public PlayingCard DealCard()
        {            
            return pack.DealCardFromPack();            
        }
        public void Shuffle()
        {
            pack = new Pack();
        }      
    }
}
