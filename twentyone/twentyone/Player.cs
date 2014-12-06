using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace twentyone
{
    public class Player
    {
        public int score;
        public Hand hand;

        public Player()
        {
            hand = new Hand();

        }

        public int getScore()
        {
            score = 0;

            for (int i = 0; i < hand.cards.Count; i++)
            {
                score += ((PlayingCard)hand.cards[i]).getIntValue();
            }

            return score;
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
