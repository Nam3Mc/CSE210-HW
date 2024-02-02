using System;
using System.Threading;

// Base class for all activities
public abstract class Activity
{
    protected int durationInSeconds;
    protected string name;
    protected string description;

    public Activity(string name, string description, int durationInSeconds)
    {
        this.name = name;
        this.description = description;
        this.durationInSeconds = durationInSeconds;
    }

    // Common starting message for all activities
    public void StartActivity()
    {
        Console.WriteLine($"Starting {name} activity...");
        Console.WriteLine(description);
        Console.WriteLine($"Duration set to {durationInSeconds} seconds.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // Common ending message for all activities
    public void EndActivity()
    {
        Console.WriteLine($"Good job! You have completed the {name} activity.");
        Console.WriteLine($"Total duration: {durationInSeconds} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // Method to display spinner animation during pauses
    protected void ShowSpinner(int milliseconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int counter = 0;
        while (milliseconds > 0)
        {
            Console.Write($"\r{spinner[counter % 4]}");
            Thread.Sleep(100);
            milliseconds -= 100;
            counter++;
        }
        Console.WriteLine();
    }

    public abstract void RunActivity();
}

// Breathing activity
public class BreathingActivity : Activity
{
    public BreathingActivity(int durationInSeconds) : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", durationInSeconds) { }

    public override void RunActivity()
    {
        StartActivity();

        for (int i = 0; i < durationInSeconds; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2000); // Pause for 2 seconds
            Console.WriteLine("Breathe out...");
            ShowSpinner(2000); // Pause for 2 seconds
        }

        EndActivity();
    }
}

// Reflection activity
public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int durationInSeconds) : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", durationInSeconds) { }

    public override void RunActivity()
    {
        StartActivity();

        Random rnd = new Random();
        int elapsedTime = 0;

        while (elapsedTime < durationInSeconds)
        {
            string prompt = prompts[rnd.Next(prompts.Length)];
            Console.WriteLine(prompt);
            ShowSpinner(2000); // Pause for 2 seconds

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                ShowSpinner(3000); // Pause for 3 seconds
                elapsedTime += 3; // Increment elapsed time by 3 seconds for each question
                if (elapsedTime >= durationInSeconds) break; // Break the loop if the duration is exceeded
            }
        }

        EndActivity();
    }
}

// Listing activity
public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int durationInSeconds) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", durationInSeconds) { }

    public override void RunActivity()
    {
        StartActivity();

        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("Get ready to list...");

        Thread.Sleep(5000); // Pause for 5 seconds

        Console.WriteLine("Start listing...");

        // Simulating user listing items
        Thread.Sleep(durationInSeconds * 1000); // Pause for durationInSeconds seconds

        Console.WriteLine($"You listed {durationInSeconds} items.");

        EndActivity();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Menu system
        Console.WriteLine("Welcome to the Activity Program!");
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter duration for Breathing activity (in seconds):");
                int breathingDuration = int.Parse(Console.ReadLine());
                BreathingActivity breathingActivity = new BreathingActivity(breathingDuration);
                breathingActivity.RunActivity();
                break;
            case 2:
                Console.WriteLine("Enter duration for Reflection activity (in seconds):");
                int reflectionDuration = int.Parse(Console.ReadLine());
                ReflectionActivity reflectionActivity = new ReflectionActivity(reflectionDuration);
                reflectionActivity.RunActivity();
                break;
            case 3:
                Console.WriteLine("Enter duration for Listing activity (in seconds):");
                int listingDuration = int.Parse(Console.ReadLine());
                ListingActivity listingActivity = new ListingActivity(listingDuration);
                listingActivity.RunActivity();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
