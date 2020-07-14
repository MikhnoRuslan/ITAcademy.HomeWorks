using System;
using Task1.Models;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            TimeOfDay time = new TimeOfDay();
            Console.WriteLine($"{time.GetTime()} {Constants.Greeting}");

            Console.WriteLine(Constants.WhatIsYourName);
            Person person = new Person(new NamePerson());
            person.GetName();
            Console.WriteLine($"{person.Name}, {Constants.GoToRegistration}.");
        }
    }
}
