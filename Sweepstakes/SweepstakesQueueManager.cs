using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesQueueManager :ISweepstakesManager
    {
        // FIFO

        //variables

        Queue<Sweepstakes> queue;

        //ctor
        public SweepstakesQueueManager()
        {
         queue = new Queue<Sweepstakes>();
        }

        //methods

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes() //REMEMBER to assign the output to a variable. You have to capture it to return it.
        {
            Sweepstakes sweep = queue.Dequeue();
            return sweep;
        }
    }
}
