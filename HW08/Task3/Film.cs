using System;


namespace Task3
{
    class Film : File
    {
        private string _producer;
        private string _mainActor;
        private string _mainActress;

        public string Producer
        {
            get => _producer;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _producer = value;
                else
                    Console.WriteLine($"Error. Try again:");
            }
        }

        public string MainActor
        {
            get => _mainActor;
            set
            {
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        _mainActor = value;
                    else
                        Console.WriteLine($"Error. Try again:");
                }
            }
        }

        public string MainActress
        {
            get => _mainActress;
            set
            {
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        _mainActress = value;
                    else
                        Console.WriteLine($"Error. Try again:");
                }
            }
        }

        public void Play()
        {
            Console.WriteLine($"Not implemented yet.");
        }

        public void RetrieveInformation()
        {
            Console.WriteLine($"In a later version.");
        }

        public void ShowData()
        {
            Console.WriteLine($"File name: {Name}");
            Console.WriteLine($"File code: {Code}");
            Console.WriteLine($"File category: {Category}");
            Console.WriteLine($"File size: {Size} bytes.");
            Console.WriteLine($"Producer: {Producer}");
            Console.WriteLine($"Main actor: {MainActor}");
            Console.WriteLine($"Main actress: {MainActress}");
        }
    }
}
