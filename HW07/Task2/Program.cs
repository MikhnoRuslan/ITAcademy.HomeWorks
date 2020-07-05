using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Enter a string: ");
            string str = Console.ReadLine()?.ToLower().Replace(" ","");

            Console.WriteLine(str);

            Console.Write($"Your result: ");

            string outPutString = ResultString(str);
            Console.WriteLine(outPutString ?? $"\"\"");
        }

        static string ResultString(string arr)
        {
            char[] inputArray = arr.ToCharArray();
            Array.Sort(inputArray);

            for (int k = 0; k < arr.Length; )
            {
                if (arr == string.Empty || char.IsNumber(inputArray[k]))
                {
                    return null;
                }
                else
                {
                    string resultString = string.Empty;
                    int count = 1;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[j] == arr[i])
                            {
                                count++;
                            }
                        }

                        if (!resultString.Contains(arr[i]))
                        {
                            resultString += count.ToString() + arr[i].ToString();
                        }

                        count = 1;
                    }

                    return resultString;
                } 
            }

            return null;
        }
    }
}
