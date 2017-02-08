using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program3
    {
        public static void Main()
        {
            bool guessCorrectly = false;
            string answer = "5";

            while (!guessCorrectly)
            {
                Console.Write("Please enter your guess: ");
                string guess = Console.ReadLine();

                if (guess == answer)
                {
                    guessCorrectly = true;
                    Console.WriteLine("Congrats. You guess correctly.");
                } else
                {
                    guessCorrectly = false;
                    Console.WriteLine("Please try again.");
                }
            }
        }
    }
}
