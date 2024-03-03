using System;
using System.Globalization;

class Program
{    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int squared = SquareNumber(UserNumber);
        DisplayResult(UserName, squared);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welsome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        String Name = Console.ReadLine();
        return Name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your Favorite Number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string UserName, int square)
    {
        Console.WriteLine($"{UserName}, the square of your number is {square}");
    }
}