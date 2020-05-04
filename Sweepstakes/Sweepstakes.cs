using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //variables
        Contestant contestant;

        //ctor
        public Sweepstakes()
        {
            contestant = new Contestant();
        }

        //methods
        Dictionary<int, string> currentContestants = new Dictionary<int, string>();

        public void AddContestantToDictonary()
        {
            currentContestants.Add(contestant.registrationNumber, contestant.lastName + contestant.firstName);
        }

       public Sweepstakes(string name)
        {
            //???
        }
        
	    public void RegisterContestant(Contestant contestant)
        {
            UserInterface.GetContestantInfo(contestant);
            AddContestantToDictonary();
        }
	   
        public Contestant PickWinner()
        {
            //???
        }
  
	    public void PrintContestantInfo(Contestant contestant)  //do I need contestant here? It's in the user stories   / this doesnt print email
        {
            foreach (KeyValuePair<int, string> Dictonarycontestant in currentContestants)
            {
                Console.WriteLine($"Contestant Registration number: {currentContestants.Keys} Contestant Name: {currentContestants.Values}");
            }
        }

    }
}
