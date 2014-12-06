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
        public int hitCount;
        public Blackjack()
        {
            InitializeComponent();

            //Making a game with a dealer and player
            dealer = new Dealer();
            player1 = new Player();
            hitCount = 0;
        }

        public void btnDeal_Click(object sender, EventArgs e)
        {
            Blackjack game = new Blackjack();

            player1.hand.AddCardToHand(dealer.DealCard());
            player1.hand.AddCardToHand(dealer.DealCard());

            dealer.hand.AddCardToHand(dealer.DealCard());
            dealer.hand.AddCardToHand(dealer.DealCard());

            pnlplayerHand0.BackgroundImage = ((PlayingCard)player1.hand.cards[0]).getCardImage();
            pnlplayerHand1.BackgroundImage = ((PlayingCard)player1.hand.cards[1]).getCardImage();
            pnlDC0.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Cards\\b1fv.png");

            pnlDC1.BackgroundImage = ((PlayingCard)dealer.hand.cards[1]).getCardImage();

            btnDeal.Visible = false;

            lblPlayerScore.Text = "" + player1.getScore();

        }

        public bool checkBlackJack(int score, double playerBet)
        {
            if (score == 21)
            {
                lblWinner.Text = "Player BlackJack!";
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
                lblWinner.Text = ("Dealer BlackJack!");

                return true;
            }
            else
            {
                return false;
            }
        }

        public string isWinner(Player player1, Dealer dealer)
        {
            if (player1.getScore() < dealer.getScore() && dealer.getScore() < 22)
            {
                return "Dealer Wins!";
            }
            else if (player1.getScore() > dealer.getScore() && player1.getScore() < 22)
            {
                return "Player Wins!";
            }
            else
            {
                return "Player Wins!";
            }
        }

        public void btnHit_Click(object sender, EventArgs e)
        {
            player1.Hit(dealer.DealCard());
            pnlPC2.BackgroundImage = ((PlayingCard)player1.hand.cards[(hitCount+2)]).getCardImage();
            lblPlayerScore.Text = "" + player1.getScore();
            if (player1.getScore() > 21)
            {
                lblWinner.Text = "Busted! Dealer Wins!";
                endGame();
            }
            
            hitCount++;
        }
        public bool dealerUnder17()
        {
            if (dealer.getScore() >= 17)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void btnStand_Click(object sender, EventArgs e)
        {
            endGame();
        }

        public void endGame()
        {
            while (dealerUnder17())
            {
                dealer.Hit(dealer.DealCard());
            }

            //Show dealer's hidden card and score
            pnlDC0.BackgroundImage = ((PlayingCard)dealer.hand.cards[0]).getCardImage();
            lblDealerScore.Text = "" + dealer.getScore();

            lblWinner.Text = isWinner(player1, dealer);

            btnDeal.Visible = true;

        }


    }
}
