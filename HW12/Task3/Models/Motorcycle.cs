namespace Task3.Models
{
    public class Motorcycle
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }

        public Motorcycle(string id, string name, string model, int year, int odometer)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}
