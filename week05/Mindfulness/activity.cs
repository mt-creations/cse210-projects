



using System.ComponentModel;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"You have selected the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine("\nHow many seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Starting in..."); 
        ShowCountDown(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood Job!");
        ShowSpinner(3);
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int endTime = DateTime.Now.AddSeconds(seconds).Second;
        
        while (DateTime.Now.Second != endTime)
        {
            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}