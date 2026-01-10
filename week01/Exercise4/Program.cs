using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished. ");
        int numChoice = int.Parse(Console.ReadLine());
        int sum = 0;

        while (numChoice != 0)
        {
            numbers.Add(numChoice);
            sum += numChoice;

            Console.WriteLine("Enter a number. ");
            numChoice = int.Parse(Console.ReadLine()); 
        }

        int largest = numbers[0];

        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }
        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The Average is {average}");
        Console.WriteLine($"The Largest number is {largest}");   
    } 
}