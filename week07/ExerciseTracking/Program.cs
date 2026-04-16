using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create the list to hold Activity objects
        List<Activity> activities = new List<Activity>();

        // 2. Create at least one of each type
        Running run = new Running("14 Apr 2026", 30, 3.0);
        Cycling bike = new Cycling("14 Apr 2026", 45, 15.0);
        Swimming swim = new Swimming("14 Apr 2026", 20, 40);

        // 3. Add them to the list (Polymorphism in action!)
        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        // 4. Iterate and display
        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("--------------------------");
        foreach (Activity activity in activities)
        {
            // Calls the base class GetSummary, which calls the derived overrides
            Console.WriteLine(activity.GetSummary());
        }
    }
}