using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction p = new Fraction();
        Console.WriteLine(p.GetFractionString());
        Console.WriteLine(p.GetDecimalValue());
        Console.WriteLine("");//Line break for reading

        Fraction p1 = new Fraction(5);
        Console.WriteLine(p1.GetFractionString());
        Console.WriteLine(p1.GetDecimalValue());
        Console.WriteLine("");//Line break for reading

        Fraction p2 = new Fraction(3,4);
        Console.WriteLine(p2.GetFractionString());
        Console.WriteLine(p2.GetDecimalValue());
        Console.WriteLine("");//line break for reading

        Fraction p3 = new Fraction(1,3);
        Console.WriteLine(p3.GetFractionString());
        Console.WriteLine(p3.GetDecimalValue());
        

    }
}