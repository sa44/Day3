using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program2
    {
        public static void Main()
        {
            bool needToRepeat = true;
            double number = 0;

            while (needToRepeat)
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine();

                bool isParsed = Double.TryParse(input, out number);

                if (!isParsed)
                {
                    Console.WriteLine("You didn't enter a number.");
                    needToRepeat = true;
                }
                else
                {
                    needToRepeat = false;
                }
            }
            Console.WriteLine("The number you've entered is {0}", number);

        }

    }
}
