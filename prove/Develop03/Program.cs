using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World welcome to the Scripture Game");
        Console.WriteLine("Please Enter a Scripture reference: ");
        string reference = Console.ReadLine();
        Console.WriteLine();//space for readability
        Console.WriteLine("Please Enter the Verse");
        string text = Console.ReadLine();

        Reference scriptureReference = new Reference(reference); //creates a referance to start the programs 
        Scripture scripture = new Scripture(reference, text); // creates the text for the programs to begin

        bool endProgram = false;
        while (!scripture.IsCompletelyHidden() && !endProgram)
        {
            Console.Clear();//makes it not stack up in console
            Console.WriteLine("Lets memorize a scripture!");
            scripture.GetDisplayText();

            Console.Write("Press Enter to hide a word or type 'DONE' to end program: ");//option to end or continue playing
            string userInput = Console.ReadLine().ToUpper();

            if(userInput == "DONE")
            {
                endProgram = true;
            }
            else
            {
                scripture.HideRandomWords(); //calls program to hide a random word
            }
        }

        if (endProgram)
        {
            Console.WriteLine("See you next time");
        }
        else
        {
            Console.Clear(); //so that it shows on the same without stacking
            scripture.GetDisplayText();
            Console.WriteLine("Final Challenge. ALL WORDS HIDDEN");
            Console.WriteLine("Please come back again soon");
        }
    }
}

//My exceeding expectations is to make it so that you input the scripture and verse
//I was trying to make it that you could do it again and again with new verses each
//time