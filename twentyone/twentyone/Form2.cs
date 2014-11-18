using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace twentyone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            // Start Game When Pressed;

            //Initiates a Player with information from login
            Player player = new Player(0, "Don", "12345", 100);
           

            // Dealer
            Dealer dealer = new Dealer("Card Dealer Don");

            //Dealer Adds one card to his hand
            dealer.getHand().AddCardToHand(dealer.deal());

            //Dealer adds two card to Players hand
            for (int deal = 0; deal < 2; deal++)
            {
                player.getHand().AddCardToHand(dealer.deal());
            }

            firstCardPanel.BackgroundImage = player.getHand().getCard(0).getCardImage();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
