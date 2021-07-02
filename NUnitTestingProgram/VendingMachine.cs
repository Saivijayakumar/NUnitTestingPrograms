using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    class VendingMachine
    {
        public static void GenerateNotes()
        {
            Console.WriteLine("Enter amount to return change");
            //Taking input from users
            int number = Convert.ToInt32(Console.ReadLine());
            FindingMinNotes(number);
        }
        private static void FindingMinNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] notecount = new int[notes.Length];

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    notecount[i] = amount / notes[i];
                    amount = amount - (notecount[i] * notes[i]);
                    if (amount <= 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Currency Count");
            for (int i = 0; i < notes.Length; i++)
            {
                if (notecount[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + notecount[i]);
                }
            }
        }
    }
}
