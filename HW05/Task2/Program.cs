using System;
using System.Globalization;
using System.Linq;

namespace Task2
{
    class Task_2
    {
        private const int SIZE = 5;
        static void Main(string[] args)
        {
            int[] myArray = new int[SIZE];

            UserArray(myArray);
            Console.WriteLine($"Array:");
            PrintArray(myArray);

            Console.Write($"\nEnter the position in the array: ");
            int position = InputCheck();

            Console.Write($"Enter value: ");
            int value = InputCheck();

            Console.WriteLine($"Result array:");
            ResultArray(ref myArray, position, value);
            PrintArray(myArray);
        }

        static int UserArray(int[] arr)
        {
            Console.WriteLine($"Enter value for array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = InputCheck();
            }

            Console.Clear();

            return arr.Length;
        }

        static int InputCheck()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write($"Error, try again: ");
            }

            return value;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int ResultArray(ref int[] arr, int position, int value)
        {
            int[] newArray = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
                if (i == position - 1)
                {
                    newArray[i] = value;
                    for (int j = position - 1; j < arr.Length; j++)
                    {
                        newArray[j + 1] = arr[j];
                    }

                    break;
                }
            }

            arr = newArray;

            return arr.Length;
        }
    }
}