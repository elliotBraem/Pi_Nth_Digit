using System;

namespace Pi_Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            string input;
            int value = -1;
        prompt:
            do
            {
                Console.WriteLine("This program prints Pi up to the specified decimal.");
                Console.WriteLine("Enter in a specified decimal between 0 and 15");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out value));

            if (value < 0 || value > 15) {
                Console.WriteLine("You entered {0}", value);
                Console.WriteLine("Please specify a decimal between 0 and 15.");
                Console.WriteLine();
                goto prompt;
            }

            String result = Math.Round(pi, value).ToString();
            Console.WriteLine(result);
        }
    }
}
