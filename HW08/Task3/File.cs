using System;

namespace Task3
{
    class File
    {
        private string _name;
        private string _category;
        private long _size;

        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    Console.WriteLine($"Error. Enter name: ");
            }
        }

        public int Code { get; set; }

        public string Category
        {
            get => _category;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _category = value;
                else
                    Console.WriteLine($"Error. Enter category:");
            }
        }

        public long Size
        {
            get => _size;
            set
            {
                if (value > 0)
                    _size = value;
                else
                    Console.WriteLine($"Error. Try again:");
            }
        }

        public File()
        {
            _name = Name;
            _category = Category;
            _size = Size;
        }

        public void Print()
        {
            Console.WriteLine($"File name: {Name}");
            Console.WriteLine($"File code: {Code}");
            Console.WriteLine($"File category: {Category}");
            Console.WriteLine($"File size: {Size} bytes.");
        }
    }
}
