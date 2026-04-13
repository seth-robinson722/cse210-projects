using System;

/*
CREATIVITY REPORT:
1. Added 'NegativeGoal' class: This allows users to track bad habits. 
   When a NegativeGoal event is recorded, points are subtracted from 
   the total score instead of added.
2. Modified the RecordEvent feedback logic to handle negative point 
   messages differently than positive ones.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}