using System;


namespace Task2
{
    class House
    {
        private int _area;

        public int Area
        {
            get => _area;
            set
            {
                if (value <= 0)
                    Console.WriteLine($"Error. The area cannot be 0 and less than 0");
                else
                    _area = value;
            }
        }

        public Door HouseDoor { get; set; }

        public House() {}

        public House(int area, string color)
        {
            Area = area;
            HouseDoor = new Door(color);
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {Area} m2.");
        }
    }

    class Door
    {
        public string Color { get; set; }

        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {Color}");
        }

        public Door() {}

        public Door(string color)
        {
            Color = color;
        }
    }
}
