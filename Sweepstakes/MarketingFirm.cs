using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //create a sweepstakes

        //variables
        ISweepstakesManager sweepstakesManager;

        //ctor
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }

        //methods

        public void CreateSweepstakes()
        {
            Console.WriteLine("Create a new sweepstakes.What's the name of this sweepstake?");
            string userInput = Console.ReadLine();
            Sweepstakes newSweepstakes = new Sweepstakes(userInput);
            sweepstakesManager.InsertSweepstakes(newSweepstakes);
        }
    }
}


    //factory design pattern to allow a user to choose between a SweepstakesStackManager or a SweepstakesQueueManager to manage the sweepstakes objects.
