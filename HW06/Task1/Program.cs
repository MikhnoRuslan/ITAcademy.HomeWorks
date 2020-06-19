using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Enter the name of the poem: ");
            string namePoem = TheNameOrAuthorOfThePoem();

            Console.Write($"Enter the author of a poem: ");
            string author = TheNameOrAuthorOfThePoem();

            string poem = UserPoem();
            Console.Clear();
            string[] poemArray = poem.Split(";");
            Replace(poemArray);

            PrintPoem(poemArray, namePoem, author);
        }

        static string TheNameOrAuthorOfThePoem()
        {
            string str = Console.ReadLine();
            if (str == string.Empty)
                return null;
            else
                return str;
        }

        static string UserPoem()
        {
            Console.WriteLine($"Enter your verse. Instead of a space, please, use \";\":");
            string str = Console.ReadLine();
            return str;
        }

        static void Replace(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Replace("O", "A");
                arr[i] = arr[i].Replace("o", "a");
            }
        }

        static void PrintPoem(string[] arr, string namePoem, string author)
        {
            Console.WriteLine($"\t{namePoem}");
            foreach (var i in arr)
                Console.WriteLine(i);

            Console.WriteLine($"\t\t{author}");
        }
    }
}
