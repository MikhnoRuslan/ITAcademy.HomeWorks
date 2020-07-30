using System;
using Task1.Interfaces;

namespace Task1.Models
{
    class NamePerson : IName
    {
        public string Name { get; set; } 
        public string Surname { get; set; } 
        public string LastName { get; set; } 


        public string[] GetFullname()
        {
            Console.WriteLine($"Enter name:");
            Name = Console.ReadLine();
            Console.WriteLine($"Enter surname:");
            Surname = Console.ReadLine();
            Console.WriteLine($"Enter last name:");
            LastName = Console.ReadLine();

            return new[] {Name , Surname, LastName};
        }
    }
}
