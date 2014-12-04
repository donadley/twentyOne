using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace twentyone
{
    class Dealer
    {
        Pack pack = new Pack();

        public void Stand()
        {

        }
        public void Hit()
        {

        }
        public PlayingCard DealCard()
        {
            
            return pack.DealCardFromPack();
            
        }
        public void Shuffle()
        {
            Pack pack = new Pack();
        }      
    }
}
