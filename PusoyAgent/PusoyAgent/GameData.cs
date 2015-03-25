using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// TODO: implement singlton

namespace Global
{

    class Identifiers
    {
        public const string PASS = "pass";
    }

    class Utils
    {
        public static Random randomNum = new Random();
    }

    class GameData
    {
        private PusoyAgent.Player[] players;

        private PusoyAgent.Deck<PusoyAgent.Card> deck;

        private PusoyAgent.GameState currentGameState;


        internal PusoyAgent.GameState getGameState()
        {
            if (currentGameState == null)
            {
                
            }
            return currentGameState;
        }

        internal string getHandString(int playerID)
        {
            return "temp";
        }

        internal void initDeckData(PusoyAgent.Deck<PusoyAgent.Card> deck)
        {
            this.deck = deck;
        }

        internal void initPlayerData(PusoyAgent.Player[] players)
        {
            this.players = players;
        }
    }
}
