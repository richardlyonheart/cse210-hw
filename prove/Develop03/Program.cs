using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        string reference = "Genesis 15:6";
        string text = "And he believed in the Lord; and he counted it to him for righteousness.";

        Reference scriptureReference = new Reference(reference);
        Scripture scripture = new Scripture(reference, text);

        bool endProgram = false;
        while (!scripture.IsCompletelyHidden() && !endProgram)
        {
            Console.Clear();
            Console.WriteLine("Lets memorize a scripture!");
            scripture.GetDisplayText();

            Console.Write("Press Enter to hide a word or type endProgram: ");
            string userInput = Console.ReadLine().ToUpper();

            if(userInput == "ENDPROGRAM")
            {
                endProgram = true;
            }
            else
            {
                scripture.HideRandomWords();
            }
        }

        if (endProgram)
        {
            Console.WriteLine("See you next time");
        }
        else
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine("Final Challenge. ALL WORDS HIDDEN");
        }
    }
}