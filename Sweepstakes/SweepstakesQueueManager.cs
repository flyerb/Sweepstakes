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

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes() //need to capture the variable to return
        {
            Sweepstakes sweep = queue.Dequeue();
            return sweep;
        }
    }
}
