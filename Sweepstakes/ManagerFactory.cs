using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{

    class ManagerFactory
    {
        //variables

        SweepstakesStackManager stack;
        SweepstakesQueueManager queue;

        //ctor

        public ManagerFactory()
        {
         stack = new SweepstakesStackManager();
         queue = new SweepstakesQueueManager();
        }

        //method

        public ISweepstakesManager ChooseSweepstakesManager()
        {
            Console.WriteLine("Welcome to the sweepstakes entry line. Would you like to sign up for North or Central Sweepstakes?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "North":
                    return stack;

                case "Central":
                    return queue;

                default:
                    throw new ApplicationException(string.Format("You did not enter a valid option.Please choose 'North' or 'Central'"));
   
            }

        }
    }
}
