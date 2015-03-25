using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PusoyAgent
{
    class Player
    {
        static private int _playerCount = -1;

        public int PlayerCount
        {
            get { return _playerCount + 1; }
        }
        
        private int _id;

        public int ID
        {
            get { return _id; }
        }

        public Player()
        {
           _id = ++_playerCount;
        }


        internal Card[] getAction(GameState currentGameState)
        {
            throw new NotImplementedException();
        }
    }
}
