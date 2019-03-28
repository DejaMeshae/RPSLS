using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissors_Week_3_4
{
    class Game
    {
        //member variables (Has A)
        Player playerOne; //Player is a class and also a datatype 
        Player playerTwo;
        Player aI;
        int rounds;       //datatype int, round is a number



        //constructor (Build This)
       
        




        //member methods (Can Do)
        public void RunGame()
        {

            CreatePlayers();
            // do all the things here
        }

        public void CreatePlayers() //notice the first letter is captalized this creates the method 
        {
            Console.WriteLine("How many players are there? 1 or 2?"); 
            string userInput = Console.ReadLine(); //ReadLine takes in an input 
            if (userInput == "1")
            {
                playerOne = new Human();
                playerTwo = new Ai();
            }
            else if (userInput == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else 
            {
                Console.WriteLine("Please enter either 1 or 2. AS STATED ABOVE *angry face*");
                Console.ReadLine();
            }
        }
    }
}






            /*public void WhoToPlayAgainst()
                    {
                        bool confirmed = false;
                        while (!confirmed)
                        {
                            Console.WriteLine("Do you want to play against the computer?");
                            string UserInput = Console.ReadLine();

                            if (UserInput == "yes")
                            {
                                confirmed = true;

                                Console.WriteLine("Good luck! "); // This is where I'm stuck at, got no idea how to do a yes/no prompt.
                            }
                            else
                            {
                                Console.WriteLine("Too late, lets play!");
                            }
                        }



            /*public void  DisplayScore() //display the score based of the 2 out of 3 game  
            {
                Console.WriteLine(overallScore); //declare it in the constructor? but how need a method to actually calculate the score?
                Console.ReadLine();
            }*/





        



    
