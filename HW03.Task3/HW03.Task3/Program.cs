using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace HW03.Task3
{
    class Birthday
    {
        static void Main(string[] args)
        {
            Birthday birthday = new Birthday();
            Console.WriteLine($"Enter date of birth:");
            short yearBirth = birthday.GetYearFromUser();
            byte monthBirth = birthday.GetMonthFromUser();
            Console.WriteLine($"Enter current date: ");
            short yearNow = birthday.GetYearFromUser();
            byte monthNow = birthday.GetMonthFromUser();
            double dateBirth = (double)yearBirth + (double)monthBirth / 100;
            double dateNow = (double)yearNow + (double)monthNow/100;
            int rez = (int)(dateNow - dateBirth);
            Console.WriteLine($"Your are {rez} years ago.");
        }

        short GetYearFromUser()
        {
            Console.Write($"Enter the year: ");
            short year = Convert.ToInt16(Console.ReadLine());
            return year;
        }

        byte GetMonthFromUser()
        {
            Console.WriteLine($"Enter the month: ");
            byte month = Convert.ToByte(Console.ReadLine());
            return month;
        }
    }
}
