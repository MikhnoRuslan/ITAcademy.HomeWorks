using System;
using System.IO;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            StreamReader textReader = new StreamReader(@"F:\Уроки C#\MikhnoRuslan\ITAcademy.HomeWorks\HW06\Task2\Text\Text.txt");
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');

            NumberOfLetters(textReaderResult);

            Console.WriteLine($"Array of strings after deleted the longest word:");
            DeleteMaxWord(ref arrayOfTextResult);
            Print(arrayOfTextResult);

            Console.WriteLine($"String after swapping the longest and shortest words:");
            Print(Swap(textReaderResult));

            Console.WriteLine($"Sorted array:");
            Print(Sort(textReaderResult));
        }

        static int MaxWord(string[] arr)
        {
            int temp = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > temp)
                    temp = arr[i].Length;
            }

            return temp;
        }

        //i know that i could used method "sort" and then i could deleted first item array.
        //But i wanted to training to use array without method "sort"
        static void DeleteMaxWord(ref string[] arr)
        {
            int maxWordLength = MaxWord(arr);

            string[] newArray = new string[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];

                if (arr[i].Length == maxWordLength)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        newArray[j - 1] = arr[j];
                    }

                    break;
                }
            }

            arr = newArray;
        }

        static void NumberOfLetters(string arr)
        {
            int letter = 0;
            int sign = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsLetter(arr[i]))
                    letter++;
                else if (char.IsPunctuation(arr[i]))
                    sign++;
            }

            Console.WriteLine($"Letters in string {letter}, signs in string {sign}\n");
        }

        static string[] Swap(string str)
        {
            string[] strArray = Sort(str);
            string temp = strArray[0];
            strArray[0] = strArray[^1];
            strArray[^1] = temp;
            return strArray;
        }

        static string[] Sort(string str)
        {
            string[] rezultStr = str.Split(' ').OrderByDescending(i => i.Length).ToArray();
            return rezultStr;
        }

        static void Print(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine($"\n");
        }
    }
}
