using System.Drawing;
using System.Resources;
using System.Reflection;

namespace twentyone
{
	public class PlayingCard
	{
        private readonly Suit suit;
        private readonly Value value;
        private Image cardImage;

		public PlayingCard(Suit s, Value v)
		{
            ResourceManager rm = new ResourceManager("twentyone.Properties.Resources", typeof(twentyone.Properties.Resources).Assembly);
			this.suit = s;
			this.value = v;            
            cardImage = rm.GetObject("3C.png") as Image;
		}

        public override string ToString()
		{
            string result = string.Format("{0} of {1}", this.value, this.suit);
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
            return cardImage;
        }
	}
}