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
        public int scoreAi;
        bool playAgain = true;




        //constructor (Build This)


        public Game()
        {
            rounds = 1; //to start the score off at 0. refer to c# methods and class demo video
        }
        




        //member methods (Can Do)
        public void RunGame() // do all the things here call all methods here 
        {
            HowToPlay();
            CreatePlayers();
            Compare();
            PlayAgain();
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
        }

        public void HowToPlay()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! This game can be played with 1 or 2 players. In order to win you must win the 2 out of 3 rounds, if its a draw the game will continue. Good Luck! ");
        }

     
        public void Compare()//method to compare gestures 
        {
            Console.WriteLine("Choose Rock, paper,scissors, lizard, or spock"); 
            playerOne.gesture = Console.ReadLine();
            playerTwo.gesture = Console.ReadLine();
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
                Console.WriteLine(playerTwo.nametoo + " Won the game!");
            }
            DisplayRound(); 
            DisplayScore();
            Console.ReadLine();       
        }


        public void DisplayRound() 
        {
            rounds++; 
            Console.WriteLine("This is now round " + rounds);
            Compare();
            //figure out how to get the best 2 out of 3 round so not end it after 3 round like I was thinking
        }


        public void  DisplayScore() //display the score based of the 2 out of 3 game  
           {
             playerTwo.score++;
             playerOne.score++;
            Console.WriteLine(playerOne.name + " score is now " + playerOne.score);
            Console.WriteLine(playerTwo.name + " score is now " + playerTwo.score);
            Console.ReadLine();
           }

        public void PlayAgain()
        {
            Console.WriteLine("Lets play again! Type in 'yes' to play again and 'no' to quit");
            string answertoplayagain = Console.ReadLine();
            if (answertoplayagain == "yes")
            {
                playAgain = true;
            }
            else if (answertoplayagain == "no")
            {
                playAgain = false;
            }
            else
            {
                Console.WriteLine("Please try again");
                Console.ReadLine();
            }
            return;
        }   

    }
}

         




        



    
