using System;
using System.Threading;
using System.Threading.Channels;

namespace HW03.Task1
{
    class Calculator
    {
        private const double P = 3.14;
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine($"Addition:");
            Console.WriteLine($"Result = {calculator.Sum(num1: GetFirstValueFromUser(), num2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Subtraction:");
            Console.WriteLine($"Result = {calculator.Subtraction(num1: GetFirstValueFromUser(), num2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Multiplication:");
            Console.WriteLine($"Result = {calculator.Multiplication(num1: GetFirstValueFromUser(), num2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Division:");
            Console.WriteLine($"Result = {calculator.Division(num1: GetFirstValueFromUser(), nume2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Remainder of the division:");
            Console.WriteLine($"Result = {calculator.Remainder(num1: GetFirstValueFromUser(), num2: GetSecondValueFromUser())}");
            Console.WriteLine();
            Console.WriteLine($"Area of a circle:");
            Console.WriteLine($"Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result = {calculator.AreaOfACircle(radius)}");
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

        double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        double Division(double num1, double nume2)
        {
            return num1 / nume2;
        }

        double Remainder(double num1, double num2)
        {
            return num1 % num2;
        }

        double AreaOfACircle(double num1)
        {
            return P*Math.Pow(num1, 2);
        }
    }
}
