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

        internal int getScore(int playerIndex)
        {
            return data.Players[playerIndex].getScore();
        }

        internal int getHandCount(int playerIndex)
        {
            Hand hand = data.Players[playerIndex].getHand();
            return hand.GetCount();
        }

        internal Hand getLastPlayedHand()
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

        internal Player[] getPlayers()
        {
            return data.Players;
        }
    }
}
