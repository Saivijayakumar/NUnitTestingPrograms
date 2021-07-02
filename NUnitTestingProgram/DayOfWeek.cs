using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingPrograms
{
    class DayOfWeek
    {
        public static void ReadInput()
        {
            int date, month, year;

            //Getting Date from 1-30
            Console.WriteLine("Enter the date");
            date = Convert.ToInt32(Console.ReadLine());
            //Getting Month from 1-12
            Console.WriteLine("Enter the Month");
            month = Convert.ToInt32(Console.ReadLine());
            //Getting Year from user
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());


            FindingDayOfWeek(date, month, year);


        }
        //method for getting date
        private static void FindingDayOfWeek(int d, int m, int y)
        {
            //Creating a array for Week
            string[] Week = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //calculating day of week by using georgian formula
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            //printing output
            Console.WriteLine($"The given date is {d}-{m}-{y} and  day is  {Week[d0]} ");
        }
    }
}