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
        public int score;
        public Pack pack;
        public Hand hand;

        public Dealer()
        {
            pack = new Pack();
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
