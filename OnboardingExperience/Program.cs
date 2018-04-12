using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Well...Welcome to my Onbaording app, we need some info to get started...");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);


            user.IsOwner = IsOwnerQuestion("have you previously set up an account here?");

            user.FirstName = AskQuestion("\nWhat is your First name? ");
            Console.WriteLine($"\nHello, {user.FirstName},");

            user.LastName = AskQuestion("\nwell...what is your last name?");
            Console.WriteLine($"\nOkay {user.FirstName} {user.LastName}, lets keep it rollin'");

            user.AccNo = IntQuestion("\nLets make a pin for your account, numbers only please!");
            Console.WriteLine($"\nSuccess! your pin: {user.AccNo} has been added to your account, keep it safe!");

            user.AccOwn = YNbool("\ndo you already have a banking account with this us?");
            Console.WriteLine($"{user.FirstName} {user.LastName}, bank account pre-existing: {user.AccOwn}, and your pin is set to {user.AccNo}");

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }

        private static bool IsOwnerQuestion(string question)
        {
            while (true)
            {
                var response = AskQuestion(question + " Yes or No");

                if (response.ToLower() == "yes")
                {
                    Console.WriteLine("Please contact customer service if you have any more issues, account holder");
                    Console.WriteLine("Thanks very much for your time and cooperation. Program will exit. Good bye");
                    Console.ReadLine();
                    Environment.Exit(-1);
                }

                return false;
            }
        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int IntQuestion(string question, int length = 0)
        {
            Console.WriteLine(question);
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("**ERROR** \n I ASKED FOR A NUMBER. Why be so difficult?");
            }
            return num;
        }

        public static bool YNbool(string question)
        {
            do
            {
                var result = AskQuestion(question + " (y/n)");

                if (result.ToLower() == "y") { return true; }
                else if (result.ToLower() == "n") { return false; }

                Console.WriteLine("\nYou must enter y or n");
            } while (true);
        }
    }
}
