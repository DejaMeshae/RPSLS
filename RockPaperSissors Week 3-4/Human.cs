﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissors_Week_3_4
{
    public class Human : Player
    {
        //member variables (Has A)
        string choice;




        //constructor (Build This)

            
        //member methods (Can Do)
        public override void ChoicesOutput()
        {
            Console.WriteLine("Choose Rock, paper,scissors, lizard, or spock"); //asks human player choose what gesture they want
            choice = Console.ReadLine();
            switch(choice)
            {
                case "rock" :
                    choice = gestures[0]; //giving the choices a int so rock = 1 then use if loop?? 
                Console.WriteLine("rock");
                break;
                case "paper":
                    choice = gestures[1];
                    Console.WriteLine("paper");
                    break;
                case "scissors":
                    choice = gestures[2];
                    Console.WriteLine("scissors");
                    break;
                case "lizard":
                    choice = gestures[3];
                    Console.WriteLine("lizard");
                    break;
                case "spock":
                    choice = gestures[4];
                    Console.WriteLine("spock");
                    break;
                default:
                    Console.WriteLine("Please try again");
                    return;
            }
        }
        
    }
}

