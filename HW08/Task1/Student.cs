using System;

namespace Task1
{
    class Student : Person
    {
        private const string _GoToClass = "I am going to class.";

        public string GoToClass { get; } = _GoToClass;

        public void GoToClasses()
        {
            Console.WriteLine(GoToClass);
        }

        public void ShowAge(int age)
        {
            Console.WriteLine($"My age is: {SetAge(age)} years old\n");
        }

        public new void PrintData()
        {
            Console.WriteLine(Greeting);
            ShowAge(Age);
        }

        public Student() {}

        public Student(int age, string person)
        {
            Age = age;
            Greeting = PersonGreeting(person);
        }
    }
}
