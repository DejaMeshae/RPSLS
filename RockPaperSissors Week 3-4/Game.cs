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
            Compare(); 
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


     
        public void Compare()//method to compare gestures 
        {
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("It's a tie, lets play again!");
            }
               else if (playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors" ||
                playerTwo.gesture == "Lizard")
            {
                Console.WriteLine(playerOne.name + " wins this round!");
                playerOne.score++;
            }
                else if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Paper" ||
                playerTwo.gesture == "Lizard")
            {
                Console.WriteLine(playerOne.name + " wins this round!");
                playerOne.score++;
            }
                else if (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock" ||
                playerTwo.gesture == "Spock")
            {
                Console.WriteLine(playerOne.name + " wins this round!");
                playerOne.score++;
            }
                else if (playerOne.gesture == "Spock" && playerTwo.gesture == "Scissors" ||
                playerTwo.gesture == "Rock")
            {
                Console.WriteLine(playerOne.name + " wins this round!");
                playerOne.score++;
            }
                else if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Paper" ||
                playerTwo.gesture == "Spock")
            {
                    Console.WriteLine(playerOne.name + " wins this round!");
                    playerOne.score++;
            }
                else
            {
                playerTwo.score++;
                Console.WriteLine(playerTwo.name + "Won the game!");
            }
            DisplayRound(); //DisplayRound outside of the if else statement
        }


        public void DisplayRound() 
        {
            rounds++; //in the constructor round starts at 1 so it displays after the first rock paper scissors then ++ adds 1 so it goes to round 2
            Console.WriteLine(rounds);
            //figure out how to get the best 2 out of 3 round so not end it after 3 round like I was thinking
        }

    }
}

          /*public void  DisplayScore() //display the score based of the 2 out of 3 game  
            {
                Console.WriteLine(overallScore); //declare it in the constructor? but how need a method to actually calculate the score?
                Console.ReadLine();
            }*/





        



    
