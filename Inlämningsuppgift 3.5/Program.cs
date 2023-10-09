using System;
using System.Diagnostics.SymbolStore;

namespace uppgift_3._5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal");
            string input = Console.ReadLine();
            int msi = input.IndexOf(" ");
            double tal1 = int.Parse(input[..msi]);
            double tal2 = int.Parse(input[msi..]);
            Console.WriteLine("Välj ett räknesätt:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string kategori = Console.ReadLine();
            double svar1 = tal1 + tal2;
            double svar2 = tal2 - tal1;
            double svar3 = tal1 * tal2;
            double svar4 = tal1 / tal2;
            switch (kategori)
            {
                case "1":
                    Console.WriteLine(tal1 + " plus " + tal2 + " är lika med " + svar1);
                    Console.Read();
                    break;
                case "2":
                    Console.WriteLine(tal1 + " minus " + tal2 + " är lika med " + svar2);
                    Console.Read();
                    break;
                case "3":
                    Console.WriteLine(tal1 + " gånger " + tal2 + " är lika med " + svar3);
                    Console.Read();
                    break;
                case "4":
                    Console.WriteLine(tal1 + " delat med " + tal2 + " är lika med " + svar4);
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Du har inte valt ett giltigt altenativ");
                    Console.Read();
                    break;

            }
        }
    }
}