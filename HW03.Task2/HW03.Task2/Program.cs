using System;
using static System.Math;

namespace HW03.Task2
{
    class Calculator
    {
        private const double P = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine($"Addition:");
            Console.WriteLine($"Result = {Sum(num1: GetFirstValueFromUser(), num2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Subtraction:");
            Console.WriteLine($"Result = {Subtraction(num1: GetFirstValueFromUser(), num2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Multiplication:");
            Console.WriteLine($"Result = {Multiplication(num1: GetFirstValueFromUser(), num2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Division:");
            Console.WriteLine($"Result = {Division(num1: GetFirstValueFromUser(), num2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Remainder of the division:");
            Console.WriteLine($"Result = {Remainder(num1: GetFirstValueFromUser(), num2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Area of a circle:");
            Console.Write($"Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result = {AreaOfACircle(radius)}");
        }

        static double GetFirstValueFromUser()
        {
            Console.Write($"Enter the first value: ");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }

        static double GetSecondValueFromUser()
        {
            Console.Write($"Enter the second value: ");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }

        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        static double Remainder(double num1, double num2)
        {
            return num1 % num2;
        }

        static double AreaOfACircle(double num1)
        {
            return P * Pow(num1, 2);
        }
    }
}
