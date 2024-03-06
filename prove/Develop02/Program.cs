using System;
using System.Security.Cryptography;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal!");
        Console.WriteLine("Would you like to write or read?");
        
        if (Console.ReadLine()== "read")
        {
            Console.WriteLine("Which journal would you like to open?");
            string filename = Console.ReadLine();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(","); 
            }
        }
        else if (Console.ReadLine()=="write")
        {
            var num = new RandomPrompt();
            num.displayprompt();

        }
        

        


    }
}