using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment1 = new Assignment("Brenden Lyon", "CSE-210");
        Console.WriteLine(assignment1.GetSummary());
    }
}