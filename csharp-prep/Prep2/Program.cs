using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your Grade Percentage? ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrtulations you are passing the class keep up the good work.");
        }
        else if (grade < 70)
        {
            Console.WriteLine("youre not quite passing yet, if you need a tutor or more assistance reach out to use on the webpage.");
        }
    }
}