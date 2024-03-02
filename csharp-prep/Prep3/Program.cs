using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        
        //Console.WriteLine("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int ans = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int ans = randomGenerator.Next(1,51);

        int numguess = -1;
        while (numguess != ans)

       {
            Console.WriteLine("Guess a number between 1 and 50? ");
            string guess = Console.ReadLine();
            numguess = int.Parse(guess);

            if (numguess == ans)
            {
            Console.WriteLine("Good guessing youre right on!");
            }
            else if (numguess < ans)
            {
            Console.WriteLine("You need to guess Higher.");
            }
            else if (numguess > ans)
            {
            Console.WriteLine("You need to guess Lower.");
            }
       } 
    }
}