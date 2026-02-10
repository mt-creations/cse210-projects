using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        string selection = "";

        while (selection != "6")
        {
            Console.Clear();
            Console.WriteLine($"You have {manager.GetScore()} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.WriteLine("Please select a menu option ");

            selection = Console.ReadLine();

            if (selection == "1")
            {
                manager.CreateGoal();
            }

            else if (selection == "2")
            {
                
            }

            else if (selection == "3")
            {
                
            }

            else if (selection == "4")
            {
                
            }

            else if (selection == "5")
            {
                
            }

        }

        Console.WriteLine("Goodbye");

    }
}