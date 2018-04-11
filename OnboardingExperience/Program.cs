using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Onbaording app, we need some info to get started...");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true); //commit
        }
    }
}
