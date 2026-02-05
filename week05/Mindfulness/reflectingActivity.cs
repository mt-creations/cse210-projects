



using System.Diagnostics.Contracts;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
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
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
        }

        DisplayEndingMessage();

    }

     private string GetRandomPrompt()
    {
        Random random = new();
        return _prompts[random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random random = new();
        return _questions[random.Next(_questions.Count)];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
    }

    private void DisplayQuestion()
    {
        Console.Write($"\n> {GetRandomQuestion()} ");
        ShowSpinner(10);
    }
}