using System.Drawing;
using System.Windows.Forms;
using System;

namespace twentyone
{
	public class PlayingCard
	{
        private readonly Suit suit;
        private readonly Value value;
    

		public PlayingCard(Suit s, Value v)
		{
			this.suit = s;
			this.value = v;
            
		}

        public override string ToString()
        {
            string result = string.Format("{0}{1}", this.value, this.suit);
            return result;
        }

        public Suit CardSuit()
        {
            return this.suit;
        }

        public Value CardValue()
        {
            return this.value;
        }

        public Image getCardImage()
        {
            Image cardImage = Image.FromFile(Application.StartupPath + "\\Cards\\" + string.Format("{0}{1}", this.CardValue(), this.CardSuit() + ".png"));
            return cardImage;
        }
        public int getIntValue(Value value)
        {
            switch (value)
            {
                case Value.Two:
                    return 2;
                case Value.Three:
                    return 3;
                case Value.Four:
                    return 4;
                case Value.Five:
                    return 5;
                case Value.Six:
                    return 6;
                case Value.Seven:
                    return 7;
                case Value.Eight:
                    return 8;
                case Value.Nine:
                    return 9;
                case Value.Ten:
                    return 10;
                case Value.Jack:
                    return 10;
                case Value.Queen:
                    return 10;
                case Value.King:
                    return 10;
                case Value.Ace:
                    return 11;
                default:
                    return 0;
            }
        }
    }
}