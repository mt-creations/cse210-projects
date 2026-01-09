using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your percentage grade in the class? ");

        string userInput = Console.ReadLine();
        int x = int.Parse(userInput);
        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >=80 && x < 90)
        {
            letter = "B";
        }
        else if (x >=70 && x < 80)
        {
            letter = "C";
        }
        else if (x >=60 && x < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        string plusMinus = "";

        if (x % 10 >= 7 && letter != "A" && letter != "F")
        {
            plusMinus = "+";
        }
        else if (x % 10 < 3 && letter != "F")
        {
            plusMinus = "-";
        }




        Console.Write($"You got a {letter}{plusMinus}.  "); 

        if (x >= 70)
        {
            Console.Write("Congratulations! You passed the class.");
        }
        else
        {
            Console.Write("Better luck next time.");
        }
    }
}