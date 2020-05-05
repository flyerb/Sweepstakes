using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class RunGame
    { 
        //variables
        Contestant contestant;
        Sweepstakes sweepstakes;

        //ctor
        public RunGame()
        {
            contestant = new Contestant();
            sweepstakes = new Sweepstakes()
          
        }

        //methods

       public void StartSweepstakes()
        {
            
            //for (int i = 0; i < 3; i++)
            //{
            //    contestant.CreateContestant();
            //    sweepstakes.RegisterContestant(contestant);
            //    sweepstakes.PrintContestantInfo(contestant);
            //    //loop end
            //    sweepstakes.PickWinner();

            //}
            

            // set amount of tickets to be sold - can be chosen by manager

            //Pick Winner

            //display winner info
        }
        
    }
}
