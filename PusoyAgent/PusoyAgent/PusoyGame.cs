using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PusoyAgent
{
    class PusoyGame
    {
        private bool _isRunning;

        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }

        private int _playerCount;

        public int PlayerCount
        {
            get { return _playerCount; }
            set { _playerCount = value; }
        }

        private Player[] players;

        private Deck<Card> deck;

        private Global.GameData gameData;

        public PusoyGame(int numPlayers)
        {
            _playerCount = numPlayers;
            players = new Player[numPlayers];
            deck = new Deck<Card>();

            gameData = new Global.GameData();
        }

        internal void initialize()
        {
            for (int i = 0; i < PlayerCount; i++)
            {
                players[i] = new Player();
                //if (i == 0)
                //{
                //    players[i].attachController(new InputController(ref gameData));
                //}
                //else
                //{
                //    players[i].attachController(new AIController(ref gameData));
                //}
            }
            gameData.initPlayerData(players);

            CardType type = CardType.SPADES;
            for (int i = 0; i < 52; i++)
            {
                Card c;
                c.type = type;
                c.Value = (i + 1) % 13;
                deck.AddCard(c);
                if ((i + 1) % 13 == 0)
                {
                    type++;
                }
            }
            // shuffle twice because we fo real
            deck.Shuffle();
            deck.Shuffle();
            gameData.initDeckData(deck);
        }

        internal void loadContent()
        {
            throw new NotImplementedException();
        }

        internal void startGame()
        {
            
            IsRunning = true;
        }

        internal void update(int deltaTime)
        {
            GameState currentGameState = gameData.getGameState();
            //GameState prevGameState = currentGameState.getPrevState();
            /*
            bool gettingPlayerInput = true;
            int startIndex = currentGameState.getTurnStartIndex();
            int index = startIndex;
            while (gettingPlayerInput)
            {
                Card[] cards = players[index++].getAction(currentGameState);

                if (cards.Length > 0)
                {

                } // otherwise player passes

                // check if we have gone through all players
                if (index == startIndex)
                {
                    gettingPlayerInput = false;
                }
            }
            */
            // throw new NotImplementedException();
            // determine who goes first
            // TODO: have each player go, update gameData each time
            Console.Write("\nType in cards or pass: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            // update things if player does not pass
            if (!string.Equals(input, Global.Identifiers.PASS, StringComparison.OrdinalIgnoreCase))
            {

            }
        }

        internal void draw()
        {
            GameState currentGameState = gameData.getGameState();
            //GameState prevGameState = currentGameState.getPrevState();

            // Top Boarder
            Console.WriteLine("-----------------------------------------------------");
            // Player Scores
            Console.Write("|Players' Scores:  P1-");
            //Console.Write(currentGameState.getScore(players[0].ID));
            Console.Write("  P2-");
            //Console.Write(currentGameState.getScore(players[1].ID));
            Console.Write("  P3-");
            //Console.Write(currentGameState.getScore(players[2].ID));
            Console.Write("  P4-");
            //Console.Write(currentGameState.getScore(players[3].ID));
            Console.WriteLine();            
            // cards in hand
            Console.Write("|Cards In Hand:  ");
            //Console.Write(currentGameState.getHandCount(players[0].ID));
            Console.Write("  P2-");
            //Console.Write(currentGameState.getHandCount(players[1].ID));
            Console.Write("  P3-");
            //Console.Write(currentGameState.getHandCount(players[2].ID));
            Console.Write("  P4-");
            //Console.Write(currentGameState.getHandCount(players[3].ID));
            Console.WriteLine("\n|");            
            // Last played hand
            Console.WriteLine("|Last Played Hand:                                   ");
            //Console.WriteLine(currentGameState.getLastPlayedHand());
            // blank space
            Console.WriteLine("|\n|");
            // players hand
            Console.WriteLine("|Player's Hand:");
            //Console.WriteLine(gameData.getHandString(players[0].ID));
            // bottom boarder
            Console.WriteLine("-----------------------------------------------------");
        }

        internal void exitGame()
        {
            throw new NotImplementedException();
        }
    }
}
