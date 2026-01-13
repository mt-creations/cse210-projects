using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

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
            Console.WriteLine();
        
            if (selection == "1")
            {
                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();

                entry._prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(entry._prompt);
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }

            else if (selection == "2")
            {
                journal.Display();
            }

            else if (selection == "3")
            {
                Console.Write("Enter a filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (selection == "4")
            {
                Console.Write("Enter a filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Good job saving your file!");
            }
            else
            {
                Console.WriteLine("Have a nice day!");
            }
        }
    }
}