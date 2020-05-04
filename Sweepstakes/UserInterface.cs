using System;
using System.Collections.Generic;
using System.Text;

 namespace Sweepstakes
{
    static class UserInterface
    {
        //private int registrationNumber; //where should the registration number go? It doesnt 'belong' to the user interface
        public static void GetContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Thanks for entering the sweepstakes! What is your first name?");
            contestant.firstName = Console.ReadLine();


            Console.WriteLine("What is your last name?");
            contestant.lastName = Console.ReadLine();


            Console.WriteLine("What is your e-mail address?");
            contestant.email = Console.ReadLine();

            Console.WriteLine($"Thank you! Your registration number is: {contestant.registrationNumber}");

        }
    }
}
