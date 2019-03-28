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
            game.CreatePlayers();



            /*Console.WriteLine();
            Console.ReadLine();*/

            //Console.WriteLine("Please choose rock, paper, or scissors"); //set it to write the string 
            //Console.ReadLine(); //reads the string/log it to the cosole

          //I MOVED THE BOOL THING TO THE GAME CLASS SO NOW HOW DO I CALL IT HERE?


        HandGesters shelter = new HandGesters();  ///to call the functions/ methods im not sure what this line is for but it was on the powerpoint
            List<string> handGesters = new List<string>();//to create the list, move this to player class
            


        }
    }
}
