using System;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        
        Console.Write("What is your guess? ");
        string numberGuess = Console.ReadLine();
        int guess = int.Parse(numberGuess);
        int amountOfGuesses = 1;

        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Guess higher. ");
            }
            else if (guess > number)
            {
                Console.WriteLine("Guess lower. ");
            }

            Console.Write("What is your guess? ");
            numberGuess = Console.ReadLine();
            guess = int.Parse(numberGuess);
            amountOfGuesses++;
        }  
        Console.WriteLine($"You guessed it in {amountOfGuesses} tries!");  
    }
}