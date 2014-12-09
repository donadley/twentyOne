using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace twentyone
{

    public partial class Blackjack : Form
    {
        int playerHitCount;
        int dealerHitCount;
        Dealer dealer;
        public Player player1;
        public int hitCount;
        bool surrender;
        int count = 0;

        public Blackjack(Player player1)
        {
            InitializeComponent();

            //Making a game with a dealer and player
            dealer = new Dealer();
            this.player1 = player1;
            hitCount = 0;
        }

        public void btnDeal_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please Enter A Bet");
            }
            else
            {


                if (count < 1)
                {
                    player1.bet = float.Parse(comboBox1.Text);
                }

                if (player1.funds == 0)
                {
                    DialogResult borrowMoney;

                    borrowMoney = MessageBox.Show("You're broke. Do you want to loan $1000 from the bank?", "", MessageBoxButtons.YesNo);

                    if (borrowMoney == DialogResult.Yes)
                    {
                        player1.funds = 1000;
                        fundsExceeded();
                    }
                    else
                    {
                        Application.Exit();
                    }

                }
                else if (Double.Parse(comboBox1.Text) > player1.funds)
                {
                    MessageBox.Show("Bet exceeds player funds. Please reduce your bet.");
                    fundsExceeded();
                }

                else
                {

                    player1.bet = float.Parse(comboBox1.Text);
                    player1.hand.AddCardToHand(dealer.DealCard());
                    player1.hand.AddCardToHand(dealer.DealCard());

                    dealer.hand.AddCardToHand(dealer.DealCard());
                    dealer.hand.AddCardToHand(dealer.DealCard());

                    lblMoney.Text = "Your Money: $" + player1.funds.ToString();

                    pnlplayerHand0.BackgroundImage = ((PlayingCard)player1.hand.cards[0]).getCardImage();
                    pnlplayerHand1.BackgroundImage = ((PlayingCard)player1.hand.cards[1]).getCardImage();
                    pnlDC0.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Cards\\b1fv.png");
                    pnlDC1.BackgroundImage = ((PlayingCard)dealer.hand.cards[1]).getCardImage();

                    if (player1.hasBlackjack(player1.getScore()))
                    {
                        endGame();
                    }
                    if (dealer.hasBlackjack(dealer.getScore()))
                    {
                        pnlDC0.BackgroundImage = ((PlayingCard)dealer.hand.cards[0]).getCardImage();
                        endGame();
                    }

                    btnDeal.Visible = false;
                    btnDouble.Visible = true;
                    btnHit.Visible = true;
                    btnSplit.Visible = true;
                    btnStand.Visible = true;
                    btnSurrender.Visible = true;
                    lblPlayerScore.Text = "" + player1.getScore();
                }
            }
        }

        public string gameResults(Player player1, Dealer dealer)
        {
            if (player1.hasBusted(player1.score))
            {
                player1.funds = player1.funds - player1.bet;
                return "Player Busted. Dealer Wins!";

            }
            else if (dealer.hasBusted(dealer.score))
            {
                player1.funds = player1.funds + player1.bet;
                return "Dealer Busted. Player Wins!";
            }

            else if (player1.hasBlackjack(player1.score))
            {

                player1.funds = player1.funds + (player1.bet * (float)1.5);
                return "Player Blackjack!";
            }
            else if (dealer.hasBlackjack(dealer.score))
            {
                player1.funds = player1.funds - player1.bet;
                return "Dealer Blackjack!";
            }

            else if (player1.getScore() < dealer.getScore())
            {
                player1.funds = player1.funds - player1.bet;
                return "Dealer Wins!";
            }
            else if (player1.getScore() > dealer.getScore())
            {
                player1.funds = player1.funds + player1.bet;
                return "Player Wins!";
            }
            else
            {
                return "Push!";
            }
        }

        public void btnHit_Click(object sender, EventArgs e)
        {
            btnSplit.Visible = false;
            btnDouble.Visible = false;
            btnSurrender.Visible = false;

            player1.Hit(dealer.DealCard());
            pnlPC2.BackgroundImage = ((PlayingCard)player1.hand.cards[(hitCount + 2)]).getCardImage();
            lblPlayerScore.Text = "" + player1.getScore();
            if (player1.getScore() > 21)
            {
                //lblWinner.Text = "Busted! Dealer Wins!";
                endGame();
            }

            hitCount++;

            //playerHitCount++;

        }

        public void btnStand_Click(object sender, EventArgs e)
        {
            dealersTurn();
        }

        public void endGame()
        {
            //Shuffle when deck almost empty
            if (dealer.pack.CloseToEmpty)
            {
                dealer.pack = new Pack();
            }

            lblMoney.Text = "Your Money: $" + player1.funds.ToString();
            DialogResult playAgain;

            if (surrender == true)
            {
                playAgain = MessageBox.Show("Player surrendered.\r\nPlay again?", "Play again?", MessageBoxButtons.YesNo);
            }

            else
            {
                playAgain = MessageBox.Show(gameResults(player1, dealer) + "\r\nPlay again?", "", MessageBoxButtons.YesNo);
            }

            // Updating funds to db
            string objConn = @"Data Source=CSCPROJECTS.lsus.local;Initial Catalog=BlackJack;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(objConn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE BlackJackPlayerTB SET Funds = @Funds WHERE (Username = @Username)";

                    cmd.Parameters.AddWithValue("@Username", player1.username);
                    cmd.Parameters.AddWithValue("@Funds", player1.funds);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Clone();
                        cmd.Parameters.Clear();
                    }
                    catch (SqlException s)
                    {
                        MessageBox.Show(s.Message.ToString(), "Did not save funds");
                    }

                }
            }
            if (playAgain == DialogResult.Yes)
            {
                pnlDC0.BackgroundImage = null;
                pnlDC1.BackgroundImage = null;
                panel1.BackgroundImage = null;
                panel2.BackgroundImage = null;
                panel3.BackgroundImage = null;
                panel4.BackgroundImage = null;
                panel5.BackgroundImage = null;
                pnlPC2.BackgroundImage = null;
                pnlplayerHand0.BackgroundImage = null;
                pnlplayerHand1.BackgroundImage = null;
                lblPlayerScore.Text = null;
                lblDealerScore.Text = null;
                player1.score = 0;
                dealer.score = 0;
                btnDeal.Visible = true;
                btnDouble.Visible = false;
                btnHit.Visible = false;
                btnSplit.Visible = false;
                btnStand.Visible = false;
                btnSurrender.Visible = false;
                player1.hand.cards.Clear();
                dealer.hand.cards.Clear();
                player1.hand = new Hand();
                //dealer = new Dealer();
                hitCount = 0;
                lblMoney.Text = "Your Money: $" + player1.funds.ToString();
                surrender = false;
                count++;

            }
            else
            {
                Application.Exit();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            player1.bet = player1.bet * 2;
            player1.Hit(dealer.DealCard());
            pnlPC2.BackgroundImage = ((PlayingCard)player1.hand.cards[2]).getCardImage();
            lblPlayerScore.Text = "" + player1.getScore();
            if (player1.hasBusted(player1.getScore()))
            {
                endGame();
            }
            else
            {
                dealersTurn();
            }
        }

        private void dealersTurn()
        {
            pnlDC0.BackgroundImage = ((PlayingCard)dealer.hand.cards[0]).getCardImage();
            lblDealerScore.Text = dealer.getScore().ToString();

            while (dealer.getScore() < 17)
            {

                if (dealer.getScore() < 17 && dealerHitCount == 0)
                {
                    dealer.Hit(dealer.DealCard());
                    panel1.BackgroundImage = ((PlayingCard)dealer.hand.cards[2]).getCardImage();
                }
                if (dealer.getScore() < 17 && dealerHitCount == 1)
                {
                    dealer.Hit(dealer.DealCard());
                    panel1.BackgroundImage = ((PlayingCard)dealer.hand.cards[3]).getCardImage();
                }
                if (dealer.getScore() < 17 && dealerHitCount == 2)
                {
                    dealer.Hit(dealer.DealCard());
                    panel1.BackgroundImage = ((PlayingCard)dealer.hand.cards[4]).getCardImage();
                }

                lblDealerScore.Text = dealer.getScore().ToString();
            }
            endGame();
        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            player1.funds = player1.funds - (player1.bet / 2);
            surrender = true;
            endGame();

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (((PlayingCard)player1.hand.cards[0]).CardValue() == ((PlayingCard)player1.hand.cards[1]).CardValue())
            {

                player1.hand.AddCardToHand(dealer.DealCard());
                player1.hand.AddCardToHand(dealer.DealCard());
                panel3.BackgroundImage = ((PlayingCard)player1.hand.cards[1]).getCardImage();
                pnlplayerHand1.BackgroundImage = ((PlayingCard)player1.hand.cards[2]).getCardImage();
                panel5.BackgroundImage = ((PlayingCard)player1.hand.cards[3]).getCardImage();
                int hand1Score = ((PlayingCard)player1.hand.cards[0]).getIntValue() + ((PlayingCard)player1.hand.cards[2]).getIntValue();
                int hand2Score = ((PlayingCard)player1.hand.cards[1]).getIntValue() + ((PlayingCard)player1.hand.cards[3]).getIntValue();

                if (hand1Score > dealer.getScore())
                {
                    player1.funds = player1.funds + player1.bet;
                }
                if (hand2Score > dealer.getScore())
                {
                    player1.funds = player1.funds + player1.bet;
                }
                else
                {
                    player1.funds = player1.funds - (player1.funds * 2);
                    endGame();
                }

                endGame();
            }
            else
            {
                MessageBox.Show("You may only split a pair with the same value.");
            }


        }
        private void fundsExceeded()
        {
            pnlDC0.BackgroundImage = null;
            pnlDC1.BackgroundImage = null;
            panel1.BackgroundImage = null;
            panel2.BackgroundImage = null;
            panel3.BackgroundImage = null;
            panel4.BackgroundImage = null;
            panel5.BackgroundImage = null;
            pnlPC2.BackgroundImage = null;
            pnlplayerHand0.BackgroundImage = null;
            pnlplayerHand1.BackgroundImage = null;
            lblPlayerScore.Text = null;
            lblDealerScore.Text = null;
            player1.score = 0;
            dealer.score = 0;
            player1.hand.cards.Clear();
            dealer.hand.cards.Clear();
            btnDeal.Visible = true;
            btnDouble.Visible = false;
            btnHit.Visible = false;
            btnSplit.Visible = false;
            btnStand.Visible = false;
            btnSurrender.Visible = false;
            lblMoney.Text = "Your Money: $" + player1.funds.ToString();
            surrender = false;

        }

        private void Blackjack_Load(object sender, EventArgs e)
        {

        }
    }
}
