using System;
using System.Text.Json;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var song = new Song(AddTitle(), AddMinutes(), AddAuthor(), AddAlbumYears());
            var dObjects = song.GetSongData(song);

            Console.WriteLine("Title: {0}\nMinutes: {1}\nAlbumYear: {2}", dObjects[0], dObjects[1], dObjects[2]);
            Console.WriteLine();

            var song1 = new Song(AddTitle(), AddMinutes(), AddAuthor(), AddAlbumYears());
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize<Song>(song1, options);
            Console.WriteLine(json);
        }

        private static string AddTitle()
        {
            Console.WriteLine($"Enter title:");
            return Console.ReadLine();
        }

        private static double AddMinutes()
        {
            Console.WriteLine($"Enter the length of the song:");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static string AddAuthor()
        {
            Console.WriteLine($"Enter author:");
            return Console.ReadLine();
        }

        private static int AddAlbumYears()
        {
            Console.WriteLine($"Enter year of manufacture:");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
