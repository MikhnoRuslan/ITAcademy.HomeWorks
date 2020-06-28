namespace Task2
{
    class Program
    {
        static void Main()
        {
            var person = new Person("Bob");
            House house = new SmallApartment();
            person.HouseOfPerson = house;
            person.HouseOfPerson.HouseDoor = new Door {Color = "red"};
            person.ShowData();
        }
    }
}
