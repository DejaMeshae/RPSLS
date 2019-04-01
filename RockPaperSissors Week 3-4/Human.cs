using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissors_Week_3_4
{
    public class Human : Player
    {
        //member variables (Has A)
        //string choice;




        //constructor (Build This)
        public Human()
        {
            name = PlayersTypeInName();
        }



        //member methods (Can Do)
        public string PlayersTypeInName()
        {
            Console.WriteLine("Player One please enter your name"); 
            string name = Console.ReadLine();
            name = name.ToUpper();
            Console.WriteLine("Good Luck " + name);
            return name; 
        }

        public string PlayersTwoTypeInName()
        {
            Console.WriteLine("Player Two please enter your name");
            string nametwo = Console.ReadLine();
            Console.WriteLine("Good Luck " + nametwo);
            return nametwo;
        }


        public override void ChoicesOutput()
        {   

        }
        
    }
}

