using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    class SwapingNibbles
    {
        public static void ReadInput()
        {
            int number;
            //geting an input from user
            Console.WriteLine("Enter Decimal number");

            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Decimal number before swapped = {number}");
            //0x0f in decimal is 15   0xf0 in decimal is 240 
            // It (number & 0x0F) will give last four binary vlaues
            //It (number & 0xF0) will give first four binary values
            int newNumber = ((number & 0x0F) << 4 | (number & 0xF0) >> 4);
            //Final decimal number
            Console.WriteLine($"Decimal number after swapped = {newNumber}");

            // checking whether it is power of two or not
            bool result = CheckingPower(newNumber);

            Console.WriteLine(result ? $"{newNumber} is power of two" : $"{ newNumber} is not power of two");
        }
        private static bool CheckingPower(int newNumber)
        {
            while (newNumber != 1)
            {
                if (newNumber % 2 != 0)
                    return false;

                newNumber /= 2;
            }
            return true;
        }
    }
}
