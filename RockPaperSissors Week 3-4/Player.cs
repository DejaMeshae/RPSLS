using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissors_Week_3_4
{
    public abstract class Player //the Parent Class
    {
        //member variables (Has A) 
        public int score;
        public int scoreAi; 
        public string name;
        public List<string> gestures;
        public string gesture;


        //constructor (Build This) //instanciate
        public Player()            //builds my list of gestures
        {
            gestures = new List<string>();
            gestures.Add("rock");
            string Rockgestures = gestures[0];
            gestures.Add("paper");
            string paperGesteres = gestures[1];
            gestures.Add("scissors");
            string scissors = gestures[2];
            gestures.Add("lizard");
            string lizard = gestures[3];
            gestures.Add("spock");
            string spock = gestures[4];
       


            score = 0; //to start the score off at 0. refer to c# methods and class demo video
        }




        //memeber methods (Can Do)
        public abstract void ChoicesOutput(); //remeber it does not need {} a body and does not need to be instanciated 



        public void DisplayScore() 
        {
            //Console.WriteLine(human.WhoPlaying + " score: " + scorePlayerOne); //refer to my question as to why human is coming back as null
        } 



    }
}
