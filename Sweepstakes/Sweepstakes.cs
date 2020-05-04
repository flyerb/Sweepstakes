using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //variables
        Contestant contestant;
        public string name;
        Dictionary<int, Contestant> currentContestants;

        //ctor
        public Sweepstakes(string name)
        {
            contestant = new Contestant();
            this.name = name;
            currentContestants = new Dictionary<int, Contestant>();
        }

        //methods
	    public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = currentContestants.Count;
            currentContestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner() // THIS MEANS A RETURN TYPE NOT A DATA TYPE 
        {
            Random rnd = new Random();
            Contestant randomKey = currentContestants[rnd.Next(currentContestants.Count)];
            Console.WriteLine($"Congratulations, the winner is number {randomKey} !");
            return randomKey;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (KeyValuePair<int, Contestant> Dictonarycontestant in currentContestants)
            {
                Console.WriteLine($"Contestant Registration number: {currentContestants.Keys} Contestant Name: {currentContestants.Values}");
            }
        }

    }
}
