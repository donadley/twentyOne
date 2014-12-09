namespace twentyone
{
	using System;
	using System.Collections;

    public class Hand
    {

        public ArrayList cards;
        private int playingCardCount;
        public bool ifAceExist;
        public int acecount = 0;

        public Hand()
        {
            cards = new ArrayList();
            playingCardCount = 0;
            ifAceExist = false;

        }

        public void AddCardToHand(PlayingCard cardDealt)
        {
            this.cards.Add(cardDealt);
            this.playingCardCount++;
            if (cardDealt.CardValue() == Value.Ace)
            {
                ifAceExist = true;
                acecount++;
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (PlayingCard card in this.cards)
            {
                result += card.ToString() + "\n";
            }

            return result;
        }

    }
}