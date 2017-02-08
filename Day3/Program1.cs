using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program1
    {
        public static void Main()
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            double number;
            bool isParsed = Double.TryParse(input, out number);
            //isParsed is going to contains the value whether the string 
            //can be successfully converted into double
            //number is going to contain the converted double value.

            if (!isParsed)
            {
                Console.WriteLine("You didn't enter a number.");
            } else
            {
                Console.WriteLine("Congratulations, you can follow instruction.");
            }
        }

    }
}
