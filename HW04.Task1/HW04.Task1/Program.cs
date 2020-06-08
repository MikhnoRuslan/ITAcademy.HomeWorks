using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }

        static void Sum()
        {
            Console.Write($"Enter the first number: ");
            double num1 = CheckInput();
            Console.Write($"Enter the second number: ");
            double num2 = CheckInput();
            Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
        }

        static double CheckInput()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
                Console.WriteLine($"Error. Try again:");
            return num;
        }
    }
}
