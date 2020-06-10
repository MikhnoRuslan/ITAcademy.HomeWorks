using System;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter the first number: ");
            double num1 = CheckInput();
            Console.Write($"Enter the second number: ");
            double num2 = CheckInput();
            double result = Sum(num1, num2);
            double resultUser;
            Console.WriteLine($"Enter your result: ");
            do
            {
                resultUser = CheckInput();
                if (CheckUserResult(result, resultUser) != true)
                    Console.WriteLine($"Wrong! Try again: ");
                else
                    Console.WriteLine($"Your answer is correct!");
            } while (CheckUserResult(result, resultUser) != true);
            
        }

        static double CheckInput()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
                Console.Write($"Error! Try again:");

            return num;
        }
        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static bool CheckUserResult(double result, double resultUser)
        {
            if (result == resultUser)
                return true;
            else
                return false;
        }
    }
}
