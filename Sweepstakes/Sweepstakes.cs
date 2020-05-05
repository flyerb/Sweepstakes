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
            contestant.registrationNumber = currentContestants.Count+ 1;
            currentContestants.Add(contestant.registrationNumber, contestant);
            Console.WriteLine($"You are registered! Your number is {contestant.registrationNumber}");
        }

        public Contestant PickWinner() // THIS MEANS A RETURN TYPE NOT A DATA TYPE 
        {
            Random rnd = new Random();

            int winningNumber = rnd.Next(currentContestants.Count);

           
            foreach (KeyValuePair<int, Contestant> sweepstakesWinner in currentContestants)
            {
                if (winningNumber == contestant.registrationNumber)
                {
                    Console.WriteLine($"Congratulations! The winning number is: {winningNumber}!");
                    Contestant winner = sweepstakesWinner.Value;
                    return winner;
                }
            }
            return contestant;//wrong! what is this? come back and figure this out.
        }

        public void PrintContestantInfo(Contestant contestant)
        {
          Console.WriteLine($"Contestant Registration number: {contestant.registrationNumber} Contestant Name: {contestant.firstName} {contestant.lastName}");

        }

    }
}
