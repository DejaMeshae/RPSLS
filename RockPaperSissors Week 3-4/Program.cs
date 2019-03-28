using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissors_Week_3_4
{
    public class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {
            //Console.WriteLine("Please choose rock, paper, or scissors"); //set it to write the string 
            //Console.ReadLine(); //reads the string/log it to the cosole
            bool confirmed = false;
            while(!confirmed)
            { 
            Console.WriteLine("Are you ready to play the game RPSLS?");
            string UserInput = Console.ReadLine();
           
            if(UserInput == "yes") 
            {
                confirmed = true;

                Console.WriteLine("Good luck! "); // This is where I'm stuck at, got no idea how to do a yes/no prompt.
            }
            else {
                Console.WriteLine("Too late, lets play!");
            }
            }



            Console.ReadLine();
        }


        HandGesters shelter = new HandGesters(); ///im not sure what this line is for but it was on the powerpoint
            List<string> handGesters = new List<string>();
            

          



            Player myPlayer = new Player();

            Rock myRock = new Rock();

            Paper myPaper = new Paper();

            Scissors myScissors = new Scissors();

            Lizard myLizard = new Lizard();

            Spock mySpock = new Spock();






        
    }
}
