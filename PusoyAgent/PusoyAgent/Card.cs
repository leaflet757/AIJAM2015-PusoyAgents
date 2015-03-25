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
    }
}
