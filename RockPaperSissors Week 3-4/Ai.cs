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





        //constructor (Build This)
        Random randomNumber = new Random(); 






        //member methods (Can Do)
        public override void ChoicesOutput()
        {
            randomInt = randomNumber.Next(0, 4);
            //switch (randomInt)
            //{
            //    case 1:
            //        inputCPU = "rock";
            //        console.WriteLine("Computer chose rock");
            //        if (inputPlayer == "rock")
            //        {
            //            Console.WriteLine("Draw! \n\n");
            //        }
            //        else if (inputPlayer == "paper")
            //        {
            //        Console.WriteLine(name +" WINS!!\n\n");
            //    scorePlayer++;
            //}

        }
        
       
    }
}
