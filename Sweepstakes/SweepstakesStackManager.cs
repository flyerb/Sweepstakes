using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager //LIFO
    {
        //variable

        Stack<Sweepstakes> stack;

        //ctor

        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes) 
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweep = stack.Pop();
            return sweep;
        }
    }
}

