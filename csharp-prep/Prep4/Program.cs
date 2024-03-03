using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type '0' when finished.");

        List<int> numbers;
        numbers = new List<int>();

        int Num = -1;
        while (Num != 0)
            {
            Console.WriteLine("Enter Number");
            string number = Console.ReadLine();
            Num = int.Parse(number);

            if (Num != 0)
            {
            numbers.Add(Num);
            }
           } 
        int sum =  0;
        foreach (int number in numbers)
        {
            sum += number;
        }   
        Console.WriteLine($"The sum is, {sum}");

        int average = sum/numbers.Count;
        Console.WriteLine($"The average is, {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number >largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is, {largest}");
    }
}