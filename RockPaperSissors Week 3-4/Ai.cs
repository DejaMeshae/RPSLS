using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissors_Week_3_4
{
    public class Ai : Player
    {
        //member variables (Has A)
        int randomInt;
        Player playerTwo;
        Player playerOne;







        //constructor (Build This)
        Random randomNumber = new Random();
        Game game = new Game();






        //member methods (Can Do)
        public override void ChoicesOutput()
        {
            randomInt = randomNumber.Next(0, 4);
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("It's a tie, lets play again!");
                return;
            }
            else if (playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors" || //can i replace aI.gesture == "Scissors" with aI.gesture == gestures[0] and itll reference the list
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
                playerOne.score++;
                Console.WriteLine(playerOne.name + "Won the game!");
            }
            Console.WriteLine("This is the start of round"); game.DisplayRound(); 
            Console.ReadLine();
        }
    }
}
            
                