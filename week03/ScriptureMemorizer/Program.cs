using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create a reference and a scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        Scripture scripture = new Scripture(reference, text);

        // 2. Main Loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break; // End the program if all words are hidden
            }

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words at a time
            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nGoodbye!");
    }
}