using System;
using System.Threading;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi would you like to play a game? (yes/no): ");
            string response = Console.ReadLine();

            if (response != null && response.Equals("yes", StringComparison.OrdinalIgnoreCase) || response.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                if (response.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    PlayGame();
                }
                else
                {
                    Console.WriteLine("No problem! Maybe next time.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Response. Please enter 'yes' or 'no'.");
            }
        }
        public static void PlayGame()
        {
            Console.WriteLine("Great! Let's play a game.");
            Thread.Sleep(2000); // Pause for 2 seconds
            Console.Clear();

            Console.WriteLine("What is 2+2?");
            string answer = Console.ReadLine();

            if (answer != null && answer.Equals("4"))
            {
                Console.WriteLine("Correct! You win!");
            }
            else
            {
                Console.WriteLine("Wrong anser! The correct answer is 4. Better luck next time!");
            }
        }
    }
}
