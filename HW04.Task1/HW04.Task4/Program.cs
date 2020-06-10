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
            Console.Write($"Enter action ('+' or '-'): ");
            double result = ActionSelection(num1, num2);
            double resultUser;
            Console.WriteLine($"Enter your result: ");
            do
            {
                resultUser = CheckInput();
                if (CheckUserResult(result, resultUser) != true)
                {
                    if (CheckMoreOrLess(result, resultUser) != true)
                        Console.WriteLine($"Your result is more then necessary.");
                    else
                        Console.WriteLine($"Your result is less then necessary.");
                    Console.WriteLine($"Wrong! Try again.");
                }
                else
                    Console.WriteLine($"Your answer is correct!");
            } while (CheckUserResult(result, resultUser) != true);

        }

        // проверка на ввод числа
        static double CheckInput()  
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
                Console.Write($"Error! Try again:");

            return num;
        }

        // сложение
        static double Sum(double num1, double num2)  
        {
            return num1 + num2;
        }

        // вычитание
        static double Subtraction(double num1, double num2) 
        {
            return num1 - num2;
        }

        // проверка результата человека и машины
        static bool CheckUserResult(double result, double resultUser) 
        {
            if (result == resultUser)
                return true;
            else
                return false;
        }

        // проверка на больше или меньше результата
        static bool CheckMoreOrLess(double result, double resultUser) 
        {
            if (resultUser < result)
                return true;
            else
                return false;
        }

        //выбор действия
        static double ActionSelection(double num1, double num2)
        {
            char key;
            do
            {
                key = Convert.ToChar(Console.ReadLine());
                if (key != '+' && key != '-')
                {
                    Console.Write($"Error. Try again: ");
                }
            } while (key != '+' && key != '-');

            return key switch
            {
                '+' => Sum(num1, num2),
                '-' => Subtraction(num1, num2),
                _ => throw new Exception("Error. Try again.")
            };
        }
    }
}