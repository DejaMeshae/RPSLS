using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissors_Week_3_4
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Game game = new Game();  //instanciate the class
            game.RunGame();  //then runGame can run all of the game functions
        }
    }
}
