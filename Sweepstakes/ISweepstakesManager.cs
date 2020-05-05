using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
     interface ISweepstakesManager
    {
        //sweepstakes management system 

        public void InsertSweepstakes(Sweepstakes sweepstakes);
        public Sweepstakes GetSweepstakes();

    }
}

            //Interface think Contract 
            //Can be used as a data type
            //dependency injection