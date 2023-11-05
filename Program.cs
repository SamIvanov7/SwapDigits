using System;

namespace SwapDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a six-digit number: ");
            string input = Console.ReadLine();

            if (input.Length == 6 && long.TryParse(input, out long number))
            {
                // Побудова нового числа після замін
                string swapped = input[5].ToString() + input[2].ToString() + input[3].ToString() +
                                 input[4].ToString() + input[1].ToString() + input[0].ToString();

                Console.WriteLine("The number after swapping digits: " + swapped);
            }
            else
            {
                Console.WriteLine("Error: You must enter a six-digit number.");
            }
        }
    }
}
