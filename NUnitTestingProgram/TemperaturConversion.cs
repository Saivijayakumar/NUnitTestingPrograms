using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    class TemperaturConversion
    {
        public static void ExecutingCode()
        {
            Console.WriteLine("\t1.Convert Celsius to Fahrenheit\n\t2.Conver Fahrenheit to Celsius");
            Console.WriteLine("Choose option");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter degree in celsius : ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    ConvertingToFahrenheit(num1);
                    break;
                case 2:
                    Console.WriteLine("Enter degree in Fahrenheit : ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    ConvertingToCelsius(num2);
                    break;
                default:
                    Console.WriteLine("Pls Enter valid option");
                    break;
            }
        }

        //Method for converting Fahrenheit to Celsius
        private static void ConvertingToCelsius(double num1)
        {
            double c = (num1 - 32) * 5 / 9;
            Console.WriteLine($"{num1}F = {c}C");
        }

        //Method for converting Celsius to Fahrenheit
        private static void ConvertingToFahrenheit(double num2)
        {
            double f = num2 * 9 / 5 + 32;
            Console.WriteLine($"{num2}C = {f}F");
        }
        
    }
}
