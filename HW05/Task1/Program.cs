using System;

namespace Task1
{
    class TaskOne
    {
        private const int SIZE = 5;
        private const int _SIZE = 28;
        static void Main(string[] args)
        {
            int[] randomArray = new int[SIZE];
            int[] secondArray = new int[SIZE];
            int[] resultArray = new int[SIZE];
            
            Console.WriteLine($"Enter value for array:");
            UserArray(secondArray);
            Console.Clear();

            Console.Write($"Random array: ");
            MyArray(randomArray);
            Print(randomArray);
            Console.WriteLine("\t+");

            Console.Write($"  User array: ");
            Print(secondArray);
            _Print(_SIZE);

            Console.Write($"Result array: ");
            ResultArray(randomArray, secondArray, resultArray);
            Print(resultArray);
        }

        static int MyArray(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }

            return arr.Length;
        }

        static int UserArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            return arr.Length;
        }

        static int ResultArray(int[] fistArr, int[] secondArr, int[] resultArr)
        {
            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = fistArr[i] + secondArr[i];
            }

            return resultArr.Length;
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] / 10 < 1)
                {
                    Console.Write(arr[i] + "  ");
                }
                else
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static void _Print(int size)
        {
            char line = '-';
            for (int i = 0; i < size; i++)
            {
                Console.Write(line);
            }

            Console.WriteLine();
        }
    }
}
