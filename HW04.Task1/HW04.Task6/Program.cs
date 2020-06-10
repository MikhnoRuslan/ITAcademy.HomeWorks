using System;
using System.Threading.Channels;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            char yesNo;
            do
            {
                Console.WriteLine($"Enter action:");
                Console.WriteLine($"'W' - step forward;");
                Console.WriteLine($"'S' - step back;");
                Console.WriteLine($"'D' - step right;");
                Console.WriteLine($"'A' - step left.");
                char act = InputAction();
                Acttion(act);
                Console.WriteLine($"Do you want to play again? (Y/N): ");
                yesNo = InputCheckYesNo();
            } while (yesNo != 'N' && yesNo != 'n');
        }

        static char InputAction()
        {
            char act;
            do
            {
                act = Convert.ToChar(Console.ReadLine());
                if(act != 'W' && act != 'w' && act != 'S' && act != 's' && act != 'D' && act != 'd' && act != 'A' && act != 'a')
                    Console.WriteLine($"Input error. Try again: ");
            } while (act != 'W' && act != 'w' && act != 'S' && act != 's' && act != 'D' && act != 'd' && act != 'A' && act != 'a');

            return act;
        }

        static void Acttion(char key)
        {
            bool yesNo;
            switch (key)
            {
                case 'W':
                case 'w':
                    yesNo = YesNo();
                    if (yesNo == true)
                        Console.WriteLine($"The Hero stepped forward.");
                    else
                        Console.WriteLine($"The Hero stayed in place.");
                    break;
                case 'S':
                case 's':
                    yesNo = YesNo();
                    if (yesNo == true)
                        Console.WriteLine($"The Hero stepped back.");
                    else
                        Console.WriteLine($"The Hero stayed in place.");
                    break;
                case 'D':
                case 'd':
                    yesNo = YesNo();
                    if (yesNo == true)
                        Console.WriteLine($"The Hero stepped right.");
                    else
                        Console.WriteLine($"The Hero stayed in place.");
                    break;
                case 'A':
                case 'a':
                    yesNo = YesNo();
                    if (yesNo == true)
                        Console.WriteLine($"The Hero stepped left.");
                    else
                        Console.WriteLine($"The Hero stayed in place.");
                    break;
            }
        }

        static char InputCheckYesNo()
        {
            char key;
            do
            {
                key = Convert.ToChar(Console.ReadLine());
                if (key != 'Y' && key != 'N' && key != 'y' && key != 'n')
                    Console.WriteLine($"Input error. Try again: ");
            } while (key != 'Y' && key != 'N' && key != 'y' && key != 'n');

            return key;
        }

        static bool YesNo()
        {
            Console.Write($"Are you sure? (Y/N): ");
            char key = InputCheckYesNo();
            if (key == 'Y' || key == 'y')
                return true;
            else
                return false;
        }
    }
}
