using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    class DecimalToBinary
    {
        public static void AnyConvertion()
        {
            int n, i;
            //creating an integer array
            int[] a = new int[10];

            Console.Write("Enter the number to convert: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            
            Console.Write("\nBinary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }

        }
    }
}
