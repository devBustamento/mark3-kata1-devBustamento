using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {

            var U = new User();

            Console.WriteLine("Welcome to my Onbaording app, we need some info to get started...");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("\nWhat is your First name? ");
            U.FirstName = Console.ReadLine();
            Console.WriteLine($"\nHello, {U.LastName}, what is your last name?");

            Console.Write("\nPress any key to exit...");
            //Console.ReadKey(true); //commit
        }


    }
}
