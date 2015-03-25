using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PusoyAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            PusoyGame game = new PusoyGame(4);
            // game.loadContent();
            game.initialize();
            game.startGame();

            int prevTime = 0;
            while (game.IsRunning)
            {
                int deltaTime = System.DateTime.Now.Millisecond - prevTime;
                prevTime = deltaTime;

                game.draw();
                game.update(deltaTime);
            }
            game.exitGame();
        }
    }
}
