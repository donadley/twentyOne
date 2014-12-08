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
            score = 0;

            for (int i = 0; i < hand.cards.Count; i++)
            {
                score += ((PlayingCard)hand.cards[i]).getIntValue();
                if (score > 21 && hand.ifAceExist)
                {
                    score -= 10;
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
