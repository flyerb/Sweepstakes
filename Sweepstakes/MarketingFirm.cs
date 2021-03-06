﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    //This class is where I used Dependency Injection. The benefit this adds to my application, is that I can pass ISweepstakesManager through as the parameter for the MarketingFirm() which allows either a queue or a stack to be created which is chosen by user input.

    class MarketingFirm 
    {
        //create a sweepstakes

        //variables
        public ISweepstakesManager sweepstakesManager;

        //ctor
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }

        //methods

        public Sweepstakes CreateSweepstakes()
        {
            int run = 3;
            Sweepstakes newSweepstakes = new Sweepstakes("");

            for (int i = 0; i < run; i++)
            {
                Console.WriteLine("Hello, Marketing team! What would you like to name the new Sweepstake?");
                string userInput = Console.ReadLine();

                newSweepstakes = new Sweepstakes(userInput);

                sweepstakesManager.InsertSweepstakes(newSweepstakes);
                
            }
            return newSweepstakes;
        }
    }
}

