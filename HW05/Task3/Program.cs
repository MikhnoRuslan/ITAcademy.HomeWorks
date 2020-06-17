using System;
using System.Diagnostics;

namespace Task3
{
    class Program
    {
        private const long SIZE = 1000000000;
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] array = new int[SIZE];
            InitArray(array);

            stopwatch.Start();
            MyRevers(array);
            stopwatch.Stop();
            Console.WriteLine($"My result: {stopwatch.ElapsedMilliseconds}");

            stopwatch.Start();
            Array.Reverse(array);
            stopwatch.Stop();
            Console.WriteLine($"Result Microsoft: {stopwatch.ElapsedMilliseconds}");
        }

        static int InitArray(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10);
            }

            return arr.Length;
        }

        static int MyRevers(int[] arr)
        {
            
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            return arr.Length;
        }
    }
}
