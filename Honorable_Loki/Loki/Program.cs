using System;
using System.Security.Cryptography;

namespace Loki
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int flips = 3;
            int guessedRight = 0;
            
            Console.WriteLine("I am the Honorable Loki, God of Mischief and Madness, may I inquire of this mortal's name?");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Would you indulge me in a simple and fair game?" +
            " the rules are easy, if you can guess the outcome of a coin flip ten times..." +
                " Ill give you a special reward; what say you mor-- I mean... " + name + "? YES or NO?");
            string answer = Convert.ToString(Console.ReadLine());

            if (answer.Contains("N"))
            {
                Console.WriteLine("Aw boo, cowardly mortal >:(");
                return;
            }
            else if (answer.Contains("Y"))
            {
                Console.WriteLine("Lets get started! shall we? >:)");
                for (int i = 0; i < flips; i++)
                {
                    guessedRight += flipCoinAndGuess();
                }
                Console.WriteLine("You got " + guessedRight + " guesses correct...");

                if (guessedRight >= Math.Floor(flips * 0.6))
                {
                    Console.WriteLine("You have earned you reward" + name + ". Here it is, ask for any wish and it will be granted in one thousand years time.");
                    string wish = Convert.ToString(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Try Harder " + name);
                }
            }
            
        }

        public static int flipCoinAndGuess()
        {
            var rng = new Random().Next(0, 2);
            bool coinFlipped = rng == 1;
            
            Console.WriteLine("What is the coin? type either Heads or Tails.");    
            bool choice = Convert.ToString(Console.ReadLine()).Contains("H");

            if (choice == coinFlipped)
            {
                Console.WriteLine("you got it right >:/");
                return 1;
            }
            
            Console.WriteLine("you got it W-W-W-WRONG >:D");
            return 0;
        }
    }
}