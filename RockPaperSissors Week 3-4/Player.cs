using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissors_Week_3_4
{
    public class Player //the Parent Class
    {
        //member variables (Has A) 
        int score;
        string name;
        List<string> gestures;
        string gesture;
        //string paper;
        //string scissors;
        //string lizard;
        //string spock;
       


        //constructor (Build This) //instanciate
        public void ListOfGestuers()
        {
            gestures = new List<string>();
            gestures.Add("rock");
            // string rockGesters = gestures[0];
            gestures.Add("paper");
            // string paperGesteres = gestures[1];
            gestures.Add("scissors");
            //string scissors = gestures[2];
            gestures.Add("lizard");
            //string lizard = gestures[3];
            gestures.Add("spock");
            //string spock = gestures[4];
        }


        //memeber methods (Can Do)
        public abstract void Delete()
        { 
            //random method of AI goes here?



        //put a switch case example from c# flow video either here or game class to reference gesters

    
}
