using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class RunGame
    { 
        //variables
        //Contestant contestant;
        //Sweepstakes sweepstakes;
        MarketingFirm marketingFirm;
        ManagerFactory managerFactory;
        ISweepstakesManager sweepstakesManager;

        //ctor
        public RunGame()
        {
            //contestant = new Contestant();
            //sweepstakes = new Sweepstakes("name");//whats the proper thing to do with this 'name'
            managerFactory = new ManagerFactory();
            sweepstakesManager = managerFactory.ChooseSweepstakesManager();
            marketingFirm = new MarketingFirm(sweepstakesManager);

        }

        //methods

       //public void StartSweepstakes()
       // {
       //     marketingFirm.CreateSweepstakes();
       //     managerFactory.ChooseSweepstakesManager();

       //     int rounds = 3;
       //     for (int i = 0; i < rounds; i++)
       //     {
       //         Contestant currentContestant = new Contestant();
       //         sweepstakes.RegisterContestant(contestant);
       //     }
            

       //     sweepstakes.PickWinner();
       //     sweepstakes.PrintContestantInfo(contestant);
       // }
        
    }
}
