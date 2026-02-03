using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John", "math");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Joe", "subtraction", "7", "1-20");
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 =new WritingAssignment("Jennifer", "History", "US History 1800 - 1900");
        Console.WriteLine(writing1.GetWritingInformation());

    }
}