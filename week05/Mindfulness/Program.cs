using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        string selection = "";

        while (selection !="4")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness program\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("\nPlease select a menu option. ");

            selection = Console.ReadLine();

            if (selection == "1")
            {
                new BreathingActivity().Run();
            }
            else if (selection == "2")
            {
                new ListingActivity().Run();
            }
            else if (selection == "3")
            {
                new ReflectionActivity().Run();
            }
        }

        Console.WriteLine("Goodbye");

    }
}