using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PusoyAgent
{
    enum CardType {
        CLUBS = 1,
        SPADES = 2,
        HEARTS = 3,
        DIAMONDS = 4
    }

    struct Card
    {
        public CardType type;
        public int Value;

        public override string ToString()
        {
            string t = "";
            switch (this.type)
            {
                case CardType.CLUBS:
                    t = "C";
                    break;
                case CardType.DIAMONDS:
                    t = "D";
                    break;
                case CardType.HEARTS:
                    t = "H";
                    break;
                case CardType.SPADES:
                    t = "S";
                    break;
            }
            string v = this.Value.ToString();
            switch (this.Value)
            {
                case 1:
                    v = "A";
                    break;
                case 11:
                    v = "J";
                    break;
                case 12:
                    v = "Q";
                    break;
                case 13:
                    v = "K";
                    break;
            }

            return v + t;
        }
    }
}
