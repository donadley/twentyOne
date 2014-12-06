namespace twentyone
{
	using System;
	using System.Collections;

    public class Hand
    {

        public ArrayList cards;
        private int playingCardCount;

        public Hand()
        {
            cards = new ArrayList();
            playingCardCount = 0;

        }

        public void AddCardToHand(PlayingCard cardDealt)
        {
            this.cards.Add(cardDealt);
            this.playingCardCount++;
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