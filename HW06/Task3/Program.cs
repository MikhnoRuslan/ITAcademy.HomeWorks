using System;
using System.Text;

namespace Task3
{
    class Program
    {
        private const string Str = "1a!2.3!!.. 4.!.?6 7! ..?";

        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");
            Console.WriteLine(str);

            str.Replace('!', ' ', 0, CountSign(str));
            str.Replace('.', ' ', 0, CountSign(str));
            str.Replace(' ', '_', CountSign(str), str.Length - CountSign(str));
            str.Replace(" ", "");
            Console.WriteLine(str);
        }

        static int CountSign(StringBuilder str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
                if (str[i] == '?')
                    break;
            }

            return count;
        }
    }
}
