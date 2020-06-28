using System;

namespace Task3
{
    class Music : Film
    {
        public string Executor { get; set; }
        public int Duration { get; set; }

        public void ShowData()
        {
            Console.WriteLine($"File name: {Name}");
            Console.WriteLine($"File code: {Code}");
            Console.WriteLine($"File category: {Category}");
            Console.WriteLine($"File size: {Size} bytes.");
            Console.WriteLine($"Executor: {Executor}");
            Console.WriteLine($"Duration: {Duration} sec.");
        }
    }
}
