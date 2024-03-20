using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Brenden Lyon", "CSE-210");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();//for readability

        MathAssignment assignment2 = new MathAssignment("Hector", "Math", "Chapt 2", "1-10" );
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();//for readability

        WritingAssignemnt assignment3 = new WritingAssignemnt("John Smith", "Science", "I am Iron Man");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());


    }
}