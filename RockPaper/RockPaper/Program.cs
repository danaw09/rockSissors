using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class Program
    {
       public  static void Main(string[] args)
        {

            GameAction myGame = new Game();
            myGame.StartGame();
        }
    }
}
