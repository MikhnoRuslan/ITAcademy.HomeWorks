using System;

namespace HW04.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastLatter = 'Z';
            char firstLatter = 'A';
            for (int i = Convert.ToInt32(lastLatter); i > Convert.ToInt32(firstLatter) - 1; i--)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
        }
    }
}
