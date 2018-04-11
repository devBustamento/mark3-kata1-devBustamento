using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {

            var user = new User();

            Console.WriteLine("Welcome to my Onbaording app, we need some info to get started...");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);

            user.FirstName = AskQuestion("\nWhat is your First name? ");
            Console.WriteLine($"\nHello, {user.FirstName},");

            user.LastName = AskQuestion("\nwell...what is your last name?");
            Console.WriteLine($"\nOkay {user.FirstName} {user.LastName}, lets keep it rollin'");


            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true); //commit
        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static int NumQuestion(string question)
        {
            Console.WriteLine(question);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
