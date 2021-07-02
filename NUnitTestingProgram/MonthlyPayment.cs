using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    class MonthlyPayment
    {
        public static void GetingInputs()
        {
            //pr = principle Roi = rate of interest
            double years, pr, Roi;

            //Asking number of years 
            Console.WriteLine("Enter the number of years");
            years = Convert.ToDouble(Console.ReadLine());

            //Asking principle amount value
            Console.WriteLine("Enter the Principle amount");
            pr = Convert.ToDouble(Console.ReadLine());

            //Asking rate of interest
            Console.WriteLine("Enter the rate of interest");
            Roi = Convert.ToDouble(Console.ReadLine());

            MonthlyPaymentIs(years, pr, Roi);
        }
        private static void MonthlyPaymentIs(double years, double pr, double Roi)
        {
            //Given formula
            double m = 12 * years;// It convert years into months
            double r = Roi / (12 * 100);
            double x = Math.Pow(1 + r, m);// (1+r)^m

            //Final formula for calculating payment
            double payment = (pr * r * x) / (x - 1);

            //Result 
            Console.WriteLine($"Monthly Payment is = {Math.Round(payment)}");
        }
    }
}
