using System;

namespace Task1
{
    class Person
    {
        private const byte _Morning = 9;
        private const byte _Day = 12;
        private const byte _Evening = 15;
        private const byte _Night = 22;

        public int Age { get; set; }
        public string Greeting { get; set; }

        public int SetAge(int age)
        {
            return Age = age;
        }

        public string PersonGreeting()
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            return time.Hours switch
            {
                { } hour when (hour >= _Morning && hour < _Day) => "Good morning!",
                { } hour when (hour >= _Day && hour < _Evening) => "Good day!",
                { } hours when (hours >= _Evening && hours < _Night) => "Good evening!",
                _ => "Good night!"
            };
        }

        public string PersonGreeting(string person)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            return time.Hours switch
            {
                { } hour when (hour >= _Morning && hour < _Day) => $"Good morning, {person}!",
                { } hour when (hour >= _Day && hour < _Evening) => $"Good day, {person}!",
                { } hours when (hours >= _Evening && hours < _Night) => $"Good evening, {person}!",
                _ => $"Good night, {person} :("
            };
        }

        public void PrintData()
        {
            Console.WriteLine($"{PersonGreeting()}\n");
        }

        public Person()
        {
            Greeting = PersonGreeting();
        }

        public Person(int age, string person)
        {
            Age = SetAge(age);
            Greeting = PersonGreeting(person);
        }
    }
}
