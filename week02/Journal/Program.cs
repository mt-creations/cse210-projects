using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        string selection = "0";

        while (selection != "5")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please select one of the following choices.");
            selection = Console.ReadLine();
        }
    }
}