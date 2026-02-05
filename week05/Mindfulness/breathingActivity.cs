



using System.Security.Cryptography;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
    {   _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            elapsed += 4;

            if (elapsed > _duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
            elapsed +=5;
        }

        DisplayEndingMessage();
    }
}