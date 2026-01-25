
//For the stretch challenge I made the program load random scriptures from several scriptures in a text file. I also made it so it only hides words that are not already hidden.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> lines = new List<string>();

        if (File.Exists("scripture.txt"))
        {
            lines.AddRange(File.ReadAllLines("scripture.txt"));
        }
        else
        {
            Console.WriteLine("scripture.txt file not found.");
            return;
        }

        Random random =  new Random();
        int i = random.Next(lines.Count);
        string chosenLine = lines[i];
        string[] parts = chosenLine.Split("|");

        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int startVerse = int.Parse(parts[2]);
        int endVerse = int.Parse(parts[3]);
        string text = parts[4];

        Reference reference;

        if (startVerse == endVerse)
        {
            reference = new Reference(book, chapter, startVerse);
        }
        else
        {
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        Scripture scripture = new Scripture(reference, text);

        while (scripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Have a nice day.");
                break;
            }

            int wordsToHide = random.Next(1,4);
            scripture.HideRandomWords(wordsToHide);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are hidden. Good job! You can do this!");
    }
}