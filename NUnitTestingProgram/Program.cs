using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    /// <summary>
    /// ===========>WELCOME<=============
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tWELCOME\n");
            Console.WriteLine("\tThese are the LIST of some NUnit Testing Programs");
            Console.WriteLine("\t----------------------------------------------");
            Console.WriteLine("\t 1.Vending Machine\n\t 2.Day Of Week\n\t 3.Prime Number\n\t 4.Reversing Number\n\t 5.");
            Console.WriteLine("\t----------------------------------------------");
            Console.Write("\tEnter your choice : ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("\t Vending Machine Code Starts");
                    VendingMachine.GenerateNotes();
                    break;
                case 2:
                    Console.WriteLine("\t Day Of Week Code Starts");
                    DayOfWeek.ReadInput();
                    break;
                /*case 3:
                    Console.WriteLine("\t Prime Number Code Starts");
                    PrimeNumber.CheckingPrime();
                    break;
                case 4:
                    Console.WriteLine("\t Reversing Number Code Starts");
                    ReversingNumber.Reversing();
                    break;*/
                default:
                    Console.WriteLine("\t PLEASE ENTER A VALID OPTION");
                    break;
            }

            Console.Read();
        }
    }
}