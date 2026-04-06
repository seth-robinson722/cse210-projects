using System;
using System.Collections.Generic;

class Program
{
    // CREATIVITY: Static log to track session counts
    private static Dictionary<string, int> _log = new Dictionary<string, int>
    {
        { "Breathing", 0 },
        { "Reflection", 0 },
        { "Listing", 0 }
    };

    static void Main(string[] args)
    {
        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View session log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    _log["Breathing"]++;
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    _log["Reflection"]++;
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    _log["Listing"]++;
                    break;
                case "4":
                    DisplayLog();
                    break;
                case "5":
                    quit = true;
                    break;
            }
        }
    }

    static void DisplayLog()
    {
        Console.Clear();
        Console.WriteLine("--- Session Activity Log ---");
        foreach (var entry in _log)
        {
            Console.WriteLine($"{entry.Key} Activities Completed: {entry.Value}");
        }
        Console.WriteLine("\nPress enter to return to menu.");
        Console.ReadLine();
    }
}