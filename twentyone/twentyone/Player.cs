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
        public float funds;
        public string username;
        public string password;
        public int playerID;
        public float bet;

        public Player(string username, string password, float funds)
        {
            this.username = username;
            this.password = password;
            this.funds = funds;

            hand = new Hand();

        }

        public int getScore()
        {
            int acecount = 0;
            score = 0;
            int bust = 0;

            for (int i = 0; i < hand.cards.Count; i++)
            {
                score += ((PlayingCard)hand.cards[i]).getIntValue();

                //counts the aces in hand
                if (((PlayingCard)hand.cards[i]).CardValue() == Value.Ace)
                {
                    acecount++;
                }


                if (score > 21 && bust < 1)
                {
                    bust++;
                    score -= (acecount * 10);  
                }

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

        public bool hasBusted(int score)
        {
            if (score > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool hasBlackjack(int score)
        {
            if (score == 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
