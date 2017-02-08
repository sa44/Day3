using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program4
    {
        public static void Main()
        {
            bool guessCorrectly = false;

            //generate random number
            Random r = new Random(); //we are creating a Random object and assign it to r
            int randomNumber = r.Next(1, 10); // some random from 1..9
            //if we need random double, we can use r.NextDouble()

            string answer = randomNumber.ToString(); //"" + randomNumber

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
