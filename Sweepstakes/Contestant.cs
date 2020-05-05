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


        public void CreateContestant()
        {
            firstName = UserInterface.GetStringInput("please enter your first name");
            lastName = UserInterface.GetStringInput("please enter your last name");
            email = UserInterface.GetStringInput("please enter your email");
        }
    }
}
