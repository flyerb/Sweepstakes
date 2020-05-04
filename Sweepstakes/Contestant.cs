using System;
using System.Collections.Generic;
using System.Text;

 namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;

        public Contestant()
        {
           
        }

        public void CreateContestant()
        {
            firstName = UserInterface.GetStringInput("please enter first name");
            lastName = UserInterface.GetStringInput("please enter last name");
            email = UserInterface.GetStringInput("please enter email");
        }

        //public int GetRegistrationNumber()
        //{
        //    registrationNumber = currentcontestant.count;

        //}
    }
}
