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
        int rounds;       




        //constructor (Build This)
        Human human = new Human(); //instanciate in the constructor class 


        public Game()
        {
            rounds = 1; //to start the score off at 0. refer to c# methods and class demo video
        }
        




        //member methods (Can Do)
        public void RunGame() // do all the things here call all methods here 
        {
            CreatePlayers();
            playerOne.name = PlayersTypeInName(); //this establish player one name
            playerTwo.name = PlayersTypeInName(); //this establish player two name
            DisplayRound();
        }



        public void CreatePlayers()  
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
            return; 
        }


        public string PlayersTypeInName()  
        {
            Console.WriteLine("Player One please enter your name");
            string name = Console.ReadLine(); 
            Console.WriteLine("Good Luck " + name);
            return name; //return it to have player 2 enter their name
        }


        public void Compare()//method to compare gestures 
        {
               //method to compare gesture here
        }


        public void DisplayRound() 
        {
            rounds++;
            Console.WriteLine(rounds);
        }

    }
}

          /*public void  DisplayScore() //display the score based of the 2 out of 3 game  
            {
                Console.WriteLine(overallScore); //declare it in the constructor? but how need a method to actually calculate the score?
                Console.ReadLine();
            }*/





        



    
