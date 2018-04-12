using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Well well...\nWelcome to my Onbaording app, we need some info to get started...");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);


            user.IsOwner = IsOwnerQuestion("have you previously set up a profile here?"); //decides to run the app or not

            user.FirstName = AskQuestion("\nWhat is your First name? ");
            Console.WriteLine($"\nHello, {user.FirstName},");

            user.LastName = AskQuestion("\nwell...what is your last name?");
            Console.WriteLine($"\nOkay {user.FirstName} {user.LastName}, lets keep it rollin'");

            user.AccNo = IntQuestion("\nLets make a pin for your account, please input exactly four numbers!", 4);
            Console.WriteLine($"\nSuccess! your pin: {user.AccNo} has been added to your account, keep it safe!");

            user.Age = IntQuestion("\nHow ancient are you?");
            Console.WriteLine($"\n Oh dear, {user.Age}?! Are you going to make it...?");

            user.AccOwn = YNbool("\nDo you already have a banking account with this us?");
            bigKaBang(user);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }

        private static void bigKaBang(User user)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName}, at a hearty {user.Age}. \n bank account pre-existing: {user.AccOwn}, and your pin is set to {user.AccNo}");
        }

        private static bool IsOwnerQuestion(string question)
        {
            while (true)
            {
                var result = AskQuestion(question + " (y/n)");

                if (result.ToLower() == "y")
                {
                    Console.WriteLine("We're very sorry but you cannot access accounts that are not your own.");
                    Console.WriteLine("Thanks very much for your time and cooperation. Program will exit. Good bye");
                    Console.ReadLine();
                    Environment.Exit(-1);
                }
                else if (result.ToLower() == "n") { return false; }

                Console.WriteLine("\nYou must enter y or n");
            }
        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int IntQuestion(string question, int length = 0) //has bug accepts 0, doesnt render 0
        {

            while (true)
            {
                var result = AskQuestion(question);//"the top"

                if (!int.TryParse(result, out var num))
                {
                    Console.WriteLine("\n **ERROR** \n Why be so difficult?");
                    continue; //Continue means time to take it back to "the top"
                }

                if (length > 0 && result.Length != length)
                {
                    Console.WriteLine($"You needed to type exactly a {length} digit number");
                    continue;
                }

                return num;
            }
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
