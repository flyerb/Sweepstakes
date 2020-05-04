using System;
using System.Collections.Generic;
using System.Text;

 namespace Sweepstakes
{
    static class UserInterface
    {
       
        public static string GetStringInput(string message)
        {
           Console.WriteLine(message);
           string userInput  = Console.ReadLine();
            return userInput;
        }
    }
}
