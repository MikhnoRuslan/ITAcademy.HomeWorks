using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Song
    {
        public string Title { get; set; }
        public double Minutes { get; set; }
        public string Author { get; set; }
        public int AlbumYear { get; set; }

        public Song(string title, double minutes, string author, int albumYear)
        {
            Title = title;
            Minutes = minutes;
            Author = author;
            AlbumYear = albumYear;
        }

        public dynamic[] GetSongData(Song song)
        {
            dynamic[] dObjects = {song.Title, song.Minutes, song.AlbumYear};

            return dObjects;
        }
    }
}
