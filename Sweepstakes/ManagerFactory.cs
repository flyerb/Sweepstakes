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
            Console.WriteLine("Welcome to the sweepstakes entry line. Would you like to sign up for Stack or Queue Sweepstakes?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "Stack":
                    return stack;

                case "Queue":
                    return queue;

                default:
                    Console.WriteLine("You did not enter a valid option.Please choose 'Stack' or 'Queue'");
                    return ChooseSweepstakesManager();

            }

        }
    }
}
