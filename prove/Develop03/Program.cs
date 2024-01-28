using System;

public class Program
{
    public static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only Son, so that everyone who believes in him may not perish but may have eternal life.");

        Console.WriteLine($"Scripture Reference: {scripture.GetReference()}");
        Console.WriteLine($"Complete Scripture: {string.Join(" ", scripture.GetWords().Select(word => word.GetText()))}");

        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
        string input = Console.ReadLine();

        while (input != "quit" && !scripture.AllWordsHidden())
        {
            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine($"Scripture Reference: {scripture.GetReference()}");
            Console.WriteLine($"Hidden Scripture: {string.Join(" ", scripture.GetWords().Select(word => word.GetText()))}");

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            input = Console.ReadLine();
        }

        Console.WriteLine("Program ended.");
    }
}
