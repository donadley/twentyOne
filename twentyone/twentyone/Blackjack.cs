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
        double winnings = 0;
        double playerBet = 0;
        

        public Blackjack()
        {
            InitializeComponent();
        }

        public void btnDeal_Click(object sender, EventArgs e)
        {
            Dealer dealer1 = new Dealer();
            Player player1 = new Player();
            
            Blackjack game = new Blackjack();
            
           
            

            PlayingCard[] playerHand = new PlayingCard[2];
            PlayingCard[] dealerHand = new PlayingCard[2];
            

            playerHand[0] = dealer1.DealCard();
            playerHand[1] = dealer1.DealCard();
            dealerHand[0] = dealer1.DealCard();
            dealerHand[1] = dealer1.DealCard();

            pnlplayerHand0.BackgroundImage = playerHand[0].getCardImage(playerHand[0]);
            pnlplayerHand1.BackgroundImage = playerHand[1].getCardImage(playerHand[1]);
            pnlDC0.BackgroundImage = dealerHand[0].getCardImage(dealerHand[0]);
            pnlDC1.BackgroundImage = dealerHand[1].getCardImage(dealerHand[1]);

            lblPlayerScore.Text = game.getScore(playerHand).ToString();
            lblDealerScore.Text = game.getScore(dealerHand).ToString();

            if (game.getScore(playerHand) < game.getScore(dealerHand))
            {
                lblWinner.Text = "Dealer Wins!";
            }
            if (game.getScore(playerHand) > game.getScore(dealerHand))
            {
                lblWinner.Text = "Player Wins!";
            }
            game.isWinner();
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

        public bool checkBlackJack(int score)
        {
            if (score == 21)
            {
                MessageBox.Show("BlackJack!");
                winnings += playerBet * 1.5;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void isWinner()
        {
            string score2 = "010";

            lblDealer.Text = score2;
           
            

        }

        //Bet Selector
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
