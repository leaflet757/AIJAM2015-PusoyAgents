using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PusoyAgent
{
    class GameState
    {
        private Global.GameData data;

        public GameState(Global.GameData data)
        {
            this.data = data;
        }

        public bool IsLegalMove(Card[] cards)
        {
            throw new NotImplementedException();
        }

        public Card[][] GetLegalMoves()
        {
            throw new NotImplementedException();
        }

        internal string getScore(int playerID)
        {
            throw new NotImplementedException();
        }

        internal string getHandCount(int playerID)
        {
            throw new NotImplementedException();
        }

        internal string getLastPlayedHand()
        {
            throw new NotImplementedException();
        }

        internal GameState getPrevState()
        {
            throw new NotImplementedException();
        }

        internal int getTurnStartIndex()
        {
            throw new NotImplementedException();
        }
    }
}
