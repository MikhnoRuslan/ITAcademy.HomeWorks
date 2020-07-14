using Task1.Interfaces;

namespace Task1.Models
{
    class Person
    {
        public string Name { get; set; }
        public IName FullName { get; set; }

        public Person(IName name)
        {
            FullName = name;
        }

        public string SetName()
        {
            string[] data = FullName.GetFullname();
            return $"{data[0]} {data[1]}";
        }

        public void GetName()
        {
            Name = SetName();
        }
    }
}
