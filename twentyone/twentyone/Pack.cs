namespace twentyone
{
	using System;
	using System.Collections;
    using System.Drawing;
    using System.Windows.Forms;

	public class Pack
	{
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        public int cardsPerPack = 52;
        private PlayingCard[,] cardPack;
        private Random randomCardSelector = new Random();
        public bool CloseToEmpty;
        public int cutCardforshuffle;

		public Pack()
		{
            CloseToEmpty = false;

            Random randomCard = new Random();
            cutCardforshuffle = randomCard.Next(5, 15);

            this.cardPack = new PlayingCard[NumSuits, CardsPerSuit];

            for (Suit suit = Suit.Club; suit <= Suit.Spade; suit++)
            {
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    this.cardPack[(int)suit, (int)value] = new PlayingCard(suit, value);
                }
            }
		}

        public PlayingCard DealCardFromPack()
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits);
            while (this.IsSuitEmpty(suit))
            {
                suit = (Suit)randomCardSelector.Next(NumSuits);
            }

            Value value = (Value)randomCardSelector.Next(CardsPerSuit);
            while (this.IsCardAlreadyDealt(suit, value))
            {
                value = (Value)randomCardSelector.Next(CardsPerSuit);
            }

            PlayingCard card = this.cardPack[(int)suit, (int)value];
            this.cardPack[(int)suit, (int)value] = null;
            cardsPerPack--;

            if (cardsPerPack == cutCardforshuffle)
            {
                CloseToEmpty = true;
            }
            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            bool result = true;

            for (Value value = Value.Two; value <= Value.Ace; value++)
            {
                if (!IsCardAlreadyDealt(suit, value))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            return (this.cardPack[(int)suit, (int)value] == null); 
        }
	}
}