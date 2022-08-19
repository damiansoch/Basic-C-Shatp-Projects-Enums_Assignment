using System;
using System.Collections.Generic;

namespace Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter current day of the week (Capital first letter, please)");

                string input = Console.ReadLine();

                var result = Enum.Parse<DayOfWeek>(input);

                Console.WriteLine(result);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Please enter an actual day of the week!: " + e.Message);
            }
            Console.Read();
        }
    }
}

