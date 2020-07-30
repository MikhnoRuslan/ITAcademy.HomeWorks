using System;

namespace Task1.Models
{
    class TimeOfDay
    {
        private const byte _Morning = 9;
        private const byte _Day = 12;
        private const byte _Evening = 15;
        private const byte _Night = 22;

        internal string GetTime()
        {
            var time = DateTime.Now.TimeOfDay;
            return time.Hours switch
            {
                { } hours when (hours >= _Morning && hours < _Day) => $"{Constants.GoodMorning}!",
                { } hours when (hours >= _Day && hours < _Evening) => $"{Constants.GoodDay}!",
                { } hours when (hours >= _Evening && hours < _Night) => $"{Constants.GoodEvening}!",
                _ => $"{Constants.GoodNight}!"
            };
        }
    }
}
