using System;

namespace Task2
{
    class Person
    {
        public string Name { get; set; }
        public House HouseOfPerson { get; set; }

        public Person() {}

        public Person(string name)
        {
            Name = name;
        }

        public Person(string namePerson, int areaHouse, string colorDoor)
        {
            Name = namePerson;
            HouseOfPerson = new House(areaHouse, colorDoor);
        }

        public void ShowData()
        {
            Console.WriteLine($"Name of person: {Name}");
            Console.WriteLine($"House area: {HouseOfPerson.Area} m2");
            Console.WriteLine($"Door color: {HouseOfPerson.HouseDoor.Color}");
        }
    }
}
