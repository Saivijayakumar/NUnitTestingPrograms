using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    class Newtonsquare
    {
        public static void ReadInput()
        {
            double l = 0.00001, num, root, x, count = 0;
            Console.WriteLine("Enter number to be Root");
            num = Convert.ToInt32(Console.ReadLine());

            x = num;

            //this loop will run until it go to break statement
            while(true)
            {
                count++;

                // Calculate more closed x
                root = 0.5 * (x + (num / x));

                // Check for closeness
                if (Math.Abs(root - x) < l)
                    break;

                // Update root
                x = root;
            }
            Console.WriteLine(root);

        }
    }
}
