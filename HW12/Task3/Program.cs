using System;
using Task3.Interfaces;
using Task3.Models;
using Task3.Repositories;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Logger.InitLogger();
            Console.WriteLine($"What do you want to take action?");
            ConsoleKeyInfo again;
            do
            {
                Console.WriteLine($"1 - create;\n2 - delete;\n3 - show all;\n4 - show by id;\n5 - exit.");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                    {
                        CreateMotorcycle();
                        break;
                    }
                    case 2:
                    {
                            DeleteMotorcycle();
                            break;
                    }
                    case 3:
                    {
                        ShowAllMotorcycle();
                        break;
                    }
                    case 4:
                    {
                        ShowMotorcycleById();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine($"Goodbye!");
                        break;
                    }
                }

                Console.WriteLine($"Do you want to perform any other action (Y/N)?");
                again = Console.ReadKey();
                Console.WriteLine();
            } while (again.Key != ConsoleKey.N);
        }

        static string AddStringData(string data)
        {
            Console.WriteLine($"Enter motorcycle {data.ToLower()}:");
            return Console.ReadLine();
        }

        static int AddIntData(string data)
        {
            Console.WriteLine($"Enter motorcycle {data.ToLower()}:");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void CreateMotorcycle()
        {
            ConsoleKeyInfo key;
            do
            {
                var motorcycle = new Motorcycle(AddStringData(Constants.ColumnId), AddStringData(Constants.ColumnName),
                    AddStringData(Constants.ColumnModel), AddIntData(Constants.ColumnYears), AddIntData(Constants.ColumnOdometer));
                IMotorcycleRepositories<Motorcycle> motorcycleRepositories = new MotorcycleRepositories();
                motorcycleRepositories.Create(motorcycle);
                Console.WriteLine($"Do you want to add more (Y/N)?");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key != ConsoleKey.N);
        }

        static void DeleteMotorcycle()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine($"Enter motorcycle id:");
                var id = Console.ReadLine();
                IMotorcycleRepositories<Motorcycle> motorcycleRepositories = new MotorcycleRepositories();
                motorcycleRepositories.Delete(id);
                Console.WriteLine($"Do you want to delete more (Y/N)?");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key != ConsoleKey.N);

        }

        static void ShowAllMotorcycle()
        {
            IMotorcycleRepositories<Motorcycle> motorcycleRepositories = new MotorcycleRepositories();
            motorcycleRepositories.GetMotorcycles();
        }

        static void ShowMotorcycleById()
        {
            Console.WriteLine($"Enter motorcycle id:");
            var id = Console.ReadLine();
            IMotorcycleRepositories<Motorcycle> motorcycleRepositories = new MotorcycleRepositories();
            motorcycleRepositories.GetMotorcycle(id);
        }
    }
}