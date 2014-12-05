using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace twentyone
{
     
    public partial class Blackjack : Form
    {
        Dealer dealer;
        Player player1;
        public int hitCount = 0;
        public Blackjack()
        {
            InitializeComponent();

            //Making a game with a dealer and player
            dealer = new Dealer();
            player1 = new Player();
        }

        public void btnDeal_Click(object sender, EventArgs e)
        {
            player1.Hit(dealer.DealCard());            
            player1.Hit(dealer.DealCard());

            dealer.Hit(dealer.DealCard());
            dealer.Hit(dealer.DealCard());

            pnlplayerHand0.BackgroundImage = player1.hand.cards[0].getCardImage();
            pnlplayerHand1.BackgroundImage = player1.hand.cards[1].getCardImage();
            pnlDC0.BackgroundImage = dealer.hand.cards[1].getCardImage();
            pnlDC1.BackgroundImage = dealer.hand.cards[1].getCardImage();

            btnDeal.Visible = false;
        }

        public int getScore(PlayingCard[] hand)
        {
            int score = 0;

            for (int i = 0; i < hand.Length; i++)
            {
                score += hand[i].getIntValue(hand[i].CardValue());
            }

            return score;
        }

        public bool checkBlackJack(int score,double playerBet)
        {
            if (score == 21)
            {
                lblWinner.Text="Player BlackJack!";
                //winnings += playerBet * 1.5;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkBlackJack(int score)
        {
            if (score == 21)
            {
                lblWinner.Text=("Dealer BlackJack!");
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public string isWinner(int playerHand, int dealerHand)
        {
            if (playerHand < dealerHand)
            {
                return "Dealer Wins!";
            }
            else if (playerHand > dealerHand)
            {
                return "Player Wins!";
            }
            else
            {
                return "Push!";
            }
        }

        public void btnHit_Click(object sender, EventArgs e)
        {
            if (hitCount == 0)
            {
                player1.Hit(dealer.DealCard());
                pnlPC2.BackgroundImage = player1.hand.cards[2].getCardImage();
            }
            if (hitCount == 1)
            {
                player1.Hit(dealer.DealCard());
                panel3.BackgroundImage = player1.hand.cards[3].getCardImage();
            }
            if (hitCount == 2)
            {
                player1.Hit(dealer.DealCard());
                panel5.BackgroundImage = player1.hand.cards[4].getCardImage();
            }
            hitCount++;                
        }
         
    }
}
