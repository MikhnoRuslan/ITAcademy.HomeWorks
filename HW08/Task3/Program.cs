using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            var film = new Film { Name = "The Upside.", Code = 12345, Category = "Film", Size = 54_321, Producer = "Neil Norman Burger", MainActor = "Bob", MainActress = "Ann"};
            film.ShowData();
            film.Play();
            film.RetrieveInformation();
            Console.WriteLine();

            var track = new Music {Name = "Rain", Code = 12346, Category = "Music", Size = 741_258, Executor = "Massive Attack", Duration = 186};
            track.ShowData();
            track.Play();
            track.RetrieveInformation();
        }
    }
}
