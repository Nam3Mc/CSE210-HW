using System;
using System.Threading;


public abstract class Activity
{
    protected int durationInSeconds;

    public Activity(int durationInSeconds)
    {
        this.durationInSeconds = durationInSeconds;
    }

    public void StartActivity(string name, string description)
    {
        Console.WriteLine($"Starting {name} activity...");
        Console.WriteLine(description);
        Console.WriteLine($"Duration set to {durationInSeconds} seconds.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); 
    }

    public void EndActivity(string name)
    {
        Console.WriteLine($"Good job! You have completed the {name} activity.");
        Console.WriteLine($"Total duration: {durationInSeconds} seconds.");
        Thread.Sleep(3000); 
    }

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
}

public class BreathingActivity : Activity
{
    public BreathingActivity(int durationInSeconds) : base(durationInSeconds) { }

    public void Start()
    {
        StartActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        for (int i = 0; i < durationInSeconds; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2000); 
            Console.WriteLine("Breathe out...");
            ShowSpinner(2000); 
        }

        EndActivity("Breathing");
    }
}

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

    public ReflectionActivity(int durationInSeconds) : base(durationInSeconds) { }

    public void Start()
    {
        StartActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Random rnd = new Random();
        int elapsedTime = 0;

        while (elapsedTime < durationInSeconds)
        {
            string prompt = prompts[rnd.Next(prompts.Length)];
            Console.WriteLine(prompt);
            ShowSpinner(2000); 

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                ShowSpinner(3000); 
                elapsedTime += 3; 
                if (elapsedTime >= durationInSeconds) break; 
            }
        }

        EndActivity("Reflection");
    }
}

public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int durationInSeconds) : base(durationInSeconds) { }

    public void Start()
    {
        StartActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("Get ready to list...");

        Thread.Sleep(5000); 

        Console.WriteLine("Start listing...");

        Thread.Sleep(durationInSeconds * 1000); 

        Console.WriteLine($"You listed {durationInSeconds} items.");

        EndActivity("Listing");
    }
}

class Program
{
    static void Main(string[] args)
    {
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
                breathingActivity.Start();
                break;
            case 2:
                Console.WriteLine("Enter duration for Reflection activity (in seconds):");
                int reflectionDuration = int.Parse(Console.ReadLine());
                ReflectionActivity reflectionActivity = new ReflectionActivity(reflectionDuration);
                reflectionActivity.Start();
                break;
            case 3:
                Console.WriteLine("Enter duration for Listing activity (in seconds):");
                int listingDuration = int.Parse(Console.ReadLine());
                ListingActivity listingActivity = new ListingActivity(listingDuration);
                listingActivity.Start();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
