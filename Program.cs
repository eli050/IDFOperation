using System;
using IDFOperation.AmanClasses;
using IDFOperation.IDFClasses;
namespace IDFOperation
{
    class Program
    {
        static void Main()
        {

        }
        static void Menu()
        {
            bool NotExit = true;
            Aman aman = new Aman();
            IDF idf = new IDF();
            do
            {
                PrintMenu();
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                        Console.WriteLine(aman.IntelligenceAnalysis());
                        break;
                    case "b":
                        Console.WriteLine(idf.GetStrikeAndArsenal());
                        break;
                    case "c":
                        Console.WriteLine(aman.MostDangoursTerrorist());
                        break;
                    case "d":
                        break;
                    case "e":
                        NotExit = false;
                        break;

                }

            } while (NotExit);

        }
        static void PrintMenu()
        {
            Console.WriteLine("Here is a military management menu. Please enter your selection:" +
                "\na. Intelligence Analysis, identifying the terrorist with the most intelligence reports" +
                "\nb. Strike Availability, displaying all currently available strike units and their capacity" +
                "\nc. Target Prioritization, determining the most dangerous terrorist based on a quality rating" +
                "\nd. Strike Execution, selecting an appropriate strike unit based on the terrorist's location\n" +
                "e. Exit");
        }
    }
}