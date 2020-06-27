using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Task1
{
    class Teacher : Person
    {
        public string Subject { get; }

        public void Explain()
        {
            Console.WriteLine($"Explanation begins.");
        }

        public new void PrintData()
        {
            Console.WriteLine(Greeting);
            Console.WriteLine($"My age is: {SetAge(Age)} years old.");
            Explain();
        }

        public Teacher() {}

        public Teacher(int age, string person)
        {
            Age = age;
            Greeting = PersonGreeting(person);
        }
    }
}
