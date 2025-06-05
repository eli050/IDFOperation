using System;
using System.ComponentModel.Design;
using IDFOperation.AmanClasses;
using IDFOperation.HamasClasses;
using IDFOperation.IDFClasses;
namespace IDFOperation
{
    class Program
    {
        static void Main()
        {
            Aman aman =  Aman.StartShow();
            IDF idf = IDF.StartShow();
            Hamas hamas =  Hamas.StartShow();
            Attack attack = new Attack(aman, idf, hamas);
            Menu(aman, idf, hamas,attack);
        }
        static void Menu(Aman aman , IDF idf , Hamas hamas , Attack attack)
        {
            bool NotExit = true;
            do
            {
                PrintMenu();
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Identifying the terrorist with the most intelligence reports\n");
                        Console.WriteLine(aman.IntelligenceAnalysis().name);
                        break;
                    case "b":
                        Dictionary<string, int> arsenal = idf.GetStrikeAndArsenal();
                        Console.WriteLine("Displaying all currently available strike units and their capacity\n");
                        foreach (string strike in arsenal.Keys)
                        {
                            Console.WriteLine($"Attack unit {strike} contains {arsenal[strike]} attacks.");
                        }
                        break;
                    case "c":
                        Console.WriteLine("Determining the most dangerous terrorist based on a quality rating\n");
                        Terrorist dangourTerrorist = aman.MostDangoursTerrorist();
                        Console.WriteLine($"The most dangours terrorist is: {dangourTerrorist.name}");
                        break;
                    case "d":
                        attack.StartAttack();
                        NotExit = attack.TerroristsExist();
                        break;
                    case "e":
                        NotExit = false;
                        break;

                }

            } while (NotExit);

        }
        static void PrintMenu()
        {
            Console.WriteLine("\nMilitary management menu." +
                "\na. Intelligence Analysis" +
                "\nb. Strike Availability" +
                "\nc. Target Prioritization" +
                "\nd. Strike Execution\n" +
                "e. Exit\n" +
                "Enter your selection:");
        }
    }
}